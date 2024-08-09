namespace Views.App.GaleriaView
{
    partial class UGalerias
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
            btnAgregarEstudiante = new Button();
            label2 = new Label();
            label1 = new Label();
            labelNoAlbunes = new Label();
            LNombreCandidata = new Label();
            dataGridGaleria = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dataGridGaleria).BeginInit();
            SuspendLayout();
            // 
            // btnAgregarEstudiante
            // 
            btnAgregarEstudiante.BackColor = Color.FromArgb(34, 197, 94);
            btnAgregarEstudiante.BackgroundImageLayout = ImageLayout.Center;
            btnAgregarEstudiante.Cursor = Cursors.Hand;
            btnAgregarEstudiante.FlatAppearance.BorderSize = 0;
            btnAgregarEstudiante.FlatStyle = FlatStyle.Flat;
            btnAgregarEstudiante.Font = new Font("SF Pro Text", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnAgregarEstudiante.Location = new Point(818, 37);
            btnAgregarEstudiante.Margin = new Padding(0);
            btnAgregarEstudiante.Name = "btnAgregarEstudiante";
            btnAgregarEstudiante.Size = new Size(167, 36);
            btnAgregarEstudiante.TabIndex = 14;
            btnAgregarEstudiante.Text = "Agregar Albun";
            btnAgregarEstudiante.TextImageRelation = TextImageRelation.ImageAboveText;
            btnAgregarEstudiante.UseVisualStyleBackColor = false;
            btnAgregarEstudiante.Click += this.btnAgregarGaleria_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("SF Pro Display", 15F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(25, 59);
            label2.Name = "label2";
            label2.Size = new Size(458, 24);
            label2.TabIndex = 13;
            label2.Text = "Estos son los albunes disponibles para los estudiantes";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("SF Pro Display", 15F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(25, 25);
            label1.Name = "label1";
            label1.Size = new Size(207, 24);
            label1.TabIndex = 12;
            label1.Text = "Albun de la Candidata";
            // 
            // labelNoAlbunes
            // 
            labelNoAlbunes.AutoSize = true;
            labelNoAlbunes.Font = new Font("SF Pro Display", 15F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelNoAlbunes.ForeColor = Color.FromArgb(113, 113, 122);
            labelNoAlbunes.Location = new Point(25, 100);
            labelNoAlbunes.Name = "labelNoAlbunes";
            labelNoAlbunes.Size = new Size(504, 24);
            labelNoAlbunes.TabIndex = 15;
            labelNoAlbunes.Text = "No se han encontrado albunes en la Galeria de la Candidata";
            labelNoAlbunes.Visible = false;
            // 
            // LNombreCandidata
            // 
            LNombreCandidata.AutoSize = true;
            LNombreCandidata.Font = new Font("SF Pro Display", 15F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LNombreCandidata.Location = new Point(248, 25);
            LNombreCandidata.Name = "LNombreCandidata";
            LNombreCandidata.Size = new Size(207, 24);
            LNombreCandidata.TabIndex = 16;
            LNombreCandidata.Text = "Albun de la Candidata";
            // 
            // dataGridGaleria
            // 
            dataGridGaleria.BackgroundColor = Color.FromArgb(250, 250, 250);
            dataGridGaleria.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridGaleria.Location = new Point(27, 142);
            dataGridGaleria.Name = "dataGridGaleria";
            dataGridGaleria.Size = new Size(958, 422);
            dataGridGaleria.TabIndex = 17;
            dataGridGaleria.CellContentClick += dataGridGaleria_CellContentClick;
            // 
            // UGalerias
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(250, 250, 250);
            Controls.Add(dataGridGaleria);
            Controls.Add(LNombreCandidata);
            Controls.Add(labelNoAlbunes);
            Controls.Add(btnAgregarEstudiante);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "UGalerias";
            Size = new Size(1022, 618);
            Load += UGaleria_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridGaleria).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnAgregarEstudiante;
        private Label label2;
        private Label label1;
        private Label labelNoAlbunes;
        private Label LNombreCandidata;
        private DataGridView dataGridGaleria;
    }
}
