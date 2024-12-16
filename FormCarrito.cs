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
        public static double[] vecp;
        public FormCarrito()
        {
            InitializeComponent();

            vecp = new double[] { 3714.00, 3571.00, 3356.00, 3428.00, 3571.00, 6185.00, 4985.00, 5072.00, 4914.00, 4714.00 };
        }

        private void FormCarrito_Load(object sender, EventArgs e)
        {
            // Limpiar el contenido del RichTextBox
            RCHTBLISTAPROD.Clear();
            if (RCHTBLISTAPROD.Text == "")
            {
                RCHTBLISTAPROD.AppendText("Lista de Productos: \n");
            }
            // Validar que FormMainUsuario.vec y demás elementos están inicializados
            if (FormMainUsuario.vec != null && FormMainUsuario.vec.Length > 0)
            {
                // Agregar contenido al RichTextBox
                RCHTBLISTAPROD.AppendText($"{FormMainUsuario.prodc} - {FormMainUsuario.vec[FormMainUsuario.cont]} - ${vecp[FormMainUsuario.cont]}");
            }
            else
            {
                RCHTBLISTAPROD.Text = "No hay datos para mostrar.";
            }
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
                    XFont font = new XFont("Verdana", 12);

                    // Encabezado del ticket
                    gfx.DrawString("Ticket de Compra", font, XBrushes.Black, new XPoint(250, 30));
                    gfx.DrawString("Fecha: " + DateTime.Now.ToString("dd/MM/yyyy HH:mm"), font, XBrushes.Black, new XPoint(50, 80));

                    // Variables para manejar productos y total
                    string[] productos = RCHTBLISTAPROD.Text.Split('\n');
                    float total = 0;

                    // Imprimir los productos del RichTextBox
                    int yOffset = 120; // Posición inicial para los productos
                    foreach (string producto in productos)
                    {
                        if (!string.IsNullOrWhiteSpace(producto))
                        {
                            gfx.DrawString(producto, font, XBrushes.Black, new XPoint(50, yOffset));
                            yOffset += 20;

                            // Extraer precio del producto y calcular el total
                            string[] partes = producto.Split('-');
                            if (partes.Length >= 3 && float.TryParse(partes[2].Trim().Replace("$", ""), out float precio))
                            {
                                total += precio;
                            }
                        }
                    }

                    // Mostrar el total al final
                    gfx.DrawString($"Total a pagar: ${total:F2}", font, XBrushes.Black, new XPoint(50, yOffset + 20));

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

        private void RCHTBLISTAPROD_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
