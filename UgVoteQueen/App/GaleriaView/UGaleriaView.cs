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
using Views.App.GaleriaView;
using Views.Common;
using Views.Components;

namespace Views.App.GaleriaView
{
    public partial class UGaleriaView : UserControl
    {
        private Galeria galeriaSelecionada;
        private FotoController fotoController = new FotoController(
            new FotoRepository()
        );
        private UserControl parent;


        public UGaleriaView(Galeria galeria, UserControl userControl)
        {
            InitializeComponent();
            this.galeriaSelecionada = galeria;
            this.parent = userControl;
        }

        private void label13_Click(object sender, EventArgs e)
        {


        }

        private void UCandidataPortafolio_Load(object sender, EventArgs e)
        {
            if (galeriaSelecionada != null)
            {
                try
                {

                    // Datos Personales
                    lTituloInput.Text = galeriaSelecionada.Titulo;
                    LDescripcionInput.Text = galeriaSelecionada.Descripcion;
                    lFechaInput.Text = galeriaSelecionada.FechaCreacion.ToString();

                    //pictureBox1.Image = Utils.ConvertImage(candidataSelecionada.FotoPrincipal);

                    // Galerias

                    List<Foto> fotos = fotoController.ObtenerFotosGaleria(galeriaSelecionada);

                    if (fotos.Count > 0)
                    {
                        fotos.ForEach(foto =>
                        {
                            fLGaleriaContainer.Controls.Add(new CardFoto(foto, parent));
                        });
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
    }
}
