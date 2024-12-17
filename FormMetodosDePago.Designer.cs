namespace ProyectoGina
{
    partial class FormMetodosPago
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
            BTNEFECTIVO = new Button();
            BTNTARJETA = new Button();
            BTNOXXO = new Button();
            SuspendLayout();
            // 
            // BTNEFECTIVO
            // 
            BTNEFECTIVO.Location = new Point(12, 31);
            BTNEFECTIVO.Name = "BTNEFECTIVO";
            BTNEFECTIVO.Size = new Size(92, 40);
            BTNEFECTIVO.TabIndex = 0;
            BTNEFECTIVO.Text = "Efectivo";
            BTNEFECTIVO.UseVisualStyleBackColor = true;
            BTNEFECTIVO.Click += BTNEFECTIVO_Click;
            // 
            // BTNTARJETA
            // 
            BTNTARJETA.Location = new Point(177, 31);
            BTNTARJETA.Name = "BTNTARJETA";
            BTNTARJETA.Size = new Size(92, 40);
            BTNTARJETA.TabIndex = 1;
            BTNTARJETA.Text = "Tarjeta";
            BTNTARJETA.UseVisualStyleBackColor = true;
            BTNTARJETA.Click += BTNTARJETA_Click_1;
            // 
            // BTNOXXO
            // 
            BTNOXXO.Location = new Point(343, 31);
            BTNOXXO.Name = "BTNOXXO";
            BTNOXXO.Size = new Size(92, 40);
            BTNOXXO.TabIndex = 2;
            BTNOXXO.Text = "OXXO";
            BTNOXXO.UseVisualStyleBackColor = true;
            BTNOXXO.Click += BTNOXXO_Click;
            // 
            // FormMetodosPago
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(447, 103);
            Controls.Add(BTNOXXO);
            Controls.Add(BTNTARJETA);
            Controls.Add(BTNEFECTIVO);
            Name = "FormMetodosPago";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Metodos de pago";
            Load += FormMetodosPago_Load;
            ResumeLayout(false);
        }

        #endregion

        private Button BTNEFECTIVO;
        private Button BTNTARJETA;
        private Button BTNOXXO;
    }
}