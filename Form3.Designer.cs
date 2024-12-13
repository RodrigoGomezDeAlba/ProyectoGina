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
            LBLImage = new Label();
            BTNPASARIMAGEN = new Button();
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
            // LBLImage
            // 
            LBLImage.BackColor = Color.Snow;
            LBLImage.Location = new Point(255, 9);
            LBLImage.Name = "LBLImage";
            LBLImage.Size = new Size(325, 299);
            LBLImage.TabIndex = 0;
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
            // FormMainUsuario
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Sienna;
            ClientSize = new Size(800, 450);
            Controls.Add(BTNPASARIMAGEN);
            Controls.Add(LBLImage);
            Name = "FormMainUsuario";
            Text = "MAIN";
            ResumeLayout(false);
        }

        #endregion

        private ImageList ImageProductos;
        private Label LBLImage;
        private Button BTNPASARIMAGEN;
    }
}