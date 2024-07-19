namespace POEcomentarioug
{
    public partial class vtn : UserControl
    {
        private Label comentarioSeleccionado; // Variable para almacenar el comentario seleccionado

        public vtn()
        {
            InitializeComponent();
        }

        private void vtn_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (comentarioSeleccionado != null)
            {

                comentarioSeleccionado.Text = txtbxcomentario.Text;
                txtbxcomentario.Clear();
                comentarioSeleccionado = null;
            }
            else
            {
                string nuevoComentario = txtbxcomentario.Text;

                Label comentarioLabel = new Label();
                comentarioLabel.Text = nuevoComentario;
                comentarioLabel.AutoSize = true;
                comentarioLabel.Margin = new Padding(0, 0, 0, 10);
                comentarioLabel.Click += (s, ev) => EditarComentario(comentarioLabel);

                flowLayoutPanel1.Controls.Add(comentarioLabel);
                txtbxcomentario.Clear();
            }
        }

        private void btneditar_Click(object sender, EventArgs e)
        {
            if (comentarioSeleccionado != null)
            {

                comentarioSeleccionado.Text = txtbxcomentario.Text;
                txtbxcomentario.Clear();
                comentarioSeleccionado = null;
            }


        }
        private void EditarComentario(Label comentarioLabel)
        {

            txtbxcomentario.Text = comentarioLabel.Text;
            comentarioSeleccionado = comentarioLabel;

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
