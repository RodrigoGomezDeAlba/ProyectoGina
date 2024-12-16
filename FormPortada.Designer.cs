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
            BTNPortadaSalir.BackColor = Color.Gainsboro;
            BTNPortadaSalir.Cursor = Cursors.Hand;
            BTNPortadaSalir.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BTNPortadaSalir.Location = new Point(39, 610);
            BTNPortadaSalir.Margin = new Padding(5);
            BTNPortadaSalir.Name = "BTNPortadaSalir";
            BTNPortadaSalir.Size = new Size(166, 78);
            BTNPortadaSalir.TabIndex = 0;
            BTNPortadaSalir.Text = "Salir";
            BTNPortadaSalir.UseVisualStyleBackColor = false;
            BTNPortadaSalir.Click += BTNPortadaSalir_Click;
            // 
            // CCB
            // 
            CCB.BackColor = Color.Snow;
            CCB.Image = (Image)resources.GetObject("CCB.Image");
            CCB.Location = new Point(76, 81);
            CCB.Margin = new Padding(5);
            CCB.Name = "CCB";
            CCB.Size = new Size(871, 494);
            CCB.SizeMode = PictureBoxSizeMode.Zoom;
            CCB.TabIndex = 1;
            CCB.TabStop = false;
            // 
            // UAALOGO
            // 
            UAALOGO.BackColor = Color.Snow;
            UAALOGO.Image = (Image)resources.GetObject("UAALOGO.Image");
            UAALOGO.Location = new Point(1002, -25);
            UAALOGO.Margin = new Padding(5);
            UAALOGO.Name = "UAALOGO";
            UAALOGO.Size = new Size(309, 268);
            UAALOGO.SizeMode = PictureBoxSizeMode.Zoom;
            UAALOGO.TabIndex = 2;
            UAALOGO.TabStop = false;
            // 
            // DATOS
            // 
            DATOS.BackColor = Color.Snow;
            DATOS.Image = (Image)resources.GetObject("DATOS.Image");
            DATOS.Location = new Point(592, 176);
            DATOS.Margin = new Padding(5);
            DATOS.Name = "DATOS";
            DATOS.Size = new Size(593, 361);
            DATOS.SizeMode = PictureBoxSizeMode.StretchImage;
            DATOS.TabIndex = 3;
            DATOS.TabStop = false;
            // 
            // FECHALBL
            // 
            FECHALBL.AutoSize = true;
            FECHALBL.BackColor = Color.Snow;
            FECHALBL.Font = new Font("Segoe UI Semibold", 7.125F, FontStyle.Bold, GraphicsUnit.Point, 0);
            FECHALBL.Location = new Point(855, 434);
            FECHALBL.Margin = new Padding(5, 0, 5, 0);
            FECHALBL.Name = "FECHALBL";
            FECHALBL.Size = new Size(59, 25);
            FECHALBL.TabIndex = 4;
            FECHALBL.Text = "fecha";
            // 
            // BTNPortadaIngresar
            // 
            BTNPortadaIngresar.BackColor = SystemColors.GradientInactiveCaption;
            BTNPortadaIngresar.Cursor = Cursors.Hand;
            BTNPortadaIngresar.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BTNPortadaIngresar.Location = new Point(1096, 610);
            BTNPortadaIngresar.Margin = new Padding(5);
            BTNPortadaIngresar.Name = "BTNPortadaIngresar";
            BTNPortadaIngresar.Size = new Size(166, 78);
            BTNPortadaIngresar.TabIndex = 6;
            BTNPortadaIngresar.Text = "Ingresar";
            BTNPortadaIngresar.UseVisualStyleBackColor = false;
            BTNPortadaIngresar.Click += BTNPortadaIngresar_Click;
            // 
            // FormPortada
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Snow;
            ClientSize = new Size(1300, 720);
            Controls.Add(BTNPortadaIngresar);
            Controls.Add(FECHALBL);
            Controls.Add(DATOS);
            Controls.Add(UAALOGO);
            Controls.Add(CCB);
            Controls.Add(BTNPortadaSalir);
            Margin = new Padding(5);
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
