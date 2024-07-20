using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Views.Common;

namespace Views.App.Session
{
    public partial class Register : UserControl
    {

        private Panel mainPanel;
        private Login loginPanel;
        private byte[] imagePerfil = [];
        private Utils utils = new Utils();

        public Register()
        {
            InitializeComponent();
        }

        public void SetPanels(Panel mainPanel, Login loginPanel)
        {
            this.mainPanel = mainPanel;
            this.loginPanel = loginPanel;
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
            utils.ReplacePanelContent(mainPanel, loginPanel);
        }

        private void btnRegister(object sender, EventArgs e)
        {

            // Obtener los datos de los campos
            /*
            try
            {

                Usuario usuario = new Usuario(

                    BoxNombre.Text,
                    BoxCorreo.Text,
                    BoxPassword.Text,
                    Rol.Estudiante,
                    imagePerfil
                );

                // Crear el usuario

                UsuarioRepositorio usuarioDAL = new UsuarioRepositorio();

                usuarioDAL.RegistrarEstudiante(usuario);

                // Notificar al usuario

                notifyIcon1.BalloonTipTitle = "Usuario creado";
                notifyIcon1.BalloonTipText = "El usuario ha sido creado exitosamente";
                notifyIcon1.ShowBalloonTip(1000);

                // Cambiar a la pantalla de login

                utils.ReplacePanelContent(mainPanel, loginPanel);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void BtnSubirImagen_Click(object sender, EventArgs e)
        {
            try
            {
                // Subir imagen
                OpenFileDialog openFileDialog = new OpenFileDialog();
                openFileDialog.Filter = "Image files (*.jpg, *.jpeg, *.jpe, *.jfif, *.png) | *.jpg; *.jpeg; *.jpe; *.jfif; *.png";
                // convertir la imagen a bytes
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string imagen = openFileDialog.FileName;
                    byte[] imagenBytes = System.IO.File.ReadAllBytes(imagen);
                    imagePerfil = imagenBytes;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al subir la imagen, verifica que la extension sea (*.jpg, *.jpeg, *.jpe, *.jfif, *.png)");
            }
            finally
            {
                lIngresarImagen.ForeColor = Color.Green;
                lIngresarImagen.Text = "Imagen Cargada";
            }
        */
        }
    }
}
