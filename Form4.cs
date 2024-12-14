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
    public partial class FormMainAdmin : Form
    {
        public FormMainAdmin()
        {
            InitializeComponent();
        }

        private void FormMainAdmin_Load(object sender, EventArgs e)
        {

        }

        private void BTNADMINSALIR_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void BTNADMINLOGOUT_Click(object sender, EventArgs e)
        {
            //Transporta a la pantalla de incicio de secion
            this.Hide();
            FormUsuario form = new FormUsuario();
            form.ShowDialog();
        }
    }
}
