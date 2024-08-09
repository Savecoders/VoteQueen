namespace Views.App.CandidatasView
{
    partial class UCandidatas
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
            dataGridCandiata = new DataGridView();
            txtFiltrar = new TextBox();
            btnFiltrar = new Button();
            label1 = new Label();
            btnAgregarCandidata = new Button();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridCandiata).BeginInit();
            SuspendLayout();
            // 
            // dataGridCandiata
            // 
            dataGridCandiata.BackgroundColor = Color.FromArgb(244, 244, 245);
            dataGridCandiata.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridCandiata.Location = new Point(18, 155);
            dataGridCandiata.Name = "dataGridCandiata";
            dataGridCandiata.Size = new Size(978, 442);
            dataGridCandiata.TabIndex = 0;
            dataGridCandiata.CellContentClick += dataGridCandiata_CellContentClick;
            // 
            // txtFiltrar
            // 
            txtFiltrar.Font = new Font("Segoe UI", 12F);
            txtFiltrar.Location = new Point(18, 107);
            txtFiltrar.Name = "txtFiltrar";
            txtFiltrar.Size = new Size(842, 29);
            txtFiltrar.TabIndex = 1;
            // 
            // btnFiltrar
            // 
            btnFiltrar.Font = new Font("SF Pro Display", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnFiltrar.Location = new Point(881, 107);
            btnFiltrar.Name = "btnFiltrar";
            btnFiltrar.Size = new Size(115, 29);
            btnFiltrar.TabIndex = 2;
            btnFiltrar.Text = "Buscar";
            btnFiltrar.UseVisualStyleBackColor = true;
            btnFiltrar.Click += btnFiltrar_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("SF Pro Display", 15F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(18, 25);
            label1.Name = "label1";
            label1.Size = new Size(215, 24);
            label1.TabIndex = 3;
            label1.Text = "Gestion de Candidatas";
            label1.Click += label1_Click;
            // 
            // btnAgregarCandidata
            // 
            btnAgregarCandidata.BackColor = Color.FromArgb(34, 197, 94);
            btnAgregarCandidata.BackgroundImageLayout = ImageLayout.Center;
            btnAgregarCandidata.Cursor = Cursors.Hand;
            btnAgregarCandidata.FlatAppearance.BorderSize = 0;
            btnAgregarCandidata.FlatStyle = FlatStyle.Flat;
            btnAgregarCandidata.Font = new Font("SF Pro Text", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnAgregarCandidata.Location = new Point(829, 47);
            btnAgregarCandidata.Margin = new Padding(0);
            btnAgregarCandidata.Name = "btnAgregarCandidata";
            btnAgregarCandidata.Size = new Size(167, 36);
            btnAgregarCandidata.TabIndex = 4;
            btnAgregarCandidata.Text = "Agregar Candidata";
            btnAgregarCandidata.TextImageRelation = TextImageRelation.ImageAboveText;
            btnAgregarCandidata.UseVisualStyleBackColor = false;
            btnAgregarCandidata.Click += btnAgregarCandidata_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("SF Pro Display", 15F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(18, 59);
            label2.Name = "label2";
            label2.Size = new Size(368, 24);
            label2.TabIndex = 5;
            label2.Text = "Candidatas registradas para las Votaciones";
            // 
            // UCandidatas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            BackColor = Color.FromArgb(250, 250, 250);
            Controls.Add(label2);
            Controls.Add(btnAgregarCandidata);
            Controls.Add(label1);
            Controls.Add(btnFiltrar);
            Controls.Add(txtFiltrar);
            Controls.Add(dataGridCandiata);
            Margin = new Padding(0);
            Name = "UCandidatas";
            Size = new Size(1022, 621);
            Load += ListadoCandidatas_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridCandiata).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridCandiata;
        private TextBox txtFiltrar;
        private Button btnFiltrar;
        private Label label1;
        private Button btnAgregarCandidata;
        private Label label2;
    }
}
