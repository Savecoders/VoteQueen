using Common.Cache;
using Controllers;
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

namespace Views.App.EstudianteView
{
    public partial class URegistrarEstudiante : UserControl
    {
        private byte[] imagePerfil = null;

        public URegistrarEstudiante()
        {
            InitializeComponent();
        }

        
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void txt_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            // return back to the list of candidates
            this.Controls.Clear();
            UEstudiantes uEstudiantes = new UEstudiantes();
            this.Controls.Add(uEstudiantes);
        }

        private void btnRegistrarEstudiante_Click(object sender, EventArgs e)
        {
            if (
                txtCorreo.Text == "" ||
                txtNombres.Text == "" ||
                txtPassword.Text == "" ||
                cbCargo.Text == ""
             )
            {
                labelError.Text = "Por favor, llene todos los campos";
            } else if (txtPassword.Text != txtConfirPassword.Text)
            {
                labelError.Text = "Las contraseñas no coinciden";
            }
            else if (imagePerfil == null)
            {
                labelError.Text = "Debe de ingresar una imagen";
            }
            else {

                Estudiante estudiante = new Estudiante();
                estudiante.Correo = txtCorreo.Text;
                estudiante.Nombre = txtNombres.Text;
                estudiante.Contrasena = txtPassword.Text;
                estudiante.Matricula = cbCargo.Text;
                estudiante.FotoPerfil = imagePerfil;
                estudiante.Estado = true;

                MessageBox.Show("Estudiante: " + estudiante.Nombre + " " + estudiante.Correo + " " + estudiante.Matricula);

                EstudianteController estudianteController = new EstudianteController(
                    new EstudianteRepository()
                );

                try
                {
                    if (estudianteController.RegistrarEstudiante(estudiante))
                    {

                        MessageBox.Show("Estudiante actualizado correctamente");

                        this.Controls.Clear();
                        UEstudiantes uEstudiantes = new UEstudiantes();
                        this.Controls.Add(uEstudiantes);
                        
                    }
                    else
                    {
                        MessageBox.Show("Error al registrar el estudiante");
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

            }

        }


        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter_1(object sender, EventArgs e)
        {

        }

        private void UEditarAdministrador_Load(object sender, EventArgs e)
        {

        }

        private void btnSubirFoto_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Image files (*.jpg, *.jpeg, *.jpe, *.jfif, *.png) | *.jpg; *.jpeg; *.jpe; *.jfif; *.png";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                pictureSubirImagen.Image = new Bitmap(openFileDialog.FileName);
                imagePerfil = File.ReadAllBytes(openFileDialog.FileName);
            }

        }
    }
}
