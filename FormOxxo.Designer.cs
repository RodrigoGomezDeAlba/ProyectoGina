namespace ProyectoGina
{
    partial class FormOxxo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormOxxo));
            label1 = new Label();
            pictureBox1 = new PictureBox();
            BTNCONFIRMAR = new Button();
            BTNREGRESAR = new Button();
            pictureBox2 = new PictureBox();
            pictureBox3 = new PictureBox();
            pictureBox4 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(112, 102);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(211, 20);
            label1.TabIndex = 0;
            label1.Text = "Cuenta Refencia: 152 140 3758";
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.White;
            pictureBox1.Image = Properties.Resources.OXXOQR;
            pictureBox1.Location = new Point(92, 124);
            pictureBox1.Margin = new Padding(4, 2, 4, 2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(246, 250);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // BTNCONFIRMAR
            // 
            BTNCONFIRMAR.BackColor = Color.FromArgb(192, 255, 192);
            BTNCONFIRMAR.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            BTNCONFIRMAR.Location = new Point(143, 386);
            BTNCONFIRMAR.Margin = new Padding(4, 2, 4, 2);
            BTNCONFIRMAR.Name = "BTNCONFIRMAR";
            BTNCONFIRMAR.Size = new Size(150, 49);
            BTNCONFIRMAR.TabIndex = 5;
            BTNCONFIRMAR.Text = "Imprimir Ticket";
            BTNCONFIRMAR.UseVisualStyleBackColor = false;
            BTNCONFIRMAR.Click += BTNCONFIRMAR_Click;
            // 
            // BTNREGRESAR
            // 
            BTNREGRESAR.BackColor = Color.FromArgb(192, 255, 255);
            BTNREGRESAR.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            BTNREGRESAR.Location = new Point(9, 469);
            BTNREGRESAR.Margin = new Padding(4, 2, 4, 2);
            BTNREGRESAR.Name = "BTNREGRESAR";
            BTNREGRESAR.Size = new Size(102, 49);
            BTNREGRESAR.TabIndex = 4;
            BTNREGRESAR.Text = "Regresar";
            BTNREGRESAR.UseVisualStyleBackColor = false;
            BTNREGRESAR.Click += BTNREGRESAR_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.FromArgb(245, 140, 0);
            pictureBox2.Location = new Point(-90, -6);
            pictureBox2.Margin = new Padding(2, 1, 2, 1);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(834, 72);
            pictureBox2.TabIndex = 22;
            pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.BackColor = Color.White;
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(63, 7);
            pictureBox3.Margin = new Padding(2, 1, 2, 1);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(156, 52);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 25;
            pictureBox3.TabStop = false;
            // 
            // pictureBox4
            // 
            pictureBox4.BackColor = Color.White;
            pictureBox4.Image = (Image)resources.GetObject("pictureBox4.Image");
            pictureBox4.Location = new Point(6, 7);
            pictureBox4.Margin = new Padding(2, 1, 2, 1);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(57, 52);
            pictureBox4.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox4.TabIndex = 24;
            pictureBox4.TabStop = false;
            // 
            // FormOxxo
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(431, 527);
            Controls.Add(pictureBox3);
            Controls.Add(pictureBox4);
            Controls.Add(pictureBox2);
            Controls.Add(BTNCONFIRMAR);
            Controls.Add(BTNREGRESAR);
            Controls.Add(pictureBox1);
            Controls.Add(label1);
            Margin = new Padding(4, 2, 4, 2);
            Name = "FormOxxo";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "PAGO EN OXXO";
            Load += FormOxxo_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private PictureBox pictureBox1;
        private Button BTNCONFIRMAR;
        private Button BTNREGRESAR;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
        private PictureBox pictureBox4;
    }
}