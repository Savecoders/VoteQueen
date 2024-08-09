using Common.Cache;
using Models.DTO;
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
using Views.App.EstudianteView;
using Views.App.Session;
using Views.App.VotacionView;
using Views.Common;

namespace Views.App.AdministradorView
{
    public partial class HomeAdministrador : Form
    {


        public HomeAdministrador()
        {
            InitializeComponent();
        }

        private void Home_Load(object sender, EventArgs e)
        {

            if (!SessionManager.IsLogged())
            {
                this.Close();
            }

            var usuarioCache = SessionManager.GetUsuario();

            if (usuarioCache is AdministradorCache)
            {
                btnVerCandidatas.Visible = false;
                btnFotogenea.Visible = false;
                btnFMCF.Visible = false;
                LUsuario.Text = "Administrador";
            }
            else
            {
                BtnCandiatas.Visible = false;
                btnVotaciones.Visible = false;
                btnEstudiantes.Visible = false;
                LUsuario.Text = "Estudiante";
            }

            if (usuarioCache.Nombre != null)
            {
                LabelNombre.Text = usuarioCache.Nombre;

            }

            if (usuarioCache.FotoPerfil != null)
            {
                using (var ms = new System.IO.MemoryStream(usuarioCache.FotoPerfil))
                {
                    PicturePerfil.Image = Image.FromStream(ms);
                }
            }




        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void FlHeader_Paint(object sender, PaintEventArgs e)
        {

        }

        private void PanelFound_Paint(object sender, PaintEventArgs e)
        {

            
        }

        private void LabelNombre_Click(object sender, EventArgs e)
        {

        }

        private void PicturePerfil_Click(object sender, EventArgs e)
        {

        }

        private void PanelLogo_Paint(object sender, PaintEventArgs e)
        {

        }

        private void BtnCandiatas_Click(object sender, EventArgs e)
        {
            PanelFound.Controls.Clear();
            UCandidatas panel_candidatas = new UCandidatas();
            PanelFound.Controls.Add(panel_candidatas);
        }

        private void btnVotaciones_Click(object sender, EventArgs e)
        {
            PanelFound.Controls.Clear();
            UVotacion uVotaciones = new UVotacion();
            PanelFound.Controls.Add(uVotaciones);

        }

        private void btnEstudiantes_Click(object sender, EventArgs e)
        {
            PanelFound.Controls.Clear();
            UEstudiantes uEstudiantes = new UEstudiantes();
            PanelFound.Controls.Add(uEstudiantes);
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void flowLayoutPanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnConfig_Click(object sender, EventArgs e)
        {
            PanelFound.Controls.Clear();

            if (SessionManager.GetUsuario() is AdministradorCache)
            {
                UEditarAdministrador uEditarAdministrador = new UEditarAdministrador();
                PanelFound.Controls.Add(uEditarAdministrador);
            }
            else
            {
                UEditarEstudiante uEditarEstudiante = new UEditarEstudiante();
                PanelFound.Controls.Add(uEditarEstudiante);
            }

        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            // logout window forms
            this.Close();
        }

        private void FLayoutPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnVerCandidatas_Click(object sender, EventArgs e)
        {
            PanelFound.Controls.Clear();
            UCandidataView uCandidataView = new UCandidataView();
            PanelFound.Controls.Add(uCandidataView);
        }

        private void btnFMCF_Click(object sender, EventArgs e)
        {
            PanelFound.Controls.Clear();
            UVoteFMCF uVoteFMCF = new UVoteFMCF();
            PanelFound.Controls.Add(uVoteFMCF);
        }

        private void btnFotogenea_Click(object sender, EventArgs e)
        {
            PanelFound.Controls.Clear();
            UvoteFotogenea uVoteFoto = new UvoteFotogenea();
            PanelFound.Controls.Add(uVoteFoto);
        }
    }
}
