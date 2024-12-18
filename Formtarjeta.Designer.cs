namespace ProyectoGina
{
    partial class Formtarjeta
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
            LBLTOTP = new Label();
            TXTPROPIE = new TextBox();
            LBLDINEROREC = new Label();
            TXTNT = new TextBox();
            BTNCONFIRMAR = new Button();
            BTNREGRESAR = new Button();
            LBLTOTAL = new Label();
            label1 = new Label();
            TXTCVV = new TextBox();
            label2 = new Label();
            TXTFV = new TextBox();
            SuspendLayout();
            // 
            // LBLTOTP
            // 
            LBLTOTP.AutoSize = true;
            LBLTOTP.Location = new Point(65, 29);
            LBLTOTP.Name = "LBLTOTP";
            LBLTOTP.Size = new Size(131, 15);
            LBLTOTP.TabIndex = 16;
            LBLTOTP.Text = "Nombre del propietario";
            // 
            // TXTPROPIE
            // 
            TXTPROPIE.Location = new Point(65, 46);
            TXTPROPIE.Margin = new Padding(3, 2, 3, 2);
            TXTPROPIE.Name = "TXTPROPIE";
            TXTPROPIE.Size = new Size(297, 23);
            TXTPROPIE.TabIndex = 15;
            // 
            // LBLDINEROREC
            // 
            LBLDINEROREC.AutoSize = true;
            LBLDINEROREC.Location = new Point(65, 84);
            LBLDINEROREC.Name = "LBLDINEROREC";
            LBLDINEROREC.Size = new Size(103, 15);
            LBLDINEROREC.TabIndex = 14;
            LBLDINEROREC.Text = "Numero de tarjeta";
            // 
            // TXTNT
            // 
            TXTNT.Location = new Point(65, 101);
            TXTNT.Margin = new Padding(3, 2, 3, 2);
            TXTNT.Name = "TXTNT";
            TXTNT.Size = new Size(297, 23);
            TXTNT.TabIndex = 13;
            // 
            // BTNCONFIRMAR
            // 
            BTNCONFIRMAR.Location = new Point(312, 251);
            BTNCONFIRMAR.Margin = new Padding(3, 2, 3, 2);
            BTNCONFIRMAR.Name = "BTNCONFIRMAR";
            BTNCONFIRMAR.Size = new Size(82, 22);
            BTNCONFIRMAR.TabIndex = 12;
            BTNCONFIRMAR.Text = "Confirmar";
            BTNCONFIRMAR.UseVisualStyleBackColor = true;
            BTNCONFIRMAR.Click += BTNCONFIRMAR_Click;
            // 
            // BTNREGRESAR
            // 
            BTNREGRESAR.Location = new Point(1, 251);
            BTNREGRESAR.Margin = new Padding(3, 2, 3, 2);
            BTNREGRESAR.Name = "BTNREGRESAR";
            BTNREGRESAR.Size = new Size(82, 22);
            BTNREGRESAR.TabIndex = 11;
            BTNREGRESAR.Text = "Regresar";
            BTNREGRESAR.UseVisualStyleBackColor = true;
            // 
            // LBLTOTAL
            // 
            LBLTOTAL.AutoSize = true;
            LBLTOTAL.Location = new Point(39, 31);
            LBLTOTAL.Name = "LBLTOTAL";
            LBLTOTAL.Size = new Size(0, 15);
            LBLTOTAL.TabIndex = 10;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(65, 137);
            label1.Name = "label1";
            label1.Size = new Size(29, 15);
            label1.TabIndex = 20;
            label1.Text = "CVV";
            // 
            // TXTCVV
            // 
            TXTCVV.Location = new Point(65, 154);
            TXTCVV.Margin = new Padding(3, 2, 3, 2);
            TXTCVV.Name = "TXTCVV";
            TXTCVV.Size = new Size(297, 23);
            TXTCVV.TabIndex = 19;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(65, 192);
            label2.Name = "label2";
            label2.Size = new Size(123, 15);
            label2.TabIndex = 18;
            label2.Text = "Fecha de vencimiento";
            // 
            // TXTFV
            // 
            TXTFV.Location = new Point(65, 209);
            TXTFV.Margin = new Padding(3, 2, 3, 2);
            TXTFV.Name = "TXTFV";
            TXTFV.Size = new Size(297, 23);
            TXTFV.TabIndex = 17;
            // 
            // Formtarjeta
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(408, 285);
            Controls.Add(label1);
            Controls.Add(TXTCVV);
            Controls.Add(label2);
            Controls.Add(TXTFV);
            Controls.Add(LBLTOTP);
            Controls.Add(TXTPROPIE);
            Controls.Add(LBLDINEROREC);
            Controls.Add(TXTNT);
            Controls.Add(BTNCONFIRMAR);
            Controls.Add(BTNREGRESAR);
            Controls.Add(LBLTOTAL);
            Margin = new Padding(3, 2, 3, 2);
            Name = "Formtarjeta";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Tarjeta";
            Load += Formtarjeta_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label LBLTOTP;
        private TextBox TXTPROPIE;
        private Label LBLDINEROREC;
        private TextBox TXTNT;
        private Button BTNCONFIRMAR;
        private Button BTNREGRESAR;
        private Label LBLTOTAL;
        private Label label1;
        private TextBox TXTCVV;
        private Label label2;
        private TextBox TXTFV;
        private Button buttonTicket;
    }
}