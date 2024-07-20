using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace Views.App.Galeria
{
    public partial class RegistrarGaleriaForm : UserControl
    {

        public RegistrarGaleriaForm()
        {
            InitializeComponent();
        }

        private void btnSiguiente_Click(object sender, EventArgs e)
        {
            //tabControlRegistrar.SelectedIndex = 1;
        }

        private void btnAnterior_Click(object sender, EventArgs e)
        {
            //tabControlRegistrar.SelectedIndex = 0;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            /*
            Galeria nuevaGaleria = new Galeria(txtTitulo.Text, txtDescripcion.Text, new List<Foto>());

            // Guardar la galería en la base de datos y obtener el ID
            int galeriaID = galeriaController.RegistrarGaleria(nuevaGaleria);

            // Guardar las fotos en la base de datos
            foreach (Image imagen in imagenesCargadas)
            {
                using (MemoryStream ms = new MemoryStream())
                {
                    imagen.Save(ms, imagen.RawFormat);
                    byte[] imagenBytes = ms.ToArray();

                    Foto nuevaFoto = new Foto
                    {
                        GaleriaID = galeriaID,
                        Imagen = imagenBytes
                    };

                    galeriaController.AgregarFotoGaleria(nuevaFoto);
                }
            }

            MessageBox.Show("Galería y fotos guardadas exitosamente.");
            */
        }

        private void flowLayoutPanelFotos_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                e.Effect = DragDropEffects.Copy;
            }
        }

        private void flowLayoutPanelFotos_DragDrop(object sender, DragEventArgs e)
        {
            /*string[] archivos = (string[])e.Data.GetData(DataFormats.FileDrop);
            foreach (string archivo in archivos)
            {
                if (Path.GetExtension(archivo).ToLower() == ".jpg" || Path.GetExtension(archivo).ToLower() == ".png")
                {
                    Image imagen = Image.FromFile(archivo);
                    imagenesCargadas.Add(imagen);

                    PictureBox pictureBox = new PictureBox
                    {
                        Image = imagen,
                        SizeMode = PictureBoxSizeMode.Zoom,
                        Size = new Size(100, 100), // Ajusta el tamaño según necesites
                        BorderStyle = BorderStyle.FixedSingle
                    };
                    flowLayoutPanelFotos.Controls.Add(pictureBox);
                }
            }
            */
        }

        private void flowLayoutPanelFotos_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
