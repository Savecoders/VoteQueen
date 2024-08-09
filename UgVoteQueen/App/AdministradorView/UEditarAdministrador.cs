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
using Views.App.CandidatasView;

namespace Views.App.AdministradorView
{
    public partial class UEditarAdministrador : UserControl
    {

        private byte[] memoryImage;

        public UEditarAdministrador()
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
        }

        private void btnRegistrarCandidata_Click(object sender, EventArgs e)
        {
            this.Controls.Clear();

            if (
                txtNombres.Text == "" ||
                txtCorreo.Text == "" ||
                cbCargo.Text == "" ||
                txtConfirPassword.Text == "" ||
                txtPassword.Text == ""
             )
            {
                labelError.Text = "Por favor, llene todos los campos";
                return;
            }

            if (txtPassword.Text != txtConfirPassword.Text)
            {
                labelError.Text = "Las contraseñas no coinciden";
                return;
            }

            if(memoryImage == null)
            {
                labelError.Text = "Por favor, suba una nueva foto de perfil";
                return;
            }

            AdministradorController administradorController = new AdministradorController(
                new AdministradorRepository()
            );

            Administrador adminDto = new Administrador();


            adminDto.ID = SessionManager.GetUsuario().ID;
            adminDto.Correo = txtCorreo.Text.Trim();
            adminDto.Nombre = txtNombres.Text.Trim();
            adminDto.Contrasena = txtPassword.Text.Trim();
            adminDto.Cargo = cbCargo.Text.Trim();
            adminDto.FotoPerfil = memoryImage;

            if (administradorController.ActualizarAdministrador(adminDto))
            {
                MessageBox.Show("Administrador actualizado correctamente");

                this.Controls.Clear();
                UCandidatas candidatasView = new UCandidatas();
                this.Controls.Add(candidatasView);

            }
            else
            {
                MessageBox.Show("Error al actualizar el administrador");
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
            this.txtNombres.Text = SessionManager.GetUsuario().Nombre;
            this.txtCorreo.Text = SessionManager.GetUsuario().Correo;
            this.cbCargo.Text = SessionManager.GetUsuario().Cargo;

        }

        private void btnSubirFoto_Click(object sender, EventArgs e)
        {

            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Image files (*.jpg, *.jpeg, *.jpe, *.jfif, *.png) | *.jpg; *.jpeg; *.jpe; *.jfif; *.png";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                pictureSubirImagen.Image = new Bitmap(openFileDialog.FileName);
                memoryImage = File.ReadAllBytes(openFileDialog.FileName);
            }

        }
    }
}
