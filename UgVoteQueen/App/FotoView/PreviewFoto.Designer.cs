using Models.DTO;

namespace Views.App.FotoView
{
    partial class PreviewFoto
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
            pictureImage = new PictureBox();
            LTituloFoto = new Label();
            flowLayoutPanel1 = new FlowLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)pictureImage).BeginInit();
            flowLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // pictureImage
            // 
            pictureImage.Location = new Point(13, 37);
            pictureImage.Name = "pictureImage";
            pictureImage.Size = new Size(153, 170);
            pictureImage.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureImage.TabIndex = 2;
            pictureImage.TabStop = false;
            // 
            // LTituloFoto
            // 
            LTituloFoto.AutoSize = true;
            LTituloFoto.Font = new Font("SF Pro Rounded", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LTituloFoto.ForeColor = Color.FromArgb(3, 7, 18);
            LTituloFoto.Location = new Point(10, 10);
            LTituloFoto.Margin = new Padding(0, 5, 0, 5);
            LTituloFoto.Name = "LTituloFoto";
            LTituloFoto.Size = new Size(50, 19);
            LTituloFoto.TabIndex = 1;
            LTituloFoto.Text = "Titulo";
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.BackColor = Color.White;
            flowLayoutPanel1.Controls.Add(LTituloFoto);
            flowLayoutPanel1.Controls.Add(pictureImage);
            flowLayoutPanel1.Dock = DockStyle.Fill;
            flowLayoutPanel1.FlowDirection = FlowDirection.TopDown;
            flowLayoutPanel1.Location = new Point(0, 0);
            flowLayoutPanel1.Margin = new Padding(0);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Padding = new Padding(10, 5, 10, 5);
            flowLayoutPanel1.Size = new Size(180, 220);
            flowLayoutPanel1.TabIndex = 1;
            flowLayoutPanel1.Paint += flowLayoutPanel1_Paint;
            // 
            // PreviewFoto
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(flowLayoutPanel1);
            Cursor = Cursors.Hand;
            ForeColor = Color.FromArgb(250, 250, 250);
            Name = "PreviewFoto";
            Size = new Size(180, 220);
            ((System.ComponentModel.ISupportInitialize)pictureImage).EndInit();
            flowLayoutPanel1.ResumeLayout(false);
            flowLayoutPanel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pictureImage;
        private Label LTituloFoto;
        private FlowLayoutPanel flowLayoutPanel1;
    }
}
