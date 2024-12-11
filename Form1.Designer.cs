namespace ProyectoGina
{
    partial class Form1
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
            BTNPortadaSalir = new Button();
            CCB = new PictureBox();
            UAALOGO = new PictureBox();
            DATOS = new PictureBox();
            FECHALBL = new Label();
            LOGOSLOGAN = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)CCB).BeginInit();
            ((System.ComponentModel.ISupportInitialize)UAALOGO).BeginInit();
            ((System.ComponentModel.ISupportInitialize)DATOS).BeginInit();
            ((System.ComponentModel.ISupportInitialize)LOGOSLOGAN).BeginInit();
            SuspendLayout();
            // 
            // BTNPortadaSalir
            // 
            BTNPortadaSalir.Location = new Point(19, 381);
            BTNPortadaSalir.Name = "BTNPortadaSalir";
            BTNPortadaSalir.Size = new Size(102, 49);
            BTNPortadaSalir.TabIndex = 0;
            BTNPortadaSalir.Text = "Salir";
            BTNPortadaSalir.UseVisualStyleBackColor = true;
            BTNPortadaSalir.Click += BTNPortadaSalir_Click;
            // 
            // CCB
            // 
            CCB.BackColor = Color.Snow;
            CCB.Location = new Point(19, 12);
            CCB.Name = "CCB";
            CCB.Size = new Size(747, 341);
            CCB.TabIndex = 1;
            CCB.TabStop = false;
            // 
            // UAALOGO
            // 
            UAALOGO.BackColor = Color.Snow;
            UAALOGO.Location = new Point(658, 12);
            UAALOGO.Name = "UAALOGO";
            UAALOGO.Size = new Size(108, 88);
            UAALOGO.TabIndex = 2;
            UAALOGO.TabStop = false;
            // 
            // DATOS
            // 
            DATOS.BackColor = Color.Snow;
            DATOS.Location = new Point(412, 82);
            DATOS.Name = "DATOS";
            DATOS.Size = new Size(354, 213);
            DATOS.TabIndex = 3;
            DATOS.TabStop = false;
            // 
            // FECHALBL
            // 
            FECHALBL.AutoSize = true;
            FECHALBL.BackColor = Color.Snow;
            FECHALBL.Location = new Point(645, 313);
            FECHALBL.Name = "FECHALBL";
            FECHALBL.Size = new Size(50, 20);
            FECHALBL.TabIndex = 4;
            FECHALBL.Text = "label1";
            // 
            // LOGOSLOGAN
            // 
            LOGOSLOGAN.BackColor = Color.Snow;
            LOGOSLOGAN.Location = new Point(328, 12);
            LOGOSLOGAN.Name = "LOGOSLOGAN";
            LOGOSLOGAN.Size = new Size(182, 147);
            LOGOSLOGAN.TabIndex = 5;
            LOGOSLOGAN.TabStop = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Sienna;
            ClientSize = new Size(800, 450);
            Controls.Add(LOGOSLOGAN);
            Controls.Add(FECHALBL);
            Controls.Add(DATOS);
            Controls.Add(UAALOGO);
            Controls.Add(CCB);
            Controls.Add(BTNPortadaSalir);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)CCB).EndInit();
            ((System.ComponentModel.ISupportInitialize)UAALOGO).EndInit();
            ((System.ComponentModel.ISupportInitialize)DATOS).EndInit();
            ((System.ComponentModel.ISupportInitialize)LOGOSLOGAN).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button BTNPortadaSalir;
        private PictureBox CCB;
        private PictureBox UAALOGO;
        private PictureBox DATOS;
        private Label FECHALBL;
        private PictureBox LOGOSLOGAN;
    }
}
