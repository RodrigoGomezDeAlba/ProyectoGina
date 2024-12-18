

namespace ProyectoGina
{
    public partial class FormPortada : System.Windows.Forms.Form
    {
        public FormPortada()
        {
            InitializeComponent();
            DATOS.SizeMode = PictureBoxSizeMode.Zoom;
            CCB.SizeMode = PictureBoxSizeMode.Zoom;
            UAALOGO.SizeMode = PictureBoxSizeMode.Zoom;
            LoadImages();
        }

        private void LoadImages()
        {
            string basePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Images");
            CCB.Image = LoadImageFromPath(Path.Combine(basePath, "logo-ccb.png"));
            UAALOGO.Image = LoadImageFromPath(Path.Combine(basePath, "UAALOGO.png"));
            DATOS.Image = LoadImageFromPath(Path.Combine(basePath, "Datos.png"));
        }

        private Image LoadImageFromPath(string imagePath)
        {
            if (File.Exists(imagePath))
            {
                return Image.FromFile(imagePath);
            }
            else
            {
                MessageBox.Show($"No se encontr� la imagen en la ruta: {imagePath}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            FECHALBL.Text = DateTime.Now.ToString("dd/MM/yyyy"); 
        }

        private void BTNPortadaSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void BTNPortadaIngresar_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormUsuario form2 = new FormUsuario();
            form2.ShowDialog();
        }

        private void CCB_Click(object sender, EventArgs e)
        {

        }
    }
}
