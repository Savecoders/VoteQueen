namespace Views.App.VotacionView
{
    partial class UVoteFMCF
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
            lInfo = new Label();
            label1 = new Label();
            dataGridView1 = new DataGridView();
            flowLayoutPanel5 = new FlowLayoutPanel();
            btnCancelar = new Button();
            btnRegistrar = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            flowLayoutPanel5.SuspendLayout();
            SuspendLayout();
            // 
            // lInfo
            // 
            lInfo.AutoSize = true;
            lInfo.Font = new Font("SF Pro Display", 15F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lInfo.Location = new Point(23, 61);
            lInfo.Name = "lInfo";
            lInfo.Size = new Size(446, 24);
            lInfo.TabIndex = 7;
            lInfo.Text = "Selecione una de las candidatas de la lista para Votar";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("SF Pro Display", 15F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(23, 27);
            label1.Name = "label1";
            label1.Size = new Size(201, 24);
            label1.TabIndex = 6;
            label1.Text = "Votacion Reina FCMF";
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = Color.FromArgb(244, 244, 245);
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(23, 114);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(971, 402);
            dataGridView1.TabIndex = 8;
            dataGridView1.CellClick += dataGridView1_CellClick;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // flowLayoutPanel5
            // 
            flowLayoutPanel5.Controls.Add(btnCancelar);
            flowLayoutPanel5.Controls.Add(btnRegistrar);
            flowLayoutPanel5.Dock = DockStyle.Bottom;
            flowLayoutPanel5.FlowDirection = FlowDirection.RightToLeft;
            flowLayoutPanel5.Location = new Point(0, 562);
            flowLayoutPanel5.Name = "flowLayoutPanel5";
            flowLayoutPanel5.Padding = new Padding(100, 10, 10, 100);
            flowLayoutPanel5.Size = new Size(1022, 59);
            flowLayoutPanel5.TabIndex = 28;
            // 
            // btnCancelar
            // 
            btnCancelar.Font = new Font("Segoe UI", 12F);
            btnCancelar.Location = new Point(743, 10);
            btnCancelar.Margin = new Padding(3, 0, 3, 3);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(166, 41);
            btnCancelar.TabIndex = 4;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            // 
            // btnRegistrar
            // 
            btnRegistrar.Font = new Font("Segoe UI", 12F);
            btnRegistrar.Location = new Point(544, 10);
            btnRegistrar.Margin = new Padding(3, 0, 30, 3);
            btnRegistrar.Name = "btnRegistrar";
            btnRegistrar.Size = new Size(166, 41);
            btnRegistrar.TabIndex = 5;
            btnRegistrar.Text = "Votar";
            btnRegistrar.UseVisualStyleBackColor = true;
            btnRegistrar.Click += btnRegistrar_Click;
            // 
            // UVoteFMCF
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(250, 250, 250);
            Controls.Add(flowLayoutPanel5);
            Controls.Add(dataGridView1);
            Controls.Add(lInfo);
            Controls.Add(label1);
            Name = "UVoteFMCF";
            Size = new Size(1022, 621);
            Load += UVoteFMCF_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            flowLayoutPanel5.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lInfo;
        private Label label1;
        private DataGridView dataGridView1;
        private FlowLayoutPanel flowLayoutPanel5;
        private Button btnCancelar;
        private Button btnRegistrar;
    }
}
