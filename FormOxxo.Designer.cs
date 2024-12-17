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
            label1 = new Label();
            pictureBox1 = new PictureBox();
            BTNCONFIRMAR = new Button();
            BTNREGRESAR = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(170, 242);
            label1.Name = "label1";
            label1.Size = new Size(247, 20);
            label1.TabIndex = 0;
            label1.Text = "Cuenta Refencia: 9000 0000 7617 94";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.OXXOQR;
            pictureBox1.Location = new Point(172, 21);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(245, 204);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // BTNCONFIRMAR
            // 
            BTNCONFIRMAR.Location = new Point(456, 283);
            BTNCONFIRMAR.Name = "BTNCONFIRMAR";
            BTNCONFIRMAR.Size = new Size(94, 29);
            BTNCONFIRMAR.TabIndex = 5;
            BTNCONFIRMAR.Text = "Confirmar";
            BTNCONFIRMAR.UseVisualStyleBackColor = true;
            BTNCONFIRMAR.Click += BTNCONFIRMAR_Click;
            // 
            // BTNREGRESAR
            // 
            BTNREGRESAR.Location = new Point(31, 287);
            BTNREGRESAR.Name = "BTNREGRESAR";
            BTNREGRESAR.Size = new Size(94, 29);
            BTNREGRESAR.TabIndex = 4;
            BTNREGRESAR.Text = "Regresar";
            BTNREGRESAR.UseVisualStyleBackColor = true;
            BTNREGRESAR.Click += BTNREGRESAR_Click;
            // 
            // FormOxxo
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(585, 328);
            Controls.Add(BTNCONFIRMAR);
            Controls.Add(BTNREGRESAR);
            Controls.Add(pictureBox1);
            Controls.Add(label1);
            Name = "FormOxxo";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "PAGO EN OXXO";
            Load += FormOxxo_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private PictureBox pictureBox1;
        private Button BTNCONFIRMAR;
        private Button BTNREGRESAR;
    }
}