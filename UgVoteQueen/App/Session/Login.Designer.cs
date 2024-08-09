namespace Views.App.Session
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            btnLogin = new Button();
            lLabel = new Label();
            TxtCorreo = new TextBox();
            TxtPassword = new TextBox();
            label1 = new Label();
            label2 = new Label();
            flowLayoutPanel1 = new FlowLayoutPanel();
            LLSesion = new LinkLabel();
            ContainerButton = new FlowLayoutPanel();
            BtnAdministrador = new Button();
            flowLayoutPanel2 = new FlowLayoutPanel();
            flowLayoutPanel1.SuspendLayout();
            ContainerButton.SuspendLayout();
            SuspendLayout();
            // 
            // btnLogin
            // 
            btnLogin.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            btnLogin.AutoSize = true;
            btnLogin.BackColor = Color.FromArgb(12, 23, 42);
            btnLogin.BackgroundImageLayout = ImageLayout.Center;
            btnLogin.Cursor = Cursors.Hand;
            btnLogin.FlatAppearance.BorderColor = Color.FromArgb(12, 23, 42);
            btnLogin.FlatAppearance.BorderSize = 3;
            btnLogin.FlatAppearance.MouseDownBackColor = Color.FromArgb(12, 23, 42);
            btnLogin.FlatAppearance.MouseOverBackColor = Color.FromArgb(12, 23, 42);
            btnLogin.FlatStyle = FlatStyle.Flat;
            btnLogin.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLogin.ForeColor = Color.White;
            btnLogin.Location = new Point(53, 310);
            btnLogin.Margin = new Padding(3, 20, 3, 20);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(420, 50);
            btnLogin.TabIndex = 3;
            btnLogin.Text = "Iniciar Sesion";
            btnLogin.UseVisualStyleBackColor = false;
            btnLogin.Click += btnLogin_Click;
            // 
            // lLabel
            // 
            lLabel.AutoSize = true;
            lLabel.Dock = DockStyle.Top;
            lLabel.Font = new Font("Yu Gothic UI", 21.75F, FontStyle.Bold);
            lLabel.ForeColor = Color.FromArgb(100, 116, 139);
            lLabel.Location = new Point(53, 50);
            lLabel.Margin = new Padding(3, 0, 3, 20);
            lLabel.Name = "lLabel";
            lLabel.Size = new Size(420, 40);
            lLabel.TabIndex = 2;
            lLabel.Text = "Login";
            lLabel.TextAlign = ContentAlignment.TopCenter;
            lLabel.Click += lLabel_Click;
            // 
            // TxtCorreo
            // 
            TxtCorreo.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            TxtCorreo.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            TxtCorreo.Location = new Point(53, 151);
            TxtCorreo.Margin = new Padding(3, 20, 3, 3);
            TxtCorreo.Multiline = true;
            TxtCorreo.Name = "TxtCorreo";
            TxtCorreo.PlaceholderText = "correo@ug.ud.ec";
            TxtCorreo.Size = new Size(420, 36);
            TxtCorreo.TabIndex = 1;
            TxtCorreo.WordWrap = false;
            TxtCorreo.TextChanged += textBox1_TextChanged;
            // 
            // TxtPassword
            // 
            TxtPassword.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            TxtPassword.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            TxtPassword.Location = new Point(53, 251);
            TxtPassword.Margin = new Padding(3, 20, 3, 3);
            TxtPassword.Multiline = true;
            TxtPassword.Name = "TxtPassword";
            TxtPassword.PasswordChar = '*';
            TxtPassword.Size = new Size(420, 36);
            TxtPassword.TabIndex = 2;
            TxtPassword.WordWrap = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F);
            label1.Location = new Point(53, 110);
            label1.Name = "label1";
            label1.Size = new Size(146, 21);
            label1.TabIndex = 5;
            label1.Text = "Correo Institucional";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F);
            label2.Location = new Point(53, 210);
            label2.Margin = new Padding(3, 20, 3, 0);
            label2.Name = "label2";
            label2.Size = new Size(76, 21);
            label2.TabIndex = 6;
            label2.Text = "Password";
            label2.Click += label2_Click;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            flowLayoutPanel1.AutoScroll = true;
            flowLayoutPanel1.AutoScrollMargin = new Size(10, 10);
            flowLayoutPanel1.AutoSize = true;
            flowLayoutPanel1.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            flowLayoutPanel1.Controls.Add(lLabel);
            flowLayoutPanel1.Controls.Add(label1);
            flowLayoutPanel1.Controls.Add(TxtCorreo);
            flowLayoutPanel1.Controls.Add(label2);
            flowLayoutPanel1.Controls.Add(TxtPassword);
            flowLayoutPanel1.Controls.Add(btnLogin);
            flowLayoutPanel1.Controls.Add(LLSesion);
            flowLayoutPanel1.FlowDirection = FlowDirection.TopDown;
            flowLayoutPanel1.Location = new Point(385, 85);
            flowLayoutPanel1.Margin = new Padding(10);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Padding = new Padding(50);
            flowLayoutPanel1.Size = new Size(526, 451);
            flowLayoutPanel1.TabIndex = 7;
            flowLayoutPanel1.Paint += flowLayoutPanel1_Paint_1;
            // 
            // LLSesion
            // 
            LLSesion.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            LLSesion.AutoSize = true;
            LLSesion.Cursor = Cursors.Hand;
            LLSesion.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            LLSesion.LinkColor = Color.FromArgb(4, 121, 246);
            LLSesion.Location = new Point(53, 380);
            LLSesion.Name = "LLSesion";
            LLSesion.RightToLeft = RightToLeft.Yes;
            LLSesion.Size = new Size(420, 21);
            LLSesion.TabIndex = 11;
            LLSesion.TabStop = true;
            LLSesion.Text = "Si no tienes Cuenta, Registrate";
            LLSesion.TextAlign = ContentAlignment.MiddleCenter;
            LLSesion.LinkClicked += LLSesion_LinkClicked;
            // 
            // ContainerButton
            // 
            ContainerButton.AutoSize = true;
            ContainerButton.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            ContainerButton.Controls.Add(BtnAdministrador);
            ContainerButton.Dock = DockStyle.Bottom;
            ContainerButton.FlowDirection = FlowDirection.RightToLeft;
            ContainerButton.Location = new Point(0, 612);
            ContainerButton.Margin = new Padding(10);
            ContainerButton.Name = "ContainerButton";
            ContainerButton.Padding = new Padding(10);
            ContainerButton.Size = new Size(1264, 69);
            ContainerButton.TabIndex = 8;
            // 
            // BtnAdministrador
            // 
            BtnAdministrador.Cursor = Cursors.Hand;
            BtnAdministrador.Location = new Point(981, 13);
            BtnAdministrador.Name = "BtnAdministrador";
            BtnAdministrador.Size = new Size(260, 43);
            BtnAdministrador.TabIndex = 0;
            BtnAdministrador.Text = "Modo Administrador";
            BtnAdministrador.UseVisualStyleBackColor = true;
            BtnAdministrador.Click += BtnAdministrador_Click;
            // 
            // flowLayoutPanel2
            // 
            flowLayoutPanel2.AutoSize = true;
            flowLayoutPanel2.Dock = DockStyle.Bottom;
            flowLayoutPanel2.FlowDirection = FlowDirection.RightToLeft;
            flowLayoutPanel2.Location = new Point(0, 681);
            flowLayoutPanel2.Name = "flowLayoutPanel2";
            flowLayoutPanel2.Size = new Size(1264, 0);
            flowLayoutPanel2.TabIndex = 9;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 254, 255);
            ClientSize = new Size(1264, 681);
            Controls.Add(ContainerButton);
            Controls.Add(flowLayoutPanel2);
            Controls.Add(flowLayoutPanel1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Login";
            StartPosition = FormStartPosition.CenterScreen;
            Load += Login_Load;
            flowLayoutPanel1.ResumeLayout(false);
            flowLayoutPanel1.PerformLayout();
            ContainerButton.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label lLabel;
        private Label label1;
        private Label label2;
        private FlowLayoutPanel flowLayoutPanel1;
        private LinkLabel LLSesion;
        public Button btnLogin;
        public TextBox TxtCorreo;
        public TextBox TxtPassword;
        private FlowLayoutPanel ContainerButton;
        private Button BtnAdministrador;
        private FlowLayoutPanel flowLayoutPanel2;
    }
}
