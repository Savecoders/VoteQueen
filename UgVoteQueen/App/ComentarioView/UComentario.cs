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

namespace Views.App.ComentarioView
{
    public partial class UComentario : UserControl
    {
        private Comentario comentario;
        public UComentario(Comentario comentario)
        {
            InitializeComponent();
            this.comentario = comentario;
        }

        private void flComentario_Paint(object sender, PaintEventArgs e)
        {

        }

        private void UComentario_Load(object sender, EventArgs e)
        {
            if (comentario != null)
            {
                try
                {
                    // Datos Comentario
                    LComentario.Text = comentario.Texto;
                    LFecha.Text = comentario.Fecha.ToString();
                    LComentario.Text = comentario.Texto;

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al cargar el comentario: " + ex.Message);
                }
            }

        }
    }
}
