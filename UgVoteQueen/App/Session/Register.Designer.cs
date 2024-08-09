namespace Views.App.Session
{
    partial class Register
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Register));
            Container = new FlowLayoutPanel();
            lLabel = new Label();
            LNombre = new Label();
            TxtNombre = new TextBox();
            LCorreo = new Label();
            TxtCorreo = new TextBox();
            label1 = new Label();
            CmbMatricula = new ComboBox();
            LPassword = new Label();
            TxtPassword = new TextBox();
            flowLayoutPanel2 = new FlowLayoutPanel();
            lIngresarImagen = new Label();
            BtnSubirImagen = new Button();
            BtnRegister = new Button();
            LLSesion = new LinkLabel();
            notifyIcon1 = new NotifyIcon(components);
            pictureBox1 = new PictureBox();
            Container.SuspendLayout();
            flowLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // Container
            // 
            Container.AutoSize = true;
            Container.Controls.Add(lLabel);
            Container.Controls.Add(LNombre);
            Container.Controls.Add(TxtNombre);
            Container.Controls.Add(LCorreo);
            Container.Controls.Add(TxtCorreo);
            Container.Controls.Add(label1);
            Container.Controls.Add(CmbMatricula);
            Container.Controls.Add(LPassword);
            Container.Controls.Add(TxtPassword);
            Container.Controls.Add(flowLayoutPanel2);
            Container.Controls.Add(BtnRegister);
            Container.Controls.Add(LLSesion);
            Container.Dock = DockStyle.Right;
            Container.FlowDirection = FlowDirection.TopDown;
            Container.Location = new Point(718, 20);
            Container.Margin = new Padding(10);
            Container.Name = "Container";
            Container.Padding = new Padding(50, 20, 50, 50);
            Container.Size = new Size(526, 641);
            Container.TabIndex = 8;
            // 
            // lLabel
            // 
            lLabel.AutoSize = true;
            lLabel.Dock = DockStyle.Top;
            lLabel.Font = new Font("Yu Gothic UI", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lLabel.ForeColor = Color.FromArgb(100, 116, 139);
            lLabel.Location = new Point(53, 20);
            lLabel.Margin = new Padding(3, 0, 3, 10);
            lLabel.Name = "lLabel";
            lLabel.Size = new Size(420, 40);
            lLabel.TabIndex = 2;
            lLabel.Text = "Registrase";
            lLabel.TextAlign = ContentAlignment.TopCenter;
            // 
            // LNombre
            // 
            LNombre.AutoSize = true;
            LNombre.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            LNombre.ForeColor = Color.FromArgb(12, 23, 42);
            LNombre.Location = new Point(53, 80);
            LNombre.Margin = new Padding(3, 10, 3, 3);
            LNombre.Name = "LNombre";
            LNombre.Size = new Size(148, 21);
            LNombre.TabIndex = 6;
            LNombre.Text = "Nombre Completo";
            // 
            // TxtNombre
            // 
            TxtNombre.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            TxtNombre.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            TxtNombre.ForeColor = Color.FromArgb(15, 23, 42);
            TxtNombre.Location = new Point(53, 114);
            TxtNombre.Margin = new Padding(3, 10, 3, 3);
            TxtNombre.Multiline = true;
            TxtNombre.Name = "TxtNombre";
            TxtNombre.Size = new Size(420, 36);
            TxtNombre.TabIndex = 1;
            TxtNombre.WordWrap = false;
            TxtNombre.TextChanged += textBox3_TextChanged;
            // 
            // LCorreo
            // 
            LCorreo.AutoSize = true;
            LCorreo.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            LCorreo.ForeColor = Color.FromArgb(12, 23, 42);
            LCorreo.Location = new Point(53, 163);
            LCorreo.Margin = new Padding(3, 10, 3, 0);
            LCorreo.Name = "LCorreo";
            LCorreo.Size = new Size(154, 21);
            LCorreo.TabIndex = 5;
            LCorreo.Text = "Correo Institucional";
            // 
            // TxtCorreo
            // 
            TxtCorreo.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            TxtCorreo.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            TxtCorreo.ForeColor = Color.FromArgb(15, 23, 42);
            TxtCorreo.Location = new Point(53, 194);
            TxtCorreo.Margin = new Padding(3, 10, 3, 3);
            TxtCorreo.Multiline = true;
            TxtCorreo.Name = "TxtCorreo";
            TxtCorreo.PlaceholderText = "correo@ug.ud.ec";
            TxtCorreo.Size = new Size(420, 36);
            TxtCorreo.TabIndex = 2;
            TxtCorreo.WordWrap = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            label1.ForeColor = Color.FromArgb(12, 23, 42);
            label1.Location = new Point(53, 243);
            label1.Margin = new Padding(3, 10, 3, 3);
            label1.Name = "label1";
            label1.Size = new Size(78, 21);
            label1.TabIndex = 11;
            label1.Text = "Matricula";
            // 
            // CmbMatricula
            // 
            CmbMatricula.Dock = DockStyle.Fill;
            CmbMatricula.FlatStyle = FlatStyle.System;
            CmbMatricula.Font = new Font("Segoe UI", 13F);
            CmbMatricula.FormattingEnabled = true;
            CmbMatricula.Items.AddRange(new object[] { "SOF2024C1", "SOF2024C2" });
            CmbMatricula.Location = new Point(53, 277);
            CmbMatricula.Margin = new Padding(3, 10, 3, 0);
            CmbMatricula.Name = "CmbMatricula";
            CmbMatricula.Size = new Size(420, 31);
            CmbMatricula.TabIndex = 3;
            // 
            // LPassword
            // 
            LPassword.AutoSize = true;
            LPassword.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            LPassword.ForeColor = Color.FromArgb(12, 23, 42);
            LPassword.Location = new Point(53, 318);
            LPassword.Margin = new Padding(3, 10, 3, 3);
            LPassword.Name = "LPassword";
            LPassword.Size = new Size(79, 21);
            LPassword.TabIndex = 8;
            LPassword.Text = "Password";
            // 
            // TxtPassword
            // 
            TxtPassword.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            TxtPassword.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            TxtPassword.Location = new Point(53, 352);
            TxtPassword.Margin = new Padding(3, 10, 3, 20);
            TxtPassword.Multiline = true;
            TxtPassword.Name = "TxtPassword";
            TxtPassword.PasswordChar = '*';
            TxtPassword.Size = new Size(420, 36);
            TxtPassword.TabIndex = 4;
            TxtPassword.WordWrap = false;
            // 
            // flowLayoutPanel2
            // 
            flowLayoutPanel2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            flowLayoutPanel2.Controls.Add(lIngresarImagen);
            flowLayoutPanel2.Controls.Add(BtnSubirImagen);
            flowLayoutPanel2.Location = new Point(50, 408);
            flowLayoutPanel2.Margin = new Padding(0, 0, 0, 20);
            flowLayoutPanel2.Name = "flowLayoutPanel2";
            flowLayoutPanel2.Size = new Size(426, 36);
            flowLayoutPanel2.TabIndex = 9;
            // 
            // lIngresarImagen
            // 
            lIngresarImagen.AccessibleRole = AccessibleRole.TitleBar;
            lIngresarImagen.AutoSize = true;
            lIngresarImagen.Dock = DockStyle.Fill;
            lIngresarImagen.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lIngresarImagen.ForeColor = Color.FromArgb(12, 23, 42);
            lIngresarImagen.Location = new Point(3, 0);
            lIngresarImagen.Margin = new Padding(3, 0, 20, 0);
            lIngresarImagen.Name = "lIngresarImagen";
            lIngresarImagen.Size = new Size(128, 36);
            lIngresarImagen.TabIndex = 1;
            lIngresarImagen.Text = "Ingresar Imagen";
            lIngresarImagen.TextAlign = ContentAlignment.MiddleCenter;
            lIngresarImagen.UseCompatibleTextRendering = true;
            lIngresarImagen.Click += label1_Click_1;
            // 
            // BtnSubirImagen
            // 
            BtnSubirImagen.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            BtnSubirImagen.AutoSize = true;
            BtnSubirImagen.Cursor = Cursors.Hand;
            BtnSubirImagen.FlatStyle = FlatStyle.Flat;
            BtnSubirImagen.Location = new Point(151, 0);
            BtnSubirImagen.Margin = new Padding(0);
            BtnSubirImagen.Name = "BtnSubirImagen";
            BtnSubirImagen.Size = new Size(272, 36);
            BtnSubirImagen.TabIndex = 5;
            BtnSubirImagen.Text = "Subir Foto de Perfil";
            BtnSubirImagen.UseVisualStyleBackColor = true;
            BtnSubirImagen.Click += BtnSubirImagen_Click;
            // 
            // BtnRegister
            // 
            BtnRegister.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            BtnRegister.AutoSize = true;
            BtnRegister.BackColor = Color.FromArgb(12, 23, 42);
            BtnRegister.BackgroundImageLayout = ImageLayout.Center;
            BtnRegister.Cursor = Cursors.Hand;
            BtnRegister.FlatAppearance.BorderColor = Color.FromArgb(12, 23, 42);
            BtnRegister.FlatAppearance.BorderSize = 3;
            BtnRegister.FlatAppearance.MouseDownBackColor = Color.FromArgb(12, 23, 42);
            BtnRegister.FlatAppearance.MouseOverBackColor = Color.FromArgb(12, 23, 42);
            BtnRegister.FlatStyle = FlatStyle.Flat;
            BtnRegister.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BtnRegister.ForeColor = Color.White;
            BtnRegister.Location = new Point(53, 474);
            BtnRegister.Margin = new Padding(3, 10, 3, 3);
            BtnRegister.Name = "BtnRegister";
            BtnRegister.Size = new Size(420, 50);
            BtnRegister.TabIndex = 6;
            BtnRegister.Text = "Registrate";
            BtnRegister.UseVisualStyleBackColor = false;
            BtnRegister.Click += BtnRegister_Click;
            // 
            // LLSesion
            // 
            LLSesion.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            LLSesion.AutoSize = true;
            LLSesion.Cursor = Cursors.Hand;
            LLSesion.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            LLSesion.LinkColor = Color.FromArgb(4, 121, 246);
            LLSesion.Location = new Point(53, 537);
            LLSesion.Margin = new Padding(3, 10, 3, 3);
            LLSesion.Name = "LLSesion";
            LLSesion.RightToLeft = RightToLeft.Yes;
            LLSesion.Size = new Size(420, 21);
            LLSesion.TabIndex = 10;
            LLSesion.TabStop = true;
            LLSesion.Text = "Estudiante si ya te registrate Inicia Sesion";
            LLSesion.TextAlign = ContentAlignment.MiddleCenter;
            LLSesion.LinkClicked += LLSesion_LinkClicked;
            // 
            // notifyIcon1
            // 
            notifyIcon1.Icon = (Icon)resources.GetObject("notifyIcon1.Icon");
            notifyIcon1.Visible = true;
            // 
            // pictureBox1
            // 
            pictureBox1.Dock = DockStyle.Fill;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(20, 20);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(698, 641);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 9;
            pictureBox1.TabStop = false;
            // 
            // Register
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 254, 255);
            ClientSize = new Size(1264, 681);
            Controls.Add(pictureBox1);
            Controls.Add(Container);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(0);
            Name = "Register";
            Padding = new Padding(20);
            StartPosition = FormStartPosition.CenterScreen;
            Container.ResumeLayout(false);
            Container.PerformLayout();
            flowLayoutPanel2.ResumeLayout(false);
            flowLayoutPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private FlowLayoutPanel Container;
        private Label LCorreo;
        private Label LNombre;
        private Label LPassword;
        private FlowLayoutPanel flowLayoutPanel2;
        private Label lIngresarImagen;
        private LinkLabel LLSesion;
        private NotifyIcon notifyIcon1;
        private PictureBox pictureBox1;
        public TextBox TxtCorreo;
        public TextBox TxtNombre;
        public TextBox TxtPassword;
        public Button BtnRegister;
        public Button BtnSubirImagen;
        private Label lLabel;
        private Label label1;
        private ComboBox CmbMatricula;
    }
}
