namespace Views.App.EstudianteView
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
            FLayoutPanel = new FlowLayoutPanel();
            PanelLogo = new Panel();
            LabelLogo = new Label();
            HambugerBar = new PictureBox();
            BtnCandiatas = new Button();
            btnVotarFMC = new Button();
            btnFotogenea = new Button();
            flowLayoutPanel1 = new FlowLayoutPanel();
            button1 = new Button();
            button2 = new Button();
            PanelFound = new Panel();
            panel3 = new Panel();
            PicturePerfil = new PictureBox();
            PanelHeader = new Panel();
            LNombre = new Label();
            PanelMenuBar.SuspendLayout();
            FLayoutPanel.SuspendLayout();
            PanelLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)HambugerBar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)PicturePerfil).BeginInit();
            PanelHeader.SuspendLayout();
            SuspendLayout();
            // 
            // PanelMenuBar
            // 
            PanelMenuBar.BackColor = Color.White;
            PanelMenuBar.Controls.Add(FLayoutPanel);
            PanelMenuBar.Dock = DockStyle.Left;
            PanelMenuBar.Location = new Point(0, 0);
            PanelMenuBar.Name = "PanelMenuBar";
            PanelMenuBar.Size = new Size(242, 661);
            PanelMenuBar.TabIndex = 0;
            PanelMenuBar.Paint += panel1_Paint;
            // 
            // FLayoutPanel
            // 
            FLayoutPanel.Controls.Add(PanelLogo);
            FLayoutPanel.Controls.Add(BtnCandiatas);
            FLayoutPanel.Controls.Add(btnVotarFMC);
            FLayoutPanel.Controls.Add(btnFotogenea);
            FLayoutPanel.Controls.Add(flowLayoutPanel1);
            FLayoutPanel.Controls.Add(button1);
            FLayoutPanel.Controls.Add(button2);
            FLayoutPanel.Dock = DockStyle.Fill;
            FLayoutPanel.FlowDirection = FlowDirection.TopDown;
            FLayoutPanel.Location = new Point(0, 0);
            FLayoutPanel.Name = "FLayoutPanel";
            FLayoutPanel.Size = new Size(242, 661);
            FLayoutPanel.TabIndex = 0;
            // 
            // PanelLogo
            // 
            PanelLogo.Controls.Add(LabelLogo);
            PanelLogo.Controls.Add(HambugerBar);
            PanelLogo.Location = new Point(3, 3);
            PanelLogo.Name = "PanelLogo";
            PanelLogo.Size = new Size(242, 60);
            PanelLogo.TabIndex = 0;
            // 
            // LabelLogo
            // 
            LabelLogo.AutoSize = true;
            LabelLogo.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            LabelLogo.Location = new Point(58, 12);
            LabelLogo.Name = "LabelLogo";
            LabelLogo.Size = new Size(134, 32);
            LabelLogo.TabIndex = 1;
            LabelLogo.Text = "VoteQueen";
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
            // BtnCandiatas
            // 
            BtnCandiatas.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            BtnCandiatas.Image = (Image)resources.GetObject("BtnCandiatas.Image");
            BtnCandiatas.ImageAlign = ContentAlignment.MiddleLeft;
            BtnCandiatas.Location = new Point(0, 66);
            BtnCandiatas.Margin = new Padding(0);
            BtnCandiatas.Name = "BtnCandiatas";
            BtnCandiatas.Padding = new Padding(20, 10, 10, 10);
            BtnCandiatas.Size = new Size(242, 60);
            BtnCandiatas.TabIndex = 2;
            BtnCandiatas.Text = "Candidatas";
            BtnCandiatas.UseVisualStyleBackColor = true;
            BtnCandiatas.Click += BtnCandiatas_Click;
            // 
            // btnVotarFMC
            // 
            btnVotarFMC.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnVotarFMC.Image = (Image)resources.GetObject("btnVotarFMC.Image");
            btnVotarFMC.ImageAlign = ContentAlignment.MiddleLeft;
            btnVotarFMC.Location = new Point(0, 126);
            btnVotarFMC.Margin = new Padding(0);
            btnVotarFMC.Name = "btnVotarFMC";
            btnVotarFMC.Padding = new Padding(20, 10, 10, 10);
            btnVotarFMC.Size = new Size(242, 60);
            btnVotarFMC.TabIndex = 5;
            btnVotarFMC.Text = "Reina FMCF";
            btnVotarFMC.UseVisualStyleBackColor = true;
            // 
            // btnFotogenea
            // 
            btnFotogenea.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnFotogenea.Image = (Image)resources.GetObject("btnFotogenea.Image");
            btnFotogenea.ImageAlign = ContentAlignment.MiddleLeft;
            btnFotogenea.Location = new Point(0, 186);
            btnFotogenea.Margin = new Padding(0);
            btnFotogenea.Name = "btnFotogenea";
            btnFotogenea.Padding = new Padding(20, 10, 10, 10);
            btnFotogenea.Size = new Size(242, 60);
            btnFotogenea.TabIndex = 7;
            btnFotogenea.Text = "Mis Fotogenia";
            btnFotogenea.UseVisualStyleBackColor = true;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Location = new Point(3, 249);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(239, 289);
            flowLayoutPanel1.TabIndex = 6;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.Image = (Image)resources.GetObject("button1.Image");
            button1.ImageAlign = ContentAlignment.MiddleLeft;
            button1.Location = new Point(0, 541);
            button1.Margin = new Padding(0);
            button1.Name = "button1";
            button1.Padding = new Padding(20, 10, 10, 10);
            button1.Size = new Size(242, 60);
            button1.TabIndex = 3;
            button1.Text = "Configuracion";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button2.Image = (Image)resources.GetObject("button2.Image");
            button2.ImageAlign = ContentAlignment.MiddleLeft;
            button2.Location = new Point(0, 601);
            button2.Margin = new Padding(0);
            button2.Name = "button2";
            button2.Padding = new Padding(20, 10, 10, 10);
            button2.Size = new Size(242, 60);
            button2.TabIndex = 4;
            button2.Text = "Cerrar Sesion";
            button2.UseVisualStyleBackColor = true;
            // 
            // PanelFound
            // 
            PanelFound.AutoScroll = true;
            PanelFound.BackColor = Color.White;
            PanelFound.Dock = DockStyle.Fill;
            PanelFound.Location = new Point(242, 63);
            PanelFound.Name = "PanelFound";
            PanelFound.Size = new Size(942, 598);
            PanelFound.TabIndex = 2;
            PanelFound.Paint += PanelFound_Paint;
            // 
            // panel3
            // 
            panel3.Location = new Point(39, 75);
            panel3.Name = "panel3";
            panel3.Size = new Size(945, 588);
            panel3.TabIndex = 2;
            // 
            // PicturePerfil
            // 
            PicturePerfil.ErrorImage = (Image)resources.GetObject("PicturePerfil.ErrorImage");
            PicturePerfil.Image = (Image)resources.GetObject("PicturePerfil.Image");
            PicturePerfil.Location = new Point(870, 7);
            PicturePerfil.Name = "PicturePerfil";
            PicturePerfil.Size = new Size(60, 50);
            PicturePerfil.SizeMode = PictureBoxSizeMode.StretchImage;
            PicturePerfil.TabIndex = 4;
            PicturePerfil.TabStop = false;
            PicturePerfil.Click += PicturePerfil_Click;
            // 
            // PanelHeader
            // 
            PanelHeader.BackColor = Color.White;
            PanelHeader.Controls.Add(LNombre);
            PanelHeader.Controls.Add(PicturePerfil);
            PanelHeader.Controls.Add(panel3);
            PanelHeader.Dock = DockStyle.Top;
            PanelHeader.Location = new Point(242, 0);
            PanelHeader.Name = "PanelHeader";
            PanelHeader.Size = new Size(942, 63);
            PanelHeader.TabIndex = 1;
            // 
            // LNombre
            // 
            LNombre.AutoSize = true;
            LNombre.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            LNombre.Location = new Point(25, 17);
            LNombre.Name = "LNombre";
            LNombre.Size = new Size(110, 30);
            LNombre.TabIndex = 5;
            LNombre.Text = "Estudiante";
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
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Home";
            Load += HomeEstudiante_Load;
            PanelMenuBar.ResumeLayout(false);
            FLayoutPanel.ResumeLayout(false);
            PanelLogo.ResumeLayout(false);
            PanelLogo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)HambugerBar).EndInit();
            ((System.ComponentModel.ISupportInitialize)PicturePerfil).EndInit();
            PanelHeader.ResumeLayout(false);
            PanelHeader.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel PanelMenuBar;
        private Panel PanelLogo;
        private Button BtnCandiatas;
        private Button button2;
        private Button button1;
        private PictureBox HambugerBar;
        private Label LabelLogo;
        private Panel PanelFound;
        private Button btnVotarFMC;
        private FlowLayoutPanel FLayoutPanel;
        private FlowLayoutPanel flowLayoutPanel1;
        private Panel panel3;
        private PictureBox PicturePerfil;
        private Panel PanelHeader;
        private Label LNombre;
        private Button btnFotogenea;
    }
}