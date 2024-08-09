using Models.DTO;

namespace Views.Components
{
    partial class CardFoto
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
            LTituloFoto = new Label();
            pictureFoto = new PictureBox();
            btnComentario = new Button();
            LayoutContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureFoto).BeginInit();
            SuspendLayout();
            // 
            // LayoutContainer
            // 
            LayoutContainer.AutoScroll = true;
            LayoutContainer.AutoScrollMargin = new Size(10, 10);
            LayoutContainer.AutoScrollMinSize = new Size(10, 10);
            LayoutContainer.AutoSize = true;
            LayoutContainer.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            LayoutContainer.BackColor = Color.White;
            LayoutContainer.Controls.Add(LTituloFoto);
            LayoutContainer.Controls.Add(pictureFoto);
            LayoutContainer.Controls.Add(btnComentario);
            LayoutContainer.Dock = DockStyle.Fill;
            LayoutContainer.FlowDirection = FlowDirection.TopDown;
            LayoutContainer.Location = new Point(0, 0);
            LayoutContainer.Margin = new Padding(0);
            LayoutContainer.MinimumSize = new Size(220, 280);
            LayoutContainer.Name = "LayoutContainer";
            LayoutContainer.Padding = new Padding(10);
            LayoutContainer.Size = new Size(220, 320);
            LayoutContainer.TabIndex = 0;
            LayoutContainer.TabStop = true;
            LayoutContainer.Paint += LayoutContainer_Paint;
            // 
            // LTituloFoto
            // 
            LTituloFoto.Font = new Font("SF Pro Rounded", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LTituloFoto.Location = new Point(10, 20);
            LTituloFoto.Margin = new Padding(0, 10, 0, 10);
            LTituloFoto.Name = "LTituloFoto";
            LTituloFoto.Size = new Size(173, 23);
            LTituloFoto.TabIndex = 0;
            LTituloFoto.Text = "Titulo";
            LTituloFoto.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pictureFoto
            // 
            pictureFoto.Location = new Point(13, 56);
            pictureFoto.Name = "pictureFoto";
            pictureFoto.Padding = new Padding(0, 0, 0, 10);
            pictureFoto.Size = new Size(170, 199);
            pictureFoto.TabIndex = 2;
            pictureFoto.TabStop = false;
            // 
            // btnComentario
            // 
            btnComentario.Location = new Point(13, 268);
            btnComentario.Margin = new Padding(3, 10, 3, 3);
            btnComentario.Name = "btnComentario";
            btnComentario.Size = new Size(170, 30);
            btnComentario.TabIndex = 4;
            btnComentario.Text = "Comentar";
            btnComentario.UseVisualStyleBackColor = true;
            btnComentario.Click += btnComentario_Click;
            // 
            // CardFoto
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(250, 250, 249);
            Controls.Add(LayoutContainer);
            Cursor = Cursors.Hand;
            Name = "CardFoto";
            Size = new Size(200, 320);
            Load += CardFoto_Load;
            LayoutContainer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureFoto).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private FlowLayoutPanel LayoutContainer;
        private Label LTituloFoto;
        private PictureBox pictureFoto;
        private Button btnComentario;
    }
}
