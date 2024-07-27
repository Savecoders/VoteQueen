namespace Views.App.Administrador
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
            HambugerBar = new PictureBox();
            BtnCandiatas = new Button();
            btnVotaciones = new Button();
            btnEstudiantes = new Button();
            flowLayoutPanel1 = new FlowLayoutPanel();
            button1 = new Button();
            button2 = new Button();
            PanelFound = new Panel();
            panel3 = new Panel();
            LabelNombre = new Label();
            PicturePerfil = new PictureBox();
            PanelHeader = new Panel();
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
            FLayoutPanel.Controls.Add(btnVotaciones);
            FLayoutPanel.Controls.Add(btnEstudiantes);
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
            // 
            // btnVotaciones
            // 
            btnVotaciones.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnVotaciones.Image = (Image)resources.GetObject("btnVotaciones.Image");
            btnVotaciones.ImageAlign = ContentAlignment.MiddleLeft;
            btnVotaciones.Location = new Point(0, 126);
            btnVotaciones.Margin = new Padding(0);
            btnVotaciones.Name = "btnVotaciones";
            btnVotaciones.Padding = new Padding(20, 10, 10, 10);
            btnVotaciones.Size = new Size(242, 60);
            btnVotaciones.TabIndex = 7;
            btnVotaciones.Text = "Votaciones";
            btnVotaciones.UseVisualStyleBackColor = true;
            // 
            // btnEstudiantes
            // 
            btnEstudiantes.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnEstudiantes.Image = (Image)resources.GetObject("btnEstudiantes.Image");
            btnEstudiantes.ImageAlign = ContentAlignment.MiddleLeft;
            btnEstudiantes.Location = new Point(0, 186);
            btnEstudiantes.Margin = new Padding(0);
            btnEstudiantes.Name = "btnEstudiantes";
            btnEstudiantes.Padding = new Padding(20, 10, 10, 10);
            btnEstudiantes.Size = new Size(242, 60);
            btnEstudiantes.TabIndex = 5;
            btnEstudiantes.Text = "Estudiantes";
            btnEstudiantes.UseVisualStyleBackColor = true;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Location = new Point(3, 249);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(239, 288);
            flowLayoutPanel1.TabIndex = 6;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.Image = (Image)resources.GetObject("button1.Image");
            button1.ImageAlign = ContentAlignment.MiddleLeft;
            button1.Location = new Point(0, 540);
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
            button2.Location = new Point(0, 600);
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
            // LabelNombre
            // 
            LabelNombre.AutoSize = true;
            LabelNombre.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            LabelNombre.Location = new Point(22, 15);
            LabelNombre.Name = "LabelNombre";
            LabelNombre.Size = new Size(144, 30);
            LabelNombre.TabIndex = 3;
            LabelNombre.Text = "Administrador";
            LabelNombre.Click += LabelNombre_Click;
            // 
            // PicturePerfil
            // 
            PicturePerfil.ErrorImage = (Image)resources.GetObject("PicturePerfil.ErrorImage");
            PicturePerfil.Image = (Image)resources.GetObject("PicturePerfil.Image");
            PicturePerfil.Location = new Point(852, 7);
            PicturePerfil.Name = "PicturePerfil";
            PicturePerfil.Size = new Size(60, 50);
            PicturePerfil.TabIndex = 4;
            PicturePerfil.TabStop = false;
            PicturePerfil.Click += PicturePerfil_Click;
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
            PanelHeader.Size = new Size(942, 63);
            PanelHeader.TabIndex = 1;
            // 
            // HomeAdministrador
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1184, 661);
            Controls.Add(PanelFound);
            Controls.Add(PanelHeader);
            Controls.Add(PanelMenuBar);
            Name = "HomeAdministrador";
            Text = "Home";
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
        private Button btnEstudiantes;
        private FlowLayoutPanel FLayoutPanel;
        private FlowLayoutPanel flowLayoutPanel1;
        private Panel panel3;
        private Label LabelNombre;
        private PictureBox PicturePerfil;
        private Panel PanelHeader;
        private Button btnVotaciones;
    }
}