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
            LBLCuenta = new Label();
            LBLContraseña = new Label();
            TXTUsuario = new TextBox();
            TEXTContra = new TextBox();
            LOGOSLOGAN = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)LOGOSLOGAN).BeginInit();
            SuspendLayout();
            // 
            // LBLCuenta
            // 
            LBLCuenta.AutoSize = true;
            LBLCuenta.BackColor = Color.Snow;
            LBLCuenta.Location = new Point(58, 92);
            LBLCuenta.Name = "LBLCuenta";
            LBLCuenta.Size = new Size(71, 20);
            LBLCuenta.TabIndex = 0;
            LBLCuenta.Text = "USUARIO";
            // 
            // LBLContraseña
            // 
            LBLContraseña.AutoSize = true;
            LBLContraseña.BackColor = Color.Snow;
            LBLContraseña.Location = new Point(58, 242);
            LBLContraseña.Name = "LBLContraseña";
            LBLContraseña.Size = new Size(104, 20);
            LBLContraseña.TabIndex = 1;
            LBLContraseña.Text = "CONTRASEÑA";
            // 
            // TXTUsuario
            // 
            TXTUsuario.Location = new Point(222, 88);
            TXTUsuario.Name = "TXTUsuario";
            TXTUsuario.Size = new Size(463, 27);
            TXTUsuario.TabIndex = 2;
            TXTUsuario.TextChanged += TXTUsuario_TextChanged;
            // 
            // TEXTContra
            // 
            TEXTContra.Location = new Point(222, 239);
            TEXTContra.Name = "TEXTContra";
            TEXTContra.Size = new Size(463, 27);
            TEXTContra.TabIndex = 3;
            TEXTContra.UseSystemPasswordChar = true;
            TEXTContra.TextChanged += TEXTContra_TextChanged;
            // 
            // LOGOSLOGAN
            // 
            LOGOSLOGAN.BackColor = Color.Snow;
            LOGOSLOGAN.Location = new Point(324, 291);
            LOGOSLOGAN.Name = "LOGOSLOGAN";
            LOGOSLOGAN.Size = new Size(182, 147);
            LOGOSLOGAN.TabIndex = 6;
            LOGOSLOGAN.TabStop = false;
            // 
            // FormUsuario
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Sienna;
            ClientSize = new Size(800, 450);
            Controls.Add(LOGOSLOGAN);
            Controls.Add(TEXTContra);
            Controls.Add(TXTUsuario);
            Controls.Add(LBLContraseña);
            Controls.Add(LBLCuenta);
            Name = "FormUsuario";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "INGRESAR";
            Load += FormUsuario_Load;
            ((System.ComponentModel.ISupportInitialize)LOGOSLOGAN).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label LBLCuenta;
        private Label LBLContraseña;
        private TextBox TXTUsuario;
        private TextBox TEXTContra;
        private PictureBox LOGOSLOGAN;
    }
}