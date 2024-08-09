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

namespace Views.App.FotoView
{
    public partial class PreviewFoto : UserControl
    {
        private Foto fotoMemoryBuffer;
        public PreviewFoto(Foto fotoMemory)
        {
            InitializeComponent();
            fotoMemoryBuffer = fotoMemory;

            if (fotoMemoryBuffer.Titulo != "" && fotoMemoryBuffer.Imagen != null)
            {
                this.LTituloFoto.Text = fotoMemoryBuffer.Titulo;

                // byte[] to image
                using (MemoryStream ms = new MemoryStream(fotoMemoryBuffer.Imagen))
                {
                    this.pictureImage.Image = Image.FromStream(ms);
                }

            }
        }

        private void CardCandidata_Load(object sender, EventArgs e)
        {

        }

        private void LayoutContainer_Paint(object sender, PaintEventArgs e)
        {

        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
