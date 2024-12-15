using System;
using System.Drawing;
using System.Windows.Forms;


namespace ProyectoGina
{
    public partial class FormMainUsuario : System.Windows.Forms.Form
    {
        public static int cont;
        public static decimal prodc;//productos a comprar
        public static string[] vec;
        public static bool flag;//bandera para transportar al carrito

        public FormMainUsuario()
        {
            InitializeComponent();

            // Configuración del PictureBox
            PICTUREIMAGES.SizeMode = PictureBoxSizeMode.Zoom; // Asegura que las imágenes se escalen correctamente

            // Asignar la primera imagen
            PICTUREIMAGES.Image = ImageProductos.Images[cont];

            //asiganr los nombres de los perfumes al vector
            vec = new string[10];
            vec[0] = "Armani Code Perfum";
            vec[1] = "Hugo Boss Bottled Absolu";
            vec[2] = "Givenchy Society Extreme";
            vec[3] = "Y Le Parfum";
            vec[4] = "Myself";
            vec[5] = "BDK Gris Charnel";
            vec[6] = "Parfums de Marly Layton";
            vec[7] = "Nishane Hacivat";
            vec[8] = "Creed Silver Mountain Water";
            vec[9] = "Byredo Mojave Ghost";
        }

        public bool comparar()
        {
            prodc=CONTADORPRODMAINUSU.Value;
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
            if (comparar())
            {
                MessageBox.Show("La fragancia se agregó al carrito", "EXITO!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                //existencias-prodc;
            }
        }

        private void BTNCARRITOMAINUSU_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormCarrito f = new FormCarrito();
            f.ShowDialog();
        }

        private void FormMainUsuario_Load(object sender, EventArgs e)
        {

        }
    }
}
