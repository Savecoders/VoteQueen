using Models.DTO;

namespace Views.Components
{
    partial class CardCandidata
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
            LCandidataNombre = new Label();
            LCarrera = new Label();
            btnCandidataView = new Button();
            LayoutState = new FlowLayoutPanel();
            pictureBox2 = new PictureBox();
            LComentarios = new Label();
            LayoutContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)ImageCandidata).BeginInit();
            LayoutState.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // LayoutContainer
            // 
            LayoutContainer.AutoScroll = true;
            LayoutContainer.AutoScrollMargin = new Size(10, 10);
            LayoutContainer.AutoScrollMinSize = new Size(20, 20);
            LayoutContainer.AutoSize = true;
            LayoutContainer.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            LayoutContainer.BackColor = Color.FromArgb(250, 250, 250);
            LayoutContainer.Controls.Add(ImageCandidata);
            LayoutContainer.Controls.Add(LCandidataNombre);
            LayoutContainer.Controls.Add(LCarrera);
            LayoutContainer.Controls.Add(btnCandidataView);
            LayoutContainer.Controls.Add(LayoutState);
            LayoutContainer.Dock = DockStyle.Fill;
            LayoutContainer.FlowDirection = FlowDirection.TopDown;
            LayoutContainer.Location = new Point(0, 0);
            LayoutContainer.Margin = new Padding(0);
            LayoutContainer.MinimumSize = new Size(220, 280);
            LayoutContainer.Name = "LayoutContainer";
            LayoutContainer.Padding = new Padding(10);
            LayoutContainer.Size = new Size(280, 437);
            LayoutContainer.TabIndex = 0;
            LayoutContainer.TabStop = true;
            // 
            // ImageCandidata
            // 
            ImageCandidata.Location = new Point(13, 13);
            ImageCandidata.Name = "ImageCandidata";
            ImageCandidata.Padding = new Padding(0, 0, 0, 10);
            ImageCandidata.Size = new Size(250, 250);
            ImageCandidata.TabIndex = 2;
            ImageCandidata.TabStop = false;
            // 
            // LCandidataNombre
            // 
            LCandidataNombre.AutoSize = true;
            LCandidataNombre.Font = new Font("SF Pro Rounded", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LCandidataNombre.Location = new Point(13, 266);
            LCandidataNombre.Name = "LCandidataNombre";
            LCandidataNombre.Padding = new Padding(0, 10, 0, 10);
            LCandidataNombre.Size = new Size(163, 39);
            LCandidataNombre.TabIndex = 0;
            LCandidataNombre.Text = "Nombre de Candidata";
            // 
            // LCarrera
            // 
            LCarrera.AutoSize = true;
            LCarrera.Font = new Font("SF Pro Display", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            LCarrera.Location = new Point(13, 305);
            LCarrera.Name = "LCarrera";
            LCarrera.Padding = new Padding(0, 0, 0, 10);
            LCarrera.Size = new Size(57, 28);
            LCarrera.TabIndex = 1;
            LCarrera.Text = "nombre";
            // 
            // btnCandidataView
            // 
            btnCandidataView.Font = new Font("SF Pro Text", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCandidataView.Location = new Point(13, 336);
            btnCandidataView.Name = "btnCandidataView";
            btnCandidataView.Size = new Size(250, 40);
            btnCandidataView.TabIndex = 4;
            btnCandidataView.Text = "Ver Mas";
            btnCandidataView.UseVisualStyleBackColor = true;
            // 
            // LayoutState
            // 
            LayoutState.Controls.Add(pictureBox2);
            LayoutState.Controls.Add(LComentarios);
            LayoutState.FlowDirection = FlowDirection.RightToLeft;
            LayoutState.Location = new Point(13, 382);
            LayoutState.Name = "LayoutState";
            LayoutState.Size = new Size(250, 38);
            LayoutState.TabIndex = 3;
            // 
            // pictureBox2
            // 
            pictureBox2.Location = new Point(217, 3);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(30, 30);
            pictureBox2.TabIndex = 2;
            pictureBox2.TabStop = false;
            // 
            // LComentarios
            // 
            LComentarios.AutoSize = true;
            LComentarios.Font = new Font("SF Pro Rounded", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            LComentarios.ForeColor = Color.FromArgb(39, 39, 42);
            LComentarios.Location = new Point(169, 0);
            LComentarios.Name = "LComentarios";
            LComentarios.Padding = new Padding(0, 10, 0, 0);
            LComentarios.Size = new Size(42, 26);
            LComentarios.TabIndex = 1;
            LComentarios.Text = "label3";
            // 
            // CardCandidata
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(250, 250, 249);
            Controls.Add(LayoutContainer);
            Name = "CardCandidata";
            Size = new Size(280, 437);
            LayoutContainer.ResumeLayout(false);
            LayoutContainer.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)ImageCandidata).EndInit();
            LayoutState.ResumeLayout(false);
            LayoutState.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private FlowLayoutPanel LayoutContainer;
        private Label LCandidataNombre;
        private Label LCarrera;
        private PictureBox ImageCandidata;
        private FlowLayoutPanel LayoutState;
        private Label LComentarios;
        private Button btnCandidataView;
        private PictureBox pictureBox2;
    }
}
