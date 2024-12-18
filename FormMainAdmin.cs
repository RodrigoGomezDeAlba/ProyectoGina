using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Intrinsics.Arm;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using Application = System.Windows.Forms.Application;


namespace ProyectoGina
{
    public partial class FormMainAdmin : Form
    {
        private int id;
        private string imagen;
        private string descripcion;
        private double precio;
        private int existencia;
        private string adminActual;
        private MySqlConnection connection;

        public FormMainAdmin(string nombreAdmin)
        {
            InitializeComponent();
            Connect();
            adminActual = nombreAdmin;
            labelNOMBRE.Text = $"{adminActual}";
        }

        public FormMainAdmin(int id, string imagen, string descripcion, double precio, int existencia)
        {
            this.Id = id;
            this.Imagen = imagen;
            this.Descripcion = descripcion;
            this.Precio = precio;
            this.Existencia = existencia;
        }

        public int Id { get => id; set => id = value; }
        public string Imagen { get => imagen; set => imagen = value; }
        public string Descripcion { get => descripcion; set => descripcion = value; }
        public double Precio { get => precio; set => precio = value; }
        public int Existencia { get => existencia; set => existencia = value; }

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

        private void FormMainAdmin_Load(object sender, EventArgs e)
        {
            // Manejador vacío
        }

        private void BTNADMINSALIR_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void BTNADMINLOGOUT_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormUsuario form = new FormUsuario();
            form.ShowDialog();
        }

        private List<FormMainAdmin> consulta()
        {
            List<FormMainAdmin> data = new List<FormMainAdmin>();
            try
            {
                string query = "SELECT * FROM productos ORDER BY existencia ASC";
                MySqlCommand command = new MySqlCommand(query, connection);
                MySqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    int id = Convert.ToInt32(reader["id"]);
                    string imagen = Convert.ToString(reader["imagen"]) ?? "";
                    string descripcion = Convert.ToString(reader["descripcion"]) ?? "";
                    double precio = Convert.ToDouble(reader["precio"]);
                    int existencia = Convert.ToInt32(reader["existencia"]);

                    data.Add(new FormMainAdmin(id, imagen, descripcion, precio, existencia));
                }

                reader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al leer la tabla de la base de datos: " + ex.Message);
                Disconnect();
            }

            return data;
        }

        private void insertar(int idp, string img, string desc, double price, int ext)
        {
            string query = "";
            try
            {
                query = "INSERT INTO productos (id,imagen,descripcion,precio,existencia) VALUES ("
                        + "'" + idp + "',"
                        + "'" + img + "',"
                        + "'" + desc + "',"
                        + "'" + price + "',"
                        + "'" + ext + "')";

                MySqlCommand cmd = new MySqlCommand(query, connection);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Registro Agregado");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al agregar producto: {ex.Message}");
                Disconnect();
            }
        }

        private void eliminar(int idp)
        {
            string query = "";
            try
            {
                query = "DELETE FROM productos WHERE id=" + idp + ";";
                MySqlCommand cmd = new MySqlCommand(query, connection);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Registro Eliminado");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al eliminar producto: {ex.Message}");
                Disconnect();
            }
        }

        private void actualizar(int idp, double price, int ext)
        {
            try
            {
                string query = "UPDATE productos SET precio='" + price + "', existencia='" + ext + "' WHERE id=" + idp + ";";
                MySqlCommand cmd = new MySqlCommand(query, connection);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Registro Actualizado");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error en la actualización: {ex.Message}");
                Disconnect();
            }
        }

        private FormMainAdmin consultaUnRegistro(int idp)
        {
            FormMainAdmin item = null;
            try
            {
                string query = "SELECT * FROM productos WHERE id=" + idp + ";";
                MySqlCommand command = new MySqlCommand(query, connection);
                MySqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    int id = Convert.ToInt32(reader["id"]);
                    string imagen = Convert.ToString(reader["imagen"]) ?? "";
                    string descripcion = Convert.ToString(reader["descripcion"]) ?? "";
                    double precio = Convert.ToDouble(reader["precio"]);
                    int existencia = Convert.ToInt32(reader["existencia"]);

                    item = new FormMainAdmin(id, imagen, descripcion, precio, existencia);
                }

                reader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al consultar registro: " + ex.Message);
                Disconnect();
            }

            return item;
        }

        private int ObtenerNumeroDeProductos()
        {
            int totalProductos = 0;
            try
            {
                string query = "SELECT COUNT(*) FROM productos";
                MySqlCommand command = new MySqlCommand(query, connection);
                totalProductos = Convert.ToInt32(command.ExecuteScalar());
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al contar productos: {ex.Message}");
                Disconnect();
            }

            return totalProductos;
        }
        private void MostrarVentasTotales()
        {
            try
            {
                string query = "SELECT SUM(monto) AS totalVentas FROM login";
                MySqlCommand cmd = new MySqlCommand(query, connection);
                object result = cmd.ExecuteScalar();

                double totalVentas = Convert.ToDouble(result);
                labelVentasTotales.Text = $"${totalVentas:F2}";
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al calcular las ventas totales: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Disconnect()
        {
            if (connection != null && connection.State == System.Data.ConnectionState.Open)
            {
                connection.Close();
            }
        }

        List<FormMainAdmin> data;

        private void botonConsulta_Click_1(object sender, EventArgs e)
        {
            FormMainAdmin obj = new FormMainAdmin("AdminActual");
            data = obj.consulta();


            this.richTextBoxDatos.Clear();
            data.ForEach(p =>
            {
                this.richTextBoxDatos.AppendText("Id: " + p.Id + "\n" + "Imagen:" + p.Imagen + "\n" + "Descripcion: " + p.Descripcion + "\n" + "Precio: " + p.Precio + "\n" + "Existencia: " + p.Existencia + "\n\n");
            });

            obj.Disconnect();

        }

        private void BTNADMINALTAS_Click_1(object sender, EventArgs e)
        {
            int id;
            string imagen;
            string descripcion;
            double precio;
            int existencia;

            if (!int.TryParse(this.textboxOtroId.Text, out id) ||
                string.IsNullOrWhiteSpace(this.textboxOtroImagen.Text) ||
                string.IsNullOrWhiteSpace(this.textboxOtroDescripcion.Text) ||
                !double.TryParse(this.textboxOtroPrecio.Text, out precio) ||
                !int.TryParse(this.textboxOtroExistencia.Text, out existencia))
            {
                MessageBox.Show("Completa todos los campos correctamente.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            imagen = this.textboxOtroImagen.Text;
            descripcion = this.textboxOtroDescripcion.Text;

            int totalProductos = ObtenerNumeroDeProductos();
            if (totalProductos >= 10)
            {
                MessageBox.Show("No puedes registrar mas de 10 productos en el inventario.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                FormMainAdmin obj = new FormMainAdmin("AdminActual");
                obj.insertar(id, imagen, descripcion, precio, existencia);
                obj.Disconnect();
                MessageBox.Show("Producto agregado correctamente.", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al agregar el producto: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }

        private void BTNADMINBAJAS_Click_1(object sender, EventArgs e)
        {
            if (!int.TryParse(textBoxEliminar.Text, out int id))
            {
                MessageBox.Show("Ingrese un ID valido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int totalProductos = ObtenerNumeroDeProductos();

            if (totalProductos <= 6)
            {
                MessageBox.Show("No puedes tener menos de 6 productos en el inventario.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            FormMainAdmin obj = new FormMainAdmin("AdminActual");
            obj.eliminar(Convert.ToInt32(this.textBoxEliminar.Text));
            obj.Disconnect();
        }

        private void buttonModificar_Click(object sender, EventArgs e)
        {
            int id, existencia;
            double precio;



            if (string.IsNullOrWhiteSpace(TextBoxId.Text) ||
                string.IsNullOrWhiteSpace(TextBoxPrecio.Text) ||
                string.IsNullOrWhiteSpace(TextBoxExistencias.Text))
            {
                MessageBox.Show("LLena todos los campos por favor. Vuelve a intentarlo", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!int.TryParse(TextBoxId.Text, out id))
            {
                MessageBox.Show("El ID debe ser un numero de 6 cifras. Vuelve a intentarlo.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!double.TryParse(TextBoxPrecio.Text, out precio))
            {
                MessageBox.Show("Ingresa un numero valido para el precio. Vuelve a intentarlo", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!int.TryParse(TextBoxExistencias.Text, out existencia))
            {
                MessageBox.Show("Ingresa un numero valido para la existencia. Vuelve a intentarlo", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }



            try
            {
                FormMainAdmin obj = new FormMainAdmin("AdminActual");
                obj.actualizar(id, precio, existencia);
                obj.Disconnect();

                MessageBox.Show("Actualización realizada con éxito.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ocurrió un error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonDatos_Click_1(object sender, EventArgs e)
        {
            FormMainAdmin obj = new FormMainAdmin("AdminActual");
            FormMainAdmin aux = obj.consultaUnRegistro(Convert.ToInt32(this.TextBoxId.Text));
            MessageBox.Show(aux.Id + " " + aux.Imagen + " " + aux.Descripcion + " " + aux.Precio + " " + aux.Existencia);


            this.TextBoxId.Text = Convert.ToString(aux.Id);
            this.TextBoxPrecio.Text = Convert.ToString(aux.Precio);
            this.TextBoxExistencias.Text = Convert.ToString(aux.Existencia);


            obj.Disconnect();
        }

        private void TextBoxId_TextChanged(object sender, EventArgs e)
        {

        }

        private void BTNADMINGRAFICA_Click(object sender, EventArgs e)
        {
            MostrarVentasTotales();
        }

        private void richTextBoxDatos_TextChanged(object sender, EventArgs e)
        {

        }
    }
}