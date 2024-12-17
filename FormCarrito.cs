using System;
using System.Diagnostics;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using PdfSharp.Drawing;
using PdfSharp.Pdf;

namespace ProyectoGina
{
    public partial class FormCarrito : Form
    {
        private MySqlConnection connection;
        private string usuarioActual;
        private decimal montoTotal = 0;

        public FormCarrito(string nombreUsuario)
        {
            InitializeComponent();
            usuarioActual = nombreUsuario;
            Connect();
        }

        public FormCarrito()
        {
        }

        public void Connect()
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

        public void Disconnect()
        {
            if (connection != null && connection.State == System.Data.ConnectionState.Open)
            {
                connection.Close();
            }
        }

        private void FormCarrito_Load(object sender, EventArgs e)
        {
            LBLUSUARIO.Text = $"{usuarioActual}";
            CargarProductosCarrito();
        }

        private void CargarProductosCarrito()
        {
            try
            {
                RCHTBLISTAPROD.Clear();
                RCHTBLISTAPROD.AppendText("Lista de Productos: \n");

                decimal subtotalgeneral = 0;
                decimal comisiontotal = 0;

                foreach (var item in FormMainUsuario.carrito)
                {
                    string producto = item.Item1;
                    decimal cantidad = item.Item2;

                    string query = $"SELECT precio FROM productos WHERE descripcion = '{producto}'";
                    MySqlCommand cargar = new MySqlCommand(query, connection);
                    MySqlDataReader reader = cargar.ExecuteReader();

                    double precio = 0.0;
                    if (reader.Read())
                    {
                        precio = Convert.ToDouble(reader["precio"]);
                    }
                    reader.Close();

                    decimal subtotal = cantidad * (decimal)precio;
                    decimal comision = subtotal * 0.06m;
                    decimal totalcomision = subtotal + comision;

                    RCHTBLISTAPROD.AppendText($"{producto} - Cantidad: {cantidad}\n");
                    RCHTBLISTAPROD.AppendText($"Subtotal: ${subtotal:F2}\n");
                    RCHTBLISTAPROD.AppendText($"Comisión (6%): ${comision:F2}\n");
                    RCHTBLISTAPROD.AppendText($"Total con Comisión: ${totalcomision:F2}\n\n");

                    subtotalgeneral += subtotal;
                    comisiontotal += comision;
                }

                montoTotal = subtotalgeneral + comisiontotal;

                RCHTBLISTAPROD.AppendText($"Subtotal General: ${subtotalgeneral:F2}\n");
                RCHTBLISTAPROD.AppendText($"Comisión Total (6%): ${comisiontotal:F2}\n");
                RCHTBLISTAPROD.AppendText($"Total a Pagar: ${montoTotal:F2}\n");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar el carrito: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Disconnect();
            }
        }

        private void BTNTICKETCARRITO_Click(object sender, EventArgs e)
        {
            try
            {
                SaveFileDialog saveFileDialog = new SaveFileDialog
                {
                    Title = "Guardar Ticket",
                    Filter = "PDF Files (.pdf)|.pdf",
                    FileName = "ticket_carrito.pdf"
                };

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string filePath = saveFileDialog.FileName;
                    GenerarPDFTicket(filePath);
                    Process.Start(new ProcessStartInfo(filePath) { UseShellExecute = true });

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al generar el ticket: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void GenerarPDFTicket(string filePath)
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
                MySqlCommand ticket = new MySqlCommand(query, connection);
                double precio = Convert.ToDouble(ticket.ExecuteScalar());

                decimal subtotal = cantidad * (decimal)precio;
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

            montoTotal = subtotalGeneral + comisionTotal;

            gfx.DrawString($"Subtotal General: ${subtotalGeneral:F2}", font, XBrushes.Black, new XPoint(230, yOffset));
            yOffset += 20;
            gfx.DrawString($"Comisión Total (6%): ${comisionTotal:F2}", font, XBrushes.Black, new XPoint(230, yOffset));
            yOffset += 20;
            gfx.DrawString($"Total a Pagar: ${montoTotal:F2}", font, XBrushes.Black, new XPoint(230, yOffset + 20));

            document.Save(filePath);
        }



        private void BTNREGRESARCARRITO_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormMainUsuario f = new FormMainUsuario(usuarioActual);
            f.ShowDialog();
        }

        private void RCHTBLISTAPROD_TextChanged(object sender, EventArgs e)
        {

        }

        private void BTNCONFIRMCARRITO_Click(object sender, EventArgs e)
        {

        }

        private void LBLUSUARIO_Click(object sender, EventArgs e)
        {

        }
    }
}