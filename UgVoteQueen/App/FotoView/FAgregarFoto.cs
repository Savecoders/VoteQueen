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

namespace Views.App.FotoView
{
    public partial class FAgregarFoto : Form
    {

        public Foto fotoIngresada = new Foto();

        public bool isDataSaved;

        public FAgregarFoto()
        {
            InitializeComponent();
            MaximizeBox = false;
            MinimizeBox = false;

            // Set the default image
            isDataSaved = false;
        }

        private void btnSubirImagen_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Image files (*.jpg, *.jpeg, *.jpe, *.jfif, *.png) | *.jpg; *.jpeg; *.jpe; *.jfif; *.png";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                pictureImage.Image = new Bitmap(openFileDialog.FileName);
                fotoIngresada.Imagen = File.ReadAllBytes(openFileDialog.FileName);
            }
        }

        public bool verificarCampos()
        {
            if (txtTitulo.Text.TrimEnd() == "" || txtDescripcion.Text.TrimEnd() == "" || fotoIngresada.Imagen == null)
            {
                MessageBox.Show("Todos los campos tienen que estar llenos incluido la foto");
                return false;
            }
            return true;
        }

        private void btnAgregarFoto_Click(object sender, EventArgs e)
        {
            if (verificarCampos())
            {
                fotoIngresada.Titulo = txtTitulo.Text;
                fotoIngresada.Descripcion = txtDescripcion.Text;
                isDataSaved = true;
                this.Close();
            }

        }

        private void FRegistrarFoto_Load(object sender, EventArgs e)
        {
            isDataSaved = false;
        }
    }
}
