using Controllers;
using Models.Repositories;
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
using Models.DTO;
using Common.Cache;
using static System.Windows.Forms.LinkLabel;

namespace Views.App.VotacionView
{
    public partial class UVoteFMCF : UserControl
    {

        private static UVoteFMCF _instance;

        private EstudianteController estudianteController = new EstudianteController(
            new EstudianteRepository()
        );

        private VotacionController votacionController = new VotacionController(
            new VotacionRepository()
        );

        private CandidataController candidataController = new CandidataController(
            new CandidataRepository()
        );

        private Candidata candidataSelecionada = new Candidata();

        public static UVoteFMCF Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new UVoteFMCF();
                }
                return _instance;
            }
        }

        public UVoteFMCF()
        {
            InitializeComponent();
        }

        private void loadDataGrid()
        {

            List<Candidata> candidatas = candidataController.ListarCandidatas();

            if (candidatas.Count > 0)
            {
                dataGridView1.DataSource = candidatas;

                // Contenido no necesario
                dataGridView1.Columns["Pasatiempos"].Visible = false;
                dataGridView1.Columns["Habilidades"].Visible = false;
                dataGridView1.Columns["Intereses"].Visible = false;
                dataGridView1.Columns["Aspiraciones"].Visible = false;
                dataGridView1.Columns["FechaNacimiento"].Visible = false;
                dataGridView1.Columns["GaleriaFotos"].Visible = false;

                // ordernar columnas

                dataGridView1.Columns["ID"].DisplayIndex = 0;
                dataGridView1.Columns["FotoPrincipal"].DisplayIndex = 1;
                dataGridView1.Columns["Nombre"].DisplayIndex = 2;
                dataGridView1.Columns["Edad"].DisplayIndex = 3;
                dataGridView1.Columns["Telefono"].DisplayIndex = 4;
                dataGridView1.Columns["Carrera"].DisplayIndex = 5;
                dataGridView1.Columns["Nivel"].DisplayIndex = 6;

                //sizes
                dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                dataGridView1.RowTemplate.Height = 120;

                // Configura las columnas de FotoPrincipal
                dataGridView1.Columns["FotoPrincipal"].DefaultCellStyle.Padding = new Padding(10, 10, 10, 10);
                ((DataGridViewImageColumn)dataGridView1.Columns["FotoPrincipal"]).ImageLayout = DataGridViewImageCellLayout.Stretch;


                dataGridView1.Rows[0].DefaultCellStyle.BackColor = Color.Yellow;
            }


        }

        private async void UVoteFMCF_Load(object sender, EventArgs e)
        {
            try
            {
                loadDataGrid();

                if(await estudianteController.VerificarVotoFMCF(SessionManager.GetUsuario().ID))
                {
                    lInfo.Text = "Ya has votado por tu candidata favorita a Reina FMCF";
                    btnRegistrar.Enabled = false;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("No pudimos cargar las candidatas" + ex.Message);
            }
        }


        private void btnRegistrar_Click(object sender, EventArgs e)
        {

            // Confirm Message

            MessageBoxButtons buttons = MessageBoxButtons.YesNo;

            DialogResult result = MessageBox.Show("¿Estas seguro de votar por esta candidata?", "Votar", buttons);

            if (result == DialogResult.No)
            {
                return;
            }


            if(result == DialogResult.Yes && candidataSelecionada.ID > 0)
            {
                Estudiante estudiante = new Estudiante()
                {
                    ID = SessionManager.GetUsuario().ID
                };
                
                Votacion votacion = new Votacion
                {
                    Usuario = estudiante,
                    Candidata = candidataSelecionada,
                    TipoVotacion = TipoVotacion.ReinaFMC
                };


                try
                {
                    if (votacionController.RegistrarVotacion(votacion))
                    {
                        MessageBox.Show("Votacion registrada");
                    }
                    else
                    {
                        MessageBox.Show("No se pudo registrar la votacion");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("No se pudo registrar la votacion" + ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Seleccione una candidata");
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                int idCandidata = (int)dataGridView1.Rows[e.RowIndex].Cells["Id"].Value;

                candidataSelecionada.ID = idCandidata;

            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }


        private void Form1_Load(object sender, EventArgs e)
        {
            // Configura las columnas del DataGridView
            dataGridView1.Columns["FotoPrincipal"].Width = 100;
            dataGridView1.Columns["FotoPrincipal"].DefaultCellStyle.NullValue = "No Image";
            dataGridView1.Columns["FotoPrincipal"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

        }

    }
}
