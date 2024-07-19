using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UgVoteQueen.Models.DAO;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace UgVoteQueen.Views.App.Candidatas
{
    public partial class ListadoCandidatas : UserControl
    {
        private Panel mainPanel;

        public ListadoCandidatas()
        {
            InitializeComponent();
        }

        public void SetPanels(Panel mainPanel)
        {
            this.mainPanel = mainPanel;
        }

        private void ListadoCandidatas_Load(object sender, EventArgs e)
        {
            CandidataDAO candidataDAO = new CandidataDAO();
            // Agregar columnas
            dataGridView1.DataSource = candidataDAO.ListarCandidatas().Tables[0];
            MessageBox.Show("Candidatas cargadas exitosamente.");

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
