using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoGina
{
    public partial class FormUsuario : Form
    {
        public string usuario;
        public string contra;

        public FormUsuario()
        {
            InitializeComponent();

            LOGOSLOGAN.SizeMode = PictureBoxSizeMode.Zoom; // Ajusta la imagen al PictureBox
            LOGOSLOGAN.Image = Image.FromFile("C:\\Users\\manue\\OneDrive\\Documentos\\UAA\\Semestre 3\\Programacion 2\\Proyecto final\\ProyectoGina/LOGOSLOGAN.png");
            usuario = TXTUsuario.Text;
            contra = TXTUsuario.Text;
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
            contra = TXTUsuario.Text;
        }
    }
}
