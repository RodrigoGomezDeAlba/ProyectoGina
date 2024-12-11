namespace ProyectoGina
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            CCB.SizeMode= PictureBoxSizeMode.Zoom; // Ajusta la imagen al PictureBox
            CCB.Image = Image.FromFile("C:\\Users\\manue\\OneDrive\\Documentos\\UAA\\Semestre 3\\Programacion 2\\Proyecto final\\ProyectoGina/logo-ccb.png");
            UAALOGO.SizeMode = PictureBoxSizeMode.Zoom; // Ajusta la imagen al PictureBox
            UAALOGO.Image = Image.FromFile("C:\\Users\\manue\\OneDrive\\Documentos\\UAA\\Semestre 3\\Programacion 2\\Proyecto final\\ProyectoGina/UAALOGO.png");
            DATOS.SizeMode = PictureBoxSizeMode.Zoom; // Ajusta la imagen al PictureBox
            DATOS.Image = Image.FromFile("C:\\Users\\manue\\OneDrive\\Documentos\\UAA\\Semestre 3\\Programacion 2\\Proyecto final\\ProyectoGina/Datos.png");
            LOGOSLOGAN.SizeMode = PictureBoxSizeMode.Zoom; // Ajusta la imagen al PictureBox
            LOGOSLOGAN.Image = Image.FromFile("C:\\Users\\manue\\OneDrive\\Documentos\\UAA\\Semestre 3\\Programacion 2\\Proyecto final\\ProyectoGina/LOGOSLOGAN.png");
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            FECHALBL.Text = DateTime.Now.ToString("dd/MM/yyyy"); // Muestra la fecha en formato día/mes/año
        }

        private void BTNPortadaSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
