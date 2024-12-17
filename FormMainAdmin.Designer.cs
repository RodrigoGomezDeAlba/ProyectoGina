namespace ProyectoGina
{
    partial class FormMainAdmin
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            BTNADMINSALIR = new Button();
            BTNADMINALTAS = new Button();
            buttonDatos = new Button();
            BTNADMINGRAFICA = new Button();
            botonConsulta = new Button();
            BTNADMINLOGOUT = new Button();
            richTextBoxDatos = new RichTextBox();
            textboxOtroId = new TextBox();
            BTNADMINBAJAS = new Button();
            buttonModificar = new Button();
            textboxOtroExistencia = new TextBox();
            textboxOtroPrecio = new TextBox();
            textboxOtroDescripcion = new TextBox();
            textboxOtroImagen = new TextBox();
            TextBoxId = new TextBox();
            TextBoxExistencias = new TextBox();
            TextBoxPrecio = new TextBox();
            textBoxEliminar = new TextBox();
            labelVentasTotales = new TextBox();
            button1 = new Button();
            labelNOMBRE = new Label();
            SuspendLayout();
            // 
            // BTNADMINSALIR
            // 
            BTNADMINSALIR.BackColor = Color.FromArgb(255, 128, 128);
            BTNADMINSALIR.Cursor = Cursors.Hand;
            BTNADMINSALIR.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            BTNADMINSALIR.Location = new Point(21, 286);
            BTNADMINSALIR.Margin = new Padding(3, 2, 3, 2);
            BTNADMINSALIR.Name = "BTNADMINSALIR";
            BTNADMINSALIR.Size = new Size(89, 37);
            BTNADMINSALIR.TabIndex = 0;
            BTNADMINSALIR.Text = "Salir";
            BTNADMINSALIR.UseVisualStyleBackColor = false;
            BTNADMINSALIR.Click += BTNADMINSALIR_Click;
            // 
            // BTNADMINALTAS
            // 
            BTNADMINALTAS.BackColor = Color.FromArgb(192, 255, 192);
            BTNADMINALTAS.Cursor = Cursors.Hand;
            BTNADMINALTAS.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            BTNADMINALTAS.Location = new Point(308, 194);
            BTNADMINALTAS.Margin = new Padding(3, 2, 3, 2);
            BTNADMINALTAS.Name = "BTNADMINALTAS";
            BTNADMINALTAS.Size = new Size(98, 29);
            BTNADMINALTAS.TabIndex = 1;
            BTNADMINALTAS.Text = "Altas";
            BTNADMINALTAS.UseVisualStyleBackColor = false;
            BTNADMINALTAS.Click += BTNADMINALTAS_Click_1;
            // 
            // buttonDatos
            // 
            buttonDatos.BackColor = Color.FromArgb(255, 224, 192);
            buttonDatos.Cursor = Cursors.Hand;
            buttonDatos.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            buttonDatos.Location = new Point(549, 79);
            buttonDatos.Margin = new Padding(3, 2, 3, 2);
            buttonDatos.Name = "buttonDatos";
            buttonDatos.Size = new Size(131, 29);
            buttonDatos.TabIndex = 2;
            buttonDatos.Text = "Mostrar Datos\r\n";
            buttonDatos.UseVisualStyleBackColor = false;
            buttonDatos.Click += buttonDatos_Click_1;
            // 
            // BTNADMINGRAFICA
            // 
            BTNADMINGRAFICA.BackColor = Color.FromArgb(192, 192, 255);
            BTNADMINGRAFICA.Cursor = Cursors.Hand;
            BTNADMINGRAFICA.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            BTNADMINGRAFICA.Location = new Point(287, 286);
            BTNADMINGRAFICA.Margin = new Padding(3, 2, 3, 2);
            BTNADMINGRAFICA.Name = "BTNADMINGRAFICA";
            BTNADMINGRAFICA.Size = new Size(98, 29);
            BTNADMINGRAFICA.TabIndex = 3;
            BTNADMINGRAFICA.Text = "Ventas";
            BTNADMINGRAFICA.UseVisualStyleBackColor = false;
            BTNADMINGRAFICA.Click += BTNADMINGRAFICA_Click;
            // 
            // botonConsulta
            // 
            botonConsulta.BackColor = Color.FromArgb(192, 255, 255);
            botonConsulta.Cursor = Cursors.Hand;
            botonConsulta.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            botonConsulta.Location = new Point(24, 235);
            botonConsulta.Margin = new Padding(3, 2, 3, 2);
            botonConsulta.Name = "botonConsulta";
            botonConsulta.Size = new Size(123, 29);
            botonConsulta.TabIndex = 4;
            botonConsulta.Text = "Actualizar lista";
            botonConsulta.UseVisualStyleBackColor = false;
            botonConsulta.Click += botonConsulta_Click_1;
            // 
            // BTNADMINLOGOUT
            // 
            BTNADMINLOGOUT.BackColor = Color.Gainsboro;
            BTNADMINLOGOUT.Cursor = Cursors.Hand;
            BTNADMINLOGOUT.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            BTNADMINLOGOUT.Location = new Point(590, 286);
            BTNADMINLOGOUT.Margin = new Padding(3, 2, 3, 2);
            BTNADMINLOGOUT.Name = "BTNADMINLOGOUT";
            BTNADMINLOGOUT.Size = new Size(89, 37);
            BTNADMINLOGOUT.TabIndex = 5;
            BTNADMINLOGOUT.Text = "Log Out";
            BTNADMINLOGOUT.UseVisualStyleBackColor = false;
            BTNADMINLOGOUT.Click += BTNADMINLOGOUT_Click;
            // 
            // richTextBoxDatos
            // 
            richTextBoxDatos.Location = new Point(24, 21);
            richTextBoxDatos.Name = "richTextBoxDatos";
            richTextBoxDatos.Size = new Size(251, 204);
            richTextBoxDatos.TabIndex = 6;
            richTextBoxDatos.Text = "";
            // 
            // textboxOtroId
            // 
            textboxOtroId.Cursor = Cursors.IBeam;
            textboxOtroId.ForeColor = Color.Lime;
            textboxOtroId.Location = new Point(307, 32);
            textboxOtroId.Name = "textboxOtroId";
            textboxOtroId.PlaceholderText = "Id a agregar";
            textboxOtroId.Size = new Size(100, 23);
            textboxOtroId.TabIndex = 7;
            textboxOtroId.TextAlign = HorizontalAlignment.Center;
            // 
            // BTNADMINBAJAS
            // 
            BTNADMINBAJAS.BackColor = Color.FromArgb(255, 192, 192);
            BTNADMINBAJAS.Cursor = Cursors.Hand;
            BTNADMINBAJAS.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            BTNADMINBAJAS.Location = new Point(580, 194);
            BTNADMINBAJAS.Margin = new Padding(3, 2, 3, 2);
            BTNADMINBAJAS.Name = "BTNADMINBAJAS";
            BTNADMINBAJAS.Size = new Size(98, 29);
            BTNADMINBAJAS.TabIndex = 8;
            BTNADMINBAJAS.Text = "BAJAS";
            BTNADMINBAJAS.UseVisualStyleBackColor = false;
            BTNADMINBAJAS.Click += BTNADMINBAJAS_Click_1;
            // 
            // buttonModificar
            // 
            buttonModificar.BackColor = Color.FromArgb(255, 255, 192);
            buttonModificar.Cursor = Cursors.Hand;
            buttonModificar.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            buttonModificar.Location = new Point(444, 194);
            buttonModificar.Margin = new Padding(3, 2, 3, 2);
            buttonModificar.Name = "buttonModificar";
            buttonModificar.Size = new Size(98, 29);
            buttonModificar.TabIndex = 9;
            buttonModificar.Text = "Modificar";
            buttonModificar.UseVisualStyleBackColor = false;
            buttonModificar.Click += buttonModificar_Click;
            // 
            // textboxOtroExistencia
            // 
            textboxOtroExistencia.Cursor = Cursors.IBeam;
            textboxOtroExistencia.ForeColor = Color.Black;
            textboxOtroExistencia.Location = new Point(307, 154);
            textboxOtroExistencia.Name = "textboxOtroExistencia";
            textboxOtroExistencia.PlaceholderText = "Existencias";
            textboxOtroExistencia.Size = new Size(100, 23);
            textboxOtroExistencia.TabIndex = 10;
            textboxOtroExistencia.TextAlign = HorizontalAlignment.Center;
            // 
            // textboxOtroPrecio
            // 
            textboxOtroPrecio.Cursor = Cursors.IBeam;
            textboxOtroPrecio.ForeColor = Color.Black;
            textboxOtroPrecio.Location = new Point(307, 119);
            textboxOtroPrecio.Name = "textboxOtroPrecio";
            textboxOtroPrecio.PlaceholderText = "Precio";
            textboxOtroPrecio.Size = new Size(100, 23);
            textboxOtroPrecio.TabIndex = 11;
            textboxOtroPrecio.TextAlign = HorizontalAlignment.Center;
            // 
            // textboxOtroDescripcion
            // 
            textboxOtroDescripcion.Cursor = Cursors.IBeam;
            textboxOtroDescripcion.ForeColor = Color.Black;
            textboxOtroDescripcion.Location = new Point(307, 90);
            textboxOtroDescripcion.Name = "textboxOtroDescripcion";
            textboxOtroDescripcion.PlaceholderText = "Descripción";
            textboxOtroDescripcion.Size = new Size(100, 23);
            textboxOtroDescripcion.TabIndex = 12;
            textboxOtroDescripcion.TextAlign = HorizontalAlignment.Center;
            // 
            // textboxOtroImagen
            // 
            textboxOtroImagen.Cursor = Cursors.IBeam;
            textboxOtroImagen.ForeColor = Color.Black;
            textboxOtroImagen.Location = new Point(308, 61);
            textboxOtroImagen.Name = "textboxOtroImagen";
            textboxOtroImagen.PlaceholderText = "Imagen";
            textboxOtroImagen.Size = new Size(100, 23);
            textboxOtroImagen.TabIndex = 13;
            textboxOtroImagen.TextAlign = HorizontalAlignment.Center;
            // 
            // TextBoxId
            // 
            TextBoxId.Cursor = Cursors.IBeam;
            TextBoxId.ForeColor = Color.Blue;
            TextBoxId.Location = new Point(444, 83);
            TextBoxId.Name = "TextBoxId";
            TextBoxId.PlaceholderText = "Id a modificar";
            TextBoxId.Size = new Size(100, 23);
            TextBoxId.TabIndex = 14;
            TextBoxId.TextAlign = HorizontalAlignment.Center;
            // 
            // TextBoxExistencias
            // 
            TextBoxExistencias.Cursor = Cursors.IBeam;
            TextBoxExistencias.ForeColor = Color.Black;
            TextBoxExistencias.Location = new Point(444, 154);
            TextBoxExistencias.Name = "TextBoxExistencias";
            TextBoxExistencias.PlaceholderText = "Existencias";
            TextBoxExistencias.Size = new Size(100, 23);
            TextBoxExistencias.TabIndex = 15;
            TextBoxExistencias.TextAlign = HorizontalAlignment.Center;
            // 
            // TextBoxPrecio
            // 
            TextBoxPrecio.Cursor = Cursors.IBeam;
            TextBoxPrecio.ForeColor = Color.Black;
            TextBoxPrecio.Location = new Point(444, 119);
            TextBoxPrecio.Name = "TextBoxPrecio";
            TextBoxPrecio.PlaceholderText = "Precio";
            TextBoxPrecio.Size = new Size(100, 23);
            TextBoxPrecio.TabIndex = 16;
            TextBoxPrecio.TextAlign = HorizontalAlignment.Center;
            // 
            // textBoxEliminar
            // 
            textBoxEliminar.Cursor = Cursors.IBeam;
            textBoxEliminar.ForeColor = Color.Red;
            textBoxEliminar.Location = new Point(580, 154);
            textBoxEliminar.Name = "textBoxEliminar";
            textBoxEliminar.PlaceholderText = "Id a eliminar";
            textBoxEliminar.Size = new Size(100, 23);
            textBoxEliminar.TabIndex = 19;
            textBoxEliminar.TextAlign = HorizontalAlignment.Center;
            // 
            // labelVentasTotales
            // 
            labelVentasTotales.Cursor = Cursors.IBeam;
            labelVentasTotales.ForeColor = Color.Blue;
            labelVentasTotales.Location = new Point(401, 290);
            labelVentasTotales.Name = "labelVentasTotales";
            labelVentasTotales.PlaceholderText = "Id a modificar";
            labelVentasTotales.Size = new Size(100, 23);
            labelVentasTotales.TabIndex = 20;
            labelVentasTotales.TextAlign = HorizontalAlignment.Center;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(192, 192, 255);
            button1.Cursor = Cursors.Hand;
            button1.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            button1.Location = new Point(177, 235);
            button1.Margin = new Padding(3, 2, 3, 2);
            button1.Name = "button1";
            button1.Size = new Size(98, 29);
            button1.TabIndex = 21;
            button1.Text = "Ventas";
            button1.UseVisualStyleBackColor = false;
            // 
            // labelNOMBRE
            // 
            labelNOMBRE.AutoSize = true;
            labelNOMBRE.Font = new Font("Segoe UI", 10.875F);
            labelNOMBRE.Location = new Point(474, 21);
            labelNOMBRE.Margin = new Padding(2, 0, 2, 0);
            labelNOMBRE.Name = "labelNOMBRE";
            labelNOMBRE.Size = new Size(70, 20);
            labelNOMBRE.TabIndex = 23;
            labelNOMBRE.Text = "PrecioBD";
            // 
            // FormMainAdmin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(700, 338);
            Controls.Add(labelNOMBRE);
            Controls.Add(button1);
            Controls.Add(labelVentasTotales);
            Controls.Add(textBoxEliminar);
            Controls.Add(TextBoxPrecio);
            Controls.Add(TextBoxExistencias);
            Controls.Add(TextBoxId);
            Controls.Add(textboxOtroImagen);
            Controls.Add(textboxOtroDescripcion);
            Controls.Add(textboxOtroPrecio);
            Controls.Add(textboxOtroExistencia);
            Controls.Add(buttonModificar);
            Controls.Add(BTNADMINBAJAS);
            Controls.Add(textboxOtroId);
            Controls.Add(richTextBoxDatos);
            Controls.Add(BTNADMINLOGOUT);
            Controls.Add(botonConsulta);
            Controls.Add(BTNADMINGRAFICA);
            Controls.Add(buttonDatos);
            Controls.Add(BTNADMINALTAS);
            Controls.Add(BTNADMINSALIR);
            Margin = new Padding(3, 2, 3, 2);
            Name = "FormMainAdmin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "MAIN ADMIN";
            Load += FormMainAdmin_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button BTNADMINSALIR;
        private Button BTNADMINALTAS;
        private Button buttonDatos;
        private Button BTNADMINGRAFICA;
        private Button botonConsulta;
        private Button BTNADMINLOGOUT;
        private RichTextBox richTextBoxDatos;
        private TextBox textboxOtroId;
        private Button BTNADMINBAJAS;
        private Button buttonModificar;
        private TextBox textboxOtroExistencia;
        private TextBox textboxOtroPrecio;
        private TextBox textboxOtroDescripcion;
        private TextBox textboxOtroImagen;
        private TextBox TextBoxId;
        private TextBox TextBoxExistencias;
        private TextBox TextBoxPrecio;
        private TextBox textBoxEliminar;
        private TextBox labelVentasTotales;
        private Button button1;
        private Label labelNOMBRE;
    }
}