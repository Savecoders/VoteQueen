namespace UgVoteQueen.PL.App
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
            button2 = new Button();
            button1 = new Button();
            PanelLogo = new Panel();
            LabelLogo = new Label();
            HambugerBar = new PictureBox();
            panel2 = new Panel();
            BtnCandiatas = new Button();
            PanelHeader = new Panel();
            PicturePerfil = new PictureBox();
            LabelNombre = new Label();
            panel3 = new Panel();
            PanelFound = new Panel();
            PanelMenuBar.SuspendLayout();
            PanelLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)HambugerBar).BeginInit();
            panel2.SuspendLayout();
            PanelHeader.SuspendLayout();
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
            // PanelLogo
            // 
            PanelLogo.Controls.Add(LabelLogo);
            PanelLogo.Controls.Add(HambugerBar);
            PanelLogo.Location = new Point(0, 0);
            PanelLogo.Name = "PanelLogo";
            PanelLogo.Size = new Size(242, 75);
            PanelLogo.TabIndex = 0;
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
            // panel2
            // 
            panel2.Controls.Add(BtnCandiatas);
            panel2.Location = new Point(0, 75);
            panel2.Name = "panel2";
            panel2.Size = new Size(242, 66);
            panel2.TabIndex = 1;
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
            // LabelNombre
            // 
            LabelNombre.AutoSize = true;
            LabelNombre.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            LabelNombre.Location = new Point(520, 22);
            LabelNombre.Name = "LabelNombre";
            LabelNombre.Size = new Size(144, 30);
            LabelNombre.TabIndex = 3;
            LabelNombre.Text = "Administrador";
            LabelNombre.Click += LabelNombre_Click;
            // 
            // panel3
            // 
            panel3.Location = new Point(39, 75);
            panel3.Name = "panel3";
            panel3.Size = new Size(945, 588);
            panel3.TabIndex = 2;
            // 
            // PanelFound
            // 
            PanelFound.BackColor = Color.White;
            PanelFound.Dock = DockStyle.Fill;
            PanelFound.Location = new Point(242, 75);
            PanelFound.Name = "PanelFound";
            PanelFound.Size = new Size(942, 586);
            PanelFound.TabIndex = 2;
            PanelFound.Paint += PanelFound_Paint;
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
            PanelLogo.ResumeLayout(false);
            PanelLogo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)HambugerBar).EndInit();
            panel2.ResumeLayout(false);
            PanelHeader.ResumeLayout(false);
            PanelHeader.PerformLayout();
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