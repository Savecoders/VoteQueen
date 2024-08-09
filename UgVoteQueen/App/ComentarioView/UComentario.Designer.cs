namespace Views.App.ComentarioView
{
    partial class UComentario
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
            flComentario = new FlowLayoutPanel();
            LComentario = new Label();
            flFecha = new FlowLayoutPanel();
            LFecha = new Label();
            flComentario.SuspendLayout();
            flFecha.SuspendLayout();
            SuspendLayout();
            // 
            // flComentario
            // 
            flComentario.Controls.Add(LComentario);
            flComentario.Dock = DockStyle.Top;
            flComentario.Location = new Point(0, 0);
            flComentario.Name = "flComentario";
            flComentario.Padding = new Padding(10, 0, 0, 0);
            flComentario.Size = new Size(645, 33);
            flComentario.TabIndex = 0;
            flComentario.Paint += flComentario_Paint;
            // 
            // LComentario
            // 
            LComentario.AutoSize = true;
            LComentario.Location = new Point(10, 5);
            LComentario.Margin = new Padding(0, 5, 0, 0);
            LComentario.Name = "LComentario";
            LComentario.Size = new Size(68, 15);
            LComentario.TabIndex = 0;
            LComentario.Text = "comentario";
            // 
            // flFecha
            // 
            flFecha.Controls.Add(LFecha);
            flFecha.Dock = DockStyle.Bottom;
            flFecha.FlowDirection = FlowDirection.RightToLeft;
            flFecha.Location = new Point(0, 32);
            flFecha.Name = "flFecha";
            flFecha.Padding = new Padding(0, 0, 10, 0);
            flFecha.Size = new Size(645, 18);
            flFecha.TabIndex = 1;
            // 
            // LFecha
            // 
            LFecha.AutoSize = true;
            LFecha.BackColor = Color.FromArgb(244, 244, 245);
            LFecha.ForeColor = Color.FromArgb(82, 82, 82);
            LFecha.Location = new Point(594, 0);
            LFecha.Name = "LFecha";
            LFecha.Size = new Size(38, 15);
            LFecha.TabIndex = 0;
            LFecha.Text = "Fecha";
            // 
            // UComentario
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(flFecha);
            Controls.Add(flComentario);
            Name = "UComentario";
            Size = new Size(645, 50);
            Load += UComentario_Load;
            flComentario.ResumeLayout(false);
            flComentario.PerformLayout();
            flFecha.ResumeLayout(false);
            flFecha.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private FlowLayoutPanel flComentario;
        private FlowLayoutPanel flFecha;
        private Label LFecha;
        private Label LComentario;
    }
}
