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

namespace Views.App.CandidatasView
{
    public partial class UCandidataPortafolio : UserControl
    {
        private Candidata candidataSelecionada;
        private GaleriaController galeriaController = new GaleriaController(
            new GaleriaRepository()
        );
        private UserControl parent;

        public UCandidataPortafolio(Candidata candidata, UserControl parent)
        {
            InitializeComponent();
            this.candidataSelecionada = candidata;
            this.parent = parent;
        }

        private void label13_Click(object sender, EventArgs e)
        {


        }

        private void UCandidataPortafolio_Load(object sender, EventArgs e)
        {
            if (candidataSelecionada != null)
            {
                try
                {

                    // Datos Personales
                    lCarreraInput.Text = candidataSelecionada.Carrera;
                    lNombresInput.Text = candidataSelecionada.Nombre;
                    lEdadInput.Text = candidataSelecionada.Edad.ToString();
                    LNivelInput.Text = candidataSelecionada.Nivel.ToString();
                    lFechaInput.Text = candidataSelecionada.FechaNacimiento.ToString();

                    // Informacion personal

                    lPasatiemposInput.Text = candidataSelecionada.Pasatiempos;
                    lHabilidadesInput.Text = candidataSelecionada.Habilidades;
                    lInteresesInput.Text = candidataSelecionada.Intereses;
                    lAspiracionesInput.Text = candidataSelecionada.Aspiraciones;

                    pictureBox1.Image = Utils.ConvertImage(candidataSelecionada.FotoPrincipal);

                    // Galerias

                    List<Galeria> galerias = galeriaController.ListarGaleriasCandidatas(candidataSelecionada);

                    if (galerias.Count > 0)
                    {
                        galerias.ForEach(galeria =>
                        {
                            fLGaleriaContainer.Controls.Add(new CardGaleria(galeria, parent));
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
