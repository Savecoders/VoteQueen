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
using UgVoteQueen.BLL;
using UgVoteQueen.Common;
using UgVoteQueen.DAL;
using UgVoteQueen.Helpers;

namespace UgVoteQueen.PL.Session
{
    public partial class Login : UserControl
    {
        private Register registerPanel;
        private Panel mainPanel;
        

        public Login()
        {
            InitializeComponent();
        }

        public void SetPanels(Panel mainPanel, Register registerPanel)
        {
            this.mainPanel = mainPanel;
            this.registerPanel = registerPanel;
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

                // Validar usuario
                Usuario usuario = new Usuario();
                usuario.Correo = BoxCorreo.Text;
                usuario.Contrasena = BoxPassword.Text;

                // Verificar si el usuario existe
                UsuarioDAL usuarioDAL = new UsuarioDAL();

                // Crear sesion
                var dataSet =  usuarioDAL.LoginUsuario(usuario);

                if (dataSet != null || dataSet.Tables.Count > 0) {
                    MessageBox.Show("Si esta cargado");
                }

                SesionUsuario.Id = Convert.ToInt32(dataSet.Tables[0].Rows[0]["UsuarioID "]);
                SesionUsuario.Nombre = dataSet.Tables[0].Rows[0]["Nombre"].ToString();
                SesionUsuario.Correo = dataSet.Tables[0].Rows[0]["Correo"].ToString();
                SesionUsuario.FotoPerfil = (byte[])dataSet.Tables[0].Rows[0]["FotoPerfil"];

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Porfavor llene los campos", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                MessageBox.Show("Bienvenido", SesionUsuario.Nombre, MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        private void btnRegister_Click(object sender, EventArgs e)
        {
            Utils utils = new Utils();
            utils.ReplacePanelContent(mainPanel, registerPanel);
        }
    }
}
