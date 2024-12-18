namespace ProyectoGina
{
    partial class Formtarjeta
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Formtarjeta));
            LBLTOTP = new Label();
            TXTPROPIE = new TextBox();
            LBLDINEROREC = new Label();
            TXTNT = new TextBox();
            BTNCONFIRMAR = new Button();
            BTNREGRESAR = new Button();
            LBLTOTAL = new Label();
            label1 = new Label();
            TXTCVV = new TextBox();
            label2 = new Label();
            TXTFV = new TextBox();
            pictureBox1 = new PictureBox();
            pictureBox3 = new PictureBox();
            pictureBox2 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // LBLTOTP
            // 
            LBLTOTP.AutoSize = true;
            LBLTOTP.Location = new Point(70, 110);
            LBLTOTP.Margin = new Padding(4, 0, 4, 0);
            LBLTOTP.Name = "LBLTOTP";
            LBLTOTP.Size = new Size(168, 20);
            LBLTOTP.TabIndex = 16;
            LBLTOTP.Text = "Nombre del propietario";
            // 
            // TXTPROPIE
            // 
            TXTPROPIE.Location = new Point(70, 132);
            TXTPROPIE.Margin = new Padding(4, 2, 4, 2);
            TXTPROPIE.Name = "TXTPROPIE";
            TXTPROPIE.Size = new Size(339, 27);
            TXTPROPIE.TabIndex = 15;
            // 
            // LBLDINEROREC
            // 
            LBLDINEROREC.AutoSize = true;
            LBLDINEROREC.Location = new Point(70, 183);
            LBLDINEROREC.Margin = new Padding(4, 0, 4, 0);
            LBLDINEROREC.Name = "LBLDINEROREC";
            LBLDINEROREC.Size = new Size(131, 20);
            LBLDINEROREC.TabIndex = 14;
            LBLDINEROREC.Text = "Numero de tarjeta";
            // 
            // TXTNT
            // 
            TXTNT.Location = new Point(70, 206);
            TXTNT.Margin = new Padding(4, 2, 4, 2);
            TXTNT.Name = "TXTNT";
            TXTNT.Size = new Size(339, 27);
            TXTNT.TabIndex = 13;
            // 
            // BTNCONFIRMAR
            // 
            BTNCONFIRMAR.BackColor = Color.FromArgb(192, 255, 192);
            BTNCONFIRMAR.Cursor = Cursors.Hand;
            BTNCONFIRMAR.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            BTNCONFIRMAR.Location = new Point(143, 334);
            BTNCONFIRMAR.Margin = new Padding(4, 2, 4, 2);
            BTNCONFIRMAR.Name = "BTNCONFIRMAR";
            BTNCONFIRMAR.Size = new Size(170, 49);
            BTNCONFIRMAR.TabIndex = 12;
            BTNCONFIRMAR.Text = "Confirmar Compra";
            BTNCONFIRMAR.UseVisualStyleBackColor = false;
            BTNCONFIRMAR.Click += BTNCONFIRMAR_Click;
            // 
            // BTNREGRESAR
            // 
            BTNREGRESAR.BackColor = Color.FromArgb(192, 255, 255);
            BTNREGRESAR.Cursor = Cursors.Hand;
            BTNREGRESAR.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            BTNREGRESAR.Location = new Point(9, 423);
            BTNREGRESAR.Margin = new Padding(4, 2, 4, 2);
            BTNREGRESAR.Name = "BTNREGRESAR";
            BTNREGRESAR.Size = new Size(102, 49);
            BTNREGRESAR.TabIndex = 11;
            BTNREGRESAR.Text = "Regresar";
            BTNREGRESAR.UseVisualStyleBackColor = false;
            BTNREGRESAR.Click += BTNREGRESAR_Click;
            // 
            // LBLTOTAL
            // 
            LBLTOTAL.AutoSize = true;
            LBLTOTAL.Location = new Point(44, 41);
            LBLTOTAL.Margin = new Padding(4, 0, 4, 0);
            LBLTOTAL.Name = "LBLTOTAL";
            LBLTOTAL.Size = new Size(0, 20);
            LBLTOTAL.TabIndex = 10;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(70, 254);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(36, 20);
            label1.TabIndex = 20;
            label1.Text = "CVV";
            // 
            // TXTCVV
            // 
            TXTCVV.Location = new Point(70, 277);
            TXTCVV.Margin = new Padding(4, 2, 4, 2);
            TXTCVV.Name = "TXTCVV";
            TXTCVV.Size = new Size(131, 27);
            TXTCVV.TabIndex = 19;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(278, 254);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(47, 20);
            label2.TabIndex = 18;
            label2.Text = "Fecha";
            // 
            // TXTFV
            // 
            TXTFV.ForeColor = Color.Black;
            TXTFV.Location = new Point(278, 277);
            TXTFV.Margin = new Padding(4, 2, 4, 2);
            TXTFV.Name = "TXTFV";
            TXTFV.PlaceholderText = "MM/AA";
            TXTFV.Size = new Size(131, 27);
            TXTFV.TabIndex = 17;
            TXTFV.TextAlign = HorizontalAlignment.Center;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.FromArgb(245, 140, 0);
            pictureBox1.Location = new Point(-183, -6);
            pictureBox1.Margin = new Padding(2, 1, 2, 1);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(834, 72);
            pictureBox1.TabIndex = 21;
            pictureBox1.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.BackColor = Color.White;
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(70, 7);
            pictureBox3.Margin = new Padding(2, 1, 2, 1);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(156, 52);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 23;
            pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.White;
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(12, 7);
            pictureBox2.Margin = new Padding(2, 1, 2, 1);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(57, 52);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 22;
            pictureBox2.TabStop = false;
            // 
            // Formtarjeta
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(466, 481);
            Controls.Add(pictureBox3);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(label1);
            Controls.Add(TXTCVV);
            Controls.Add(label2);
            Controls.Add(TXTFV);
            Controls.Add(LBLTOTP);
            Controls.Add(TXTPROPIE);
            Controls.Add(LBLDINEROREC);
            Controls.Add(TXTNT);
            Controls.Add(BTNCONFIRMAR);
            Controls.Add(BTNREGRESAR);
            Controls.Add(LBLTOTAL);
            Margin = new Padding(4, 2, 4, 2);
            Name = "Formtarjeta";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Tarjeta";
            Load += Formtarjeta_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label LBLTOTP;
        private TextBox TXTPROPIE;
        private Label LBLDINEROREC;
        private TextBox TXTNT;
        private Button BTNCONFIRMAR;
        private Button BTNREGRESAR;
        private Label LBLTOTAL;
        private Label label1;
        private TextBox TXTCVV;
        private Label label2;
        private TextBox TXTFV;
        private Button buttonTicket;
        private PictureBox pictureBox1;
        private PictureBox pictureBox3;
        private PictureBox pictureBox2;
    }
}