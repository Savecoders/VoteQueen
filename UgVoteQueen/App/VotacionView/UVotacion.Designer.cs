namespace Views.App.VotacionView
{
    partial class UVotacion
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
            label1 = new Label();
            lInfo = new Label();
            comboBox1 = new ComboBox();
            dataGridView1 = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("SF Pro Display", 15F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(30, 33);
            label1.Name = "label1";
            label1.Size = new Size(272, 24);
            label1.TabIndex = 7;
            label1.Text = "Resultados de las Votaciones";
            // 
            // lInfo
            // 
            lInfo.AutoSize = true;
            lInfo.Font = new Font("SF Pro Display", 14F);
            lInfo.Location = new Point(30, 75);
            lInfo.Name = "lInfo";
            lInfo.Size = new Size(335, 23);
            lInfo.TabIndex = 8;
            lInfo.Text = "Selecione Reina FMCF O Miss Fotogenia";
            // 
            // comboBox1
            // 
            comboBox1.Font = new Font("SF Pro Display", 14F);
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Reina FCMF", "Miss Fotogenia" });
            comboBox1.Location = new Point(399, 72);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(596, 31);
            comboBox1.TabIndex = 9;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            comboBox1.SelectedValueChanged += comboBox1_SelectedIndexChanged;
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = Color.FromArgb(244, 244, 245);
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(30, 132);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(965, 402);
            dataGridView1.TabIndex = 10;
            // 
            // UVotacion
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(250, 250, 250);
            Controls.Add(dataGridView1);
            Controls.Add(comboBox1);
            Controls.Add(lInfo);
            Controls.Add(label1);
            Name = "UVotacion";
            Size = new Size(1022, 618);
            Load += UVotacion_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label lInfo;
        private ComboBox comboBox1;
        private DataGridView dataGridView1;
    }
}
