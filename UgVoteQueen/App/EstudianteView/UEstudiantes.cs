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

namespace Views.App.EstudianteView
{
    public partial class UEstudiantes : UserControl
    {

        private EstudianteController estudianteController = new(
                new EstudianteRepository()
        );

        public UEstudiantes()
        {
            InitializeComponent();
        }

        private void UEstudiantes_Load(object sender, EventArgs e)
        {

            dataGridEstudiantes.ClearSelection();


            List<Estudiante> estudiantes = estudianteController.FiltrarEstudiantes(txtFiltrar.Text);

            // show Id, Nombres, Correo, Matricula

            dataGridEstudiantes.DataSource = estudiantes;

            dataGridEstudiantes.Columns["FotoPerfil"].Visible = false;
            dataGridEstudiantes.Columns["Contrasena"].Visible = false;
            dataGridEstudiantes.Columns["Estado"].Visible = false;

            // ordernar columnas
            dataGridEstudiantes.Columns["Id"].DisplayIndex = 0;
            dataGridEstudiantes.Columns["Nombre"].DisplayIndex = 1;
            dataGridEstudiantes.Columns["Correo"].DisplayIndex = 2;
            dataGridEstudiantes.Columns["Matricula"].DisplayIndex = 3;


            // Crear la columna de edición
            DataGridViewButtonColumn btnEdit = new DataGridViewButtonColumn();
            btnEdit.HeaderText = "Edit";
            btnEdit.Name = "btnEdit";
            btnEdit.Text = "Edit";
            btnEdit.UseColumnTextForButtonValue = true;
            dataGridEstudiantes.Columns.Add(btnEdit);

            // Crear la columna de eliminación
            DataGridViewButtonColumn btnDelete = new DataGridViewButtonColumn();
            btnDelete.HeaderText = "Delete";
            btnDelete.Name = "btnDelete";
            btnDelete.Text = "Delete";
            btnDelete.UseColumnTextForButtonValue = true;
            dataGridEstudiantes.Columns.Add(btnDelete);


            dataGridEstudiantes.Columns["btnEdit"].DisplayIndex = 4;
            dataGridEstudiantes.Columns["btnDelete"].DisplayIndex = 5;

            dataGridEstudiantes.AllowUserToOrderColumns = false;


            // sizes
            dataGridEstudiantes.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }


        private void EditarEstudiante(string correo)
        {
            try
            {

                Estudiante estudiante = estudianteController.BuscarEstudiante(

                    new Estudiante()
                    {
                        Correo = correo
                    }
                );
                if (estudiante != null)
                {
                    // Abrir el formulario de edición
                    this.Controls.Clear();
                    UEditarEstudiante formEstudiante = new UEditarEstudiante(estudiante);
                    this.Controls.Add(formEstudiante);

                }
                else
                {
                    MessageBox.Show("Estudiante no encontrado");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error en la fila selecionada");
            }

        }

        private void EliminarEstudiante(int id)
        {
            // Message estas seguro?

            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result = MessageBox.Show("Estas seguro de eliminar el estudiante?", "Eliminar Estudiante", buttons);
            if (result == DialogResult.No)
            {
                return;
            }
            else
            {
                estudianteController.EliminarEstudiante(
                    new Estudiante()
                    {
                        ID = id
                    }
                );

                // Recargar la lista de estudiantes
                dataGridEstudiantes.DataSource = estudianteController.FiltrarEstudiantes(txtFiltrar.Text);
            }

        }


        private void dataGridEstudiantes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dataGridEstudiantes.Columns["btnEdit"].Index && e.RowIndex >= 0)
            {
                // Acción de edición
                string correo = (string)dataGridEstudiantes.Rows[e.RowIndex].Cells["Correo"].Value;
                EditarEstudiante(correo);
            }
            else if (e.ColumnIndex == dataGridEstudiantes.Columns["btnDelete"].Index && e.RowIndex >= 0)
            {
                // Acción de eliminación
                int estudianteId = (int)dataGridEstudiantes.Rows[e.RowIndex].Cells["Id"].Value;
                EliminarEstudiante(estudianteId);
            }
        }

        private void btnFiltrar_Click(object sender, EventArgs e)
        {
            txtFiltrar.Text = txtFiltrar.Text.Trim();
            List<Estudiante> estudiantes = estudianteController.FiltrarEstudiantes(txtFiltrar.Text);
            dataGridEstudiantes.DataSource = estudiantes;

        }

        private void btnAgregarEstudiante_Click(object sender, EventArgs e)
        {
            this.Controls.Clear();
            URegistrarEstudiante uRegistrarEstudiante = new URegistrarEstudiante();
            this.Controls.Add(uRegistrarEstudiante);
        }
    }
}
