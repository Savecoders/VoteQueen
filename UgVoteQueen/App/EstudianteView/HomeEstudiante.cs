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
using Views.Common;

namespace Views.App.EstudianteView
{
    public partial class HomeEstudiante : Form
    {

        public HomeEstudiante()
        {
            InitializeComponent();
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

        private void BtnCandiatas_Click(object sender, EventArgs e)
        {

        }

        private void HomeEstudiante_Load(object sender, EventArgs e)
        {
            /*
            if (EstudianteCache.Estado)
            {
                LNombre.Text = EstudianteCache.Nombre;

                using (MemoryStream ms = new MemoryStream(EstudianteCache.FotoPerfil))
                {
                    PicturePerfil.Image = Image.FromStream(ms);
                }

            }

            */
        }
    }
}
