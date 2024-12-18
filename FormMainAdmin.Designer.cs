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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMainAdmin));
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
            btnGrafica = new Button();
            labelNOMBRE = new Label();
            pictureBox1 = new PictureBox();
            pictureBox5 = new PictureBox();
            pictureBox6 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).BeginInit();
            SuspendLayout();
            // 
            // BTNADMINSALIR
            // 
            BTNADMINSALIR.BackColor = Color.FromArgb(255, 128, 128);
            BTNADMINSALIR.Cursor = Cursors.Hand;
            BTNADMINSALIR.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            BTNADMINSALIR.Location = new Point(19, 335);
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
            BTNADMINALTAS.Location = new Point(306, 243);
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
            buttonDatos.Location = new Point(548, 121);
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
            BTNADMINGRAFICA.Location = new Point(305, 284);
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
            botonConsulta.Location = new Point(149, 284);
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
            BTNADMINLOGOUT.Location = new Point(589, 335);
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
            richTextBoxDatos.Location = new Point(23, 70);
            richTextBoxDatos.Name = "richTextBoxDatos";
            richTextBoxDatos.Size = new Size(251, 204);
            richTextBoxDatos.TabIndex = 6;
            richTextBoxDatos.Text = "";
            richTextBoxDatos.TextChanged += richTextBoxDatos_TextChanged;
            // 
            // textboxOtroId
            // 
            textboxOtroId.Cursor = Cursors.IBeam;
            textboxOtroId.ForeColor = Color.Lime;
            textboxOtroId.Location = new Point(305, 81);
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
            BTNADMINBAJAS.Location = new Point(578, 243);
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
            buttonModificar.Location = new Point(443, 243);
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
            textboxOtroExistencia.Location = new Point(305, 203);
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
            textboxOtroPrecio.Location = new Point(305, 168);
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
            textboxOtroDescripcion.Location = new Point(305, 139);
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
            textboxOtroImagen.Location = new Point(306, 110);
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
            TextBoxId.Location = new Point(443, 132);
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
            TextBoxExistencias.Location = new Point(443, 203);
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
            TextBoxPrecio.Location = new Point(443, 168);
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
            textBoxEliminar.Location = new Point(578, 203);
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
            labelVentasTotales.Location = new Point(305, 327);
            labelVentasTotales.Name = "labelVentasTotales";
            labelVentasTotales.PlaceholderText = "Id a modificar";
            labelVentasTotales.Size = new Size(100, 23);
            labelVentasTotales.TabIndex = 20;
            labelVentasTotales.TextAlign = HorizontalAlignment.Center;
            // 
            // btnGrafica
            // 
            btnGrafica.BackColor = Color.FromArgb(255, 192, 255);
            btnGrafica.Cursor = Cursors.Hand;
            btnGrafica.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnGrafica.Location = new Point(443, 284);
            btnGrafica.Margin = new Padding(3, 2, 3, 2);
            btnGrafica.Name = "btnGrafica";
            btnGrafica.Size = new Size(98, 29);
            btnGrafica.TabIndex = 21;
            btnGrafica.Text = "Grafica";
            btnGrafica.UseVisualStyleBackColor = false;
            // 
            // labelNOMBRE
            // 
            labelNOMBRE.AutoSize = true;
            labelNOMBRE.Font = new Font("Segoe UI", 10.875F);
            labelNOMBRE.Location = new Point(615, 56);
            labelNOMBRE.Margin = new Padding(2, 0, 2, 0);
            labelNOMBRE.Name = "labelNOMBRE";
            labelNOMBRE.Size = new Size(59, 20);
            labelNOMBRE.TabIndex = 23;
            labelNOMBRE.Text = "Usuario";
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.FromArgb(245, 140, 0);
            pictureBox1.Location = new Point(-18, -5);
            pictureBox1.Margin = new Padding(2, 1, 2, 1);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(730, 54);
            pictureBox1.TabIndex = 24;
            pictureBox1.TabStop = false;
            // 
            // pictureBox5
            // 
            pictureBox5.BackColor = Color.White;
            pictureBox5.Image = (Image)resources.GetObject("pictureBox5.Image");
            pictureBox5.Location = new Point(58, 5);
            pictureBox5.Margin = new Padding(2, 1, 2, 1);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(136, 39);
            pictureBox5.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox5.TabIndex = 27;
            pictureBox5.TabStop = false;
            pictureBox5.Click += pictureBox5_Click;
            // 
            // pictureBox6
            // 
            pictureBox6.BackColor = Color.White;
            pictureBox6.Image = (Image)resources.GetObject("pictureBox6.Image");
            pictureBox6.Location = new Point(8, 5);
            pictureBox6.Margin = new Padding(2, 1, 2, 1);
            pictureBox6.Name = "pictureBox6";
            pictureBox6.Size = new Size(50, 39);
            pictureBox6.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox6.TabIndex = 26;
            pictureBox6.TabStop = false;
            // 
            // FormMainAdmin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(700, 387);
            Controls.Add(pictureBox5);
            Controls.Add(pictureBox6);
            Controls.Add(pictureBox1);
            Controls.Add(labelNOMBRE);
            Controls.Add(btnGrafica);
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
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).EndInit();
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
        private Button btnGrafica;
        private Label labelNOMBRE;
        private PictureBox pictureBox1;
        private PictureBox pictureBox5;
        private PictureBox pictureBox6;
    }
}