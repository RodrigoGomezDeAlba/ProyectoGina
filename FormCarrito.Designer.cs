namespace ProyectoGina
{
    partial class FormCarrito
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormCarrito));
            BTNREGRESARCARRITO = new Button();
            BTNCONFIRMCARRITO = new Button();
            RCHTBLISTAPROD = new RichTextBox();
            pictureBox2 = new PictureBox();
            pictureBox3 = new PictureBox();
            pictureBox1 = new PictureBox();
            LBLUSUARIO = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // BTNREGRESARCARRITO
            // 
            BTNREGRESARCARRITO.BackColor = Color.FromArgb(192, 255, 255);
            BTNREGRESARCARRITO.Cursor = Cursors.Hand;
            BTNREGRESARCARRITO.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            BTNREGRESARCARRITO.Location = new Point(45, 749);
            BTNREGRESARCARRITO.Margin = new Padding(6, 4, 6, 4);
            BTNREGRESARCARRITO.Name = "BTNREGRESARCARRITO";
            BTNREGRESARCARRITO.Size = new Size(154, 75);
            BTNREGRESARCARRITO.TabIndex = 0;
            BTNREGRESARCARRITO.Text = "Regresar";
            BTNREGRESARCARRITO.UseVisualStyleBackColor = false;
            BTNREGRESARCARRITO.Click += BTNREGRESARCARRITO_Click;
            // 
            // BTNCONFIRMCARRITO
            // 
            BTNCONFIRMCARRITO.BackColor = Color.FromArgb(192, 255, 192);
            BTNCONFIRMCARRITO.Cursor = Cursors.Hand;
            BTNCONFIRMCARRITO.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            BTNCONFIRMCARRITO.Location = new Point(418, 749);
            BTNCONFIRMCARRITO.Margin = new Padding(6, 4, 6, 4);
            BTNCONFIRMCARRITO.Name = "BTNCONFIRMCARRITO";
            BTNCONFIRMCARRITO.Size = new Size(349, 75);
            BTNCONFIRMCARRITO.TabIndex = 2;
            BTNCONFIRMCARRITO.Text = "Ir al Pago";
            BTNCONFIRMCARRITO.UseVisualStyleBackColor = false;
            BTNCONFIRMCARRITO.Click += BTNCONFIRMCARRITO_Click_1;
            // 
            // RCHTBLISTAPROD
            // 
            RCHTBLISTAPROD.Enabled = false;
            RCHTBLISTAPROD.Location = new Point(45, 117);
            RCHTBLISTAPROD.Margin = new Padding(6, 4, 6, 4);
            RCHTBLISTAPROD.Name = "RCHTBLISTAPROD";
            RCHTBLISTAPROD.Size = new Size(721, 601);
            RCHTBLISTAPROD.TabIndex = 3;
            RCHTBLISTAPROD.Text = "";
            RCHTBLISTAPROD.TextChanged += RCHTBLISTAPROD_TextChanged;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(11, 13);
            pictureBox2.Margin = new Padding(4, 2, 4, 2);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(93, 83);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 13;
            pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(106, 13);
            pictureBox3.Margin = new Padding(4, 2, 4, 2);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(253, 83);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 14;
            pictureBox3.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.FromArgb(245, 140, 0);
            pictureBox1.Location = new Point(-269, -4);
            pictureBox1.Margin = new Padding(4, 2, 4, 2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(1356, 115);
            pictureBox1.TabIndex = 15;
            pictureBox1.TabStop = false;
            // 
            // LBLUSUARIO
            // 
            LBLUSUARIO.AutoSize = true;
            LBLUSUARIO.Font = new Font("Segoe UI", 10.875F);
            LBLUSUARIO.Location = new Point(653, 56);
            LBLUSUARIO.Margin = new Padding(4, 0, 4, 0);
            LBLUSUARIO.Name = "LBLUSUARIO";
            LBLUSUARIO.Size = new Size(114, 40);
            LBLUSUARIO.TabIndex = 24;
            LBLUSUARIO.Text = "Usuario";
            LBLUSUARIO.Click += LBLUSUARIO_Click_1;
            // 
            // FormCarrito
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(815, 864);
            Controls.Add(LBLUSUARIO);
            Controls.Add(pictureBox3);
            Controls.Add(pictureBox2);
            Controls.Add(RCHTBLISTAPROD);
            Controls.Add(BTNCONFIRMCARRITO);
            Controls.Add(BTNREGRESARCARRITO);
            Controls.Add(pictureBox1);
            Margin = new Padding(6, 4, 6, 4);
            Name = "FormCarrito";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Carrito";
            Load += FormCarrito_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button BTNREGRESARCARRITO;
        private Button BTNCONFIRMCARRITO;
        private RichTextBox RCHTBLISTAPROD;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
        private PictureBox pictureBox1;
        private Label LBLUSUARIO;
    }
}