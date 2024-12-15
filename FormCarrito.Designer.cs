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
            BTNREGRESARCARRITO = new Button();
            BTNTICKETCARRITO = new Button();
            BTNCONFIRMCARRITO = new Button();
            SuspendLayout();
            // 
            // BTNREGRESARCARRITO
            // 
            BTNREGRESARCARRITO.Location = new Point(27, 383);
            BTNREGRESARCARRITO.Name = "BTNREGRESARCARRITO";
            BTNREGRESARCARRITO.Size = new Size(122, 46);
            BTNREGRESARCARRITO.TabIndex = 0;
            BTNREGRESARCARRITO.Text = "Regresar";
            BTNREGRESARCARRITO.UseVisualStyleBackColor = true;
            BTNREGRESARCARRITO.Click += BTNREGRESARCARRITO_Click;
            // 
            // BTNTICKETCARRITO
            // 
            BTNTICKETCARRITO.Location = new Point(650, 383);
            BTNTICKETCARRITO.Name = "BTNTICKETCARRITO";
            BTNTICKETCARRITO.Size = new Size(122, 46);
            BTNTICKETCARRITO.TabIndex = 1;
            BTNTICKETCARRITO.Text = "Imprimir ticket";
            BTNTICKETCARRITO.UseVisualStyleBackColor = true;
            BTNTICKETCARRITO.Click += BTNTICKETCARRITO_Click;
            // 
            // BTNCONFIRMCARRITO
            // 
            BTNCONFIRMCARRITO.Location = new Point(310, 284);
            BTNCONFIRMCARRITO.Name = "BTNCONFIRMCARRITO";
            BTNCONFIRMCARRITO.Size = new Size(190, 62);
            BTNCONFIRMCARRITO.TabIndex = 2;
            BTNCONFIRMCARRITO.Text = "Confirmar Compra";
            BTNCONFIRMCARRITO.UseVisualStyleBackColor = true;
            // 
            // FormCarrito
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Sienna;
            ClientSize = new Size(800, 450);
            Controls.Add(BTNCONFIRMCARRITO);
            Controls.Add(BTNTICKETCARRITO);
            Controls.Add(BTNREGRESARCARRITO);
            Name = "FormCarrito";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Carrito";
            Load += FormCarrito_Load;
            ResumeLayout(false);
        }

        #endregion

        private Button BTNREGRESARCARRITO;
        private Button BTNTICKETCARRITO;
        private Button BTNCONFIRMCARRITO;
    }
}