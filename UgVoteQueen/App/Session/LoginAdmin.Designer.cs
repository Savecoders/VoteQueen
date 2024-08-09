namespace Views.App.Session
{
    partial class LoginAdmin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginAdmin));
            btnLogin = new Button();
            lLabel = new Label();
            txtCorreo = new TextBox();
            txtPassword = new TextBox();
            label1 = new Label();
            label2 = new Label();
            flowLayoutPanel1 = new FlowLayoutPanel();
            txtNombre = new TextBox();
            label3 = new Label();
            pictureBox1 = new PictureBox();
            flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
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
            btnLogin.Location = new Point(53, 430);
            btnLogin.Margin = new Padding(3, 40, 3, 20);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(420, 50);
            btnLogin.TabIndex = 0;
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
            lLabel.Text = "Administracion";
            lLabel.TextAlign = ContentAlignment.TopCenter;
            lLabel.Click += lLabel_Click;
            // 
            // txtCorreo
            // 
            txtCorreo.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txtCorreo.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtCorreo.Location = new Point(53, 251);
            txtCorreo.Margin = new Padding(3, 20, 3, 3);
            txtCorreo.Multiline = true;
            txtCorreo.Name = "txtCorreo";
            txtCorreo.PlaceholderText = "correo@ug.ud.ec";
            txtCorreo.Size = new Size(420, 36);
            txtCorreo.TabIndex = 3;
            txtCorreo.WordWrap = false;
            txtCorreo.TextChanged += textBox1_TextChanged;
            // 
            // txtPassword
            // 
            txtPassword.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txtPassword.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtPassword.Location = new Point(53, 351);
            txtPassword.Margin = new Padding(3, 20, 3, 3);
            txtPassword.Multiline = true;
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '*';
            txtPassword.Size = new Size(420, 36);
            txtPassword.TabIndex = 4;
            txtPassword.WordWrap = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F);
            label1.Location = new Point(53, 210);
            label1.Name = "label1";
            label1.Size = new Size(146, 21);
            label1.TabIndex = 5;
            label1.Text = "Correo Institucional";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F);
            label2.Location = new Point(53, 130);
            label2.Margin = new Padding(3, 20, 3, 0);
            label2.Name = "label2";
            label2.Size = new Size(68, 21);
            label2.TabIndex = 6;
            label2.Text = "Nombre";
            label2.Click += label2_Click;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.AutoScrollMargin = new Size(10, 10);
            flowLayoutPanel1.AutoSize = true;
            flowLayoutPanel1.Controls.Add(lLabel);
            flowLayoutPanel1.Controls.Add(label2);
            flowLayoutPanel1.Controls.Add(txtNombre);
            flowLayoutPanel1.Controls.Add(label1);
            flowLayoutPanel1.Controls.Add(txtCorreo);
            flowLayoutPanel1.Controls.Add(label3);
            flowLayoutPanel1.Controls.Add(txtPassword);
            flowLayoutPanel1.Controls.Add(btnLogin);
            flowLayoutPanel1.Dock = DockStyle.Right;
            flowLayoutPanel1.FlowDirection = FlowDirection.TopDown;
            flowLayoutPanel1.Location = new Point(718, 20);
            flowLayoutPanel1.Margin = new Padding(10);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Padding = new Padding(50);
            flowLayoutPanel1.Size = new Size(526, 641);
            flowLayoutPanel1.TabIndex = 7;
            // 
            // txtNombre
            // 
            txtNombre.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txtNombre.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtNombre.Location = new Point(53, 171);
            txtNombre.Margin = new Padding(3, 20, 3, 3);
            txtNombre.Multiline = true;
            txtNombre.Name = "txtNombre";
            txtNombre.PlaceholderText = "correo@ug.ud.ec";
            txtNombre.Size = new Size(420, 36);
            txtNombre.TabIndex = 13;
            txtNombre.WordWrap = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F);
            label3.Location = new Point(53, 310);
            label3.Margin = new Padding(3, 20, 3, 0);
            label3.Name = "label3";
            label3.Size = new Size(76, 21);
            label3.TabIndex = 12;
            label3.Text = "Password";
            // 
            // pictureBox1
            // 
            pictureBox1.Dock = DockStyle.Fill;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(20, 20);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(698, 641);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 8;
            pictureBox1.TabStop = false;
            // 
            // LoginAdmin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 254, 255);
            ClientSize = new Size(1264, 681);
            Controls.Add(pictureBox1);
            Controls.Add(flowLayoutPanel1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "LoginAdmin";
            Padding = new Padding(20);
            StartPosition = FormStartPosition.CenterScreen;
            Load += Login_Load;
            flowLayoutPanel1.ResumeLayout(false);
            flowLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label lLabel;
        private Label label1;
        private Label label2;
        private FlowLayoutPanel flowLayoutPanel1;
        public Button btnLogin;
        public TextBox txtCorreo;
        public TextBox txtPassword;
        private Label label3;
        public TextBox txtNombre;
        private PictureBox pictureBox1;
    }
}
