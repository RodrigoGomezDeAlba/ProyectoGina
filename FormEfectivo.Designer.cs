namespace ProyectoGina
{
    partial class FormEfectivo
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
            components = new System.ComponentModel.Container();
            LBLTOTAL = new Label();
            BTNREGRESAR = new Button();
            BTNCONFIRMAR = new Button();
            TXTDR = new TextBox();
            LBLDINEROREC = new Label();
            LBLTOTP = new Label();
            TXTTOT = new TextBox();
            timer = new System.Windows.Forms.Timer(components);
            SuspendLayout();
            // 
            // LBLTOTAL
            // 
            LBLTOTAL.AutoSize = true;
            LBLTOTAL.Location = new Point(56, 13);
            LBLTOTAL.Name = "LBLTOTAL";
            LBLTOTAL.Size = new Size(0, 20);
            LBLTOTAL.TabIndex = 0;
            // 
            // BTNREGRESAR
            // 
            BTNREGRESAR.Location = new Point(12, 307);
            BTNREGRESAR.Name = "BTNREGRESAR";
            BTNREGRESAR.Size = new Size(94, 29);
            BTNREGRESAR.TabIndex = 2;
            BTNREGRESAR.Text = "Regresar";
            BTNREGRESAR.UseVisualStyleBackColor = true;
            BTNREGRESAR.Click += BTNREGRESAR_Click;
            // 
            // BTNCONFIRMAR
            // 
            BTNCONFIRMAR.Location = new Point(367, 307);
            BTNCONFIRMAR.Name = "BTNCONFIRMAR";
            BTNCONFIRMAR.Size = new Size(94, 29);
            BTNCONFIRMAR.TabIndex = 3;
            BTNCONFIRMAR.Text = "Confirmar";
            BTNCONFIRMAR.UseVisualStyleBackColor = true;
            BTNCONFIRMAR.Click += BTNCONFIRMAR_Click;
            // 
            // TXTDR
            // 
            TXTDR.Location = new Point(85, 107);
            TXTDR.Name = "TXTDR";
            TXTDR.Size = new Size(339, 27);
            TXTDR.TabIndex = 4;
            TXTDR.TextChanged += TXTDR_TextChanged;
            // 
            // LBLDINEROREC
            // 
            LBLDINEROREC.AutoSize = true;
            LBLDINEROREC.Location = new Point(85, 84);
            LBLDINEROREC.Name = "LBLDINEROREC";
            LBLDINEROREC.Size = new Size(117, 20);
            LBLDINEROREC.TabIndex = 5;
            LBLDINEROREC.Text = "Dinero Recibido";
            // 
            // LBLTOTP
            // 
            LBLTOTP.AutoSize = true;
            LBLTOTP.Location = new Point(85, 11);
            LBLTOTP.Name = "LBLTOTP";
            LBLTOTP.Size = new Size(101, 20);
            LBLTOTP.TabIndex = 9;
            LBLTOTP.Text = "Total  a pagar";
            // 
            // TXTTOT
            // 
            TXTTOT.Location = new Point(85, 34);
            TXTTOT.Name = "TXTTOT";
            TXTTOT.Size = new Size(339, 27);
            TXTTOT.TabIndex = 8;
            // 
            // FormEfectivo
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(473, 348);
            Controls.Add(LBLTOTP);
            Controls.Add(TXTTOT);
            Controls.Add(LBLDINEROREC);
            Controls.Add(TXTDR);
            Controls.Add(BTNCONFIRMAR);
            Controls.Add(BTNREGRESAR);
            Controls.Add(LBLTOTAL);
            Name = "FormEfectivo";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Efectivo";
            Load += FormEfectivo_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label LBLTOTAL;
        private Button BTNREGRESAR;
        private Button BTNCONFIRMAR;
        private TextBox TXTDR;
        private Label LBLDINEROREC;
        private Label LBLTOTP;
        private TextBox TXTTOT;
        private System.Windows.Forms.Timer timer;
    }
}