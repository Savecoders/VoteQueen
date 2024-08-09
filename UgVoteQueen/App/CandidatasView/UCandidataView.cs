using Controllers;
using Models.Repositories;
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
using Views.Components;

namespace Views.App.CandidatasView
{
    public partial class UCandidataView : UserControl
    {

        private CandidataController candidataController = new CandidataController(
            new CandidataRepository()
        );

        public UCandidataView()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void UCandidataView_Load(object sender, EventArgs e)
        {
            try
            {
                List<Candidata> candidatas = candidataController.ListarCandidatas();

                if (candidatas.Count > 0)
                {

                    candidataController.ListarCandidatas().ForEach(candidata =>
                    {
                        flCardCandidatas.Controls.Add(new CardCandidata(candidata, this));
                    });

                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void flCardCandidatas_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
