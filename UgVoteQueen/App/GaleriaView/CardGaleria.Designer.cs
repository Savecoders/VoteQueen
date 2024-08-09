using Models.DTO;

namespace Views.App.GaleriaView
{
    partial class CardGaleria
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
            LayoutContainer = new FlowLayoutPanel();
            ImageCandidata = new PictureBox();
            LGaleriaTitulo = new Label();
            flowLayoutPanel1 = new FlowLayoutPanel();
            LFecha = new Label();
            LFechaCreacion = new Label();
            btnVerGaleria = new Button();
            LayoutContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)ImageCandidata).BeginInit();
            flowLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // LayoutContainer
            // 
            LayoutContainer.AutoScroll = true;
            LayoutContainer.AutoScrollMargin = new Size(10, 10);
            LayoutContainer.AutoScrollMinSize = new Size(20, 20);
            LayoutContainer.AutoSize = true;
            LayoutContainer.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            LayoutContainer.BackColor = Color.White;
            LayoutContainer.Controls.Add(ImageCandidata);
            LayoutContainer.Controls.Add(LGaleriaTitulo);
            LayoutContainer.Controls.Add(flowLayoutPanel1);
            LayoutContainer.Controls.Add(btnVerGaleria);
            LayoutContainer.Dock = DockStyle.Fill;
            LayoutContainer.FlowDirection = FlowDirection.TopDown;
            LayoutContainer.Location = new Point(0, 0);
            LayoutContainer.Margin = new Padding(0);
            LayoutContainer.MinimumSize = new Size(220, 280);
            LayoutContainer.Name = "LayoutContainer";
            LayoutContainer.Padding = new Padding(10);
            LayoutContainer.Size = new Size(250, 420);
            LayoutContainer.TabIndex = 0;
            LayoutContainer.TabStop = true;
            // 
            // ImageCandidata
            // 
            ImageCandidata.Location = new Point(13, 13);
            ImageCandidata.Name = "ImageCandidata";
            ImageCandidata.Padding = new Padding(0, 0, 0, 10);
            ImageCandidata.Size = new Size(221, 254);
            ImageCandidata.SizeMode = PictureBoxSizeMode.StretchImage;
            ImageCandidata.TabIndex = 2;
            ImageCandidata.TabStop = false;
            ImageCandidata.Click += ImageCandidata_Click;
            // 
            // LGaleriaTitulo
            // 
            LGaleriaTitulo.AutoSize = true;
            LGaleriaTitulo.Font = new Font("SF Pro Rounded", 13F, FontStyle.Bold);
            LGaleriaTitulo.Location = new Point(13, 270);
            LGaleriaTitulo.Name = "LGaleriaTitulo";
            LGaleriaTitulo.Padding = new Padding(0, 10, 0, 15);
            LGaleriaTitulo.Size = new Size(116, 46);
            LGaleriaTitulo.TabIndex = 0;
            LGaleriaTitulo.Text = "Titulo Galeria";
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Controls.Add(LFecha);
            flowLayoutPanel1.Controls.Add(LFechaCreacion);
            flowLayoutPanel1.Location = new Point(13, 319);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(221, 28);
            flowLayoutPanel1.TabIndex = 5;
            // 
            // LFecha
            // 
            LFecha.AutoSize = true;
            LFecha.Font = new Font("Segoe UI", 9.75F);
            LFecha.Location = new Point(3, 0);
            LFecha.Name = "LFecha";
            LFecha.Size = new Size(41, 17);
            LFecha.TabIndex = 0;
            LFecha.Text = "Fecha";
            // 
            // LFechaCreacion
            // 
            LFechaCreacion.AutoSize = true;
            LFechaCreacion.Font = new Font("Segoe UI", 9.75F);
            LFechaCreacion.Location = new Point(55, 0);
            LFechaCreacion.Margin = new Padding(8, 0, 3, 0);
            LFechaCreacion.Name = "LFechaCreacion";
            LFechaCreacion.Size = new Size(43, 17);
            LFechaCreacion.TabIndex = 1;
            LFechaCreacion.Text = "label2";
            // 
            // btnVerGaleria
            // 
            btnVerGaleria.Font = new Font("SF Pro Text", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnVerGaleria.Location = new Point(13, 360);
            btnVerGaleria.Margin = new Padding(3, 10, 3, 3);
            btnVerGaleria.Name = "btnVerGaleria";
            btnVerGaleria.Size = new Size(221, 38);
            btnVerGaleria.TabIndex = 4;
            btnVerGaleria.Text = "Ver Galeria";
            btnVerGaleria.UseVisualStyleBackColor = true;
            btnVerGaleria.Click += btnCandidataView_Click;
            // 
            // CardGaleria
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(LayoutContainer);
            Cursor = Cursors.Hand;
            Name = "CardGaleria";
            Size = new Size(250, 420);
            LayoutContainer.ResumeLayout(false);
            LayoutContainer.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)ImageCandidata).EndInit();
            flowLayoutPanel1.ResumeLayout(false);
            flowLayoutPanel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private FlowLayoutPanel LayoutContainer;
        private Label LGaleriaTitulo;
        private PictureBox ImageCandidata;
        private Button btnVerGaleria;
        private FlowLayoutPanel flowLayoutPanel1;
        private Label LFecha;
        private Label LFechaCreacion;
    }
}
