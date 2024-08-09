using Controllers;
using Models.DTO;
using Models.Repositories;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Views.App.FotoView;

namespace Views.App.GaleriaView
{
    public partial class UActualizarGaleria : UserControl
    {
        private GaleriaController GaleriaController = new GaleriaController(
            new GaleriaRepository()
        );

        private FotoController FotoController = new FotoController(
            new FotoRepository()
        );

        private Candidata candidata;

        private Galeria galeriaCache;

        private byte[] imagePortada;

        private List<Foto> fotosEnMemoria = new List<Foto>();

        public UActualizarGaleria(Candidata candidata, Galeria galeria)
        {
            InitializeComponent();
            this.candidata = candidata;
            this.galeriaCache = galeria;
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private bool verificarCampos()
        {
            if (txtTitulo.Text.TrimEnd() == "" || txtDescripcion.Text.TrimEnd() == "" || imagePortada == null)
            {
                MessageBox.Show("Todos los campos tienen que estar llenos incluido la portada");
                return false;
            }
            return true;
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {

            if (verificarCampos() && fotosEnMemoria.Count > 0)
            {
                Galeria galeria = new Galeria();
                galeria.Titulo = txtTitulo.Text;
                galeria.Descripcion = txtDescripcion.Text;
                galeria.FechaCreacion = DateTime.Now;
                galeria.Portada = imagePortada;

                try
                {
                    galeria.ID = GaleriaController.RegistrarGaleria(galeria, candidata.ID);

                    if (galeria.ID > 0)
                    {
                        // every photo in the memory
                        fotosEnMemoria.ForEach(foto =>
                        {
                            FotoController.RegistrarFoto(foto, galeria.ID);
                        });

                        MessageBox.Show("Galeria registrada con exito");

                        // return back to the list of galleries
                        this.Controls.Clear();
                        UGalerias uGalerias = new UGalerias(candidata);
                        this.Controls.Add(uGalerias);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }

        }

        private void btnSubirFoto_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Image files (*.jpg, *.jpeg, *.jpe, *.jfif, *.png) | *.jpg; *.jpeg; *.jpe; *.jfif; *.png";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                pictureSubirImagen.Image = new Bitmap(openFileDialog.FileName);
                imagePortada = File.ReadAllBytes(openFileDialog.FileName);
            }
        }

        private void btnAgregarFotos_Click(object sender, EventArgs e)
        {
            FAgregarFoto fAgregarFoto = new FAgregarFoto();
            fAgregarFoto.ShowDialog();

            if (fAgregarFoto.isDataSaved)
            {
                Foto foto = new Foto()
                {
                    Titulo = fAgregarFoto.fotoIngresada.Titulo,
                    Descripcion = fAgregarFoto.fotoIngresada.Descripcion,
                    Imagen = fAgregarFoto.fotoIngresada.Imagen
                };

                fotosEnMemoria.Add(foto);

                this.flFotos.Controls.Add(
                    new PreviewFoto(foto)
                );
            }

        }

        private void flFotos_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
