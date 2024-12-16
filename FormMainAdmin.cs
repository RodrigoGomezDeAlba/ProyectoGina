﻿using MySql.Data.MySqlClient;
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
        public FormMainAdmin()
        {
            InitializeComponent();
            this.Connect();

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
        private void FormMainAdmin_Load(object sender, EventArgs e)
        {

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

        public List<FormMainAdmin> consulta()
        {
            List<FormMainAdmin> data = new List<FormMainAdmin>();
            FormMainAdmin item;
            int id;
            string imagen;
            string descripcion;
            double precio;
            int existencia;
            try
            {
                string query = "SELECT * FROM productos ORDER BY existencia ASC";
                MySqlCommand command = new MySqlCommand(query, this.connection);


                MySqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {

                    id = Convert.ToInt32(reader["id"]);
                    imagen = Convert.ToString(reader["imagen"]) ?? "";
                    descripcion = Convert.ToString(reader["descripcion"]) ?? "";
                    precio = Convert.ToDouble(reader["precio"]);
                    existencia = Convert.ToInt32(reader["existencia"]);

                    item = new FormMainAdmin(id, imagen, descripcion, precio, existencia);
                    data.Add(item);

                }
                reader.Close();
                data.ForEach((p) =>
                {


                });

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al leer la tabla de la base de datos: " + ex.Message);
                this.Disconnect();
            }

            return data;
        }

        public void insertar(int idp, string img, string desc, double price, int ext)
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
                MessageBox.Show(query + "\nRegistro Agregado");
            }
            catch (Exception ex)
            {
                MessageBox.Show(query + "\nProducto duplicado" + ex.Message);
                this.Disconnect();
            }
        }

        public FormMainAdmin consultaUnRegistro(int idp)
        {

            FormMainAdmin item = null;
            int id;
            string imagen;
            string descripcion;
            double precio;
            int existencia;
            try
            {
                string query = "SELECT * FROM productos where id=" + idp + ";";
                MySqlCommand command = new MySqlCommand(query, this.connection);


                MySqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {

                    id = Convert.ToInt32(reader["id"]);
                    imagen = Convert.ToString(reader["imagen"]) ?? "";
                    descripcion = Convert.ToString(reader["descripcion"]) ?? "";
                    precio = Convert.ToDouble(reader["precio"]);
                    existencia = Convert.ToInt32(reader["existencia"]);

                    item = new FormMainAdmin(id, imagen, descripcion, precio, existencia);


                }
                reader.Close();


            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al leer la tabla de la base de datos: " + ex.Message);
                this.Disconnect();
            }
            return item;
        }


        public void eliminar(int idp)
        {
            string query = "";
            try
            {

                query = "DELETE FROM productos WHERE id=" + idp + ";";

                MySqlCommand cmd = new MySqlCommand(query, connection);
                cmd.ExecuteNonQuery();
                MessageBox.Show(query + "\nRegistro Eliminado");
            }
            catch (Exception ex)
            {
                MessageBox.Show(query + "\nError " + ex.Message);
                this.Disconnect();
            }
        }


        public void actualizar(int idp, string img, string desc, double price, int ext)
        {

            try
            {
                string query = "UPDATE productos SET id=" + "'" + idp + "'" + ",imagen=" + "'" + img + "'" + ",descripcion=" + "'" + desc + "'" + ",precio=" + "'" + price + "'" + ",existencia=" + "'" + ext + "'" + "where id=" + idp + ";";
                MessageBox.Show(query);
                MySqlCommand cmd = new MySqlCommand(query, connection);
                cmd.ExecuteNonQuery();
                MessageBox.Show("\nRegistro Actualizado");


            }
            catch (Exception ex)
            {
                MessageBox.Show("Error en la actualizacion: " + ex.Message);
                this.Disconnect();
            }
        }

        List<FormMainAdmin> data;

        private void botonConsulta_Click_1(object sender, EventArgs e)
        {
            FormMainAdmin obj = new FormMainAdmin();
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
            id = Convert.ToInt32(this.textboxOtroId.Text);
            imagen = this.textboxOtroImagen.Text;
            descripcion = this.textboxOtroDescripcion.Text;
            precio = Convert.ToDouble(this.textboxOtroPrecio.Text);
            existencia = Convert.ToInt32(this.textboxOtroExistencia.Text);

            FormMainAdmin obj = new FormMainAdmin();
            obj.insertar(id, imagen, descripcion, precio, existencia);
            obj.Disconnect();
        }

        private void BTNADMINBAJAS_Click_1(object sender, EventArgs e)
        {
            FormMainAdmin obj = new FormMainAdmin();
            obj.eliminar(Convert.ToInt32(this.textBoxEliminar.Text));
            obj.Disconnect();
        }

        private void buttonModificar_Click(object sender, EventArgs e)
        {
            int id, existencia;
            double precio;
            string imagen, descripcion;

           
            if (string.IsNullOrWhiteSpace(TextBoxId.Text) ||
                string.IsNullOrWhiteSpace(TextBoxImagen.Text) ||
                string.IsNullOrWhiteSpace(TextBoxDescripcion.Text) ||
                string.IsNullOrWhiteSpace(TextBoxPrecio.Text) ||
                string.IsNullOrWhiteSpace(TextBoxExistencias.Text))
            {
                MessageBox.Show("Ingresa información en todos los campos. Vuelve a intentarlo", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!int.TryParse(TextBoxId.Text, out id))
            {
                MessageBox.Show("El ID debe ser un número de 6 cifras válido. Vuelve a intentarlo.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!double.TryParse(TextBoxPrecio.Text, out precio))
            {
                MessageBox.Show("El precio debe ser un número válido. Vuelve a intentarlo", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!int.TryParse(TextBoxExistencias.Text, out existencia))
            {
                MessageBox.Show("La existencia debe ser un número válido. Vuelve a intentarlo", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }


            imagen = TextBoxImagen.Text;
            descripcion = TextBoxDescripcion.Text;


            try
            {
                FormMainAdmin obj = new FormMainAdmin();
                obj.actualizar(id, imagen, descripcion, precio, existencia);
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
            FormMainAdmin obj = new FormMainAdmin();
            FormMainAdmin aux = obj.consultaUnRegistro(Convert.ToInt32(this.TextBoxId.Text));
            MessageBox.Show(aux.Id + " " + aux.Imagen + " " + aux.Descripcion + " " + aux.Precio + " " + aux.Existencia);


            this.TextBoxId.Text = Convert.ToString(aux.Id);
            this.TextBoxImagen.Text = aux.Imagen;
            this.TextBoxDescripcion.Text = aux.Descripcion;
            this.TextBoxPrecio.Text = Convert.ToString(aux.Precio);
            this.TextBoxExistencias.Text = Convert.ToString(aux.Existencia);


            obj.Disconnect();
        }

        private void TextBoxId_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
