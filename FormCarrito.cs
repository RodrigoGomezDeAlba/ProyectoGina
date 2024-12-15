using System;
using System.IO;
using System.Diagnostics;
using System.Windows.Forms;
using PdfSharp.Drawing;
using PdfSharp.Pdf;

namespace ProyectoGina
{
    public partial class FormCarrito : Form
    {
        public FormCarrito()
        {
            InitializeComponent();
        }

        private void FormCarrito_Load(object sender, EventArgs e)
        {
        }

        private void BTNREGRESARCARRITO_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormMainUsuario f = new FormMainUsuario();
            f.ShowDialog();
        }

        private void BTNTICKETCARRITO_Click(object sender, EventArgs e)
        {
            try
            {
                // Crear un cuadro de diálogo para guardar el archivo
                SaveFileDialog saveFileDialog = new SaveFileDialog
                {
                    Title = "Guardar Ticket",
                    Filter = "PDF Files (*.pdf)|*.pdf",
                    FileName = "ticket_carrito.pdf"
                };

                // Si el usuario selecciona una ruta y confirma
                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string filePath = saveFileDialog.FileName;

                    // Crear un nuevo documento PDF
                    PdfDocument document = new PdfDocument();
                    PdfPage page = document.AddPage();
                    XGraphics gfx = XGraphics.FromPdfPage(page);

                    // Configurar fuente
                    XFont font = new XFont("Verdana", 12); // Omite XFontStyle.Regular

                    // Agregar contenido al documento
                    gfx.DrawString("Ticket de Compra", font, XBrushes.Black, new XPoint(250, 30));

                    gfx.DrawString("Fecha: " + DateTime.Now.ToString("dd/MM/yyyy HH:mm"), font, XBrushes.Black, new XPoint(50, 80));

                    // Agregar los detalles del carrito
                    gfx.DrawString("Producto 1 - Cantidad: 2 - Precio: $10.00", font, XBrushes.Black, new XPoint(50, 120));
                    gfx.DrawString("Producto 2 - Cantidad: 1 - Precio: $25.50", font, XBrushes.Black, new XPoint(50, 140));
                    gfx.DrawString("Producto 3 - Cantidad: 3 - Precio: $15.00", font, XBrushes.Black, new XPoint(50, 160));

                    // Calcular el total
                    float total = (2 * 10.00f) + (1 * 25.50f) + (3 * 15.00f);
                    gfx.DrawString($"Total a pagar: ${total:F2}", font, XBrushes.Black, new XPoint(50, 200));

                    // Guardar el documento PDF
                    document.Save(filePath);

                    // Abrir el PDF generado
                    System.Diagnostics.Process.Start(new System.Diagnostics.ProcessStartInfo(filePath) { UseShellExecute = true });

                    MessageBox.Show("Ticket generado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al generar el ticket: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
