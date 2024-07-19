using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UgVoteQueen.Common;
using UgVoteQueen.Views.App.Candidatas;

namespace UgVoteQueen.PL.App
{
    public partial class HomeAdministrador : Form
    {

        private Utils utils = new Utils();
        private ListadoCandidatas listadoCandidatas = new ListadoCandidatas();

        public HomeAdministrador()
        {
            InitializeComponent();
            listadoCandidatas.SetPanels(PanelFound);
            utils.ReplacePanelContent(PanelFound, listadoCandidatas);
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
    }
}
