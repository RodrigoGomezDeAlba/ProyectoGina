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
    public partial class FormMainUsuario : System.Windows.Forms.Form
    {
        public static int cont;
        public FormMainUsuario()
        {
            InitializeComponent();
            LBLImage.Image = ImageProductos.Images[0];
        }

        private void BTNPASARIMAGEN_Click(object sender, EventArgs e)
        {
            cont++;
            LBLImage.Image=ImageProductos.Images[cont];

            if (cont == 9)
            {
                cont = 0;
            }

        }
    }
}
