using System;
using System.Windows.Forms;

namespace ProyectoGina
{
    public partial class FormMetodosPago : Form
    {
        private string usuarioActual;

        public FormMetodosPago(string nombreUsuario)
        {
            InitializeComponent();
            usuarioActual = nombreUsuario;
        }

        private void FormMetodosPago_Load(object sender, EventArgs e)
        {
        }

        private void BTNEFECTIVO_Click(object sender, EventArgs e)
        {
            // Obtener el total a pagar desde FormCarrito
            decimal totalPagar = FormCarrito.montoTotal;  // Usamos la variable pública que contiene el total a pagar

            // Crear y mostrar el formulario FormEfectivo pasando el total a pagar
            this.Hide();
            FormEfectivo f = new FormEfectivo(totalPagar, usuarioActual);  // Pasamos el total al constructor de FormEfectivo
            f.ShowDialog();
        }

        private void BTNTARJETA_Click(object sender, EventArgs e)
        {
        }

        private void BTNTARJETA_Click_1(object sender, EventArgs e)
        {
            try
            {
                // Crear y mostrar el formulario Formtarjeta
                this.Hide();
                Formtarjeta f = new Formtarjeta(usuarioActual);
                f.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al abrir el formulario: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BTNOXXO_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormOxxo f = new FormOxxo(usuarioActual);
            f.ShowDialog();
        }

        private void BTNREGRESAR_Click(object sender, EventArgs e)
        {
            // Cerrar este formulario y regresar
            this.Close();
        }
    }
}
