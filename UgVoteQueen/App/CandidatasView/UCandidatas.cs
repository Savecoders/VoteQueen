using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Controllers;
using Models.DTO;
using Models.Repositories;
using Views.App.GaleriaView;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Views.App.CandidatasView
{
    public partial class UCandidatas : UserControl
    {

        private CandidataController candidataController = new CandidataController(
                new CandidataRepository()
        );

        public UCandidatas()
        {
            InitializeComponent();
        }


        private void ListadoCandidatas_Load(object sender, EventArgs e)
        {

            List<Candidata> candidatas = candidataController.ListarCandidatas();

            if (candidatas.Count > 0)
            {
                dataGridCandiata.DataSource = candidatas;

                // Contenido no necesario
                dataGridCandiata.Columns["FotoPrincipal"].Visible = false;
                dataGridCandiata.Columns["Pasatiempos"].Visible = false;
                dataGridCandiata.Columns["Habilidades"].Visible = false;
                dataGridCandiata.Columns["Intereses"].Visible = false;
                dataGridCandiata.Columns["Aspiraciones"].Visible = false;
                dataGridCandiata.Columns["FechaNacimiento"].Visible = false;
                dataGridCandiata.Columns["GaleriaFotos"].Visible = false;

                // ordernar columnas

                dataGridCandiata.Columns["ID"].DisplayIndex = 0;
                dataGridCandiata.Columns["Nombre"].DisplayIndex = 1;
                dataGridCandiata.Columns["Edad"].DisplayIndex = 2;
                dataGridCandiata.Columns["Telefono"].DisplayIndex = 3;
                dataGridCandiata.Columns["Carrera"].DisplayIndex = 4;
                dataGridCandiata.Columns["Nivel"].DisplayIndex = 5;


                // Revisar Galeria | albun de Fotos
                DataGridViewButtonColumn btnGaleria = new DataGridViewButtonColumn();
                btnGaleria.HeaderText = "Galeria";
                btnGaleria.Name = "btnGaleria";
                btnGaleria.Text = "Galeria";
                btnGaleria.UseColumnTextForButtonValue = true;
                dataGridCandiata.Columns.Add(btnGaleria);

                // Crear la columna de edición
                DataGridViewButtonColumn btnEdit = new DataGridViewButtonColumn();
                btnEdit.HeaderText = "Edit";
                btnEdit.Name = "btnEdit";
                btnEdit.Text = "Edit";
                btnEdit.UseColumnTextForButtonValue = true;
                dataGridCandiata.Columns.Add(btnEdit);


                // Crear la columna de eliminación
                DataGridViewButtonColumn btnDelete = new DataGridViewButtonColumn();
                btnDelete.HeaderText = "Delete";
                btnDelete.Name = "btnDelete";
                btnDelete.Text = "Delete";
                btnDelete.UseColumnTextForButtonValue = true;
                dataGridCandiata.Columns.Add(btnDelete);



                dataGridCandiata.Columns["btnEdit"].DisplayIndex = 6;
                dataGridCandiata.Columns["btnDelete"].DisplayIndex = 7;
                dataGridCandiata.Columns["btnGaleria"].DisplayIndex = 8;

                dataGridCandiata.AllowUserToOrderColumns = false;

                // sizes
                dataGridCandiata.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            }
        }

        private void btnAgregarCandidata_Click(object sender, EventArgs e)
        {
            this.Controls.Clear();
            URegistrarCandidata uCrearCandidata = new URegistrarCandidata();
            this.Controls.Add(uCrearCandidata);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txtFiltrar_TextChanged(object sender, EventArgs e)
        {
            List<Candidata> candidatas = candidataController.FiltrarCandidatas(txtFiltrar.Text);

            dataGridCandiata.DataSource = candidatas;
        }

        private void EditarCandidata(int id)
        {
            Candidata candidataSelect = candidataController.ObtenerCandidataId(new Candidata { ID = id });

            this.Controls.Clear();
            UEditarCandidata uEditarCandidata = new UEditarCandidata(candidataSelect);
            this.Controls.Add(uEditarCandidata);
        }

        private void EliminarCandidata(int id)
        {
            MessageBox.Show("Eliminar Candidata con id: " + id);
        }

        private void EditarGaleria(int candidataId)
        {
            Candidata candidataSelect = candidataController.ObtenerCandidataId(new Candidata { ID = candidataId });

            this.Controls.Clear();
            UGalerias uGalerias = new UGalerias(candidataSelect);
            this.Controls.Add(uGalerias);

        }

        private void dataGridCandiata_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dataGridCandiata.Columns["btnEdit"].Index && e.RowIndex >= 0)
            {
                // Acción de edición
                int id = (int)dataGridCandiata.Rows[e.RowIndex].Cells["Id"].Value;
                this.EditarCandidata(id);
            }
            else if (e.ColumnIndex == dataGridCandiata.Columns["btnDelete"].Index && e.RowIndex >= 0)
            {
                // Acción de eliminación
                int id = (int)dataGridCandiata.Rows[e.RowIndex].Cells["Id"].Value;
                this.EliminarCandidata(id);

            }
            else if (e.ColumnIndex == dataGridCandiata.Columns["btnGaleria"].Index && e.RowIndex >= 0)
            {
                // Acción de edición
                int candidataId = (int)dataGridCandiata.Rows[e.RowIndex].Cells["ID"].Value;
                this.EditarGaleria(candidataId);
            }
        }

        private void btnFiltrar_Click(object sender, EventArgs e)
        {
            
        }
    }
}
