﻿namespace ProyectoGina
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
            label1.Location = new Point(149, 182);
            label1.Name = "label1";
            label1.Size = new Size(192, 15);
            label1.TabIndex = 0;
            label1.Text = "Cuenta Refencia: 9000 0000 7617 94";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.OXXOQR;
            pictureBox1.Location = new Point(150, 16);
            pictureBox1.Margin = new Padding(3, 2, 3, 2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(214, 153);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // BTNCONFIRMAR
            // 
            BTNCONFIRMAR.Location = new Point(399, 212);
            BTNCONFIRMAR.Margin = new Padding(3, 2, 3, 2);
            BTNCONFIRMAR.Name = "BTNCONFIRMAR";
            BTNCONFIRMAR.Size = new Size(82, 22);
            BTNCONFIRMAR.TabIndex = 5;
            BTNCONFIRMAR.Text = "Confirmar";
            BTNCONFIRMAR.UseVisualStyleBackColor = true;
            BTNCONFIRMAR.Click += BTNCONFIRMAR_Click;
            // 
            // BTNREGRESAR
            // 
            BTNREGRESAR.Location = new Point(27, 215);
            BTNREGRESAR.Margin = new Padding(3, 2, 3, 2);
            BTNREGRESAR.Name = "BTNREGRESAR";
            BTNREGRESAR.Size = new Size(82, 22);
            BTNREGRESAR.TabIndex = 4;
            BTNREGRESAR.Text = "Regresar";
            BTNREGRESAR.UseVisualStyleBackColor = true;
            BTNREGRESAR.Click += BTNREGRESAR_Click;
            // 
            // FormOxxo
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(512, 246);
            Controls.Add(BTNCONFIRMAR);
            Controls.Add(BTNREGRESAR);
            Controls.Add(pictureBox1);
            Controls.Add(label1);
            Margin = new Padding(3, 2, 3, 2);
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