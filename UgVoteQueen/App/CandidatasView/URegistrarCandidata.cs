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

namespace Views.App.CandidatasView
{
    public partial class URegistrarCandidata : UserControl
    {
        private CandidataController candidataController = new CandidataController(
                new CandidataRepository()
        );

        private byte[] imagePerfil;

        public URegistrarCandidata()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void txt_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            // return back to the list of candidates
            this.Controls.Clear();
            UCandidatas uCandidatas = new UCandidatas();
            this.Controls.Add(uCandidatas);
        }

        private bool verificarCampos()
        {
            if (
                txtNombres.Text == "" || numEdad.Text == "" ||
                txtTelefono.Text == "" || txtPasatiempos.Text == "" ||
                txtHabilidades.Text == "" || txtIntereses.Text == "" ||
                txtAspiraciones.Text == "" || cbCarrera.Text == "" || cbNivel.Text == ""
            )
            {
                labelError.Text = "Por favor, llene todos los campos";
                return false;
            }
            return true;
        }

        private void btnRegistrarCandidata_Click(object sender, EventArgs e)
        {

            if (verificarCampos())
            {

                try
                {
                    Candidata candidata = new Candidata()
                    {
                        Nombre = txtNombres.Text,
                        Edad = Convert.ToInt32(numEdad.Text),
                        Telefono = txtTelefono.Text,
                        FechaNacimiento = dateTimerNacimiento.Value.Date,
                        Pasatiempos = txtPasatiempos.Text,
                        Habilidades = txtHabilidades.Text,
                        Intereses = txtIntereses.Text,
                        Aspiraciones = txtAspiraciones.Text,
                        Carrera = cbCarrera.Text,
                        Nivel = Convert.ToInt32(cbNivel.Text),
                        FotoPrincipal = imagePerfil
                    };

                    //MessageBox.Show(candidata.Nombre);

                    try
                    {
                        if (candidataController.RegistrarCandidata(candidata))
                        {
                            MessageBox.Show("Candidata registrada con exito");
                            // return back to the list of candidates
                            this.Controls.Clear();
                            UCandidatas uCandidatas = new UCandidatas();
                            this.Controls.Add(uCandidatas);
                        }
                        else
                        {
                            labelError.Text = "Error al registrar la candidata, Verifica los campos";
                        }

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }

                }
                catch (Exception ex)
                {
                    labelError.Text = ex.Message;
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
                imagePerfil = File.ReadAllBytes(openFileDialog.FileName);
            }
        }

        private void URegistrarCandidata_Load(object sender, EventArgs e)
        {

        }
    }
}
