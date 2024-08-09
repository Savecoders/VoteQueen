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

namespace Views.App.GaleriaView
{
    public partial class UGalerias : UserControl
    {

        private GaleriaController galeriaController = new GaleriaController(
            new GaleriaRepository()    
        );

        private Candidata candidata;


        public UGalerias(Candidata candidata)
        {
            InitializeComponent();
            this.candidata = candidata;
        }

        private void UGaleria_Load(object sender, EventArgs e)
        {

            List<Galeria> galerias = galeriaController.ListarGaleriasCandidatas(candidata);

            if(galerias.Count > 0)
            {
                dataGridGaleria.ClearSelection();

                LNombreCandidata.Text = candidata.Nombre;

                dataGridGaleria.DataSource = galerias;

                dataGridGaleria.Columns["Portada"].Visible = false;

                // orden de columnas
                dataGridGaleria.Columns["ID"].DisplayIndex = 0;
                dataGridGaleria.Columns["Titulo"].DisplayIndex = 1;
                dataGridGaleria.Columns["Descripcion"].DisplayIndex = 2;
                dataGridGaleria.Columns["FechaCreacion"].DisplayIndex = 3;

                // Crear la columna de edición - eliminar

                DataGridViewButtonColumn btnEdit = new DataGridViewButtonColumn();
                btnEdit.HeaderText = "Edit";
                btnEdit.Name = "btnEdit";
                btnEdit.Text = "Edit";
                btnEdit.UseColumnTextForButtonValue = true;
                dataGridGaleria.Columns.Add(btnEdit);



                dataGridGaleria.Columns["btnEdit"].DisplayIndex = 4;

                dataGridGaleria.AllowUserToOrderColumns = false;


                // sizes
                dataGridGaleria.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            }

        }

        private void EditarGaleria(int idGaleria)
        {
            this.Controls.Clear();

            GaleriaController galeriaController = new GaleriaController(
                new GaleriaRepository()
            );

            Galeria galeria = galeriaController.ObtenerGaleria( new Galeria { ID = idGaleria});

            UActualizarGaleria uActualizarGaleria = new UActualizarGaleria(candidata, galeria);

            this.Controls.Add(uActualizarGaleria);
        }


        private void EliminarGaleria(int idGaleria)
        {
            MessageBox.Show("Eliminar Galeria: " + idGaleria);
        }

        private void dataGridGaleria_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dataGridGaleria.Columns["btnEdit"].Index && e.RowIndex >= 0)
            {
                // Acción de edición
                int idGaleria = (int)dataGridGaleria.Rows[e.RowIndex].Cells["Id"].Value;
                EditarGaleria(idGaleria);
            }
            
        }

        private void btnAgregarGaleria_Click(object sender, EventArgs e)
        {
            this.Controls.Clear();
            URegistrarGaleria uRegistrarGaleria = new URegistrarGaleria(candidata);
            this.Controls.Add(uRegistrarGaleria);
        }
    }
}
