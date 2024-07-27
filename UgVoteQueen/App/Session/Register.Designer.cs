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
            flowLayoutPanel1 = new FlowLayoutPanel();
            lLabel = new Label();
            LNombre = new Label();
            BoxNombre = new TextBox();
            LCorreo = new Label();
            BoxCorreo = new TextBox();
            LPassword = new Label();
            BoxPassword = new TextBox();
            flowLayoutPanel2 = new FlowLayoutPanel();
            lIngresarImagen = new Label();
            BtnSubirImagen = new Button();
            BtnRegister = new Button();
            LLSesion = new LinkLabel();
            notifyIcon1 = new NotifyIcon(components);
            flowLayoutPanel1.SuspendLayout();
            flowLayoutPanel2.SuspendLayout();
            SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.AutoScrollMargin = new Size(12, 12);
            flowLayoutPanel1.AutoSize = true;
            flowLayoutPanel1.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            flowLayoutPanel1.Controls.Add(lLabel);
            flowLayoutPanel1.Controls.Add(LNombre);
            flowLayoutPanel1.Controls.Add(BoxNombre);
            flowLayoutPanel1.Controls.Add(LCorreo);
            flowLayoutPanel1.Controls.Add(BoxCorreo);
            flowLayoutPanel1.Controls.Add(LPassword);
            flowLayoutPanel1.Controls.Add(BoxPassword);
            flowLayoutPanel1.Controls.Add(flowLayoutPanel2);
            flowLayoutPanel1.Controls.Add(BtnRegister);
            flowLayoutPanel1.Controls.Add(LLSesion);
            flowLayoutPanel1.FlowDirection = FlowDirection.TopDown;
            flowLayoutPanel1.Location = new Point(330, 10);
            flowLayoutPanel1.Margin = new Padding(10);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Padding = new Padding(50, 20, 50, 50);
            flowLayoutPanel1.Size = new Size(526, 614);
            flowLayoutPanel1.TabIndex = 8;
            // 
            // lLabel
            // 
            lLabel.AutoSize = true;
            lLabel.Dock = DockStyle.Top;
            lLabel.Font = new Font("Yu Gothic UI", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lLabel.ForeColor = Color.FromArgb(100, 116, 139);
            lLabel.Location = new Point(53, 20);
            lLabel.Margin = new Padding(3, 0, 3, 20);
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
            LNombre.Location = new Point(53, 100);
            LNombre.Margin = new Padding(3, 20, 3, 0);
            LNombre.Name = "LNombre";
            LNombre.Size = new Size(148, 21);
            LNombre.TabIndex = 6;
            LNombre.Text = "Nombre Completo";
            // 
            // BoxNombre
            // 
            BoxNombre.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            BoxNombre.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            BoxNombre.ForeColor = Color.FromArgb(15, 23, 42);
            BoxNombre.Location = new Point(53, 141);
            BoxNombre.Margin = new Padding(3, 20, 3, 3);
            BoxNombre.Multiline = true;
            BoxNombre.Name = "BoxNombre";
            BoxNombre.Size = new Size(420, 36);
            BoxNombre.TabIndex = 7;
            BoxNombre.WordWrap = false;
            BoxNombre.TextChanged += textBox3_TextChanged;
            // 
            // LCorreo
            // 
            LCorreo.AutoSize = true;
            LCorreo.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            LCorreo.ForeColor = Color.FromArgb(12, 23, 42);
            LCorreo.Location = new Point(53, 200);
            LCorreo.Margin = new Padding(3, 20, 3, 0);
            LCorreo.Name = "LCorreo";
            LCorreo.Size = new Size(154, 21);
            LCorreo.TabIndex = 5;
            LCorreo.Text = "Correo Institucional";
            // 
            // BoxCorreo
            // 
            BoxCorreo.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            BoxCorreo.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            BoxCorreo.ForeColor = Color.FromArgb(15, 23, 42);
            BoxCorreo.Location = new Point(53, 241);
            BoxCorreo.Margin = new Padding(3, 20, 3, 3);
            BoxCorreo.Multiline = true;
            BoxCorreo.Name = "BoxCorreo";
            BoxCorreo.PlaceholderText = "correo@ug.ud.ec";
            BoxCorreo.Size = new Size(420, 36);
            BoxCorreo.TabIndex = 3;
            BoxCorreo.WordWrap = false;
            // 
            // LPassword
            // 
            LPassword.AutoSize = true;
            LPassword.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            LPassword.ForeColor = Color.FromArgb(12, 23, 42);
            LPassword.Location = new Point(53, 300);
            LPassword.Margin = new Padding(3, 20, 3, 0);
            LPassword.Name = "LPassword";
            LPassword.Size = new Size(79, 21);
            LPassword.TabIndex = 8;
            LPassword.Text = "Password";
            // 
            // BoxPassword
            // 
            BoxPassword.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            BoxPassword.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            BoxPassword.Location = new Point(53, 341);
            BoxPassword.Margin = new Padding(3, 20, 3, 20);
            BoxPassword.Multiline = true;
            BoxPassword.Name = "BoxPassword";
            BoxPassword.PasswordChar = '*';
            BoxPassword.Size = new Size(420, 36);
            BoxPassword.TabIndex = 4;
            BoxPassword.WordWrap = false;
            // 
            // flowLayoutPanel2
            // 
            flowLayoutPanel2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            flowLayoutPanel2.Controls.Add(lIngresarImagen);
            flowLayoutPanel2.Controls.Add(BtnSubirImagen);
            flowLayoutPanel2.Location = new Point(50, 397);
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
            BtnSubirImagen.TabIndex = 0;
            BtnSubirImagen.Text = "Subir Foto de Perfil";
            BtnSubirImagen.UseVisualStyleBackColor = true;
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
            BtnRegister.Location = new Point(53, 473);
            BtnRegister.Margin = new Padding(3, 20, 3, 20);
            BtnRegister.Name = "BtnRegister";
            BtnRegister.Size = new Size(420, 50);
            BtnRegister.TabIndex = 0;
            BtnRegister.Text = "Registrate";
            BtnRegister.UseVisualStyleBackColor = false;
            BtnRegister.Click += btnRegister;
            // 
            // LLSesion
            // 
            LLSesion.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            LLSesion.AutoSize = true;
            LLSesion.Cursor = Cursors.Hand;
            LLSesion.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            LLSesion.LinkColor = Color.FromArgb(4, 121, 246);
            LLSesion.Location = new Point(53, 543);
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
            // Register
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 254, 255);
            Controls.Add(flowLayoutPanel1);
            Margin = new Padding(0);
            Name = "Register";
            Size = new Size(1184, 661);
            flowLayoutPanel1.ResumeLayout(false);
            flowLayoutPanel1.PerformLayout();
            flowLayoutPanel2.ResumeLayout(false);
            flowLayoutPanel2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private FlowLayoutPanel flowLayoutPanel1;
        private Label lLabel;
        private Label LCorreo;
        private TextBox BoxCorreo;
        private Label LNombre;
        private TextBox BoxNombre;
        private Label LPassword;
        private TextBox BoxPassword;
        private Button BtnRegister;
        private FlowLayoutPanel flowLayoutPanel2;
        private Label lIngresarImagen;
        private Button BtnSubirImagen;
        private LinkLabel LLSesion;
        private NotifyIcon notifyIcon1;
    }
}
