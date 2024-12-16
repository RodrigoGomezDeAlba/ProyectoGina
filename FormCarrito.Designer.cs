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
            RCHTBLISTAPROD = new RichTextBox();
            SuspendLayout();
            // 
            // BTNREGRESARCARRITO
            // 
            BTNREGRESARCARRITO.Location = new Point(44, 613);
            BTNREGRESARCARRITO.Margin = new Padding(5);
            BTNREGRESARCARRITO.Name = "BTNREGRESARCARRITO";
            BTNREGRESARCARRITO.Size = new Size(198, 74);
            BTNREGRESARCARRITO.TabIndex = 0;
            BTNREGRESARCARRITO.Text = "Regresar";
            BTNREGRESARCARRITO.UseVisualStyleBackColor = true;
            BTNREGRESARCARRITO.Click += BTNREGRESARCARRITO_Click;
            // 
            // BTNTICKETCARRITO
            // 
            BTNTICKETCARRITO.Location = new Point(1056, 613);
            BTNTICKETCARRITO.Margin = new Padding(5);
            BTNTICKETCARRITO.Name = "BTNTICKETCARRITO";
            BTNTICKETCARRITO.Size = new Size(198, 74);
            BTNTICKETCARRITO.TabIndex = 1;
            BTNTICKETCARRITO.Text = "Imprimir ticket";
            BTNTICKETCARRITO.UseVisualStyleBackColor = true;
            BTNTICKETCARRITO.Click += BTNTICKETCARRITO_Click;
            // 
            // BTNCONFIRMCARRITO
            // 
            BTNCONFIRMCARRITO.Location = new Point(504, 454);
            BTNCONFIRMCARRITO.Margin = new Padding(5);
            BTNCONFIRMCARRITO.Name = "BTNCONFIRMCARRITO";
            BTNCONFIRMCARRITO.Size = new Size(309, 99);
            BTNCONFIRMCARRITO.TabIndex = 2;
            BTNCONFIRMCARRITO.Text = "Confirmar Compra";
            BTNCONFIRMCARRITO.UseVisualStyleBackColor = true;
            // 
            // RCHTBLISTAPROD
            // 
            RCHTBLISTAPROD.Enabled = false;
            RCHTBLISTAPROD.Location = new Point(296, 19);
            RCHTBLISTAPROD.Margin = new Padding(5);
            RCHTBLISTAPROD.Name = "RCHTBLISTAPROD";
            RCHTBLISTAPROD.Size = new Size(716, 401);
            RCHTBLISTAPROD.TabIndex = 3;
            RCHTBLISTAPROD.Text = "";
            RCHTBLISTAPROD.TextChanged += RCHTBLISTAPROD_TextChanged;
            // 
            // FormCarrito
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1300, 720);
            Controls.Add(RCHTBLISTAPROD);
            Controls.Add(BTNCONFIRMCARRITO);
            Controls.Add(BTNTICKETCARRITO);
            Controls.Add(BTNREGRESARCARRITO);
            Margin = new Padding(5);
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
        private RichTextBox RCHTBLISTAPROD;
    }
}