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
            TextBoxDescripcion = new TextBox();
            TextBoxImagen = new TextBox();
            textBoxEliminar = new TextBox();
            SuspendLayout();
            // 
            // BTNADMINSALIR
            // 
            BTNADMINSALIR.Location = new Point(35, 287);
            BTNADMINSALIR.Margin = new Padding(3, 2, 3, 2);
            BTNADMINSALIR.Name = "BTNADMINSALIR";
            BTNADMINSALIR.Size = new Size(89, 34);
            BTNADMINSALIR.TabIndex = 0;
            BTNADMINSALIR.Text = "Salir";
            BTNADMINSALIR.UseVisualStyleBackColor = true;
            BTNADMINSALIR.Click += BTNADMINSALIR_Click;
            // 
            // BTNADMINALTAS
            // 
            BTNADMINALTAS.Location = new Point(307, 193);
            BTNADMINALTAS.Margin = new Padding(3, 2, 3, 2);
            BTNADMINALTAS.Name = "BTNADMINALTAS";
            BTNADMINALTAS.Size = new Size(97, 29);
            BTNADMINALTAS.TabIndex = 1;
            BTNADMINALTAS.Text = "ALTAS";
            BTNADMINALTAS.UseVisualStyleBackColor = true;
            BTNADMINALTAS.Click += BTNADMINALTAS_Click_1;
            // 
            // buttonDatos
            // 
            buttonDatos.Location = new Point(591, 33);
            buttonDatos.Margin = new Padding(3, 2, 3, 2);
            buttonDatos.Name = "buttonDatos";
            buttonDatos.Size = new Size(97, 52);
            buttonDatos.TabIndex = 2;
            buttonDatos.Text = "id a modificar y mostrar";
            buttonDatos.UseVisualStyleBackColor = true;
            buttonDatos.Click += buttonDatos_Click_1;
            // 
            // BTNADMINGRAFICA
            // 
            BTNADMINGRAFICA.Location = new Point(532, 234);
            BTNADMINGRAFICA.Margin = new Padding(3, 2, 3, 2);
            BTNADMINGRAFICA.Name = "BTNADMINGRAFICA";
            BTNADMINGRAFICA.Size = new Size(135, 36);
            BTNADMINGRAFICA.TabIndex = 3;
            BTNADMINGRAFICA.Text = "VENTAS Y GRAFICA";
            BTNADMINGRAFICA.UseVisualStyleBackColor = true;
            // 
            // botonConsulta
            // 
            botonConsulta.Location = new Point(35, 234);
            botonConsulta.Margin = new Padding(3, 2, 3, 2);
            botonConsulta.Name = "botonConsulta";
            botonConsulta.Size = new Size(106, 36);
            botonConsulta.TabIndex = 4;
            botonConsulta.Text = "LISTA DE PRODUCTOS";
            botonConsulta.UseVisualStyleBackColor = true;
            botonConsulta.Click += botonConsulta_Click_1;
            // 
            // BTNADMINLOGOUT
            // 
            BTNADMINLOGOUT.Location = new Point(578, 287);
            BTNADMINLOGOUT.Margin = new Padding(3, 2, 3, 2);
            BTNADMINLOGOUT.Name = "BTNADMINLOGOUT";
            BTNADMINLOGOUT.Size = new Size(89, 34);
            BTNADMINLOGOUT.TabIndex = 5;
            BTNADMINLOGOUT.Text = "LOG OUT";
            BTNADMINLOGOUT.UseVisualStyleBackColor = true;
            BTNADMINLOGOUT.Click += BTNADMINLOGOUT_Click;
            // 
            // richTextBoxDatos
            // 
            richTextBoxDatos.Location = new Point(24, 21);
            richTextBoxDatos.Name = "richTextBoxDatos";
            richTextBoxDatos.Size = new Size(251, 190);
            richTextBoxDatos.TabIndex = 6;
            richTextBoxDatos.Text = "";
            // 
            // textboxOtroId
            // 
            textboxOtroId.Location = new Point(307, 33);
            textboxOtroId.Name = "textboxOtroId";
            textboxOtroId.Size = new Size(100, 23);
            textboxOtroId.TabIndex = 7;
            // 
            // BTNADMINBAJAS
            // 
            BTNADMINBAJAS.Location = new Point(410, 273);
            BTNADMINBAJAS.Margin = new Padding(3, 2, 3, 2);
            BTNADMINBAJAS.Name = "BTNADMINBAJAS";
            BTNADMINBAJAS.Size = new Size(97, 29);
            BTNADMINBAJAS.TabIndex = 8;
            BTNADMINBAJAS.Text = "BAJAS";
            BTNADMINBAJAS.UseVisualStyleBackColor = true;
            BTNADMINBAJAS.Click += BTNADMINBAJAS_Click_1;
            // 
            // buttonModificar
            // 
            buttonModificar.Location = new Point(587, 91);
            buttonModificar.Margin = new Padding(3, 2, 3, 2);
            buttonModificar.Name = "buttonModificar";
            buttonModificar.Size = new Size(97, 29);
            buttonModificar.TabIndex = 9;
            buttonModificar.Text = "modificar";
            buttonModificar.UseVisualStyleBackColor = true;
            buttonModificar.Click += buttonModificar_Click;
            // 
            // textboxOtroExistencia
            // 
            textboxOtroExistencia.Location = new Point(307, 155);
            textboxOtroExistencia.Name = "textboxOtroExistencia";
            textboxOtroExistencia.Size = new Size(100, 23);
            textboxOtroExistencia.TabIndex = 10;
            // 
            // textboxOtroPrecio
            // 
            textboxOtroPrecio.Location = new Point(307, 120);
            textboxOtroPrecio.Name = "textboxOtroPrecio";
            textboxOtroPrecio.Size = new Size(100, 23);
            textboxOtroPrecio.TabIndex = 11;
            // 
            // textboxOtroDescripcion
            // 
            textboxOtroDescripcion.Location = new Point(307, 91);
            textboxOtroDescripcion.Name = "textboxOtroDescripcion";
            textboxOtroDescripcion.Size = new Size(100, 23);
            textboxOtroDescripcion.TabIndex = 12;
            // 
            // textboxOtroImagen
            // 
            textboxOtroImagen.Location = new Point(308, 62);
            textboxOtroImagen.Name = "textboxOtroImagen";
            textboxOtroImagen.Size = new Size(100, 23);
            textboxOtroImagen.TabIndex = 13;
            // 
            // TextBoxId
            // 
            TextBoxId.Location = new Point(481, 33);
            TextBoxId.Name = "TextBoxId";
            TextBoxId.Size = new Size(100, 23);
            TextBoxId.TabIndex = 14;
            // 
            // TextBoxExistencias
            // 
            TextBoxExistencias.Location = new Point(481, 149);
            TextBoxExistencias.Name = "TextBoxExistencias";
            TextBoxExistencias.Size = new Size(100, 23);
            TextBoxExistencias.TabIndex = 15;
            // 
            // TextBoxPrecio
            // 
            TextBoxPrecio.Location = new Point(481, 120);
            TextBoxPrecio.Name = "TextBoxPrecio";
            TextBoxPrecio.Size = new Size(100, 23);
            TextBoxPrecio.TabIndex = 16;
            // 
            // TextBoxDescripcion
            // 
            TextBoxDescripcion.Location = new Point(481, 91);
            TextBoxDescripcion.Name = "TextBoxDescripcion";
            TextBoxDescripcion.Size = new Size(100, 23);
            TextBoxDescripcion.TabIndex = 17;
            // 
            // TextBoxImagen
            // 
            TextBoxImagen.Location = new Point(481, 62);
            TextBoxImagen.Name = "TextBoxImagen";
            TextBoxImagen.Size = new Size(100, 23);
            TextBoxImagen.TabIndex = 18;
            // 
            // textBoxEliminar
            // 
            textBoxEliminar.Location = new Point(292, 277);
            textBoxEliminar.Name = "textBoxEliminar";
            textBoxEliminar.Size = new Size(100, 23);
            textBoxEliminar.TabIndex = 19;
            // 
            // FormMainAdmin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Sienna;
            ClientSize = new Size(700, 338);
            Controls.Add(textBoxEliminar);
            Controls.Add(TextBoxImagen);
            Controls.Add(TextBoxDescripcion);
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
        private TextBox TextBoxDescripcion;
        private TextBox TextBoxImagen;
        private TextBox textBoxEliminar;
    }
}