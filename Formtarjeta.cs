using System;
using System.Diagnostics;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using PdfSharp.Drawing;
using PdfSharp.Pdf;

namespace ProyectoGina
{
    public partial class Formtarjeta : Form
    {
        private MySqlConnection connection;
        private string usuarioActual;

        public Formtarjeta(string nombreUsuario)
        {
            InitializeComponent();
            Connect();
            usuarioActual = nombreUsuario;
        }

        private void Formtarjeta_Load(object sender, EventArgs e)
        {
            
        }

        private void Connect()
        {
            string cadena = "Server=localhost; Database=logininfo; User=root; Password=; SslMode=none;";
            connection = new MySqlConnection(cadena);
            try
            {
                connection.Open();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al conectar con la base de datos: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Disconnect()
        {
            if (connection != null && connection.State == System.Data.ConnectionState.Open)
            {
                connection.Close();
            }
        }

        private void BTNREGRESAR_Click(object sender, EventArgs e)
        {
            this.Close(); 
        }

        private void BTNCONFIRMAR_Click(object sender, EventArgs e)
        {
            if (FormMainUsuario.carrito.Count == 0)
            {
                MessageBox.Show("No hay productos en el carrito para confirmar la compra.", "Carrito Vacío", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string numeroTarjeta = TXTNT.Text;
            string fechaExpiracion = TXTFV.Text;
            string cvv = TXTCVV.Text;

            if (ValidarTarjeta(numeroTarjeta, fechaExpiracion, cvv))
            {
                decimal total = CalcularTotal();
                MessageBox.Show($"Pago confirmado. Total: ${total:F2}", "Confirmación", MessageBoxButtons.OK, MessageBoxIcon.Information);

                string filePath = $"Ticket_{DateTime.Now:yyyyMMdd_HHmmss}.pdf";
                GenerarPDFTicket(filePath, numeroTarjeta);

                try
                {
                    Process.Start(new ProcessStartInfo(filePath) { UseShellExecute = true });
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error al abrir el ticket: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                ActualizarBaseDeDatos();
                ActualizarMontoUsuario(total);
                Disconnect();

                
                FormMainUsuario usuarioForm = new FormMainUsuario("guest");
                usuarioForm.Show();
                this.Close();
            }
            else
            {
                MessageBox.Show("Datos de la tarjeta inválidos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private bool ValidarTarjeta(string numeroTarjeta, string fechaExpiracion, string cvv)
        {
            
            if (numeroTarjeta.Length != 16 || !long.TryParse(numeroTarjeta, out _))
            {
                return false;
            }

            
            if (!DateTime.TryParseExact(fechaExpiracion, "MM/yy", null, System.Globalization.DateTimeStyles.None, out DateTime fechaExp))
            {
                return false;
            }

            
            if (cvv.Length != 3 || !int.TryParse(cvv, out _))
            {
                return false;
            }

            
            if (fechaExp < DateTime.Now)
            {
                return false;
            }

            return true;
        }

        private decimal CalcularTotal()
        {
            decimal total = 0;
            foreach (var item in FormMainUsuario.carrito)
            {
                string producto = item.Item1;
                decimal cantidad = item.Item2;

                
                string query = $"SELECT precio FROM productos WHERE descripcion = '{producto}'";
                MySqlCommand cmd = new MySqlCommand(query, connection);
                decimal precio = Convert.ToDecimal(cmd.ExecuteScalar());

                decimal subtotal = cantidad * precio;
                decimal comision = subtotal * 0.06m;
                total += subtotal + comision;
            }
            return total;
        }

        private void GenerarPDFTicket(string filePath, string numeroTarjeta)
        {
            try
            {
                PdfDocument document = new PdfDocument();
                PdfPage page = document.AddPage();
                XGraphics gfx = XGraphics.FromPdfPage(page);
                XFont font = new XFont("Verdana", 12);

                gfx.DrawString("Ticket de Compra", font, XBrushes.Black, new XPoint(250, 30));
                gfx.DrawString("Fecha: " + DateTime.Now.ToString("dd/MM/yyyy HH:mm"), font, XBrushes.Black, new XPoint(230, 80));

                int yOffset = 120;
                decimal totalGeneral = 0;

                foreach (var item in FormMainUsuario.carrito)
                {
                    string producto = item.Item1;
                    decimal cantidad = item.Item2;

                    string query = $"SELECT precio FROM productos WHERE descripcion = '{producto}'";
                    MySqlCommand cmd = new MySqlCommand(query, connection);
                    decimal precio = Convert.ToDecimal(cmd.ExecuteScalar());

                    decimal subtotal = cantidad * precio;
                    decimal comision = subtotal * 0.06m;
                    decimal totalConComision = subtotal + comision;

                    gfx.DrawString($"{producto} - Cantidad: {cantidad}", font, XBrushes.Black, new XPoint(50, yOffset));
                    yOffset += 20;
                    gfx.DrawString($"Subtotal: ${subtotal:F2}", font, XBrushes.Black, new XPoint(50, yOffset));
                    yOffset += 20;
                    gfx.DrawString($"Comisión del 6%: ${comision:F2}", font, XBrushes.Black, new XPoint(50, yOffset));
                    yOffset += 30;

                    totalGeneral += totalConComision;
                }

                gfx.DrawString($"Total General: ${totalGeneral:F2}", font, XBrushes.Black, new XPoint(50, yOffset));
                yOffset += 20;
                gfx.DrawString($"Tarjeta: **** **** **** {numeroTarjeta.Substring(12)}", font, XBrushes.Black, new XPoint(50, yOffset + 20));

                document.Save(filePath);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al generar el ticket: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ActualizarBaseDeDatos()
        {
            if (connection == null || connection.State != System.Data.ConnectionState.Open)
            {
                MessageBox.Show("La conexión con la base de datos no está abierta.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                foreach (var item in FormMainUsuario.carrito)
                {
                    string producto = item.Item1;
                    decimal cantidad = item.Item2;

                    string queryExistencias = $"UPDATE productos SET existencia = existencia - {cantidad} WHERE descripcion = '{producto}'";
                    MySqlCommand cmd = new MySqlCommand(queryExistencias, connection);
                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al actualizar la base de datos: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        
        private void ActualizarMontoUsuario(decimal monto)
        {

            try
            {
                
                string query = $"UPDATE login SET monto = monto + {monto} WHERE usuario = '{usuarioActual}'";
                MySqlCommand cmd = new MySqlCommand(query, connection);

                int rowsAffected = cmd.ExecuteNonQuery();
                if (rowsAffected == 0)
                {
                    MessageBox.Show($"No se encontró el usuario '{usuarioActual}' en la base de datos.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al actualizar el monto del usuario: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
