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
            BTNCARRITOMAINUSU = new Button();
            ((System.ComponentModel.ISupportInitialize)PICTUREIMAGES).BeginInit();
            ((System.ComponentModel.ISupportInitialize)CONTADORPRODMAINUSU).BeginInit();
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
            BTNPASARIMAGEN.Location = new Point(586, 278);
            BTNPASARIMAGEN.Name = "BTNPASARIMAGEN";
            BTNPASARIMAGEN.Size = new Size(41, 30);
            BTNPASARIMAGEN.TabIndex = 1;
            BTNPASARIMAGEN.UseVisualStyleBackColor = true;
            BTNPASARIMAGEN.Click += BTNPASARIMAGEN_Click;
            // 
            // PICTUREIMAGES
            // 
            PICTUREIMAGES.BackColor = Color.Snow;
            PICTUREIMAGES.Location = new Point(259, 9);
            PICTUREIMAGES.Name = "PICTUREIMAGES";
            PICTUREIMAGES.Size = new Size(325, 296);
            PICTUREIMAGES.TabIndex = 2;
            PICTUREIMAGES.TabStop = false;
            // 
            // BTNSALIRMAINUSU
            // 
            BTNSALIRMAINUSU.Location = new Point(28, 384);
            BTNSALIRMAINUSU.Name = "BTNSALIRMAINUSU";
            BTNSALIRMAINUSU.Size = new Size(109, 46);
            BTNSALIRMAINUSU.TabIndex = 3;
            BTNSALIRMAINUSU.Text = "Salir";
            BTNSALIRMAINUSU.UseVisualStyleBackColor = true;
            BTNSALIRMAINUSU.Click += BTNSALIRMAINUSU_Click;
            // 
            // BTNLOGOUTMAINUSER
            // 
            BTNLOGOUTMAINUSER.Location = new Point(663, 384);
            BTNLOGOUTMAINUSER.Name = "BTNLOGOUTMAINUSER";
            BTNLOGOUTMAINUSER.Size = new Size(109, 46);
            BTNLOGOUTMAINUSER.TabIndex = 4;
            BTNLOGOUTMAINUSER.Text = "LOG OUT";
            BTNLOGOUTMAINUSER.UseVisualStyleBackColor = true;
            BTNLOGOUTMAINUSER.Click += BTNLOGOUTMAINUSER_Click;
            // 
            // BTNCOMPRARMAINUSU
            // 
            BTNCOMPRARMAINUSU.Location = new Point(341, 355);
            BTNCOMPRARMAINUSU.Name = "BTNCOMPRARMAINUSU";
            BTNCOMPRARMAINUSU.Size = new Size(193, 36);
            BTNCOMPRARMAINUSU.TabIndex = 5;
            BTNCOMPRARMAINUSU.Text = "Agregar al carrito";
            BTNCOMPRARMAINUSU.UseVisualStyleBackColor = true;
            BTNCOMPRARMAINUSU.Click += BTNCOMPRARMAINUSU_Click;
            // 
            // CONTADORPRODMAINUSU
            // 
            CONTADORPRODMAINUSU.Location = new Point(357, 322);
            CONTADORPRODMAINUSU.Name = "CONTADORPRODMAINUSU";
            CONTADORPRODMAINUSU.Size = new Size(163, 27);
            CONTADORPRODMAINUSU.TabIndex = 6;
            // 
            // BTNCARRITOMAINUSU
            // 
            BTNCARRITOMAINUSU.Location = new Point(728, 11);
            BTNCARRITOMAINUSU.Name = "BTNCARRITOMAINUSU";
            BTNCARRITOMAINUSU.Size = new Size(63, 34);
            BTNCARRITOMAINUSU.TabIndex = 7;
            BTNCARRITOMAINUSU.Text = "Carrito";
            BTNCARRITOMAINUSU.UseVisualStyleBackColor = true;
            BTNCARRITOMAINUSU.Click += this.BTNCARRITOMAINUSU_Click;
            // 
            // FormMainUsuario
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Sienna;
            ClientSize = new Size(800, 450);
            Controls.Add(BTNCARRITOMAINUSU);
            Controls.Add(CONTADORPRODMAINUSU);
            Controls.Add(BTNCOMPRARMAINUSU);
            Controls.Add(BTNLOGOUTMAINUSER);
            Controls.Add(BTNSALIRMAINUSU);
            Controls.Add(PICTUREIMAGES);
            Controls.Add(BTNPASARIMAGEN);
            Name = "FormMainUsuario";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "MAIN";
            ((System.ComponentModel.ISupportInitialize)PICTUREIMAGES).EndInit();
            ((System.ComponentModel.ISupportInitialize)CONTADORPRODMAINUSU).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private ImageList ImageProductos;
        private Button BTNPASARIMAGEN;
        private PictureBox PICTUREIMAGES;
        private Button BTNSALIRMAINUSU;
        private Button BTNLOGOUTMAINUSER;
        private Button BTNCOMPRARMAINUSU;
        private NumericUpDown CONTADORPRODMAINUSU;
        private Button BTNCARRITOMAINUSU;
    }
}