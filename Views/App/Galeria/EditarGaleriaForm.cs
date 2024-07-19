using System;
using System.Windows.Forms;
using UgVoteQueen.Controllers;
using UgVoteQueen.Models.DTO;


namespace UgVoteQueen.Views.Candidatas
{
    public partial class EditarGaleriaForm : UserControl
    {
        private int galeriaID;
        private GaleriaController galeriaController;
        private List<Foto> fotoSeleccionada = new List<Foto>();
        public EditarGaleriaForm() {  }

        public EditarGaleriaForm(int galeriaID)
        {
            InitializeComponent();
            this.galeriaID = galeriaID;
            this.galeriaController = new GaleriaController();
            this.fotoSeleccionada = new List<Foto>();
        }



        private void btnSiguiente_Click(object sender, EventArgs e)
        {
            if (tabControlEditar.SelectedIndex < tabControlEditar.TabCount - 1)
            {
                tabControlEditar.SelectedIndex++;
            }
        }

        private void btnAnterior_Click(object sender, EventArgs e)
        {
            if (tabControlEditar.SelectedIndex > 0)
            {
                tabControlEditar.SelectedIndex--;
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            /*
            string titulo = txtTitulo.Text;
            string descripcion = txtDescripcion.Text;

            bool resultado = galeriaController.ActualizarGaleria(galeriaID, titulo, descripcion);

            if (resultado)
            {
                MessageBox.Show("Galería actualizada exitosamente.");
            }
            else
            {
                MessageBox.Show("Error al actualizar la galería.");
            }
            */
        }


        private void EditarGaleriaForm_Load(object sender, EventArgs e)
        {

        }


        private void CargarFotos()
        {
            /*
            flowLayoutPanelFotos.Controls.Clear();
            List<Foto> fotos = galeriaController.ObtenerFotoGaleria(galeriaID); // Asume que tienes un método para obtener las fotos de la galería

            foreach (var foto in fotos)
            {
                PictureBox pictureBox = new PictureBox
                {
                    Image = ByteArrayToImage(foto.Imagen), // Ajusta según la ruta o fuente de la imagen
                    SizeMode = PictureBoxSizeMode.Zoom,
                    Size = new Size(100, 100), // Ajusta el tamaño según necesites
                    BorderStyle = BorderStyle.FixedSingle,
                    Tag = foto
                };
                pictureBox.Click += new EventHandler(PictureBox_Click);
                flowLayoutPanelFotos.Controls.Add(pictureBox);
            }
            */
        }

        private Image ByteArrayToImage(byte[] byteArray)
        {
            using (MemoryStream ms = new MemoryStream(byteArray))
            {
                return Image.FromStream(ms);
            }
        }

        private void PictureBox_Click(object sender, EventArgs e)
        {
            PictureBox pictureBox = sender as PictureBox;
            Foto foto = pictureBox.Tag as Foto;

            if (fotoSeleccionada.Contains(foto))
            {
                fotoSeleccionada.Remove(foto);
                pictureBox.BorderStyle = BorderStyle.FixedSingle; // Deseleccionar
            }
            else
            {
                fotoSeleccionada.Add(foto);
                pictureBox.BorderStyle = BorderStyle.Fixed3D; // Seleccionar
            }
        }


        private void btnEliminarFoto_Click(object sender, EventArgs e)
        {
            /*
            foreach (var foto in fotoSeleccionada)
            {
                bool resultado = galeriaController.EliminarFotoGaleria(foto.ID);

                if (!resultado)
                {
                    MessageBox.Show("Error al eliminar la foto con ID: " + foto.ID);
                    return;
                }
            }

            */

            MessageBox.Show("Fotos eliminadas exitosamente.");
            fotoSeleccionada.Clear();
            CargarFotos(); // Recargar las fotos después de la eliminación
        }


    }
}
