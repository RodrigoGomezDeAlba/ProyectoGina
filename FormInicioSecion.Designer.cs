namespace ProyectoGina
{
    partial class FormUsuario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormUsuario));
            TXTUsuario = new TextBox();
            TEXTContra = new TextBox();
            LOGOSLOGAN = new PictureBox();
            BTNIngresar = new Button();
            BTNSalirF2 = new Button();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)LOGOSLOGAN).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // TXTUsuario
            // 
            TXTUsuario.Cursor = Cursors.IBeam;
            TXTUsuario.Location = new Point(637, 443);
            TXTUsuario.Margin = new Padding(5);
            TXTUsuario.Name = "TXTUsuario";
            TXTUsuario.PlaceholderText = "Usuario";
            TXTUsuario.Size = new Size(475, 39);
            TXTUsuario.TabIndex = 2;
            TXTUsuario.TextAlign = HorizontalAlignment.Center;
            TXTUsuario.TextChanged += TXTUsuario_TextChanged;
            // 
            // TEXTContra
            // 
            TEXTContra.Cursor = Cursors.IBeam;
            TEXTContra.Location = new Point(637, 510);
            TEXTContra.Margin = new Padding(5);
            TEXTContra.Name = "TEXTContra";
            TEXTContra.PlaceholderText = "Contraseña";
            TEXTContra.Size = new Size(475, 39);
            TEXTContra.TabIndex = 3;
            TEXTContra.TextAlign = HorizontalAlignment.Center;
            TEXTContra.UseSystemPasswordChar = true;
            TEXTContra.TextChanged += TEXTContra_TextChanged;
            // 
            // LOGOSLOGAN
            // 
            LOGOSLOGAN.BackColor = Color.White;
            LOGOSLOGAN.Location = new Point(637, 66);
            LOGOSLOGAN.Margin = new Padding(5);
            LOGOSLOGAN.Name = "LOGOSLOGAN";
            LOGOSLOGAN.Size = new Size(475, 344);
            LOGOSLOGAN.TabIndex = 6;
            LOGOSLOGAN.TabStop = false;
            // 
            // BTNIngresar
            // 
            BTNIngresar.BackColor = SystemColors.GradientInactiveCaption;
            BTNIngresar.Cursor = Cursors.Hand;
            BTNIngresar.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BTNIngresar.Location = new Point(1096, 610);
            BTNIngresar.Margin = new Padding(5);
            BTNIngresar.Name = "BTNIngresar";
            BTNIngresar.Size = new Size(166, 78);
            BTNIngresar.TabIndex = 7;
            BTNIngresar.Text = "Ingresar";
            BTNIngresar.UseVisualStyleBackColor = false;
            BTNIngresar.Click += BTNIngresar_Click;
            // 
            // BTNSalirF2
            // 
            BTNSalirF2.BackColor = Color.Gainsboro;
            BTNSalirF2.Cursor = Cursors.Hand;
            BTNSalirF2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BTNSalirF2.Location = new Point(39, 610);
            BTNSalirF2.Margin = new Padding(5);
            BTNSalirF2.Name = "BTNSalirF2";
            BTNSalirF2.Size = new Size(166, 78);
            BTNSalirF2.TabIndex = 8;
            BTNSalirF2.Text = "Salir";
            BTNSalirF2.UseVisualStyleBackColor = false;
            BTNSalirF2.Click += BTNSalirF2_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(186, 89);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(334, 473);
            pictureBox1.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox1.TabIndex = 11;
            pictureBox1.TabStop = false;
            // 
            // FormUsuario
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1300, 720);
            Controls.Add(pictureBox1);
            Controls.Add(BTNSalirF2);
            Controls.Add(BTNIngresar);
            Controls.Add(LOGOSLOGAN);
            Controls.Add(TEXTContra);
            Controls.Add(TXTUsuario);
            Margin = new Padding(5);
            Name = "FormUsuario";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "INGRESAR";
            Load += FormUsuario_Load;
            ((System.ComponentModel.ISupportInitialize)LOGOSLOGAN).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox TXTUsuario;
        private TextBox TEXTContra;
        private PictureBox LOGOSLOGAN;
        private Button BTNIngresar;
        private Button BTNSalirF2;
        private PictureBox pictureBox1;
    }
}