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
using Views.App.ComentarioView;
using Views.Common;

namespace Views.Components
{
    public partial class CardFoto : UserControl
    {
        private Foto fotoSelect;
        private UserControl parent;
        public CardFoto(Foto fotoSelect, UserControl parent)
        {
            InitializeComponent();
            this.fotoSelect = fotoSelect;
            this.parent = parent;
        }

        private void CardCandidata_Load(object sender, EventArgs e, Candidata candidata)
        {


        }

        private void LayoutContainer_Paint(object sender, PaintEventArgs e)
        {

        }

        private void CardFoto_Load(object sender, EventArgs e)
        {
            if (fotoSelect != null)
            {
                try
                {
                    // Datos Foto
                    pictureFoto.Image = Utils.ConvertImage(fotoSelect.Imagen);
                    LTituloFoto.Text = fotoSelect.Titulo;

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al cargar la imagen: " + ex.Message);
                }
            }
        }

        private void btnComentario_Click(object sender, EventArgs e)
        {
            this.parent.Controls.Clear();
            this.parent.Controls.Add(new UComentariosFoto(fotoSelect, parent));

        }
    }
}
