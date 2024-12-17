namespace ProyectoGina
{
    partial class FormMainUsuario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMainUsuario));
            ImageProductos = new ImageList(components);
            BTNPASARIMAGEN = new Button();
            PICTUREIMAGES = new PictureBox();
            BTNSALIRMAINUSU = new Button();
            BTNLOGOUTMAINUSER = new Button();
            BTNCOMPRARMAINUSU = new Button();
            CONTADORPRODMAINUSU = new NumericUpDown();
            pictureBoxCarrito = new PictureBox();
            buttonRegresarImagen = new Button();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            pictureBox2 = new PictureBox();
            pictureBox3 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)PICTUREIMAGES).BeginInit();
            ((System.ComponentModel.ISupportInitialize)CONTADORPRODMAINUSU).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxCarrito).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            SuspendLayout();
            // 
            // ImageProductos
            // 
            ImageProductos.ColorDepth = ColorDepth.Depth32Bit;
            ImageProductos.ImageStream = (ImageListStreamer)resources.GetObject("ImageProductos.ImageStream");
            ImageProductos.TransparentColor = Color.Snow;
            ImageProductos.Images.SetKeyName(0, "ArmaniCodeParfum.jpg");
            ImageProductos.Images.SetKeyName(1, "BSKGrisChannel.jpg");
            ImageProductos.Images.SetKeyName(2, "CreedSilverWater.jpg");
            ImageProductos.Images.SetKeyName(3, "GivenchySocietyExtreme.jpg");
            ImageProductos.Images.SetKeyName(4, "HgoBossAbsolu.jpg");
            ImageProductos.Images.SetKeyName(5, "MojaveGhost.jpg");
            ImageProductos.Images.SetKeyName(6, "Myself.jpg");
            ImageProductos.Images.SetKeyName(7, "NishaneHacivat.jpg");
            ImageProductos.Images.SetKeyName(8, "ParfumsMarlyLayton.jpg");
            ImageProductos.Images.SetKeyName(9, "Y LE PARFUM.jpg");
            // 
            // BTNPASARIMAGEN
            // 
            BTNPASARIMAGEN.BackColor = Color.FromArgb(244, 169, 0);
            BTNPASARIMAGEN.Cursor = Cursors.Hand;
            BTNPASARIMAGEN.Font = new Font("Segoe UI", 7.875F, FontStyle.Bold);
            BTNPASARIMAGEN.Location = new Point(367, 512);
            BTNPASARIMAGEN.Margin = new Padding(5);
            BTNPASARIMAGEN.Name = "BTNPASARIMAGEN";
            BTNPASARIMAGEN.Size = new Size(66, 57);
            BTNPASARIMAGEN.TabIndex = 1;
            BTNPASARIMAGEN.TabStop = false;
            BTNPASARIMAGEN.Text = ">";
            BTNPASARIMAGEN.UseVisualStyleBackColor = false;
            BTNPASARIMAGEN.Click += BTNPASARIMAGEN_Click;
            // 
            // PICTUREIMAGES
            // 
            PICTUREIMAGES.BackColor = Color.White;
            PICTUREIMAGES.Image = (Image)resources.GetObject("PICTUREIMAGES.Image");
            PICTUREIMAGES.Location = new Point(151, 134);
            PICTUREIMAGES.Margin = new Padding(5);
            PICTUREIMAGES.Name = "PICTUREIMAGES";
            PICTUREIMAGES.Size = new Size(425, 368);
            PICTUREIMAGES.SizeMode = PictureBoxSizeMode.StretchImage;
            PICTUREIMAGES.TabIndex = 2;
            PICTUREIMAGES.TabStop = false;
            // 
            // BTNSALIRMAINUSU
            // 
            BTNSALIRMAINUSU.BackColor = Color.FromArgb(255, 128, 128);
            BTNSALIRMAINUSU.Cursor = Cursors.Hand;
            BTNSALIRMAINUSU.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BTNSALIRMAINUSU.Location = new Point(39, 610);
            BTNSALIRMAINUSU.Margin = new Padding(5);
            BTNSALIRMAINUSU.Name = "BTNSALIRMAINUSU";
            BTNSALIRMAINUSU.Size = new Size(166, 78);
            BTNSALIRMAINUSU.TabIndex = 3;
            BTNSALIRMAINUSU.Text = "Salir";
            BTNSALIRMAINUSU.UseVisualStyleBackColor = false;
            BTNSALIRMAINUSU.Click += BTNSALIRMAINUSU_Click;
            // 
            // BTNLOGOUTMAINUSER
            // 
            BTNLOGOUTMAINUSER.BackColor = Color.Gainsboro;
            BTNLOGOUTMAINUSER.Cursor = Cursors.Hand;
            BTNLOGOUTMAINUSER.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BTNLOGOUTMAINUSER.Location = new Point(1096, 610);
            BTNLOGOUTMAINUSER.Margin = new Padding(5);
            BTNLOGOUTMAINUSER.Name = "BTNLOGOUTMAINUSER";
            BTNLOGOUTMAINUSER.Size = new Size(166, 78);
            BTNLOGOUTMAINUSER.TabIndex = 4;
            BTNLOGOUTMAINUSER.Text = "Log Out";
            BTNLOGOUTMAINUSER.UseVisualStyleBackColor = false;
            BTNLOGOUTMAINUSER.Click += BTNLOGOUTMAINUSER_Click;
            // 
            // BTNCOMPRARMAINUSU
            // 
            BTNCOMPRARMAINUSU.BackColor = Color.FromArgb(192, 255, 192);
            BTNCOMPRARMAINUSU.Cursor = Cursors.Hand;
            BTNCOMPRARMAINUSU.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BTNCOMPRARMAINUSU.Location = new Point(895, 511);
            BTNCOMPRARMAINUSU.Margin = new Padding(5);
            BTNCOMPRARMAINUSU.Name = "BTNCOMPRARMAINUSU";
            BTNCOMPRARMAINUSU.Size = new Size(166, 57);
            BTNCOMPRARMAINUSU.TabIndex = 5;
            BTNCOMPRARMAINUSU.Text = "Agregar";
            BTNCOMPRARMAINUSU.UseVisualStyleBackColor = false;
            BTNCOMPRARMAINUSU.Click += BTNCOMPRARMAINUSU_Click;
            // 
            // CONTADORPRODMAINUSU
            // 
            CONTADORPRODMAINUSU.Location = new Point(742, 521);
            CONTADORPRODMAINUSU.Margin = new Padding(5);
            CONTADORPRODMAINUSU.Name = "CONTADORPRODMAINUSU";
            CONTADORPRODMAINUSU.Size = new Size(117, 39);
            CONTADORPRODMAINUSU.TabIndex = 6;
            // 
            // pictureBoxCarrito
            // 
            pictureBoxCarrito.BackColor = Color.Transparent;
            pictureBoxCarrito.Cursor = Cursors.Hand;
            pictureBoxCarrito.Image = (Image)resources.GetObject("pictureBoxCarrito.Image");
            pictureBoxCarrito.Location = new Point(1182, 12);
            pictureBoxCarrito.Name = "pictureBoxCarrito";
            pictureBoxCarrito.Size = new Size(106, 84);
            pictureBoxCarrito.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxCarrito.TabIndex = 8;
            pictureBoxCarrito.TabStop = false;
            pictureBoxCarrito.Click += pictureBox1_Click;
            // 
            // buttonRegresarImagen
            // 
            buttonRegresarImagen.BackColor = Color.FromArgb(244, 169, 0);
            buttonRegresarImagen.Cursor = Cursors.Hand;
            buttonRegresarImagen.Font = new Font("Segoe UI", 7.875F, FontStyle.Bold);
            buttonRegresarImagen.Location = new Point(291, 512);
            buttonRegresarImagen.Margin = new Padding(5);
            buttonRegresarImagen.Name = "buttonRegresarImagen";
            buttonRegresarImagen.Size = new Size(66, 57);
            buttonRegresarImagen.TabIndex = 9;
            buttonRegresarImagen.TabStop = false;
            buttonRegresarImagen.Text = "<";
            buttonRegresarImagen.UseVisualStyleBackColor = false;
            buttonRegresarImagen.Click += buttonRegresarImagen_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.FromArgb(245, 140, 0);
            pictureBox1.Location = new Point(-13, -5);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(1355, 115);
            pictureBox1.TabIndex = 10;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(648, 272);
            label1.Name = "label1";
            label1.Size = new Size(488, 96);
            label1.TabIndex = 11;
            label1.Text = "AQUI VA EL TEXTO DE LA INFORMACION \r\nDE LOS PERFUMES, CLARAMANTE QUE \r\nCAMBIE DEPENDEIENDO DEL PERFUME VEA ";
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(12, 12);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(93, 84);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 12;
            pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(104, 12);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(253, 84);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 13;
            pictureBox3.TabStop = false;
            // 
            // FormMainUsuario
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1300, 720);
            Controls.Add(pictureBox3);
            Controls.Add(pictureBox2);
            Controls.Add(label1);
            Controls.Add(pictureBoxCarrito);
            Controls.Add(pictureBox1);
            Controls.Add(buttonRegresarImagen);
            Controls.Add(CONTADORPRODMAINUSU);
            Controls.Add(BTNCOMPRARMAINUSU);
            Controls.Add(BTNLOGOUTMAINUSER);
            Controls.Add(BTNSALIRMAINUSU);
            Controls.Add(PICTUREIMAGES);
            Controls.Add(BTNPASARIMAGEN);
            Margin = new Padding(5);
            Name = "FormMainUsuario";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "MAIN";
            Load += FormMainUsuario_Load;
            ((System.ComponentModel.ISupportInitialize)PICTUREIMAGES).EndInit();
            ((System.ComponentModel.ISupportInitialize)CONTADORPRODMAINUSU).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxCarrito).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ImageList ImageProductos;
        private Button BTNPASARIMAGEN;
        private PictureBox PICTUREIMAGES;
        private Button BTNSALIRMAINUSU;
        private Button BTNLOGOUTMAINUSER;
        private Button BTNCOMPRARMAINUSU;
        private NumericUpDown CONTADORPRODMAINUSU;
        private PictureBox pictureBoxCarrito;
        private Button buttonRegresarImagen;
        private PictureBox pictureBox1;
        private Label label1;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
    }
}