namespace Views.App.AdministradorView
{
    partial class HomeAdministrador
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HomeAdministrador));
            PanelMenuBar = new Panel();
            FLayoutPanel = new FlowLayoutPanel();
            PanelLogo = new Panel();
            LabelLogo = new Label();
            pictureBox2 = new PictureBox();
            pictureBox1 = new PictureBox();
            HambugerBar = new PictureBox();
            BtnCandiatas = new Button();
            btnVotaciones = new Button();
            btnEstudiantes = new Button();
            btnVerCandidatas = new Button();
            btnFMCF = new Button();
            btnFotogenea = new Button();
            btnLogout = new Button();
            btnConfig = new Button();
            PanelFound = new Panel();
            label2 = new Label();
            label1 = new Label();
            panel3 = new Panel();
            LabelNombre = new Label();
            PicturePerfil = new PictureBox();
            PanelHeader = new Panel();
            flowLayoutPanel2 = new FlowLayoutPanel();
            LUsuario = new Label();
            PanelMenuBar.SuspendLayout();
            FLayoutPanel.SuspendLayout();
            PanelLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)HambugerBar).BeginInit();
            PanelFound.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)PicturePerfil).BeginInit();
            PanelHeader.SuspendLayout();
            flowLayoutPanel2.SuspendLayout();
            SuspendLayout();
            // 
            // PanelMenuBar
            // 
            PanelMenuBar.BackColor = Color.White;
            PanelMenuBar.Controls.Add(FLayoutPanel);
            PanelMenuBar.Controls.Add(btnLogout);
            PanelMenuBar.Controls.Add(btnConfig);
            PanelMenuBar.Dock = DockStyle.Left;
            PanelMenuBar.Location = new Point(0, 0);
            PanelMenuBar.Name = "PanelMenuBar";
            PanelMenuBar.Size = new Size(242, 681);
            PanelMenuBar.TabIndex = 0;
            PanelMenuBar.Paint += panel1_Paint;
            // 
            // FLayoutPanel
            // 
            FLayoutPanel.Controls.Add(PanelLogo);
            FLayoutPanel.Controls.Add(BtnCandiatas);
            FLayoutPanel.Controls.Add(btnVotaciones);
            FLayoutPanel.Controls.Add(btnEstudiantes);
            FLayoutPanel.Controls.Add(btnVerCandidatas);
            FLayoutPanel.Controls.Add(btnFMCF);
            FLayoutPanel.Controls.Add(btnFotogenea);
            FLayoutPanel.FlowDirection = FlowDirection.TopDown;
            FLayoutPanel.Location = new Point(0, 0);
            FLayoutPanel.Name = "FLayoutPanel";
            FLayoutPanel.Padding = new Padding(10);
            FLayoutPanel.Size = new Size(242, 479);
            FLayoutPanel.TabIndex = 0;
            // 
            // PanelLogo
            // 
            PanelLogo.AutoSize = true;
            PanelLogo.Controls.Add(LabelLogo);
            PanelLogo.Controls.Add(pictureBox2);
            PanelLogo.Controls.Add(pictureBox1);
            PanelLogo.Controls.Add(HambugerBar);
            PanelLogo.Dock = DockStyle.Fill;
            PanelLogo.Location = new Point(10, 10);
            PanelLogo.Margin = new Padding(0, 0, 0, 10);
            PanelLogo.Name = "PanelLogo";
            PanelLogo.Size = new Size(212, 55);
            PanelLogo.TabIndex = 0;
            PanelLogo.Paint += PanelLogo_Paint;
            // 
            // LabelLogo
            // 
            LabelLogo.AutoSize = true;
            LabelLogo.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            LabelLogo.ForeColor = Color.FromArgb(9, 9, 11);
            LabelLogo.Location = new Point(58, 12);
            LabelLogo.Name = "LabelLogo";
            LabelLogo.Size = new Size(134, 32);
            LabelLogo.TabIndex = 1;
            LabelLogo.Text = "VoteQueen";
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(12, 7);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(40, 40);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 0;
            pictureBox2.TabStop = false;
            pictureBox2.Click += pictureBox2_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(12, 4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(40, 40);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
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
            BtnCandiatas.AutoSize = true;
            BtnCandiatas.Cursor = Cursors.Hand;
            BtnCandiatas.FlatAppearance.BorderSize = 0;
            BtnCandiatas.FlatStyle = FlatStyle.Flat;
            BtnCandiatas.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            BtnCandiatas.Image = (Image)resources.GetObject("BtnCandiatas.Image");
            BtnCandiatas.ImageAlign = ContentAlignment.MiddleLeft;
            BtnCandiatas.Location = new Point(10, 75);
            BtnCandiatas.Margin = new Padding(0, 0, 0, 10);
            BtnCandiatas.Name = "BtnCandiatas";
            BtnCandiatas.Padding = new Padding(20, 10, 10, 10);
            BtnCandiatas.Size = new Size(212, 52);
            BtnCandiatas.TabIndex = 2;
            BtnCandiatas.Text = "Candidatas";
            BtnCandiatas.UseVisualStyleBackColor = true;
            BtnCandiatas.Click += BtnCandiatas_Click;
            // 
            // btnVotaciones
            // 
            btnVotaciones.Cursor = Cursors.Hand;
            btnVotaciones.FlatAppearance.BorderSize = 0;
            btnVotaciones.FlatStyle = FlatStyle.Flat;
            btnVotaciones.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnVotaciones.Image = (Image)resources.GetObject("btnVotaciones.Image");
            btnVotaciones.ImageAlign = ContentAlignment.MiddleLeft;
            btnVotaciones.Location = new Point(10, 137);
            btnVotaciones.Margin = new Padding(0, 0, 0, 10);
            btnVotaciones.Name = "btnVotaciones";
            btnVotaciones.Padding = new Padding(20, 10, 10, 10);
            btnVotaciones.Size = new Size(212, 52);
            btnVotaciones.TabIndex = 7;
            btnVotaciones.Text = "Votaciones";
            btnVotaciones.UseVisualStyleBackColor = true;
            btnVotaciones.Click += btnVotaciones_Click;
            // 
            // btnEstudiantes
            // 
            btnEstudiantes.Cursor = Cursors.Hand;
            btnEstudiantes.FlatAppearance.BorderSize = 0;
            btnEstudiantes.FlatStyle = FlatStyle.Flat;
            btnEstudiantes.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnEstudiantes.Image = (Image)resources.GetObject("btnEstudiantes.Image");
            btnEstudiantes.ImageAlign = ContentAlignment.MiddleLeft;
            btnEstudiantes.Location = new Point(10, 199);
            btnEstudiantes.Margin = new Padding(0, 0, 0, 10);
            btnEstudiantes.Name = "btnEstudiantes";
            btnEstudiantes.Padding = new Padding(20, 10, 10, 10);
            btnEstudiantes.Size = new Size(212, 52);
            btnEstudiantes.TabIndex = 5;
            btnEstudiantes.Text = "Estudiantes";
            btnEstudiantes.UseVisualStyleBackColor = true;
            btnEstudiantes.Click += btnEstudiantes_Click;
            // 
            // btnVerCandidatas
            // 
            btnVerCandidatas.Cursor = Cursors.Hand;
            btnVerCandidatas.FlatAppearance.BorderSize = 0;
            btnVerCandidatas.FlatStyle = FlatStyle.Flat;
            btnVerCandidatas.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnVerCandidatas.Image = (Image)resources.GetObject("btnVerCandidatas.Image");
            btnVerCandidatas.ImageAlign = ContentAlignment.MiddleLeft;
            btnVerCandidatas.Location = new Point(10, 261);
            btnVerCandidatas.Margin = new Padding(0, 0, 0, 10);
            btnVerCandidatas.Name = "btnVerCandidatas";
            btnVerCandidatas.Padding = new Padding(20, 10, 10, 10);
            btnVerCandidatas.Size = new Size(212, 52);
            btnVerCandidatas.TabIndex = 8;
            btnVerCandidatas.Text = "Candidatas";
            btnVerCandidatas.UseVisualStyleBackColor = true;
            btnVerCandidatas.Click += btnVerCandidatas_Click;
            // 
            // btnFMCF
            // 
            btnFMCF.CausesValidation = false;
            btnFMCF.Cursor = Cursors.Hand;
            btnFMCF.FlatAppearance.BorderSize = 0;
            btnFMCF.FlatStyle = FlatStyle.Flat;
            btnFMCF.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnFMCF.Image = (Image)resources.GetObject("btnFMCF.Image");
            btnFMCF.ImageAlign = ContentAlignment.MiddleLeft;
            btnFMCF.Location = new Point(10, 323);
            btnFMCF.Margin = new Padding(0, 0, 0, 10);
            btnFMCF.Name = "btnFMCF";
            btnFMCF.Padding = new Padding(20, 10, 10, 10);
            btnFMCF.Size = new Size(212, 52);
            btnFMCF.TabIndex = 9;
            btnFMCF.Text = "Vote FMCF";
            btnFMCF.UseVisualStyleBackColor = true;
            btnFMCF.Click += btnFMCF_Click;
            // 
            // btnFotogenea
            // 
            btnFotogenea.CausesValidation = false;
            btnFotogenea.Cursor = Cursors.Hand;
            btnFotogenea.FlatAppearance.BorderSize = 0;
            btnFotogenea.FlatStyle = FlatStyle.Flat;
            btnFotogenea.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnFotogenea.Image = (Image)resources.GetObject("btnFotogenea.Image");
            btnFotogenea.ImageAlign = ContentAlignment.MiddleLeft;
            btnFotogenea.Location = new Point(10, 385);
            btnFotogenea.Margin = new Padding(0, 0, 0, 10);
            btnFotogenea.Name = "btnFotogenea";
            btnFotogenea.Padding = new Padding(20, 10, 10, 10);
            btnFotogenea.Size = new Size(212, 52);
            btnFotogenea.TabIndex = 10;
            btnFotogenea.Text = "Vote FOTO";
            btnFotogenea.UseVisualStyleBackColor = true;
            btnFotogenea.Click += btnFotogenea_Click;
            // 
            // btnLogout
            // 
            btnLogout.Cursor = Cursors.Hand;
            btnLogout.FlatAppearance.BorderSize = 0;
            btnLogout.FlatStyle = FlatStyle.Flat;
            btnLogout.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnLogout.Image = (Image)resources.GetObject("btnLogout.Image");
            btnLogout.ImageAlign = ContentAlignment.MiddleLeft;
            btnLogout.Location = new Point(10, 611);
            btnLogout.Margin = new Padding(0);
            btnLogout.Name = "btnLogout";
            btnLogout.Padding = new Padding(20, 10, 10, 10);
            btnLogout.Size = new Size(212, 52);
            btnLogout.TabIndex = 4;
            btnLogout.Text = "Cerrar Sesion";
            btnLogout.UseVisualStyleBackColor = true;
            btnLogout.Click += btnLogout_Click;
            // 
            // btnConfig
            // 
            btnConfig.Cursor = Cursors.Hand;
            btnConfig.FlatAppearance.BorderSize = 0;
            btnConfig.FlatStyle = FlatStyle.Flat;
            btnConfig.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnConfig.Image = (Image)resources.GetObject("btnConfig.Image");
            btnConfig.ImageAlign = ContentAlignment.MiddleLeft;
            btnConfig.Location = new Point(10, 549);
            btnConfig.Margin = new Padding(0, 0, 0, 10);
            btnConfig.Name = "btnConfig";
            btnConfig.Padding = new Padding(20, 10, 10, 10);
            btnConfig.Size = new Size(212, 52);
            btnConfig.TabIndex = 3;
            btnConfig.Text = "Configuracion";
            btnConfig.UseVisualStyleBackColor = true;
            btnConfig.Click += btnConfig_Click;
            // 
            // PanelFound
            // 
            PanelFound.BackColor = Color.FromArgb(250, 250, 250);
            PanelFound.Controls.Add(label2);
            PanelFound.Controls.Add(label1);
            PanelFound.Dock = DockStyle.Fill;
            PanelFound.Location = new Point(242, 60);
            PanelFound.Name = "PanelFound";
            PanelFound.Size = new Size(1022, 621);
            PanelFound.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("SF Pro Display", 15F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(26, 93);
            label2.Margin = new Padding(0);
            label2.Name = "label2";
            label2.Size = new Size(663, 24);
            label2.TabIndex = 10;
            label2.Text = "En esta aplicacion podras encontrar la lista de candidatas y votar por tu favorita";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("SF Pro Display", 17F, FontStyle.Bold);
            label1.Location = new Point(26, 40);
            label1.Margin = new Padding(0);
            label1.Name = "label1";
            label1.Size = new Size(421, 27);
            label1.TabIndex = 9;
            label1.Text = "Bienvenido a la Aplicacion de VoteQueen";
            // 
            // panel3
            // 
            panel3.Location = new Point(39, 75);
            panel3.Name = "panel3";
            panel3.Size = new Size(945, 588);
            panel3.TabIndex = 2;
            // 
            // LabelNombre
            // 
            LabelNombre.AutoSize = true;
            LabelNombre.Font = new Font("SF Pro Text", 15F, FontStyle.Regular, GraphicsUnit.Point, 0);
            LabelNombre.Location = new Point(761, 20);
            LabelNombre.Margin = new Padding(10, 15, 20, 10);
            LabelNombre.Name = "LabelNombre";
            LabelNombre.Size = new Size(141, 24);
            LabelNombre.TabIndex = 3;
            LabelNombre.Text = "Administrador";
            LabelNombre.Click += LabelNombre_Click;
            // 
            // PicturePerfil
            // 
            PicturePerfil.ErrorImage = (Image)resources.GetObject("PicturePerfil.ErrorImage");
            PicturePerfil.Image = (Image)resources.GetObject("PicturePerfil.Image");
            PicturePerfil.Location = new Point(922, 5);
            PicturePerfil.Margin = new Padding(0);
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
            PanelHeader.Controls.Add(flowLayoutPanel2);
            PanelHeader.Controls.Add(panel3);
            PanelHeader.Dock = DockStyle.Top;
            PanelHeader.Location = new Point(242, 0);
            PanelHeader.Name = "PanelHeader";
            PanelHeader.Size = new Size(1022, 60);
            PanelHeader.TabIndex = 1;
            // 
            // flowLayoutPanel2
            // 
            flowLayoutPanel2.Controls.Add(PicturePerfil);
            flowLayoutPanel2.Controls.Add(LabelNombre);
            flowLayoutPanel2.Controls.Add(LUsuario);
            flowLayoutPanel2.Dock = DockStyle.Fill;
            flowLayoutPanel2.FlowDirection = FlowDirection.RightToLeft;
            flowLayoutPanel2.Location = new Point(0, 0);
            flowLayoutPanel2.Name = "flowLayoutPanel2";
            flowLayoutPanel2.Padding = new Padding(20, 5, 20, 10);
            flowLayoutPanel2.Size = new Size(1022, 60);
            flowLayoutPanel2.TabIndex = 3;
            flowLayoutPanel2.Paint += flowLayoutPanel2_Paint;
            // 
            // LUsuario
            // 
            LUsuario.AutoSize = true;
            LUsuario.Font = new Font("Segoe UI Semibold", 15F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LUsuario.ForeColor = Color.FromArgb(9, 9, 11);
            LUsuario.Location = new Point(660, 15);
            LUsuario.Margin = new Padding(3, 10, 10, 10);
            LUsuario.Name = "LUsuario";
            LUsuario.Size = new Size(81, 28);
            LUsuario.TabIndex = 5;
            LUsuario.Text = "Usuario";
            // 
            // HomeAdministrador
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1264, 681);
            Controls.Add(PanelFound);
            Controls.Add(PanelHeader);
            Controls.Add(PanelMenuBar);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "HomeAdministrador";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Home";
            Load += Home_Load;
            PanelMenuBar.ResumeLayout(false);
            FLayoutPanel.ResumeLayout(false);
            FLayoutPanel.PerformLayout();
            PanelLogo.ResumeLayout(false);
            PanelLogo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)HambugerBar).EndInit();
            PanelFound.ResumeLayout(false);
            PanelFound.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)PicturePerfil).EndInit();
            PanelHeader.ResumeLayout(false);
            flowLayoutPanel2.ResumeLayout(false);
            flowLayoutPanel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel PanelMenuBar;
        private Panel PanelLogo;
        private Button BtnCandiatas;
        private Button btnLogout;
        private Button btnConfig;
        private PictureBox HambugerBar;
        private Label LabelLogo;
        private Panel PanelFound;
        private Button btnEstudiantes;
        private FlowLayoutPanel FLayoutPanel;
        private Panel panel3;
        private Label LabelNombre;
        private PictureBox PicturePerfil;
        private Panel PanelHeader;
        private Button btnVotaciones;
        private PictureBox pictureBox2;
        private PictureBox pictureBox1;
        private FlowLayoutPanel flowLayoutPanel2;
        private Label LUsuario;
        private Button btnVerCandidatas;
        private Button btnFMCF;
        private Button btnFotogenea;
        private Label label2;
        private Label label1;
    }
}