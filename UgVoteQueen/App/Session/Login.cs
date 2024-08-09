using Controllers;
using Microsoft.VisualBasic.Logging;
using Microsoft.Win32;
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
using Views.App.AdministradorView;
using Views.App.EstudianteView;
using Views.Common;

namespace Views.App.Session
{
    public partial class Login : Form
    {
        public Login()
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

        private void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                EstudianteRepository estudianteRepository = new EstudianteRepository();
                EstudianteController estudianteController = new EstudianteController(
                        estudianteRepository
                );

                Estudiante estudiante = new Estudiante();
                estudiante.Correo = TxtCorreo.Text.Trim().ToLower();
                estudiante.Contrasena = TxtPassword.Text.Trim();

                if (estudianteController.LoginEstudiante(estudiante))
                {
                    // Open the student home
                    HomeAdministrador homeEstudiante = new HomeAdministrador();
                    this.Hide();
                    homeEstudiante.ShowDialog();
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

                MessageBox.Show(ex.Message);

            }

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
            this.Hide();
            Register register = new Register();
            register.ShowDialog();
            this.Close();
        }

        private void flowLayoutPanel1_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void BtnAdministrador_Click(object sender, EventArgs e)
        {
            LoginAdmin loginAdmin = new LoginAdmin();
            this.Hide();
            loginAdmin.ShowDialog();
            this.Close();
        }
    }
}
