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
            LBLTOTAL.Location = new Point(49, 10);
            LBLTOTAL.Name = "LBLTOTAL";
            LBLTOTAL.Size = new Size(0, 15);
            LBLTOTAL.TabIndex = 0;
            // 
            // BTNREGRESAR
            // 
            BTNREGRESAR.Location = new Point(10, 230);
            BTNREGRESAR.Margin = new Padding(3, 2, 3, 2);
            BTNREGRESAR.Name = "BTNREGRESAR";
            BTNREGRESAR.Size = new Size(82, 22);
            BTNREGRESAR.TabIndex = 2;
            BTNREGRESAR.Text = "Regresar";
            BTNREGRESAR.UseVisualStyleBackColor = true;
            BTNREGRESAR.Click += BTNREGRESAR_Click;
            // 
            // BTNCONFIRMAR
            // 
            BTNCONFIRMAR.Location = new Point(321, 230);
            BTNCONFIRMAR.Margin = new Padding(3, 2, 3, 2);
            BTNCONFIRMAR.Name = "BTNCONFIRMAR";
            BTNCONFIRMAR.Size = new Size(82, 22);
            BTNCONFIRMAR.TabIndex = 3;
            BTNCONFIRMAR.Text = "Confirmar";
            BTNCONFIRMAR.UseVisualStyleBackColor = true;
            BTNCONFIRMAR.Click += BTNCONFIRMAR_Click;
            // 
            // TXTDR
            // 
            TXTDR.Location = new Point(74, 80);
            TXTDR.Margin = new Padding(3, 2, 3, 2);
            TXTDR.Name = "TXTDR";
            TXTDR.Size = new Size(297, 23);
            TXTDR.TabIndex = 4;
            TXTDR.TextChanged += TXTDR_TextChanged;
            // 
            // LBLDINEROREC
            // 
            LBLDINEROREC.AutoSize = true;
            LBLDINEROREC.Location = new Point(74, 63);
            LBLDINEROREC.Name = "LBLDINEROREC";
            LBLDINEROREC.Size = new Size(91, 15);
            LBLDINEROREC.TabIndex = 5;
            LBLDINEROREC.Text = "Dinero Recibido";
            // 
            // LBLTOTP
            // 
            LBLTOTP.AutoSize = true;
            LBLTOTP.Location = new Point(74, 8);
            LBLTOTP.Name = "LBLTOTP";
            LBLTOTP.Size = new Size(77, 15);
            LBLTOTP.TabIndex = 9;
            LBLTOTP.Text = "Total  a pagar";
            // 
            // TXTTOT
            // 
            TXTTOT.Location = new Point(74, 26);
            TXTTOT.Margin = new Padding(3, 2, 3, 2);
            TXTTOT.Name = "TXTTOT";
            TXTTOT.Size = new Size(297, 23);
            TXTTOT.TabIndex = 8;
            // 
            // FormEfectivo
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(414, 261);
            Controls.Add(LBLTOTP);
            Controls.Add(TXTTOT);
            Controls.Add(LBLDINEROREC);
            Controls.Add(TXTDR);
            Controls.Add(BTNCONFIRMAR);
            Controls.Add(BTNREGRESAR);
            Controls.Add(LBLTOTAL);
            Margin = new Padding(3, 2, 3, 2);
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
        
        private Button buttonTicket;
    }
}