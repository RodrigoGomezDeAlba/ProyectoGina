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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormEfectivo));
            LBLTOTAL = new Label();
            BTNREGRESAR = new Button();
            BTNCONFIRMAR = new Button();
            TXTDR = new TextBox();
            LBLDINEROREC = new Label();
            LBLTOTP = new Label();
            TXTTOT = new TextBox();
            timer = new System.Windows.Forms.Timer(components);
            pictureBox1 = new PictureBox();
            pictureBox3 = new PictureBox();
            pictureBox2 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // LBLTOTAL
            // 
            LBLTOTAL.AutoSize = true;
            LBLTOTAL.Location = new Point(56, 13);
            LBLTOTAL.Margin = new Padding(4, 0, 4, 0);
            LBLTOTAL.Name = "LBLTOTAL";
            LBLTOTAL.Size = new Size(0, 20);
            LBLTOTAL.TabIndex = 0;
            // 
            // BTNREGRESAR
            // 
            BTNREGRESAR.BackColor = Color.FromArgb(192, 255, 255);
            BTNREGRESAR.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            BTNREGRESAR.Location = new Point(9, 354);
            BTNREGRESAR.Margin = new Padding(4, 2, 4, 2);
            BTNREGRESAR.Name = "BTNREGRESAR";
            BTNREGRESAR.Size = new Size(102, 49);
            BTNREGRESAR.TabIndex = 2;
            BTNREGRESAR.Text = "Regresar";
            BTNREGRESAR.UseVisualStyleBackColor = false;
            BTNREGRESAR.Click += BTNREGRESAR_Click;
            // 
            // BTNCONFIRMAR
            // 
            BTNCONFIRMAR.BackColor = Color.FromArgb(192, 255, 192);
            BTNCONFIRMAR.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            BTNCONFIRMAR.Location = new Point(97, 250);
            BTNCONFIRMAR.Margin = new Padding(4, 2, 4, 2);
            BTNCONFIRMAR.Name = "BTNCONFIRMAR";
            BTNCONFIRMAR.Size = new Size(143, 49);
            BTNCONFIRMAR.TabIndex = 3;
            BTNCONFIRMAR.Text = "Confirmar Pago";
            BTNCONFIRMAR.UseVisualStyleBackColor = false;
            BTNCONFIRMAR.Click += BTNCONFIRMAR_Click;
            // 
            // TXTDR
            // 
            TXTDR.Location = new Point(66, 208);
            TXTDR.Margin = new Padding(4, 2, 4, 2);
            TXTDR.Name = "TXTDR";
            TXTDR.Size = new Size(206, 27);
            TXTDR.TabIndex = 4;
            TXTDR.TextChanged += TXTDR_TextChanged;
            // 
            // LBLDINEROREC
            // 
            LBLDINEROREC.AutoSize = true;
            LBLDINEROREC.Location = new Point(66, 185);
            LBLDINEROREC.Margin = new Padding(4, 0, 4, 0);
            LBLDINEROREC.Name = "LBLDINEROREC";
            LBLDINEROREC.Size = new Size(117, 20);
            LBLDINEROREC.TabIndex = 5;
            LBLDINEROREC.Text = "Dinero Recibido";
            // 
            // LBLTOTP
            // 
            LBLTOTP.AutoSize = true;
            LBLTOTP.Location = new Point(66, 112);
            LBLTOTP.Margin = new Padding(4, 0, 4, 0);
            LBLTOTP.Name = "LBLTOTP";
            LBLTOTP.Size = new Size(101, 20);
            LBLTOTP.TabIndex = 9;
            LBLTOTP.Text = "Total  a pagar";
            // 
            // TXTTOT
            // 
            TXTTOT.Location = new Point(66, 136);
            TXTTOT.Margin = new Padding(4, 2, 4, 2);
            TXTTOT.Name = "TXTTOT";
            TXTTOT.Size = new Size(206, 27);
            TXTTOT.TabIndex = 8;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.FromArgb(245, 140, 0);
            pictureBox1.Location = new Point(-153, -6);
            pictureBox1.Margin = new Padding(2, 1, 2, 1);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(834, 72);
            pictureBox1.TabIndex = 22;
            pictureBox1.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.BackColor = Color.White;
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(66, 7);
            pictureBox3.Margin = new Padding(2, 1, 2, 1);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(156, 52);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 25;
            pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.White;
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(9, 7);
            pictureBox2.Margin = new Padding(2, 1, 2, 1);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(57, 52);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 24;
            pictureBox2.TabStop = false;
            // 
            // FormEfectivo
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(341, 411);
            Controls.Add(pictureBox3);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(LBLTOTP);
            Controls.Add(TXTTOT);
            Controls.Add(LBLDINEROREC);
            Controls.Add(TXTDR);
            Controls.Add(BTNCONFIRMAR);
            Controls.Add(BTNREGRESAR);
            Controls.Add(LBLTOTAL);
            Margin = new Padding(4, 2, 4, 2);
            Name = "FormEfectivo";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Efectivo";
            Load += FormEfectivo_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
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
        private PictureBox pictureBox1;
        private PictureBox pictureBox3;
        private PictureBox pictureBox2;
    }
}