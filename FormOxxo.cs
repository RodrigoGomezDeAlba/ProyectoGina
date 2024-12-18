using System;
using System.Diagnostics;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using PdfSharp.Drawing;
using PdfSharp.Pdf;

namespace ProyectoGina
{
    public partial class FormOxxo : Form
    {
        private MySqlConnection connection;
        private string usuarioActual;
        public FormOxxo(string nombreUsuario)
        {
            InitializeComponent();
            usuarioActual = nombreUsuario;
            Connect();
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

        private void FormOxxo_Load(object sender, EventArgs e)
        {
            
        }

        private void BTNCONFIRMAR_Click(object sender, EventArgs e)
        {
            // Validar que haya productos en el carrito
            if (FormMainUsuario.carrito.Count == 0)
            {
                MessageBox.Show("No hay productos en el carrito para confirmar la compra.", "Carrito Vacío", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Confirmar pago
            decimal total = CalcularTotal();
            ActualizarBaseDeDatos();
            ActualizarMontoUsuario(total);
            MessageBox.Show($"Pago confirmado. Total: ${total:F2}", "Confirmación", MessageBoxButtons.OK, MessageBoxIcon.Information);

            // Generar y abrir el ticket en PDF
            string filePath = $"Ticket_Pago_Oxxo_{DateTime.Now:yyyyMMdd_HHmmss}.pdf";
            GenerarPDFTicket(filePath, total);

            try
            {
                Process.Start(new ProcessStartInfo(filePath) { UseShellExecute = true });
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al abrir el ticket: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            // Redirigir al formulario principal del usuario
            FormMainUsuario usuarioForm = new FormMainUsuario("guest");
            usuarioForm.Show();
            this.Close();
        }

        private void BTNREGRESAR_Click(object sender, EventArgs e)
        {
            this.Close(); // Cerrar este formulario
        }

        private void GenerarPDFTicket(string filePath, decimal total)
        {
            try
            {
                PdfDocument document = new PdfDocument();
                PdfPage page = document.AddPage();
                XGraphics gfx = XGraphics.FromPdfPage(page);
                XFont font = new XFont("Verdana", 12);
                gfx.DrawString("Ticket de Pago OXXO", font, XBrushes.Black, new XPoint(250, 30));
                gfx.DrawString("Fecha: " + DateTime.Now.ToString("dd/MM/yyyy HH:mm"), font, XBrushes.Black, new XPoint(230, 80));

                int yOffset = 120;

                // Detalles del carrito
                foreach (var item in FormMainUsuario.carrito)
                {
                    string producto = item.Item1;
                    decimal cantidad = item.Item2;

                    gfx.DrawString($"{producto} - Cantidad: {cantidad}", font, XBrushes.Black, new XPoint(50, yOffset));
                    yOffset += 20;
                }

                // Total
                gfx.DrawString($"Total a Pagar: ${total:F2}", font, XBrushes.Black, new XPoint(50, yOffset + 20));

                // Guardar PDF
                document.Save(filePath);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al generar el ticket: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private decimal CalcularTotal()
        {
            decimal total = 0;

            foreach (var item in FormMainUsuario.carrito)
            {
                string producto = item.Item1;
                decimal cantidad = item.Item2;
                // Se consulta el precio 
                try
                {
                    string query = $"SELECT precio FROM productos WHERE descripcion = '{producto}'";
                    MySqlCommand cmd = new MySqlCommand(query, connection);

                    object result = cmd.ExecuteScalar();

                    if (result != null)
                    {
                        decimal precio = Convert.ToDecimal(result);
                        decimal subtotal = cantidad * precio;
                        total += subtotal;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error al calcular el precio de '{producto}': {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            // se agrega la comision
            decimal comision = total * 0.06m;
            return total + comision;
        }

        private void ActualizarMontoUsuario(decimal monto)
        {

            try
            {
                // Consulta para actualizar el monto en login
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

        private void ActualizarBaseDeDatos()
        {
            // Consulta para actualizar la existencia en productos
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


    }
    
}
