using System;
using System.Windows.Forms;
using PdfSharp.Drawing;
using PdfSharp.Pdf;

namespace ProyectoGina
{
    public partial class FormOxxo : Form
    {
        public FormOxxo()
        {
            InitializeComponent();
        }

        private void FormOxxo_Load(object sender, EventArgs e)
        {

        }

        private void BTNCONFIRMAR_Click(object sender, EventArgs e)
        {
            // Verificar si los campos requeridos están completos (si los hay)
            if (true) // Aquí puedes agregar validaciones según los campos que quieras verificar
            {
                // Mostrar mensaje de confirmación
                MessageBox.Show($"Pago confirmado", "Confirmado", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Generar el PDF con el total a pagar
                string filePath = "ticket_pago_oxxo.pdf";  // Puedes cambiar la ruta si lo deseas
                GenerarPDFTicket(filePath);

                // Abrir el PDF generado
                System.Diagnostics.Process.Start(new System.Diagnostics.ProcessStartInfo(filePath) { UseShellExecute = true });

                // Cerrar el formulario y abrir el siguiente
                this.Hide();
                FormMainUsuario form2 = new FormMainUsuario("guest");
                form2.ShowDialog();
            }
            else
            {
                MessageBox.Show("Completa los campos correspondientes", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BTNREGRESAR_Click(object sender, EventArgs e)
        {
            // Cerrar este formulario y regresar
            this.Close();
        }

        private void GenerarPDFTicket(string filePath)
        {
            PdfDocument document = new PdfDocument();
            PdfPage page = document.AddPage();
            XGraphics gfx = XGraphics.FromPdfPage(page);
            XFont font = new XFont("Verdana", 12);

            gfx.DrawString("Ticket de Pago OXXO", font, XBrushes.Black, new XPoint(250, 30));
            gfx.DrawString("Fecha: " + DateTime.Now.ToString("dd/MM/yyyy HH:mm"), font, XBrushes.Black, new XPoint(230, 80));

            // Aquí puedes agregar más detalles de la transacción o pago
            decimal total = FormCarrito.montoTotal; // Usamos el total de FormCarrito para el ticket

            gfx.DrawString($"Total a Pagar: ${total:F2}", font, XBrushes.Black, new XPoint(230, 120));

            // Guardar el archivo PDF
            document.Save(filePath);
        }
    }
}
