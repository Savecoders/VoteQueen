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
using Views.Common;

namespace Views.App.Session
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
            /*
            try
            {

                // Validar usuario
                Usuario usuario = new Usuario();
                usuario.Correo = BoxCorreo.Text;
                usuario.Contrasena = BoxPassword.Text;

                // Verificar si el usuario existe
                UsuarioRepositorio usuarioDAL = new UsuarioRepositorio();

                // Crear sesion
                DataSet dataSet = usuarioDAL.LoginUsuario(usuario);
                MessageBox.Show("Entra" + (dataSet.Tables[0].Rows.Count > 0) + "");

                if (dataSet.Tables.Count > 0 && dataSet.Tables[0].Rows.Count > 0)
                {
                    // Primera Tabla
                    DataTable tabla = dataSet.Tables[0];

                    // Primera Fila
                    DataRow fila = tabla.Rows[0];


                    // Sesion Statica de Usuario
                    SesionUsuario.Id = Convert.ToInt32(fila["UsuarioID"]);
                    SesionUsuario.Nombre = fila["Nombre"].ToString();
                    SesionUsuario.Correo = fila["Correo"].ToString();
                    SesionUsuario.FotoPerfil = (byte[])fila["FotoPerfil"];

                    // Mensaje a Usuario
                    MessageBox.Show("Bienvenido " + SesionUsuario.Nombre, "Inicio de Sesion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Porfavor llene los campos", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            */

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
