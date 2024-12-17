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
            SuspendLayout();
            // 
            // BTNADMINSALIR
            // 
            BTNADMINSALIR.BackColor = Color.FromArgb(255, 128, 128);
            BTNADMINSALIR.Cursor = Cursors.Hand;
            BTNADMINSALIR.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            BTNADMINSALIR.Location = new Point(39, 610);
            BTNADMINSALIR.Margin = new Padding(5);
            BTNADMINSALIR.Name = "BTNADMINSALIR";
            BTNADMINSALIR.Size = new Size(166, 78);
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
            BTNADMINALTAS.Location = new Point(572, 413);
            BTNADMINALTAS.Margin = new Padding(5);
            BTNADMINALTAS.Name = "BTNADMINALTAS";
            BTNADMINALTAS.Size = new Size(182, 62);
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
            buttonDatos.Location = new Point(1019, 169);
            buttonDatos.Margin = new Padding(5);
            buttonDatos.Name = "buttonDatos";
            buttonDatos.Size = new Size(243, 62);
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
            BTNADMINGRAFICA.Location = new Point(326, 502);
            BTNADMINGRAFICA.Margin = new Padding(6, 4, 6, 4);
            BTNADMINGRAFICA.Name = "BTNADMINGRAFICA";
            BTNADMINGRAFICA.Size = new Size(182, 62);
            BTNADMINGRAFICA.TabIndex = 3;
            BTNADMINGRAFICA.Text = "Ventas";
            BTNADMINGRAFICA.UseVisualStyleBackColor = false;
            // 
            // botonConsulta
            // 
            botonConsulta.BackColor = Color.FromArgb(192, 255, 255);
            botonConsulta.Cursor = Cursors.Hand;
            botonConsulta.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            botonConsulta.Location = new Point(45, 502);
            botonConsulta.Margin = new Padding(6, 4, 6, 4);
            botonConsulta.Name = "botonConsulta";
            botonConsulta.Size = new Size(229, 62);
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
            BTNADMINLOGOUT.Location = new Point(1096, 610);
            BTNADMINLOGOUT.Margin = new Padding(5);
            BTNADMINLOGOUT.Name = "BTNADMINLOGOUT";
            BTNADMINLOGOUT.Size = new Size(166, 78);
            BTNADMINLOGOUT.TabIndex = 5;
            BTNADMINLOGOUT.Text = "Log Out";
            BTNADMINLOGOUT.UseVisualStyleBackColor = false;
            BTNADMINLOGOUT.Click += BTNADMINLOGOUT_Click;
            // 
            // richTextBoxDatos
            // 
            richTextBoxDatos.Location = new Point(45, 45);
            richTextBoxDatos.Margin = new Padding(6);
            richTextBoxDatos.Name = "richTextBoxDatos";
            richTextBoxDatos.Size = new Size(463, 430);
            richTextBoxDatos.TabIndex = 6;
            richTextBoxDatos.Text = "";
            // 
            // textboxOtroId
            // 
            textboxOtroId.Cursor = Cursors.IBeam;
            textboxOtroId.ForeColor = Color.Lime;
            textboxOtroId.Location = new Point(570, 68);
            textboxOtroId.Margin = new Padding(6);
            textboxOtroId.Name = "textboxOtroId";
            textboxOtroId.PlaceholderText = "Id a agregar";
            textboxOtroId.Size = new Size(182, 39);
            textboxOtroId.TabIndex = 7;
            textboxOtroId.TextAlign = HorizontalAlignment.Center;
            // 
            // BTNADMINBAJAS
            // 
            BTNADMINBAJAS.BackColor = Color.FromArgb(255, 192, 192);
            BTNADMINBAJAS.Cursor = Cursors.Hand;
            BTNADMINBAJAS.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            BTNADMINBAJAS.Location = new Point(1078, 413);
            BTNADMINBAJAS.Margin = new Padding(6, 4, 6, 4);
            BTNADMINBAJAS.Name = "BTNADMINBAJAS";
            BTNADMINBAJAS.Size = new Size(182, 62);
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
            buttonModificar.Location = new Point(824, 413);
            buttonModificar.Margin = new Padding(5);
            buttonModificar.Name = "buttonModificar";
            buttonModificar.Size = new Size(182, 62);
            buttonModificar.TabIndex = 9;
            buttonModificar.Text = "Modificar";
            buttonModificar.UseVisualStyleBackColor = false;
            buttonModificar.Click += buttonModificar_Click;
            // 
            // textboxOtroExistencia
            // 
            textboxOtroExistencia.Cursor = Cursors.IBeam;
            textboxOtroExistencia.ForeColor = Color.Black;
            textboxOtroExistencia.Location = new Point(570, 329);
            textboxOtroExistencia.Margin = new Padding(6);
            textboxOtroExistencia.Name = "textboxOtroExistencia";
            textboxOtroExistencia.PlaceholderText = "Existencias";
            textboxOtroExistencia.Size = new Size(182, 39);
            textboxOtroExistencia.TabIndex = 10;
            textboxOtroExistencia.TextAlign = HorizontalAlignment.Center;
            // 
            // textboxOtroPrecio
            // 
            textboxOtroPrecio.Cursor = Cursors.IBeam;
            textboxOtroPrecio.ForeColor = Color.Black;
            textboxOtroPrecio.Location = new Point(570, 254);
            textboxOtroPrecio.Margin = new Padding(6);
            textboxOtroPrecio.Name = "textboxOtroPrecio";
            textboxOtroPrecio.PlaceholderText = "Precio";
            textboxOtroPrecio.Size = new Size(182, 39);
            textboxOtroPrecio.TabIndex = 11;
            textboxOtroPrecio.TextAlign = HorizontalAlignment.Center;
            // 
            // textboxOtroDescripcion
            // 
            textboxOtroDescripcion.Cursor = Cursors.IBeam;
            textboxOtroDescripcion.ForeColor = Color.Black;
            textboxOtroDescripcion.Location = new Point(570, 192);
            textboxOtroDescripcion.Margin = new Padding(6);
            textboxOtroDescripcion.Name = "textboxOtroDescripcion";
            textboxOtroDescripcion.PlaceholderText = "Descripción";
            textboxOtroDescripcion.Size = new Size(182, 39);
            textboxOtroDescripcion.TabIndex = 12;
            textboxOtroDescripcion.TextAlign = HorizontalAlignment.Center;
            // 
            // textboxOtroImagen
            // 
            textboxOtroImagen.Cursor = Cursors.IBeam;
            textboxOtroImagen.ForeColor = Color.Black;
            textboxOtroImagen.Location = new Point(572, 130);
            textboxOtroImagen.Margin = new Padding(6);
            textboxOtroImagen.Name = "textboxOtroImagen";
            textboxOtroImagen.PlaceholderText = "Imagen";
            textboxOtroImagen.Size = new Size(182, 39);
            textboxOtroImagen.TabIndex = 13;
            textboxOtroImagen.TextAlign = HorizontalAlignment.Center;
            // 
            // TextBoxId
            // 
            TextBoxId.Cursor = Cursors.IBeam;
            TextBoxId.ForeColor = Color.Blue;
            TextBoxId.Location = new Point(824, 192);
            TextBoxId.Margin = new Padding(6);
            TextBoxId.Name = "TextBoxId";
            TextBoxId.PlaceholderText = "Id a modificar";
            TextBoxId.Size = new Size(182, 39);
            TextBoxId.TabIndex = 14;
            TextBoxId.TextAlign = HorizontalAlignment.Center;
            // 
            // TextBoxExistencias
            // 
            TextBoxExistencias.Cursor = Cursors.IBeam;
            TextBoxExistencias.ForeColor = Color.Black;
            TextBoxExistencias.Location = new Point(824, 329);
            TextBoxExistencias.Margin = new Padding(6);
            TextBoxExistencias.Name = "TextBoxExistencias";
            TextBoxExistencias.PlaceholderText = "Existencias";
            TextBoxExistencias.Size = new Size(182, 39);
            TextBoxExistencias.TabIndex = 15;
            TextBoxExistencias.TextAlign = HorizontalAlignment.Center;
            // 
            // TextBoxPrecio
            // 
            TextBoxPrecio.Cursor = Cursors.IBeam;
            TextBoxPrecio.ForeColor = Color.Black;
            TextBoxPrecio.Location = new Point(824, 254);
            TextBoxPrecio.Margin = new Padding(6);
            TextBoxPrecio.Name = "TextBoxPrecio";
            TextBoxPrecio.PlaceholderText = "Precio";
            TextBoxPrecio.Size = new Size(182, 39);
            TextBoxPrecio.TabIndex = 16;
            TextBoxPrecio.TextAlign = HorizontalAlignment.Center;
            // 
            // textBoxEliminar
            // 
            textBoxEliminar.Cursor = Cursors.IBeam;
            textBoxEliminar.ForeColor = Color.Red;
            textBoxEliminar.Location = new Point(1078, 329);
            textBoxEliminar.Margin = new Padding(6);
            textBoxEliminar.Name = "textBoxEliminar";
            textBoxEliminar.PlaceholderText = "Id a eliminar";
            textBoxEliminar.Size = new Size(182, 39);
            textBoxEliminar.TabIndex = 19;
            textBoxEliminar.TextAlign = HorizontalAlignment.Center;
            // 
            // FormMainAdmin
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1300, 721);
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
            Margin = new Padding(6, 4, 6, 4);
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
    }
}