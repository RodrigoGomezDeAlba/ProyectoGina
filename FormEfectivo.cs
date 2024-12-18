using System;
using System.Diagnostics;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using PdfSharp.Drawing;
using PdfSharp.Pdf;

namespace ProyectoGina
{
    public partial class FormEfectivo : Form
    {
        public static decimal DR; 
        public static decimal Cambio; 
        private decimal totalPagar; 
        private MySqlConnection connection;
        private System.Windows.Forms.Timer timer;
        private string usuarioActual;


        public FormEfectivo(decimal total, string nombreUsuario)
        {
            InitializeComponent();
            Connect();
            usuarioActual = nombreUsuario;
            totalPagar = total; 

        }

        private void FormEfectivo_Load(object sender, EventArgs e)
        {
            
            TXTTOT.Text = totalPagar.ToString("F2");
        }

        private void Connect()
        {
            string cadena = "Server=localhost; Database=logininfo; User=root; Password=; SslMode=none;";
            try
            {
                connection = new MySqlConnection(cadena);
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

        private void ActualizarBaseDeDatos()
        {
            try
            {
                foreach (var item in FormMainUsuario.carrito)
                {
                    string producto = item.Item1;
                    decimal cantidad = item.Item2;

                    string queryExistencias = $"UPDATE productos SET existencia = existencia - {cantidad} WHERE descripcion = '{producto}'";
                    MySqlCommand cmdExistencias = new MySqlCommand(queryExistencias, connection);
                    cmdExistencias.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al actualizar la base de datos: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Disconnect();
            }
        }

        private void BTNCONFIRMAR_Click(object sender, EventArgs e)
        {
            if (FormMainUsuario.carrito.Count == 0)
            {
                MessageBox.Show("No hay productos en el carrito para confirmar la compra.", "Carrito Vacío", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (decimal.TryParse(TXTTOT.Text, out decimal total) && DR >= total)
            {
                Cambio = DR - total;
                MessageBox.Show($"Pago confirmado.\nSu cambio es: ${Cambio:F2}", "Cambio", MessageBoxButtons.OK, MessageBoxIcon.Information);

                
                string filePath = $"Ticket_{DateTime.Now:yyyyMMdd_HHmmss}.pdf";
                GenerarPDFTicket(filePath);

                
                Process.Start(new ProcessStartInfo(filePath) { UseShellExecute = true });

                
                ActualizarBaseDeDatos();
                ActualizarMontoUsuario(total);

                
                this.Hide();
                FormMainUsuario form2 = new FormMainUsuario("guest");
                form2.ShowDialog();
            }
            else
            {
                MessageBox.Show("El dinero recibido no es suficiente.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void GenerarPDFTicket(string filePath)
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
                decimal subtotalGeneral = 0;
                decimal comisionTotal = 0;

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
                    yOffset += 20;
                    gfx.DrawString($"Total con Comisión: ${totalConComision:F2}", font, XBrushes.Black, new XPoint(50, yOffset));
                    yOffset += 30;

                    subtotalGeneral += subtotal;
                    comisionTotal += comision;
                }

                gfx.DrawString($"Subtotal General: ${subtotalGeneral:F2}", font, XBrushes.Black, new XPoint(50, yOffset));
                yOffset += 20;
                gfx.DrawString($"Comisión Total (6%): ${comisionTotal:F2}", font, XBrushes.Black, new XPoint(50, yOffset));
                yOffset += 20;
                gfx.DrawString($"Total a Pagar: ${totalPagar:F2}", font, XBrushes.Black, new XPoint(50, yOffset + 20));

                gfx.DrawString($"Dinero Recibido: ${DR:F2}", font, XBrushes.Black, new XPoint(50, yOffset + 40));
                gfx.DrawString($"Cambio: ${Cambio:F2}", font, XBrushes.Black, new XPoint(50, yOffset + 60));

                document.Save(filePath);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al generar el ticket: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void TXTDR_TextChanged(object sender, EventArgs e)
        {
            
            if (!decimal.TryParse(TXTDR.Text, out DR))
            {
                DR = 0; 
            }
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
           
        }

        private void buttonTicket_Click(object sender, EventArgs e)
        {
            
        }

        private void buttonTicket_Click_1(object sender, EventArgs e)
        {
            
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
