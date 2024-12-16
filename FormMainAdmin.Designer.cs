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
            BTNADMINBAJAS = new Button();
            BTNADMINGRAFICA = new Button();
            BTNADMINLISTA = new Button();
            BTNADMINLOGOUT = new Button();
            SuspendLayout();
            // 
            // BTNADMINSALIR
            // 
            BTNADMINSALIR.Location = new Point(65, 613);
            BTNADMINSALIR.Margin = new Padding(5);
            BTNADMINSALIR.Name = "BTNADMINSALIR";
            BTNADMINSALIR.Size = new Size(166, 72);
            BTNADMINSALIR.TabIndex = 0;
            BTNADMINSALIR.Text = "Salir";
            BTNADMINSALIR.UseVisualStyleBackColor = true;
            BTNADMINSALIR.Click += BTNADMINSALIR_Click;
            // 
            // BTNADMINALTAS
            // 
            BTNADMINALTAS.Location = new Point(65, 62);
            BTNADMINALTAS.Margin = new Padding(5);
            BTNADMINALTAS.Name = "BTNADMINALTAS";
            BTNADMINALTAS.Size = new Size(180, 62);
            BTNADMINALTAS.TabIndex = 1;
            BTNADMINALTAS.Text = "ALTAS";
            BTNADMINALTAS.UseVisualStyleBackColor = true;
            // 
            // BTNADMINBAJAS
            // 
            BTNADMINBAJAS.Location = new Point(1058, 62);
            BTNADMINBAJAS.Margin = new Padding(5);
            BTNADMINBAJAS.Name = "BTNADMINBAJAS";
            BTNADMINBAJAS.Size = new Size(180, 62);
            BTNADMINBAJAS.TabIndex = 2;
            BTNADMINBAJAS.Text = "BAJAS";
            BTNADMINBAJAS.UseVisualStyleBackColor = true;
            // 
            // BTNADMINGRAFICA
            // 
            BTNADMINGRAFICA.Location = new Point(1034, 373);
            BTNADMINGRAFICA.Margin = new Padding(5);
            BTNADMINGRAFICA.Name = "BTNADMINGRAFICA";
            BTNADMINGRAFICA.Size = new Size(205, 77);
            BTNADMINGRAFICA.TabIndex = 3;
            BTNADMINGRAFICA.Text = "VENTAS Y GRAFICA";
            BTNADMINGRAFICA.UseVisualStyleBackColor = true;
            // 
            // BTNADMINLISTA
            // 
            BTNADMINLISTA.Location = new Point(65, 373);
            BTNADMINLISTA.Margin = new Padding(5);
            BTNADMINLISTA.Name = "BTNADMINLISTA";
            BTNADMINLISTA.Size = new Size(197, 77);
            BTNADMINLISTA.TabIndex = 4;
            BTNADMINLISTA.Text = "LISTA DE PRODUCTOS";
            BTNADMINLISTA.UseVisualStyleBackColor = true;
            // 
            // BTNADMINLOGOUT
            // 
            BTNADMINLOGOUT.Location = new Point(1072, 613);
            BTNADMINLOGOUT.Margin = new Padding(5);
            BTNADMINLOGOUT.Name = "BTNADMINLOGOUT";
            BTNADMINLOGOUT.Size = new Size(166, 72);
            BTNADMINLOGOUT.TabIndex = 5;
            BTNADMINLOGOUT.Text = "LOG OUT";
            BTNADMINLOGOUT.UseVisualStyleBackColor = true;
            BTNADMINLOGOUT.Click += BTNADMINLOGOUT_Click;
            // 
            // FormMainAdmin
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Sienna;
            ClientSize = new Size(1300, 720);
            Controls.Add(BTNADMINLOGOUT);
            Controls.Add(BTNADMINLISTA);
            Controls.Add(BTNADMINGRAFICA);
            Controls.Add(BTNADMINBAJAS);
            Controls.Add(BTNADMINALTAS);
            Controls.Add(BTNADMINSALIR);
            Margin = new Padding(5);
            Name = "FormMainAdmin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "MAIN ADMIN";
            Load += FormMainAdmin_Load;
            ResumeLayout(false);
        }

        #endregion

        private Button BTNADMINSALIR;
        private Button BTNADMINALTAS;
        private Button BTNADMINBAJAS;
        private Button BTNADMINGRAFICA;
        private Button BTNADMINLISTA;
        private Button BTNADMINLOGOUT;
    }
}