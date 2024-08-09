using Controllers;
using Models.Repositories;
using Models.DTO;
using System;
using Views.App.ComentarioView;
using Views.Common;
using Common.Cache;

namespace Views.App.CandidatasView
{
    public partial class UComentariosFoto : UserControl
    {

        private Foto fotoSeleccionada;

        private ComentarioController comentarioController = new ComentarioController(
            new ComentarioRepository()
        );

        private UserControl parent;

        public UComentariosFoto(Foto fotoSeleccionada, UserControl parent)
        {
            InitializeComponent();
            this.fotoSeleccionada = fotoSeleccionada;
            this.parent = parent;
        }

        private void vtn_Load(object sender, EventArgs e)
        {
            if(fotoSeleccionada != null)
            {
                try
                {
                    // Datos de la foto
                    lTitulo.Text = fotoSeleccionada.Titulo;
                    lDescripcion.Text = fotoSeleccionada.Descripcion;
                    lcandidata.Text = fotoSeleccionada.FechaCreacion.ToString();

                    pictureFoto.Image = Utils.ConvertImage(fotoSeleccionada.Imagen);

                    // Comentarios
                    List<Comentario> comentarios = comentarioController.ObtenerPorFoto(fotoSeleccionada.ID);

                    if (comentarios.Count > 0)
                    {
                        foreach (Comentario comentario in comentarios)
                        {
                            flContainerComentarios.Controls.Add(new UComentario(comentario));
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al cargar la foto: " + ex.Message);
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtComentario.Text != "")
            {
                Comentario comentario = new Comentario();
                comentario.Texto = txtComentario.Text;
                comentario.Estudiante = new Estudiante
                {
                    ID = SessionManager.GetUsuario().ID,
                    Nombre = SessionManager.GetUsuario().Nombre,
                };

                comentarioController.RegistrarComentario(comentario, fotoSeleccionada);

                flContainerComentarios.Controls.Clear();

                try
                {
                    this.CargarComentarios();
                }catch(Exception ex)
                {
                    MessageBox.Show("Error al cargar los comentarios: " + ex.Message);
                }
            }
            
        }

        private void btneditar_Click(object sender, EventArgs e)
        {


        }
        private void EditarComentario(Label comentarioLabel)
        {

            txtComentario.Text = comentarioLabel.Text;

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void CargarComentarios()
        {
            flContainerComentarios.Controls.Clear();
            List<Comentario> comentarios = comentarioController.ObtenerPorFoto(fotoSeleccionada.ID);

            if (comentarios.Count > 0)
            {
                foreach (Comentario comentario in comentarios)
                {
                    flContainerComentarios.Controls.Add(new UComentario(comentario));
                }
            }
        }

        private void flContainerComentarios_Paint(object sender, PaintEventArgs e)
        {
            
        }
    }
}
