using System;
using System.Drawing;
using System.Windows.Forms;

namespace ProyectoGina
{
    public partial class FormMainUsuario : System.Windows.Forms.Form
    {
        public static int cont;

        public FormMainUsuario()
        {
            InitializeComponent();

            // Configuración del PictureBox
            PICTUREIMAGES.SizeMode = PictureBoxSizeMode.Zoom; // Asegura que las imágenes se escalen correctamente

            // Asignar la primera imagen
            PICTUREIMAGES.Image = ImageProductos.Images[cont];
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
    }
}
