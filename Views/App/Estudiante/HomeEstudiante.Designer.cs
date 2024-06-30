namespace UgVoteQueen.PL.App
{
    partial class HomeEstudiante
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HomeEstudiante));
            PanelMenuBar = new Panel();
            PanelHeader = new Panel();
            panel3 = new Panel();
            PanelLogo = new Panel();
            BtnCandiatas = new Button();
            panel2 = new Panel();
            button1 = new Button();
            button2 = new Button();
            HambugerBar = new PictureBox();
            LabelLogo = new Label();
            LabelNombre = new Label();
            PanelFound = new Panel();
            PicturePerfil = new PictureBox();
            PanelMenuBar.SuspendLayout();
            PanelHeader.SuspendLayout();
            PanelLogo.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)HambugerBar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)PicturePerfil).BeginInit();
            SuspendLayout();
            // 
            // PanelMenuBar
            // 
            PanelMenuBar.BackColor = Color.White;
            PanelMenuBar.Controls.Add(button2);
            PanelMenuBar.Controls.Add(button1);
            PanelMenuBar.Controls.Add(PanelLogo);
            PanelMenuBar.Controls.Add(panel2);
            PanelMenuBar.Dock = DockStyle.Left;
            PanelMenuBar.Location = new Point(0, 0);
            PanelMenuBar.Name = "PanelMenuBar";
            PanelMenuBar.Size = new Size(242, 661);
            PanelMenuBar.TabIndex = 0;
            PanelMenuBar.Paint += panel1_Paint;
            // 
            // PanelHeader
            // 
            PanelHeader.BackColor = Color.White;
            PanelHeader.Controls.Add(PicturePerfil);
            PanelHeader.Controls.Add(LabelNombre);
            PanelHeader.Controls.Add(panel3);
            PanelHeader.Dock = DockStyle.Top;
            PanelHeader.Location = new Point(242, 0);
            PanelHeader.Name = "PanelHeader";
            PanelHeader.Size = new Size(942, 75);
            PanelHeader.TabIndex = 1;
            // 
            // panel3
            // 
            panel3.Location = new Point(39, 75);
            panel3.Name = "panel3";
            panel3.Size = new Size(945, 588);
            panel3.TabIndex = 2;
            // 
            // PanelLogo
            // 
            PanelLogo.Controls.Add(LabelLogo);
            PanelLogo.Controls.Add(HambugerBar);
            PanelLogo.Location = new Point(0, 0);
            PanelLogo.Name = "PanelLogo";
            PanelLogo.Size = new Size(242, 75);
            PanelLogo.TabIndex = 0;
            // 
            // BtnCandiatas
            // 
            BtnCandiatas.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            BtnCandiatas.Image = (Image)resources.GetObject("BtnCandiatas.Image");
            BtnCandiatas.ImageAlign = ContentAlignment.MiddleLeft;
            BtnCandiatas.Location = new Point(0, 13);
            BtnCandiatas.Margin = new Padding(10);
            BtnCandiatas.Name = "BtnCandiatas";
            BtnCandiatas.Padding = new Padding(20, 10, 10, 10);
            BtnCandiatas.Size = new Size(242, 66);
            BtnCandiatas.TabIndex = 2;
            BtnCandiatas.Text = "Candidatas";
            BtnCandiatas.UseVisualStyleBackColor = true;
            BtnCandiatas.Click += this.BtnCandiatas_Click_1;
            // 
            // panel2
            // 
            panel2.Controls.Add(BtnCandiatas);
            panel2.Location = new Point(0, 75);
            panel2.Name = "panel2";
            panel2.Size = new Size(242, 66);
            panel2.TabIndex = 1;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.Image = (Image)resources.GetObject("button1.Image");
            button1.ImageAlign = ContentAlignment.MiddleLeft;
            button1.Location = new Point(0, 161);
            button1.Margin = new Padding(10);
            button1.Name = "button1";
            button1.Padding = new Padding(20, 10, 10, 10);
            button1.Size = new Size(242, 66);
            button1.TabIndex = 3;
            button1.Text = "Configuracion";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button2.Image = (Image)resources.GetObject("button2.Image");
            button2.ImageAlign = ContentAlignment.MiddleLeft;
            button2.Location = new Point(0, 597);
            button2.Margin = new Padding(10);
            button2.Name = "button2";
            button2.Padding = new Padding(20, 10, 10, 10);
            button2.Size = new Size(242, 66);
            button2.TabIndex = 4;
            button2.Text = "Cerrar Sesion";
            button2.UseVisualStyleBackColor = true;
            button2.Click += this.button2_Click;
            // 
            // HambugerBar
            // 
            HambugerBar.Image = (Image)resources.GetObject("HambugerBar.Image");
            HambugerBar.Location = new Point(12, 12);
            HambugerBar.Name = "HambugerBar";
            HambugerBar.Size = new Size(40, 40);
            HambugerBar.SizeMode = PictureBoxSizeMode.StretchImage;
            HambugerBar.TabIndex = 0;
            HambugerBar.TabStop = false;
            // 
            // LabelLogo
            // 
            LabelLogo.AutoSize = true;
            LabelLogo.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            LabelLogo.Location = new Point(72, 20);
            LabelLogo.Name = "LabelLogo";
            LabelLogo.Size = new Size(134, 32);
            LabelLogo.TabIndex = 1;
            LabelLogo.Text = "VoteQueen";
            LabelLogo.Click += this.label1_Click;
            // 
            // LabelNombre
            // 
            LabelNombre.AutoSize = true;
            LabelNombre.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            LabelNombre.Location = new Point(520, 22);
            LabelNombre.Name = "LabelNombre";
            LabelNombre.Size = new Size(221, 30);
            LabelNombre.TabIndex = 3;
            LabelNombre.Text = "Nombre de Estudiante";
            // 
            // PanelFound
            // 
            PanelFound.BackColor = Color.White;
            PanelFound.Dock = DockStyle.Fill;
            PanelFound.Location = new Point(242, 75);
            PanelFound.Name = "PanelFound";
            PanelFound.Size = new Size(942, 586);
            PanelFound.TabIndex = 2;
            // 
            // PicturePerfil
            // 
            PicturePerfil.ErrorImage = (Image)resources.GetObject("PicturePerfil.ErrorImage");
            PicturePerfil.Image = (Image)resources.GetObject("PicturePerfil.Image");
            PicturePerfil.Location = new Point(807, 12);
            PicturePerfil.Name = "PicturePerfil";
            PicturePerfil.Size = new Size(60, 50);
            PicturePerfil.TabIndex = 4;
            PicturePerfil.TabStop = false;
            // 
            // HomeEstudiante
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1184, 661);
            Controls.Add(PanelFound);
            Controls.Add(PanelHeader);
            Controls.Add(PanelMenuBar);
            Name = "HomeEstudiante";
            Text = "Home";
            Load += this.HomeEstudiante_Load;
            PanelMenuBar.ResumeLayout(false);
            PanelHeader.ResumeLayout(false);
            PanelHeader.PerformLayout();
            PanelLogo.ResumeLayout(false);
            PanelLogo.PerformLayout();
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)HambugerBar).EndInit();
            ((System.ComponentModel.ISupportInitialize)PicturePerfil).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel PanelMenuBar;
        private Panel PanelHeader;
        private Panel panel3;
        private Panel PanelLogo;
        private Button BtnCandiatas;
        private Panel panel2;
        private Button button2;
        private Button button1;
        private PictureBox HambugerBar;
        private Label LabelLogo;
        private Label LabelNombre;
        private Panel PanelFound;
        private PictureBox PicturePerfil;
    }
}