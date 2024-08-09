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

namespace Views.App.VotacionView
{
    public partial class UVotacion : UserControl
    {
        VotacionController votacionController = new VotacionController(
            new VotacionRepository()
        );
        public UVotacion()
        {
            InitializeComponent();
        }

        private void UVotacion_Load(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Reina FCMF
            //Miss Fotogenia
            TipoVotacion tipo = comboBox1.Text == "Reina FCMF" ? TipoVotacion.ReinaFMC : TipoVotacion.MissFotogenia; 
            try
            {
                MessageBox.Show("Cargando votaciones " + tipo.ToString());

                DataSet dataSet = votacionController.GetVotaciones(tipo);

                dataGridView1.AutoGenerateColumns = true;
                dataGridView1.DataSource = dataSet;

                dataGridView1.DataMember = dataSet.Tables[0].TableName;

                dataGridView1.Columns[0].HeaderText = "ID";
                dataGridView1.Columns[1].HeaderText = "Nombre";
                dataGridView1.Columns[2].HeaderText = "FotoPrincipal";
                dataGridView1.Columns[3].HeaderText = "Edad";
                dataGridView1.Columns[4].HeaderText = "Telefono";
                dataGridView1.Columns[5].HeaderText = "Fecha_Nacimiento";
                dataGridView1.Columns[6].HeaderText = "Carrera";
                dataGridView1.Columns[7].HeaderText = "Nivel";
                dataGridView1.Columns[8].HeaderText = "FechaInscripcion";
                dataGridView1.Columns[9].HeaderText = "NumeroDeVotos";

                // informacion que no se necesita mostrar
                dataGridView1.Columns[3].Visible = false;
                dataGridView1.Columns[5].Visible = false;
                dataGridView1.Columns[8].Visible = false;

                //sizes
                dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                dataGridView1.RowTemplate.Height = 120;

                // Configura las columnas de FotoPrincipal
                dataGridView1.Columns[2].DefaultCellStyle.Padding = new Padding(10, 10, 10, 10);
                ((DataGridViewImageColumn)dataGridView1.Columns[2]).ImageLayout = DataGridViewImageCellLayout.Stretch;

                // omitir la ultima fila
                dataGridView1.AllowUserToAddRows = false;
                dataGridView1.AllowUserToDeleteRows = false;
                dataGridView1.ReadOnly = true;

            } catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }
    }
}
