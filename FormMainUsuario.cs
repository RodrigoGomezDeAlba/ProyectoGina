using System;
using System.Drawing;
using System.Windows.Forms;
using System.Collections.Generic;
using MySql.Data.MySqlClient;

namespace ProyectoGina
{
    public partial class FormMainUsuario : System.Windows.Forms.Form
    {
        private MySqlConnection connection;
        public static int cont;
        public static decimal prodc;
        public static List<string> vec;
        public static bool flag;
        public static List<Tuple<string, decimal>> carrito;
        private List<Tuple<string, decimal>> productos;
        private List<Tuple<string, decimal, Image>> productosConImagen;

        public FormMainUsuario()
        {
            InitializeComponent();


            PICTUREIMAGES.SizeMode = PictureBoxSizeMode.Zoom;


            productos = new List<Tuple<string, decimal>>();
            carrito = new List<Tuple<string, decimal>>();
            vec = new List<string>();
            productosConImagen = new List<Tuple<string, decimal, Image>>();

            Connect();
            CargarProductos();
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


        private void CargarProductos()
        {
            try
            {
                string query = "SELECT descripcion, precio FROM productos";
                MySqlCommand cmd = new MySqlCommand(query, connection);
                MySqlDataReader reader = cmd.ExecuteReader();

                int imageIndex = 0;

                while (reader.Read())
                {
                    string nombre = reader["descripcion"].ToString();
                    decimal precio = Convert.ToDecimal(reader["precio"]);


                    if (imageIndex < ImageProductos.Images.Count)
                    {
                        Image imagenProducto = ImageProductos.Images[imageIndex];
                        productosConImagen.Add(new Tuple<string, decimal, Image>(nombre, precio, imagenProducto));
                    }
                    else
                    {
                        MessageBox.Show($"No hay suficientes imágenes para el producto '{nombre}'", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        break;
                    }

                    imageIndex++;
                }

                reader.Close();


                if (productosConImagen.Count > 0)
                {
                    MostrarProducto(0);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar los productos: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Disconnect();
            }
        }


        private void MostrarProducto(int index)
        {
            if (index >= 0 && index < productosConImagen.Count)
            {
                var producto = productosConImagen[index];
                PICTUREIMAGES.Image = producto.Item3;
                LBLPRODUCTONOMBRE.Text = producto.Item1;
                LBLPRODUCTOPRECIO.Text = $"${producto.Item2}";
            }
        }


        public bool comparar()
        {
            prodc = CONTADORPRODMAINUSU.Value;
            return true;
        }


        private void BTNPASARIMAGEN_Click(object sender, EventArgs e)
        {
            cont = (cont + 1) % productosConImagen.Count;
            MostrarProducto(cont);
        }


        private void BTNSALIRMAINUSU_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }


        private void BTNLOGOUTMAINUSER_Click(object sender, EventArgs e)
        {

            this.Hide();
            FormUsuario form = new FormUsuario();
            form.ShowDialog();
        }


        private void BTNCOMPRARMAINUSU_Click(object sender, EventArgs e)
        {
            if (CONTADORPRODMAINUSU.Value > 0)
            {
                prodc = CONTADORPRODMAINUSU.Value;


                var productoActual = productosConImagen[cont];
                carrito.Add(new Tuple<string, decimal>(productoActual.Item1, prodc));


                CONTADORPRODMAINUSU.Value = 0;

                MessageBox.Show("La fragancia se agregó al carrito", "¡Éxito!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }


        private void BTNCARRITOMAINUSU_Click(object sender, EventArgs e)
        {

        }


        private void buttonRegresarImagen_Click(object sender, EventArgs e)
        {
            cont = (cont - 1 + productosConImagen.Count) % productosConImagen.Count;
            MostrarProducto(cont);
        }


        private void FormMainUsuario_Load(object sender, EventArgs e)
        {

        }


        private void pictureBox1_Click(object sender, EventArgs e)
        {
            string nombreUsuario = "usuarioEjemplo";


            FormCarrito formCarrito = new FormCarrito(nombreUsuario);


            this.Hide();


            formCarrito.ShowDialog();
        }


    }
}