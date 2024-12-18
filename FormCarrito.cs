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
        public static decimal st;//subtotal

        private MySqlConnection connection;
        private string usuarioActual;
        public static decimal montoTotal = 0;

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

        private void BTNCONFIRMCARRITO_Click_1(object sender, EventArgs e)
        {
            FormMetodosPago f = new FormMetodosPago(usuarioActual);
            f.ShowDialog();
        }

        private void LBLUSUARIO_Click_1(object sender, EventArgs e)
        {

        }
    }
}