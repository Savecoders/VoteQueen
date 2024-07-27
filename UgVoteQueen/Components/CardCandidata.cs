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
using Views.Common;

namespace Views.Components
{
    public partial class CardCandidata : UserControl
    {
        public CardCandidata()
        {
            InitializeComponent();

        }

        private void CardCandidata_Load(object sender, EventArgs e, Candidata candidata)
        {

            LCandidataNombre.Text = candidata.Nombre;
            LCarrera.Text = candidata.Carrera;
            ImageCandidata.Image = Utils.ConvertImage(candidata.FotoPrincipal);
            LComentarios.Text = candidata.Comentarios.Count.ToString();
            LayoutState.Controls.Add(pictureBox2);
            LayoutState.Controls.Add(LComentarios);

        }

    }
}
