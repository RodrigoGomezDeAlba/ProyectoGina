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
            BTNIngresar = new Button();
            BTNSalirF2 = new Button();
            button1 = new Button();
            button2 = new Button();
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
            // BTNIngresar
            // 
            BTNIngresar.Location = new Point(644, 337);
            BTNIngresar.Name = "BTNIngresar";
            BTNIngresar.Size = new Size(122, 41);
            BTNIngresar.TabIndex = 7;
            BTNIngresar.Text = "Ingresar";
            BTNIngresar.UseVisualStyleBackColor = true;
            BTNIngresar.Click += BTNIngresar_Click;
            // 
            // BTNSalirF2
            // 
            BTNSalirF2.Location = new Point(40, 337);
            BTNSalirF2.Name = "BTNSalirF2";
            BTNSalirF2.Size = new Size(122, 41);
            BTNSalirF2.TabIndex = 8;
            BTNSalirF2.Text = "Salir";
            BTNSalirF2.UseVisualStyleBackColor = true;
            BTNSalirF2.Click += BTNSalirF2_Click;
            // 
            // button1
            // 
            button1.Location = new Point(558, 22);
            button1.Name = "button1";
            button1.Size = new Size(85, 36);
            button1.TabIndex = 9;
            button1.Text = "FormUsuario";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(68, 17);
            button2.Name = "button2";
            button2.Size = new Size(97, 38);
            button2.TabIndex = 10;
            button2.Text = "FormAdmin";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // FormUsuario
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Sienna;
            ClientSize = new Size(800, 450);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(BTNSalirF2);
            Controls.Add(BTNIngresar);
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
        private Button BTNIngresar;
        private Button BTNSalirF2;
        private Button button1;
        private Button button2;
    }
}