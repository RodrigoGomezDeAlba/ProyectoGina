using System;
using System.Drawing;
using System.Windows.Forms;
using System.Collections.Generic;



namespace ProyectoGina
{
    public partial class FormMainUsuario : System.Windows.Forms.Form
    {
        public static int cont;
        public static decimal prodc;//productos a comprar
        public static string[] vec;
        public static bool flag;//bandera para transportar al carrito
        public static List<Tuple<string, decimal>> carrito; // Lista de productos y cantidades


        public FormMainUsuario()
        {
            InitializeComponent();

            // Configuración del PictureBox
            PICTUREIMAGES.SizeMode = PictureBoxSizeMode.Zoom; // Asegura que las imágenes se escalen correctamente

            // Asignar la primera imagen
            PICTUREIMAGES.Image = ImageProductos.Images[cont];

            //asiganr los nombres de los perfumes al vector
            vec = new string[10];
            vec[0] = "Armani Code Parfum";
            vec[1] = "BDK Gris Channel";
            vec[2] = "Creed Silver Mountain Water";
            vec[3] = "Givenchy Society Extreme";
            vec[4] = "Hugo Boss Absolu";
            vec[5] = "Byredo Mojave Ghost";
            vec[6] = "Myself";
            vec[7] = "Nishane Hacivat";
            vec[8] = "Parfums Marly Layton";
            vec[9] = "Y Le Parfum";

            carrito = new List<Tuple<string, decimal>>();
        }

        public bool comparar()
        {
            prodc = CONTADORPRODMAINUSU.Value;
            /*if (existencias<prodc)
            {
                MessageBox.Show("No hay existencias suficientes", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else
            {
                CONTADORPRODMAINUSU.Value=0;
                return true;
            }*/
            return true;
        }

        private void BTNPASARIMAGEN_Click(object sender, EventArgs e)
        {
            // Incrementar el contador
            cont++;

            // Validar que el contador no exceda la cantidad de imágenes
            if (cont >= ImageProductos.Images.Count)
            {
                cont = 0; // Reiniciar al inicio
            }

            // Cambiar la imagen en el PictureBox
            PICTUREIMAGES.Image = ImageProductos.Images[cont];
        }

        private void BTNSALIRMAINUSU_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void BTNLOGOUTMAINUSER_Click(object sender, EventArgs e)
        {
            //Transporta a la pantalla de incicio de secion
            this.Hide();
            FormUsuario form = new FormUsuario();
            form.ShowDialog();
        }

        private void BTNCOMPRARMAINUSU_Click(object sender, EventArgs e)
        {
            if(CONTADORPRODMAINUSU.Value>0)
            {
                if (comparar())
                {
                    // Agregar el producto al carrito
                    string productoSeleccionado = vec[cont];
                    carrito.Add(new Tuple<string, decimal>(productoSeleccionado, prodc));
                    CONTADORPRODMAINUSU.Value = 0;

                    // Mostrar mensaje de éxito
                    MessageBox.Show("La fragancia se agregó al carrito", "¡Éxito!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void BTNCARRITOMAINUSU_Click(object sender, EventArgs e)
        {

        }

        private void FormMainUsuario_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormCarrito f = new FormCarrito();
            f.ShowDialog();
        }

        private void buttonRegresarImagen_Click(object sender, EventArgs e)
        {
            // Decremento el contador
            cont--;

            // Validar que el contador no exceda la cantidad de imágenes
            if (cont >= ImageProductos.Images.Count)
            {
                cont = 0; // Reiniciar al inicio
            }

            // Cambiar la imagen en el PictureBox
            PICTUREIMAGES.Image = ImageProductos.Images[cont];
        }
    }
}
