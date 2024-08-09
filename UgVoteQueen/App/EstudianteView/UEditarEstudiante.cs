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
    public partial class UEditarEstudiante : UserControl
    {
        private Estudiante estudianteEdit;
        private byte[] imagePerfil = null;

        public UEditarEstudiante()
        {
            InitializeComponent();
            estudianteEdit = null;
        }

        public UEditarEstudiante(Estudiante estudiante)
        {
            InitializeComponent();
            estudianteEdit = estudiante;
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

            if (SessionManager.GetUsuario() is EstudianteCache)
            {

            }
            else
            {
                UEstudiantes uEstudiantes = new UEstudiantes();
                this.Controls.Add(uEstudiantes);
            }

        }

        private void btnRegistrarCandidata_Click(object sender, EventArgs e)
        {
            if (
                txtCorreo.Text == "" ||
                txtNombres.Text == "" ||
                txtPassword.Text == "" ||
                cbCargo.Text == ""
             )
            {
                labelError.Text = "Por favor, llene todos los campos";
            }
            else if (txtPassword.Text != txtConfirPassword.Text)
            {
                labelError.Text = "Las contraseñas no coinciden";
            }
            else
            {

                Estudiante estudiante = new Estudiante();
                estudiante.ID = estudianteEdit.ID > 0 ? estudianteEdit.ID : SessionManager.GetUsuario().ID;
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
                    if (estudianteController.ActualizarEstudiante(estudiante))
                    {

                        MessageBox.Show("Estudiante actualizado correctamente");
                        this.Controls.Clear();
                        if (estudianteEdit != null)
                        {
                            this.Controls.Clear();
                            UEstudiantes uEstudiantes = new UEstudiantes();
                            this.Controls.Add(uEstudiantes);
                        }
                        else
                        {
                            this.Controls.Clear();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Error al actualizar el estudiante");
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
            if (SessionManager.GetUsuario().Correo != null)
            {
                txtCorreo.Text = SessionManager.GetUsuario().Correo;
                txtNombres.Text = SessionManager.GetUsuario().Nombre;
                cbCargo.Text = "";
            }
            else if (estudianteEdit != null)
            {
                txtCorreo.Text = estudianteEdit.Correo;
                txtNombres.Text = estudianteEdit.Nombre;
                cbCargo.Text = estudianteEdit.Matricula;
            }

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

        private void cbCargo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
