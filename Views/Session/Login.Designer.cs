namespace UgVoteQueen.PL.Session
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
            btnRegister = new Button();
            btnLogin = new Button();
            lLabel = new Label();
            BoxCorreo = new TextBox();
            BoxPassword = new TextBox();
            label1 = new Label();
            label2 = new Label();
            flowLayoutPanel1 = new FlowLayoutPanel();
            flowLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // btnRegister
            // 
            btnRegister.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            btnRegister.AutoSize = true;
            btnRegister.BackColor = Color.White;
            btnRegister.FlatAppearance.BorderColor = Color.DimGray;
            btnRegister.FlatAppearance.MouseDownBackColor = Color.White;
            btnRegister.FlatAppearance.MouseOverBackColor = Color.White;
            btnRegister.FlatStyle = FlatStyle.Flat;
            btnRegister.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnRegister.ForeColor = Color.FromArgb(12, 23, 42);
            btnRegister.Location = new Point(53, 383);
            btnRegister.Name = "btnRegister";
            btnRegister.Size = new Size(420, 50);
            btnRegister.TabIndex = 1;
            btnRegister.Text = "Registrate";
            btnRegister.UseVisualStyleBackColor = false;
            btnRegister.Click += btnRegister_Click;
            // 
            // btnLogin
            // 
            btnLogin.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            btnLogin.AutoSize = true;
            btnLogin.BackColor = Color.FromArgb(12, 23, 42);
            btnLogin.BackgroundImageLayout = ImageLayout.Center;
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
            lLabel.Text = "Login";
            lLabel.TextAlign = ContentAlignment.TopCenter;
            lLabel.Click += lLabel_Click;
            // 
            // BoxCorreo
            // 
            BoxCorreo.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            BoxCorreo.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            BoxCorreo.Location = new Point(53, 151);
            BoxCorreo.Margin = new Padding(3, 20, 3, 3);
            BoxCorreo.Multiline = true;
            BoxCorreo.Name = "BoxCorreo";
            BoxCorreo.PlaceholderText = "correo@ug.ud.ec";
            BoxCorreo.Size = new Size(420, 36);
            BoxCorreo.TabIndex = 3;
            BoxCorreo.WordWrap = false;
            BoxCorreo.TextChanged += textBox1_TextChanged;
            // 
            // BoxPassword
            // 
            BoxPassword.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            BoxPassword.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            BoxPassword.Location = new Point(53, 251);
            BoxPassword.Margin = new Padding(3, 20, 3, 3);
            BoxPassword.Multiline = true;
            BoxPassword.Name = "BoxPassword";
            BoxPassword.PasswordChar = '*';
            BoxPassword.Size = new Size(420, 36);
            BoxPassword.TabIndex = 4;
            BoxPassword.WordWrap = false;
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
            flowLayoutPanel1.AutoScrollMargin = new Size(12, 12);
            flowLayoutPanel1.AutoSize = true;
            flowLayoutPanel1.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            flowLayoutPanel1.Controls.Add(lLabel);
            flowLayoutPanel1.Controls.Add(label1);
            flowLayoutPanel1.Controls.Add(BoxCorreo);
            flowLayoutPanel1.Controls.Add(label2);
            flowLayoutPanel1.Controls.Add(BoxPassword);
            flowLayoutPanel1.Controls.Add(btnLogin);
            flowLayoutPanel1.Controls.Add(btnRegister);
            flowLayoutPanel1.FlowDirection = FlowDirection.TopDown;
            flowLayoutPanel1.Location = new Point(328, 66);
            flowLayoutPanel1.Margin = new Padding(10);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Padding = new Padding(50);
            flowLayoutPanel1.Size = new Size(526, 486);
            flowLayoutPanel1.TabIndex = 7;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 254, 255);
            Controls.Add(flowLayoutPanel1);
            Name = "Login";
            Size = new Size(1184, 661);
            Load += Login_Load;
            flowLayoutPanel1.ResumeLayout(false);
            flowLayoutPanel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnRegister;
        private Button btnLogin;
        private Label lLabel;
        private TextBox BoxCorreo;
        private TextBox BoxPassword;
        private Label label1;
        private Label label2;
        private FlowLayoutPanel flowLayoutPanel1;
    }
}
