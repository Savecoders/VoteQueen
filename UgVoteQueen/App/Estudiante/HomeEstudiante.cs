using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Views.App.Candidatas;
using Views.Common;

namespace Views.App.Estudiante
{
    public partial class HomeEstudiante : Form
    {

        private UCandidatas listadoCandidatas = new UCandidatas();

        public HomeEstudiante()
        {
            InitializeComponent();
            listadoCandidatas.SetPanels(PanelFound);
            Utils.ReplacePanelContent(PanelFound, listadoCandidatas);
        }

        private void Home_Load(object sender, EventArgs e)
        {

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
    }
}
