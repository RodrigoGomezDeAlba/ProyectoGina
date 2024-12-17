namespace ProyectoGina
{
    partial class FormPortada
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPortada));
            BTNPortadaSalir = new Button();
            CCB = new PictureBox();
            UAALOGO = new PictureBox();
            DATOS = new PictureBox();
            FECHALBL = new Label();
            BTNPortadaIngresar = new Button();
            ((System.ComponentModel.ISupportInitialize)CCB).BeginInit();
            ((System.ComponentModel.ISupportInitialize)UAALOGO).BeginInit();
            ((System.ComponentModel.ISupportInitialize)DATOS).BeginInit();
            SuspendLayout();
            // 
            // BTNPortadaSalir
            // 
            BTNPortadaSalir.BackColor = Color.FromArgb(255, 128, 128);
            BTNPortadaSalir.Cursor = Cursors.Hand;
            BTNPortadaSalir.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BTNPortadaSalir.Location = new Point(21, 286);
            BTNPortadaSalir.Margin = new Padding(3, 2, 3, 2);
            BTNPortadaSalir.Name = "BTNPortadaSalir";
            BTNPortadaSalir.Size = new Size(89, 37);
            BTNPortadaSalir.TabIndex = 0;
            BTNPortadaSalir.Text = "Salir";
            BTNPortadaSalir.UseVisualStyleBackColor = false;
            BTNPortadaSalir.Click += BTNPortadaSalir_Click;
            // 
            // CCB
            // 
            CCB.BackColor = Color.Snow;
            CCB.Image = (Image)resources.GetObject("CCB.Image");
            CCB.Location = new Point(41, 38);
            CCB.Margin = new Padding(3, 2, 3, 2);
            CCB.Name = "CCB";
            CCB.Size = new Size(469, 232);
            CCB.SizeMode = PictureBoxSizeMode.Zoom;
            CCB.TabIndex = 1;
            CCB.TabStop = false;
            CCB.Click += CCB_Click;
            // 
            // UAALOGO
            // 
            UAALOGO.BackColor = Color.Snow;
            UAALOGO.Image = (Image)resources.GetObject("UAALOGO.Image");
            UAALOGO.Location = new Point(540, -12);
            UAALOGO.Margin = new Padding(3, 2, 3, 2);
            UAALOGO.Name = "UAALOGO";
            UAALOGO.Size = new Size(166, 126);
            UAALOGO.SizeMode = PictureBoxSizeMode.Zoom;
            UAALOGO.TabIndex = 2;
            UAALOGO.TabStop = false;
            // 
            // DATOS
            // 
            DATOS.BackColor = Color.Snow;
            DATOS.Image = (Image)resources.GetObject("DATOS.Image");
            DATOS.Location = new Point(319, 82);
            DATOS.Margin = new Padding(3, 2, 3, 2);
            DATOS.Name = "DATOS";
            DATOS.Size = new Size(319, 169);
            DATOS.SizeMode = PictureBoxSizeMode.StretchImage;
            DATOS.TabIndex = 3;
            DATOS.TabStop = false;
            // 
            // FECHALBL
            // 
            FECHALBL.AutoSize = true;
            FECHALBL.BackColor = Color.Snow;
            FECHALBL.Font = new Font("Segoe UI Semibold", 7.125F, FontStyle.Bold, GraphicsUnit.Point, 0);
            FECHALBL.Location = new Point(460, 203);
            FECHALBL.Name = "FECHALBL";
            FECHALBL.Size = new Size(29, 12);
            FECHALBL.TabIndex = 4;
            FECHALBL.Text = "fecha";
            // 
            // BTNPortadaIngresar
            // 
            BTNPortadaIngresar.BackColor = SystemColors.GradientInactiveCaption;
            BTNPortadaIngresar.Cursor = Cursors.Hand;
            BTNPortadaIngresar.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BTNPortadaIngresar.Location = new Point(590, 286);
            BTNPortadaIngresar.Margin = new Padding(3, 2, 3, 2);
            BTNPortadaIngresar.Name = "BTNPortadaIngresar";
            BTNPortadaIngresar.Size = new Size(89, 37);
            BTNPortadaIngresar.TabIndex = 6;
            BTNPortadaIngresar.Text = "Ingresar";
            BTNPortadaIngresar.UseVisualStyleBackColor = false;
            BTNPortadaIngresar.Click += BTNPortadaIngresar_Click;
            // 
            // FormPortada
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Snow;
            ClientSize = new Size(700, 338);
            Controls.Add(BTNPortadaIngresar);
            Controls.Add(FECHALBL);
            Controls.Add(DATOS);
            Controls.Add(UAALOGO);
            Controls.Add(CCB);
            Controls.Add(BTNPortadaSalir);
            Margin = new Padding(3, 2, 3, 2);
            Name = "FormPortada";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "PORTADA";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)CCB).EndInit();
            ((System.ComponentModel.ISupportInitialize)UAALOGO).EndInit();
            ((System.ComponentModel.ISupportInitialize)DATOS).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button BTNPortadaSalir;
        private PictureBox CCB;
        private PictureBox UAALOGO;
        private PictureBox DATOS;
        private Label FECHALBL;
        private Button BTNPortadaIngresar;
    }
}
