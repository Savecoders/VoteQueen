using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Views.App.AdministradorView;
using Views.Common;
using Models.DTO;
using Controllers;
using Models.Repositories;

namespace Views.App.Session
{
    public partial class LoginAdmin : Form
    {

        public LoginAdmin()
        {
            InitializeComponent();
        }


        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void FlexLayout_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void lLabel_Click(object sender, EventArgs e)
        {

        }


        private void LLSesion_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                AdministradorRepository administradorRepository = new AdministradorRepository();
                AdministradorController administradorController = new AdministradorController(
                        administradorRepository
                );
                Administrador adminDto = new Administrador();
                adminDto.Correo = txtCorreo.Text.Trim();
                adminDto.Nombre = txtNombre.Text.Trim();
                adminDto.Contrasena = txtPassword.Text;


                if (administradorController.LoginAdministrador(adminDto))
                {
                    // Open the admin home
                    this.Hide();
                    HomeAdministrador homeAdmin = new HomeAdministrador();
                    homeAdmin.ShowDialog();
                    this.Close();
                }
                else
                {
                    // Show error message
                    MessageBox.Show("Usuario o contraseña incorrecta");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
    }
}
