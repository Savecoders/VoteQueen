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

namespace Views.Components
{
    public partial class CardCandidata : UserControl
    {

        public Candidata candidata { get; set; }
        private UserControl mainPanel;

        public CardCandidata(Candidata candidata, UserControl main)
        {
            InitializeComponent();
            this.candidata = candidata;
            this.mainPanel = main;

            LCandidataNombre.Text = candidata.Nombre;
            LCarrera.Text = candidata.Carrera;
            ImageCandidata.Image = Utils.ConvertImage(candidata.FotoPrincipal);
        }

        private void CardCandidata_Load(object sender, EventArgs e)
        {

        }

        private void ImageCandidata_Click(object sender, EventArgs e)
        {

        }

        private void btnCandidataView_Click(object sender, EventArgs e)
        {
            mainPanel.Controls.Clear();
            mainPanel.Controls.Add(new UCandidataPortafolio(candidata, mainPanel));
        }
    }
}
