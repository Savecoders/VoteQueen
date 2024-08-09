namespace Views.App.EstudianteView
{
    partial class UEstudiantes
    {
        /// <summary> 
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            label2 = new Label();
            label1 = new Label();
            btnFiltrar = new Button();
            txtFiltrar = new TextBox();
            dataGridEstudiantes = new DataGridView();
            btnAgregarEstudiante = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridEstudiantes).BeginInit();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("SF Pro Display", 15F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(22, 58);
            label2.Name = "label2";
            label2.Size = new Size(371, 24);
            label2.TabIndex = 10;
            label2.Text = "Estudiantes registrados para las Votaciones";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("SF Pro Display", 15F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(22, 24);
            label1.Name = "label1";
            label1.Size = new Size(217, 24);
            label1.TabIndex = 9;
            label1.Text = "Gestion de Estudiantes";
            // 
            // btnFiltrar
            // 
            btnFiltrar.Font = new Font("SF Pro Display", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnFiltrar.Location = new Point(885, 106);
            btnFiltrar.Name = "btnFiltrar";
            btnFiltrar.Size = new Size(115, 29);
            btnFiltrar.TabIndex = 8;
            btnFiltrar.Text = "Buscar";
            btnFiltrar.UseVisualStyleBackColor = true;
            btnFiltrar.Click += btnFiltrar_Click;
            // 
            // txtFiltrar
            // 
            txtFiltrar.Font = new Font("Segoe UI", 12F);
            txtFiltrar.Location = new Point(22, 106);
            txtFiltrar.Name = "txtFiltrar";
            txtFiltrar.Size = new Size(842, 29);
            txtFiltrar.TabIndex = 7;
            // 
            // dataGridEstudiantes
            // 
            dataGridEstudiantes.BackgroundColor = Color.FromArgb(244, 244, 245);
            dataGridEstudiantes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridEstudiantes.Location = new Point(22, 154);
            dataGridEstudiantes.Name = "dataGridEstudiantes";
            dataGridEstudiantes.ScrollBars = ScrollBars.Vertical;
            dataGridEstudiantes.Size = new Size(978, 442);
            dataGridEstudiantes.TabIndex = 6;
            dataGridEstudiantes.CellContentClick += dataGridEstudiantes_CellContentClick;
            // 
            // btnAgregarEstudiante
            // 
            btnAgregarEstudiante.BackColor = Color.FromArgb(34, 197, 94);
            btnAgregarEstudiante.BackgroundImageLayout = ImageLayout.Center;
            btnAgregarEstudiante.Cursor = Cursors.Hand;
            btnAgregarEstudiante.FlatAppearance.BorderSize = 0;
            btnAgregarEstudiante.FlatStyle = FlatStyle.Flat;
            btnAgregarEstudiante.Font = new Font("SF Pro Text", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnAgregarEstudiante.Location = new Point(833, 34);
            btnAgregarEstudiante.Margin = new Padding(0);
            btnAgregarEstudiante.Name = "btnAgregarEstudiante";
            btnAgregarEstudiante.Size = new Size(167, 36);
            btnAgregarEstudiante.TabIndex = 11;
            btnAgregarEstudiante.Text = "Agregar Estudiante";
            btnAgregarEstudiante.TextImageRelation = TextImageRelation.ImageAboveText;
            btnAgregarEstudiante.UseVisualStyleBackColor = false;
            btnAgregarEstudiante.Click += btnAgregarEstudiante_Click;
            // 
            // UEstudiantes
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(250, 250, 250);
            Controls.Add(btnAgregarEstudiante);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnFiltrar);
            Controls.Add(txtFiltrar);
            Controls.Add(dataGridEstudiantes);
            Name = "UEstudiantes";
            Size = new Size(1022, 621);
            Load += UEstudiantes_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridEstudiantes).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label2;
        private Label label1;
        private Button btnFiltrar;
        private TextBox txtFiltrar;
        private DataGridView dataGridEstudiantes;
        private Button btnAgregarEstudiante;
    }
}
