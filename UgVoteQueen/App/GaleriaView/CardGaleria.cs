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

namespace Views.App.GaleriaView
{
    public partial class CardGaleria : UserControl
    {

        public Galeria galeria { get; set; }
        public UserControl parent { get; set; }

        public CardGaleria(Galeria galeria, UserControl parent)
        {
            InitializeComponent();
            this.galeria = galeria;

            LGaleriaTitulo.Text = galeria.Titulo;
            LFechaCreacion.Text = galeria.FechaCreacion.ToString();
            ImageCandidata.Image = Utils.ConvertImage(galeria.Portada);
            this.parent = parent;
        }

        private void CardCandidata_Load(object sender, EventArgs e)
        {

        }

        private void ImageCandidata_Click(object sender, EventArgs e)
        {

        }

        private void btnCandidataView_Click(object sender, EventArgs e)
        {
            parent.Controls.Clear();
            parent.Controls.Add(new UGaleriaView(galeria, parent));
        }
    }
}
