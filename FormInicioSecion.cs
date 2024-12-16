﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Runtime.InteropServices.JavaScript.JSType;


namespace ProyectoGina
{
    public partial class FormUsuario : System.Windows.Forms.Form
    {
        public string usuario;
        public string contra;
        private bool visible;

        public FormUsuario()
        {
            InitializeComponent();

            LOGOSLOGAN.SizeMode = PictureBoxSizeMode.Zoom; // Ajusta la imagen al PictureBox
            usuario = TXTUsuario.Text;
            contra = TXTUsuario.Text;
            visible = false;

            //Cragar imagenes
            LoadImages();

        }

        private void LoadImages()
        {
            string basePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Images");
            LOGOSLOGAN.Image = LoadImageFromPath(Path.Combine(basePath, "LOGOSLOGAN.png"));
        }

        private Image LoadImageFromPath(string imagePath)
        {
            if (File.Exists(imagePath))
            {
                return Image.FromFile(imagePath);
            }
            else
            {
                MessageBox.Show($"No se encontró la imagen en la ruta: {imagePath}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }

        private void FormUsuario_Load(object sender, EventArgs e)
        {

        }

        private void TXTUsuario_TextChanged(object sender, EventArgs e)
        {
            usuario = TXTUsuario.Text;
        }

        private void TEXTContra_TextChanged(object sender, EventArgs e)
        {
            contra = TXTUsuario.Text;
        }

        private void BTNSalirF2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void BTNIngresar_Click(object sender, EventArgs e)
        {
            
            usuario = TXTUsuario.Text;
            contra = TXTUsuario.Text;
            //aqui va el if de si es igual o no la contraseña y el usuario
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormMainUsuario form3 = new FormMainUsuario();
            form3.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormMainAdmin form4 = new FormMainAdmin();
            form4.ShowDialog();
        }
    }
}
