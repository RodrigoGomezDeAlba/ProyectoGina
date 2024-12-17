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
            usuarioActual = nombreUsuario;  // Asigna el nombre del usuario al campo de clase
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
            LBLUSUARIO.Text = $"Usuario: {usuarioActual}";
            CargarProductosCarrito();
        }

        private void CargarProductosCarrito()
        {
            try
            {
                RCHTBLISTAPROD.Clear();
                RCHTBLISTAPROD.AppendText("Lista de Productos: \n");

                montoTotal = 0;

                foreach (var item in FormMainUsuario.carrito)
                {
                    string producto = item.Item1;
                    decimal cantidad = item.Item2;


                    string query = $"SELECT precio FROM productos WHERE descripcion = '{producto}'";
                    MySqlCommand cmd = new MySqlCommand(query, connection);
                    MySqlDataReader reader = cmd.ExecuteReader();

                    double precio = 0.0;
                    if (reader.Read())
                    {
                        precio = Convert.ToDouble(reader["precio"]);
                    }
                    reader.Close();

                    decimal subtotal = cantidad * (decimal)precio;
                    RCHTBLISTAPROD.AppendText($"{producto} - Cantidad: {cantidad} - Subtotal: ${subtotal:F2}\n");
                    montoTotal += subtotal;
                }

                RCHTBLISTAPROD.AppendText($"\nTotal a pagar: ${montoTotal:F2}");
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
                    ActualizarBaseDeDatos();
                    Process.Start(new ProcessStartInfo(filePath) { UseShellExecute = true });

                    MessageBox.Show("Ticket generado y base de datos actualizada.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
            foreach (var item in FormMainUsuario.carrito)
            {
                string producto = item.Item1;
                decimal cantidad = item.Item2;

                string query = $"SELECT precio FROM productos WHERE descripcion = '{producto}'";
                MySqlCommand cmd = new MySqlCommand(query, connection);
                double precio = Convert.ToDouble(cmd.ExecuteScalar());

                decimal subtotal = cantidad * (decimal)precio;

                gfx.DrawString($"{producto} - Cantidad: {cantidad} - Subtotal: ${subtotal:F2}", font, XBrushes.Black, new XPoint(50, yOffset));
                yOffset += 20;
            }

            gfx.DrawString($"Total a pagar: ${montoTotal:F2}", font, XBrushes.Black, new XPoint(230, yOffset + 20));
            document.Save(filePath);
        }

        private void ActualizarBaseDeDatos()
        {
            try
            {
                foreach (var item in FormMainUsuario.carrito)
                {
                    string producto = item.Item1;
                    decimal cantidad = item.Item2;

                    string queryExistencias = $"UPDATE productos SET existenciaa = existenciaa - {cantidad} WHERE descripcion = '{producto}'";
                    MySqlCommand Existencias = new MySqlCommand(queryExistencias, connection);
                    Existencias.ExecuteNonQuery();
                }

                // Actualizar monto del usuario
                string queryMonto = $"UPDATE login SET monto = monto + {montoTotal} WHERE nombre = '{usuarioActual}'";
                MySqlCommand Monto = new MySqlCommand(queryMonto, connection);
                Monto.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al actualizar la base de datos: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Disconnect();
            }
        }

        private void BTNREGRESARCARRITO_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormMainUsuario f = new FormMainUsuario();
            f.ShowDialog();
        }

        private void RCHTBLISTAPROD_TextChanged(object sender, EventArgs e)
        {

        }

        private void BTNCONFIRMCARRITO_Click(object sender, EventArgs e)
        {
            try
            {
                // Verificar si el carrito tiene productos
                if (FormMainUsuario.carrito.Count == 0)
                {
                    MessageBox.Show("No hay productos en el carrito para confirmar la compra.", "Carrito Vacío", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Actualizar la base de datos
                foreach (var item in FormMainUsuario.carrito)
                {
                    string producto = item.Item1;
                    decimal cantidad = item.Item2;

                    // Restar existencias
                    string queryExistencias = $"UPDATE productos SET existencia = existencia - {cantidad} WHERE descripcion = '{producto}'";
                    MySqlCommand cmdExistencias = new MySqlCommand(queryExistencias, connection);
                    cmdExistencias.ExecuteNonQuery();
                }

                // Actualizar el monto total del usuario
                string queryMonto = $"UPDATE login SET monto = monto + {montoTotal} WHERE nombre = '{usuarioActual}'";
                MySqlCommand cmdMonto = new MySqlCommand(queryMonto, connection);
                cmdMonto.ExecuteNonQuery();

                // Mostrar mensaje de confirmación
                MessageBox.Show($"Acabas de comprar los productos con un monto total de ${montoTotal:F2}.\n¡Compra exitosa!",
                    "Compra Confirmada", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Reiniciar carrito y refrescar lista
                FormMainUsuario.carrito.Clear();
                CargarProductosCarrito();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al confirmar la compra: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}