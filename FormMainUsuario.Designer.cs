﻿namespace ProyectoGina
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
            pictureBox2 = new PictureBox();
            pictureBox3 = new PictureBox();
            LBLPRODUCTONOMBRE = new Label();
            LBLPRODUCTOPRECIO = new Label();
            LBLPRODUCTOEXISTENCIAS = new Label();
            labelNombre = new Label();
            fileSystemWatcher1 = new FileSystemWatcher();
            botonBorrar = new Button();
            ((System.ComponentModel.ISupportInitialize)PICTUREIMAGES).BeginInit();
            ((System.ComponentModel.ISupportInitialize)CONTADORPRODMAINUSU).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxCarrito).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)fileSystemWatcher1).BeginInit();
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
            BTNPASARIMAGEN.Location = new Point(198, 240);
            BTNPASARIMAGEN.Margin = new Padding(3, 2, 3, 2);
            BTNPASARIMAGEN.Name = "BTNPASARIMAGEN";
            BTNPASARIMAGEN.Size = new Size(36, 27);
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
            PICTUREIMAGES.Location = new Point(81, 63);
            PICTUREIMAGES.Margin = new Padding(3, 2, 3, 2);
            PICTUREIMAGES.Name = "PICTUREIMAGES";
            PICTUREIMAGES.Size = new Size(229, 172);
            PICTUREIMAGES.SizeMode = PictureBoxSizeMode.StretchImage;
            PICTUREIMAGES.TabIndex = 2;
            PICTUREIMAGES.TabStop = false;
            // 
            // BTNSALIRMAINUSU
            // 
            BTNSALIRMAINUSU.BackColor = Color.FromArgb(255, 128, 128);
            BTNSALIRMAINUSU.Cursor = Cursors.Hand;
            BTNSALIRMAINUSU.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BTNSALIRMAINUSU.Location = new Point(21, 286);
            BTNSALIRMAINUSU.Margin = new Padding(3, 2, 3, 2);
            BTNSALIRMAINUSU.Name = "BTNSALIRMAINUSU";
            BTNSALIRMAINUSU.Size = new Size(89, 37);
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
            BTNLOGOUTMAINUSER.Location = new Point(590, 286);
            BTNLOGOUTMAINUSER.Margin = new Padding(3, 2, 3, 2);
            BTNLOGOUTMAINUSER.Name = "BTNLOGOUTMAINUSER";
            BTNLOGOUTMAINUSER.Size = new Size(89, 37);
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
            BTNCOMPRARMAINUSU.Location = new Point(482, 240);
            BTNCOMPRARMAINUSU.Margin = new Padding(3, 2, 3, 2);
            BTNCOMPRARMAINUSU.Name = "BTNCOMPRARMAINUSU";
            BTNCOMPRARMAINUSU.Size = new Size(89, 27);
            BTNCOMPRARMAINUSU.TabIndex = 5;
            BTNCOMPRARMAINUSU.Text = "Agregar";
            BTNCOMPRARMAINUSU.UseVisualStyleBackColor = false;
            BTNCOMPRARMAINUSU.Click += BTNCOMPRARMAINUSU_Click;
            // 
            // CONTADORPRODMAINUSU
            // 
            CONTADORPRODMAINUSU.Location = new Point(400, 244);
            CONTADORPRODMAINUSU.Margin = new Padding(3, 2, 3, 2);
            CONTADORPRODMAINUSU.Name = "CONTADORPRODMAINUSU";
            CONTADORPRODMAINUSU.Size = new Size(63, 23);
            CONTADORPRODMAINUSU.TabIndex = 6;
            // 
            // pictureBoxCarrito
            // 
            pictureBoxCarrito.BackColor = Color.Transparent;
            pictureBoxCarrito.Cursor = Cursors.Hand;
            pictureBoxCarrito.Image = (Image)resources.GetObject("pictureBoxCarrito.Image");
            pictureBoxCarrito.Location = new Point(636, 6);
            pictureBoxCarrito.Margin = new Padding(2, 1, 2, 1);
            pictureBoxCarrito.Name = "pictureBoxCarrito";
            pictureBoxCarrito.Size = new Size(57, 39);
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
            buttonRegresarImagen.Location = new Point(157, 240);
            buttonRegresarImagen.Margin = new Padding(3, 2, 3, 2);
            buttonRegresarImagen.Name = "buttonRegresarImagen";
            buttonRegresarImagen.Size = new Size(36, 27);
            buttonRegresarImagen.TabIndex = 9;
            buttonRegresarImagen.TabStop = false;
            buttonRegresarImagen.Text = "<";
            buttonRegresarImagen.UseVisualStyleBackColor = false;
            buttonRegresarImagen.Click += buttonRegresarImagen_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.FromArgb(245, 140, 0);
            pictureBox1.Location = new Point(-7, -2);
            pictureBox1.Margin = new Padding(2, 1, 2, 1);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(730, 54);
            pictureBox1.TabIndex = 10;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(6, 6);
            pictureBox2.Margin = new Padding(2, 1, 2, 1);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(50, 39);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 12;
            pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(56, 6);
            pictureBox3.Margin = new Padding(2, 1, 2, 1);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(136, 39);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 13;
            pictureBox3.TabStop = false;
            // 
            // LBLPRODUCTONOMBRE
            // 
            LBLPRODUCTONOMBRE.AutoSize = true;
            LBLPRODUCTONOMBRE.Font = new Font("Segoe UI", 10.875F);
            LBLPRODUCTONOMBRE.Location = new Point(352, 116);
            LBLPRODUCTONOMBRE.Margin = new Padding(2, 0, 2, 0);
            LBLPRODUCTONOMBRE.Name = "LBLPRODUCTONOMBRE";
            LBLPRODUCTONOMBRE.Size = new Size(84, 20);
            LBLPRODUCTONOMBRE.TabIndex = 14;
            LBLPRODUCTONOMBRE.Text = "NombreBD";
            // 
            // LBLPRODUCTOPRECIO
            // 
            LBLPRODUCTOPRECIO.AutoSize = true;
            LBLPRODUCTOPRECIO.Font = new Font("Segoe UI", 10.875F);
            LBLPRODUCTOPRECIO.Location = new Point(352, 147);
            LBLPRODUCTOPRECIO.Margin = new Padding(2, 0, 2, 0);
            LBLPRODUCTOPRECIO.Name = "LBLPRODUCTOPRECIO";
            LBLPRODUCTOPRECIO.Size = new Size(70, 20);
            LBLPRODUCTOPRECIO.TabIndex = 15;
            LBLPRODUCTOPRECIO.Text = "PrecioBD";
            // 
            // LBLPRODUCTOEXISTENCIAS
            // 
            LBLPRODUCTOEXISTENCIAS.AutoSize = true;
            LBLPRODUCTOEXISTENCIAS.Font = new Font("Segoe UI", 10.875F);
            LBLPRODUCTOEXISTENCIAS.Location = new Point(352, 181);
            LBLPRODUCTOEXISTENCIAS.Margin = new Padding(2, 0, 2, 0);
            LBLPRODUCTOEXISTENCIAS.Name = "LBLPRODUCTOEXISTENCIAS";
            LBLPRODUCTOEXISTENCIAS.Size = new Size(80, 20);
            LBLPRODUCTOEXISTENCIAS.TabIndex = 16;
            LBLPRODUCTOEXISTENCIAS.Text = "Existencias";
            // 
            // labelNombre
            // 
            labelNombre.AutoSize = true;
            labelNombre.Font = new Font("Segoe UI", 10.875F);
            labelNombre.Location = new Point(541, 26);
            labelNombre.Margin = new Padding(2, 0, 2, 0);
            labelNombre.Name = "labelNombre";
            labelNombre.Size = new Size(59, 20);
            labelNombre.TabIndex = 17;
            labelNombre.Text = "Usuario";
            labelNombre.Click += labelNombre_Click;
            // 
            // fileSystemWatcher1
            // 
            fileSystemWatcher1.EnableRaisingEvents = true;
            fileSystemWatcher1.SynchronizingObject = this;
            // 
            // botonBorrar
            // 
            botonBorrar.BackColor = Color.FromArgb(255, 192, 192);
            botonBorrar.Cursor = Cursors.Hand;
            botonBorrar.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            botonBorrar.Location = new Point(625, 63);
            botonBorrar.Margin = new Padding(3, 2, 3, 2);
            botonBorrar.Name = "botonBorrar";
            botonBorrar.Size = new Size(68, 29);
            botonBorrar.TabIndex = 18;
            botonBorrar.Text = "Borrar";
            botonBorrar.UseVisualStyleBackColor = false;
            botonBorrar.Click += botonBorrar_Click;
            // 
            // FormMainUsuario
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(700, 338);
            Controls.Add(botonBorrar);
            Controls.Add(labelNombre);
            Controls.Add(LBLPRODUCTOEXISTENCIAS);
            Controls.Add(LBLPRODUCTOPRECIO);
            Controls.Add(LBLPRODUCTONOMBRE);
            Controls.Add(pictureBox3);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBoxCarrito);
            Controls.Add(pictureBox1);
            Controls.Add(buttonRegresarImagen);
            Controls.Add(CONTADORPRODMAINUSU);
            Controls.Add(BTNCOMPRARMAINUSU);
            Controls.Add(BTNLOGOUTMAINUSER);
            Controls.Add(BTNSALIRMAINUSU);
            Controls.Add(PICTUREIMAGES);
            Controls.Add(BTNPASARIMAGEN);
            Margin = new Padding(3, 2, 3, 2);
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
            ((System.ComponentModel.ISupportInitialize)fileSystemWatcher1).EndInit();
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
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
        private Label LBLPRODUCTONOMBRE;
        private Label LBLPRODUCTOPRECIO;
        private Label LBLPRODUCTOEXISTENCIAS;
        private Label labelNombre;
        private FileSystemWatcher fileSystemWatcher1;
        private Button botonBorrar;
    }
}