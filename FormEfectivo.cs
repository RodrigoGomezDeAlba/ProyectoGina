using System;
using System.Diagnostics;
using System.Windows.Forms;
using PdfSharp.Drawing;
using PdfSharp.Pdf;

namespace ProyectoGina
{
    public partial class FormEfectivo : Form
    {
        public static decimal DR; // Dinero recibido
        public static decimal Cambio; // Cambio
        private decimal totalPagar; // Total a pagar recibido desde FormCarrito

        // Constructor modificado para recibir el total a pagar
        public FormEfectivo(decimal total)
        {
            InitializeComponent();
            totalPagar = total; // Asignar el total recibido al campo local

            // Inicializar el timer correctamente
            timer = new System.Windows.Forms.Timer();
            timer.Interval = 100; // Intervalo en milisegundos (100 ms)
            timer.Tick += Timer_Tick; // Asignar el evento Tick
            timer.Tick += TXTDR_TextChanged;

            timer.Start(); // Iniciar el timer
        }

        private void FormEfectivo_Load(object sender, EventArgs e)
        {
            // Mostrar el total en el TextBox al cargar el formulario
            TXTTOT.Text = totalPagar.ToString("F2");
        }

        private void BTNREGRESAR_Click(object sender, EventArgs e)
        {
            // Cerrar este formulario y regresar
            this.Close();
        }

        private void BTNCONFIRMAR_Click(object sender, EventArgs e)
        {
            decimal total;
            if (decimal.TryParse(TXTTOT.Text, out total))
            {
                if (DR >= total)
                {
                    Cambio = DR - total;
                    MessageBox.Show($"Pago confirmado.\nSu cambio es: ${Cambio:F2}", "Cambio", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // Generar el PDF
                    string filePath = $"Ticket_{DateTime.Now:yyyyMMdd_HHmmss}.pdf";
                    GenerarPDFTicket(filePath);

                    // Imprimir el PDF
                    Process.Start(new ProcessStartInfo(filePath) { UseShellExecute = true });

                    // Cerrar este formulario y regresar al menú principal
                    this.Hide();
                    FormMainUsuario form2 = new FormMainUsuario("guest");
                    form2.ShowDialog();
                }
                else
                {
                    MessageBox.Show("El dinero recibido no es suficiente.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void GenerarPDFTicket(string filePath)
        {
            PdfDocument document = new PdfDocument();
            PdfPage page = document.AddPage();
            XGraphics gfx = XGraphics.FromPdfPage(page);
            XFont font = new XFont("Verdana", 12);

            gfx.DrawString("Ticket de Compra", font, XBrushes.Black, new XPoint(250, 30));
            gfx.DrawString("Fecha: " + DateTime.Now.ToString("dd/MM/yyyy HH:mm"), font, XBrushes.Black, new XPoint(230, 80));

            int yOffset = 120;

            decimal comision = totalPagar * 0.06m;
            decimal subtotalGeneral = totalPagar - comision;

            gfx.DrawString($"Subtotal General: ${subtotalGeneral:F2}", font, XBrushes.Black, new XPoint(50, yOffset));
            yOffset += 20;
            gfx.DrawString($"Comisión (6%): ${comision:F2}", font, XBrushes.Black, new XPoint(50, yOffset));
            yOffset += 20;
            gfx.DrawString($"Total: ${totalPagar:F2}", font, XBrushes.Black, new XPoint(50, yOffset));
            yOffset += 40;
            gfx.DrawString($"Dinero Recibido: ${DR:F2}", font, XBrushes.Black, new XPoint(50, yOffset));
            yOffset += 20;
            gfx.DrawString($"Cambio: ${Cambio:F2}", font, XBrushes.Black, new XPoint(50, yOffset));

            document.Save(filePath);
        }

        private void TXTDR_TextChanged(object sender, EventArgs e)
        {
            // Leer el valor del TextBox y asignarlo a DR
            if (!decimal.TryParse(TXTDR.Text, out DR))
            {
                DR = 0; // Si no es válido, asignar 0
            }
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            // El timer puede usarse para otras validaciones en el futuro si es necesario
            // Actualmente no realiza ninguna acción adicional
        }
    }
}
