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
            BTNADMINSALIR.Location = new Point(40, 383);
            BTNADMINSALIR.Name = "BTNADMINSALIR";
            BTNADMINSALIR.Size = new Size(102, 45);
            BTNADMINSALIR.TabIndex = 0;
            BTNADMINSALIR.Text = "Salir";
            BTNADMINSALIR.UseVisualStyleBackColor = true;
            BTNADMINSALIR.Click += BTNADMINSALIR_Click;
            // 
            // BTNADMINALTAS
            // 
            BTNADMINALTAS.Location = new Point(40, 39);
            BTNADMINALTAS.Name = "BTNADMINALTAS";
            BTNADMINALTAS.Size = new Size(111, 39);
            BTNADMINALTAS.TabIndex = 1;
            BTNADMINALTAS.Text = "ALTAS";
            BTNADMINALTAS.UseVisualStyleBackColor = true;
            // 
            // BTNADMINBAJAS
            // 
            BTNADMINBAJAS.Location = new Point(651, 39);
            BTNADMINBAJAS.Name = "BTNADMINBAJAS";
            BTNADMINBAJAS.Size = new Size(111, 39);
            BTNADMINBAJAS.TabIndex = 2;
            BTNADMINBAJAS.Text = "BAJAS";
            BTNADMINBAJAS.UseVisualStyleBackColor = true;
            // 
            // BTNADMINGRAFICA
            // 
            BTNADMINGRAFICA.Location = new Point(636, 233);
            BTNADMINGRAFICA.Name = "BTNADMINGRAFICA";
            BTNADMINGRAFICA.Size = new Size(126, 48);
            BTNADMINGRAFICA.TabIndex = 3;
            BTNADMINGRAFICA.Text = "VENTAS Y GRAFICA";
            BTNADMINGRAFICA.UseVisualStyleBackColor = true;
            // 
            // BTNADMINLISTA
            // 
            BTNADMINLISTA.Location = new Point(40, 233);
            BTNADMINLISTA.Name = "BTNADMINLISTA";
            BTNADMINLISTA.Size = new Size(121, 48);
            BTNADMINLISTA.TabIndex = 4;
            BTNADMINLISTA.Text = "LISTA DE PRODUCTOS";
            BTNADMINLISTA.UseVisualStyleBackColor = true;
            // 
            // BTNADMINLOGOUT
            // 
            BTNADMINLOGOUT.Location = new Point(660, 383);
            BTNADMINLOGOUT.Name = "BTNADMINLOGOUT";
            BTNADMINLOGOUT.Size = new Size(102, 45);
            BTNADMINLOGOUT.TabIndex = 5;
            BTNADMINLOGOUT.Text = "LOG OUT";
            BTNADMINLOGOUT.UseVisualStyleBackColor = true;
            BTNADMINLOGOUT.Click += BTNADMINLOGOUT_Click;
            // 
            // FormMainAdmin
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Sienna;
            ClientSize = new Size(800, 450);
            Controls.Add(BTNADMINLOGOUT);
            Controls.Add(BTNADMINLISTA);
            Controls.Add(BTNADMINGRAFICA);
            Controls.Add(BTNADMINBAJAS);
            Controls.Add(BTNADMINALTAS);
            Controls.Add(BTNADMINSALIR);
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