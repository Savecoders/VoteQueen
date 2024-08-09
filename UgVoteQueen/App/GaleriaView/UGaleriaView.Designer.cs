namespace Views.App.GaleriaView
{
    partial class UGaleriaView
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
            flowLayoutPanel1 = new FlowLayoutPanel();
            label1 = new Label();
            fLGaleriaContainer = new FlowLayoutPanel();
            LGalerias = new Label();
            label2 = new Label();
            lNombres = new Label();
            lTituloInput = new Label();
            LEdad = new Label();
            LDescripcionInput = new Label();
            lFechaInput = new Label();
            flowLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Controls.Add(label1);
            flowLayoutPanel1.Location = new Point(0, 0);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Padding = new Padding(30, 10, 10, 10);
            flowLayoutPanel1.Size = new Size(1022, 51);
            flowLayoutPanel1.TabIndex = 23;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("SF Pro Display", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(33, 14);
            label1.Margin = new Padding(3, 4, 3, 0);
            label1.Name = "label1";
            label1.Size = new Size(113, 25);
            label1.TabIndex = 3;
            label1.Text = "Ver Galeria";
            // 
            // fLGaleriaContainer
            // 
            fLGaleriaContainer.AutoScroll = true;
            fLGaleriaContainer.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            fLGaleriaContainer.FlowDirection = FlowDirection.TopDown;
            fLGaleriaContainer.Location = new Point(33, 213);
            fLGaleriaContainer.Margin = new Padding(10);
            fLGaleriaContainer.Name = "fLGaleriaContainer";
            fLGaleriaContainer.Size = new Size(947, 378);
            fLGaleriaContainer.TabIndex = 24;
            // 
            // LGalerias
            // 
            LGalerias.AutoSize = true;
            LGalerias.Font = new Font("SF Pro Rounded", 14F, FontStyle.Bold);
            LGalerias.Location = new Point(33, 172);
            LGalerias.Margin = new Padding(0, 10, 0, 10);
            LGalerias.Name = "LGalerias";
            LGalerias.Size = new Size(144, 23);
            LGalerias.TabIndex = 25;
            LGalerias.Text = "Fotos de Galeria";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("SF Pro Rounded", 14F, FontStyle.Bold);
            label2.Location = new Point(33, 64);
            label2.Margin = new Padding(0, 10, 0, 10);
            label2.Name = "label2";
            label2.RightToLeft = RightToLeft.Yes;
            label2.Size = new Size(198, 23);
            label2.TabIndex = 26;
            label2.Text = "Informacion de Galeria";
            // 
            // lNombres
            // 
            lNombres.AutoSize = true;
            lNombres.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lNombres.Location = new Point(33, 109);
            lNombres.Name = "lNombres";
            lNombres.Padding = new Padding(0, 0, 0, 5);
            lNombres.Size = new Size(52, 26);
            lNombres.TabIndex = 19;
            lNombres.Text = "Titulo";
            // 
            // lTituloInput
            // 
            lTituloInput.AutoSize = true;
            lTituloInput.Font = new Font("Segoe UI", 11F);
            lTituloInput.Location = new Point(105, 105);
            lTituloInput.Name = "lTituloInput";
            lTituloInput.Padding = new Padding(0, 5, 0, 5);
            lTituloInput.Size = new Size(58, 30);
            lTituloInput.TabIndex = 20;
            lTituloInput.Text = "label12";
            // 
            // LEdad
            // 
            LEdad.AutoSize = true;
            LEdad.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LEdad.Location = new Point(357, 109);
            LEdad.Name = "LEdad";
            LEdad.Padding = new Padding(0, 0, 0, 5);
            LEdad.Size = new Size(96, 26);
            LEdad.TabIndex = 28;
            LEdad.Text = "Descripcion";
            LEdad.Click += label13_Click;
            // 
            // LDescripcionInput
            // 
            LDescripcionInput.AutoSize = true;
            LDescripcionInput.Font = new Font("Segoe UI", 11F);
            LDescripcionInput.Location = new Point(473, 105);
            LDescripcionInput.Name = "LDescripcionInput";
            LDescripcionInput.Padding = new Padding(0, 5, 0, 5);
            LDescripcionInput.Size = new Size(58, 30);
            LDescripcionInput.TabIndex = 29;
            LDescripcionInput.Text = "label14";
            // 
            // lFechaInput
            // 
            lFechaInput.AutoSize = true;
            lFechaInput.Font = new Font("Segoe UI", 11F);
            lFechaInput.Location = new Point(204, 174);
            lFechaInput.Name = "lFechaInput";
            lFechaInput.Padding = new Padding(0, 5, 0, 5);
            lFechaInput.Size = new Size(58, 30);
            lFechaInput.TabIndex = 30;
            lFechaInput.Text = "label14";
            // 
            // UGaleriaView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(250, 250, 250);
            Controls.Add(lFechaInput);
            Controls.Add(LEdad);
            Controls.Add(LDescripcionInput);
            Controls.Add(label2);
            Controls.Add(LGalerias);
            Controls.Add(fLGaleriaContainer);
            Controls.Add(flowLayoutPanel1);
            Controls.Add(lNombres);
            Controls.Add(lTituloInput);
            Name = "UGaleriaView";
            Size = new Size(1022, 618);
            Load += UCandidataPortafolio_Load;
            flowLayoutPanel1.ResumeLayout(false);
            flowLayoutPanel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private FlowLayoutPanel flowLayoutPanel1;
        private Label label1;
        private FlowLayoutPanel fLGaleriaContainer;
        private Label LGalerias;
        private Label label2;
        private Label lNombres;
        private Label lTituloInput;
        private Label LEdad;
        private Label LDescripcionInput;
        private Label lFechaInput;
    }
}
