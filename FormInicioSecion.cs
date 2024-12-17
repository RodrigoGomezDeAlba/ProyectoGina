using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Runtime.InteropServices.JavaScript.JSType;
using MySql.Data.MySqlClient;

namespace ProyectoGina
{
    public partial class FormUsuario : System.Windows.Forms.Form
    {
        public string usuario;
        public string contra;

        public FormUsuario()
        {
            InitializeComponent();
            this.Connect();
            LOGOSLOGAN.SizeMode = PictureBoxSizeMode.Zoom; 
            usuario = TXTUsuario.Text;
            contra = TEXTContra.Text;           
            LoadImages();
        }
        private MySqlConnection connection;

        public void Disconnect()
        {
            if (connection != null && connection.State == System.Data.ConnectionState.Open)
            {
                connection.Close();

            }
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

        public void LoginValidacion()
        {

            string usuario = TXTUsuario.Text;
            string contrasena = TEXTContra.Text;


            if (string.IsNullOrWhiteSpace(usuario) || string.IsNullOrWhiteSpace(contrasena))
            {
                MessageBox.Show("Campos vacíos, ingresa un usuario y contraseña.", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {

                string queryUsuario = $"SELECT * FROM login WHERE usuario = '{usuario}'";
                MySqlCommand commandUsuario = new MySqlCommand(queryUsuario, this.connection);
                MySqlDataReader readerUsuario = commandUsuario.ExecuteReader();

                if (readerUsuario.Read())
                {
                    readerUsuario.Close();
                    string queryContrasena = $"SELECT * FROM login WHERE usuario = '{usuario}' AND contrasena = '{contrasena}'";
                    MySqlCommand commandContrasena = new MySqlCommand(queryContrasena, this.connection);
                    MySqlDataReader readerContrasena = commandContrasena.ExecuteReader();

                    if (readerContrasena.Read())
                    {
                        string nombreusuario = readerContrasena.GetString("usuario");
                        readerContrasena.Close();

                        if (nombreusuario == "admin")
                        {
                            MessageBox.Show($"Bienvenido, administrador. Entrando como {nombreusuario}.", "Acceso Exitoso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            this.Hide();
                            FormMainAdmin form4 = new FormMainAdmin(nombreusuario);
                            form4.ShowDialog();
                        }
                        else
                        {
                            MessageBox.Show($"Bienvenido, {nombreusuario}. Disfruta tu estadía en LFR perfumery.", "Acceso Exitoso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            this.Hide();
                            FormMainUsuario form3 = new FormMainUsuario(nombreusuario);
                            form3.ShowDialog();
                        }
                    }
                    else
                    {

                        readerContrasena.Close();
                        MessageBox.Show("Contraseña incorrecta. Intenta nuevamente.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    readerUsuario.Close();
                    MessageBox.Show("Usuario no encontrado. Verifica el nombre del usuario.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error en el inicio sesión: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadImages()
        {
            string basePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Images");
            LOGOSLOGAN.Image = LoadImageFromPath(Path.Combine(basePath, "LOGOSLOGAN.png"));
        }

        private Image LoadImageFromPath(string imagePath)
        {
        
                return Image.FromFile(imagePath);
           
        }

        private void FormUsuario_Load(object sender, EventArgs e)
        {

        }

        private void TXTUsuario_TextChanged(object sender, EventArgs e)
        {
            usuario = TXTUsuario.Text;
        }

        private void TEXTContra_TextChanged(object sender, EventArgs e)
        {
            contra = TEXTContra.Text;
        }

        private void BTNSalirF2_Click(object sender, EventArgs e)
        {
            Application.Exit();
            this.Disconnect();
        }

        private void BTNIngresar_Click(object sender, EventArgs e)
        {
            LoginValidacion();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormMainUsuario form3 = new FormMainUsuario("usuarioActual");
            form3.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormMainAdmin form4 = new FormMainAdmin("usuarioActual");
            form4.ShowDialog();
        }
    }
}