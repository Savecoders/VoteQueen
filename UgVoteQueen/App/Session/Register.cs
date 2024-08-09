using Controllers;
using Microsoft.Win32;
using Models;
using Models.DTO;
using Models.Repositories;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Views.App.EstudianteView;
using Views.Common;

namespace Views.App.Session
{
    public partial class Register : Form
    {

        public byte[] imagePerfil = [];

        public Register()
        {
            InitializeComponent();
        }


        private void lLabel_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void LLSesion_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            Login login = new Login();
            login.ShowDialog();
            this.Close();
        }

        private void BtnSubirImagen_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Image files (*.jpg, *.jpeg, *.jpe, *.jfif, *.png) | *.jpg; *.jpeg; *.jpe; *.jfif; *.png";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Image = new Bitmap(openFileDialog.FileName);
                imagePerfil = File.ReadAllBytes(openFileDialog.FileName);
            }
        }

        private void BtnRegister_Click(object sender, EventArgs e)
        {
            try
            {
                EstudianteRepository estudianteRepository = new EstudianteRepository();
                EstudianteController estudianteController = new EstudianteController(
                        estudianteRepository
                );

                Estudiante estudiante = new Estudiante();
                estudiante.Nombre = TxtNombre.Text;
                estudiante.Correo = TxtCorreo.Text;
                estudiante.Contrasena = TxtPassword.Text;
                estudiante.Matricula = "SOF2024C1";
                estudiante.FotoPerfil = imagePerfil;


                if (estudianteController.RegistrarEstudiante(estudiante))
                {
                    // Open the student home
                    MessageBox.Show("Usuario registrado correctamente");
                    this.Hide();
                    Login login = new Login();
                    login.ShowDialog();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Error al registrar el usuario");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
    }
}
