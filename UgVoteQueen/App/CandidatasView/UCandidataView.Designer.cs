namespace Views.App.CandidatasView
{
    partial class UCandidataView
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
            label2 = new Label();
            label1 = new Label();
            flCardCandidatas = new FlowLayoutPanel();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("SF Pro Display", 15F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(32, 66);
            label2.Margin = new Padding(0);
            label2.Name = "label2";
            label2.Size = new Size(379, 24);
            label2.TabIndex = 7;
            label2.Text = "Estas son las candidatas para las Votaciones";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("SF Pro Display", 15F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(32, 29);
            label1.Margin = new Padding(0);
            label1.Name = "label1";
            label1.Size = new Size(362, 24);
            label1.TabIndex = 6;
            label1.Text = "Lista de Candidatas aspirantes a  Reina";
            label1.Click += label1_Click;
            // 
            // flCardCandidatas
            // 
            flCardCandidatas.AutoScroll = true;
            flCardCandidatas.Location = new Point(32, 109);
            flCardCandidatas.Margin = new Padding(0);
            flCardCandidatas.Name = "flCardCandidatas";
            flCardCandidatas.Padding = new Padding(0, 10, 0, 10);
            flCardCandidatas.Size = new Size(961, 481);
            flCardCandidatas.TabIndex = 8;
            flCardCandidatas.Paint += flCardCandidatas_Paint;
            // 
            // UCandidataView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(250, 250, 250);
            Controls.Add(flCardCandidatas);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "UCandidataView";
            Size = new Size(1022, 621);
            Load += UCandidataView_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label2;
        private Label label1;
        private FlowLayoutPanel flCardCandidatas;
    }
}
