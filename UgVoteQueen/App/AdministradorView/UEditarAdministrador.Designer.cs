namespace Views.App.AdministradorView
{
    partial class UEditarAdministrador
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
            components = new System.ComponentModel.Container();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            btnSubirImagen = new Button();
            openFileDialog1 = new OpenFileDialog();
            imageList1 = new ImageList(components);
            label3 = new Label();
            lCorreo = new Label();
            label5 = new Label();
            txtNombres = new TextBox();
            flowLayoutPanel1 = new FlowLayoutPanel();
            groupBox1 = new GroupBox();
            flowLayoutPanel3 = new FlowLayoutPanel();
            txtCorreo = new TextBox();
            txtPassword = new TextBox();
            label4 = new Label();
            txtConfirPassword = new TextBox();
            label2 = new Label();
            cbCargo = new ComboBox();
            flowLayoutPanel5 = new FlowLayoutPanel();
            btnCancelar = new Button();
            btnActualizar = new Button();
            groupBox2 = new GroupBox();
            btnSubirFoto = new Button();
            pictureSubirImagen = new PictureBox();
            labelError = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            flowLayoutPanel1.SuspendLayout();
            groupBox1.SuspendLayout();
            flowLayoutPanel3.SuspendLayout();
            flowLayoutPanel5.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureSubirImagen).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("SF Pro Display", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(33, 10);
            label1.Name = "label1";
            label1.Size = new Size(123, 23);
            label1.TabIndex = 3;
            label1.Text = "Editar Cuenta";
            label1.Click += label1_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Dock = DockStyle.Right;
            pictureBox1.Location = new Point(354, 74);
            pictureBox1.Margin = new Padding(3, 2, 3, 2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(247, 264);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;
            // 
            // btnSubirImagen
            // 
            btnSubirImagen.Location = new Point(20, 315);
            btnSubirImagen.Margin = new Padding(3, 2, 3, 2);
            btnSubirImagen.Name = "btnSubirImagen";
            btnSubirImagen.Size = new Size(247, 45);
            btnSubirImagen.TabIndex = 5;
            btnSubirImagen.Text = "Subir Imagen";
            btnSubirImagen.UseVisualStyleBackColor = true;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // imageList1
            // 
            imageList1.ColorDepth = ColorDepth.Depth32Bit;
            imageList1.ImageSize = new Size(16, 16);
            imageList1.TransparentColor = Color.Transparent;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("SF Pro Display", 12F);
            label3.Location = new Point(13, 10);
            label3.Name = "label3";
            label3.Padding = new Padding(0, 0, 0, 10);
            label3.Size = new Size(70, 29);
            label3.TabIndex = 7;
            label3.Text = "Nombres";
            // 
            // lCorreo
            // 
            lCorreo.AutoSize = true;
            lCorreo.Font = new Font("SF Pro Display", 12F);
            lCorreo.Location = new Point(13, 70);
            lCorreo.Name = "lCorreo";
            lCorreo.Padding = new Padding(0, 10, 0, 10);
            lCorreo.Size = new Size(54, 39);
            lCorreo.TabIndex = 8;
            lCorreo.Text = "Correo";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("SF Pro Display", 12F);
            label5.Location = new Point(13, 142);
            label5.Name = "label5";
            label5.Padding = new Padding(0, 10, 0, 10);
            label5.Size = new Size(72, 39);
            label5.TabIndex = 9;
            label5.Text = "Password";
            // 
            // txtNombres
            // 
            txtNombres.BackColor = SystemColors.ButtonHighlight;
            txtNombres.Dock = DockStyle.Fill;
            txtNombres.Font = new Font("SF Pro Display", 12F);
            txtNombres.Location = new Point(13, 41);
            txtNombres.Margin = new Padding(3, 2, 3, 2);
            txtNombres.Name = "txtNombres";
            txtNombres.Size = new Size(314, 27);
            txtNombres.TabIndex = 13;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Controls.Add(label1);
            flowLayoutPanel1.Location = new Point(0, 0);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Padding = new Padding(30, 10, 10, 10);
            flowLayoutPanel1.Size = new Size(1022, 42);
            flowLayoutPanel1.TabIndex = 22;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(flowLayoutPanel3);
            groupBox1.Font = new Font("SF Pro Rounded", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox1.Location = new Point(33, 61);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(361, 400);
            groupBox1.TabIndex = 24;
            groupBox1.TabStop = false;
            groupBox1.Text = "Datos Personales";
            groupBox1.Enter += groupBox1_Enter_1;
            // 
            // flowLayoutPanel3
            // 
            flowLayoutPanel3.Controls.Add(label3);
            flowLayoutPanel3.Controls.Add(txtNombres);
            flowLayoutPanel3.Controls.Add(lCorreo);
            flowLayoutPanel3.Controls.Add(txtCorreo);
            flowLayoutPanel3.Controls.Add(label5);
            flowLayoutPanel3.Controls.Add(txtPassword);
            flowLayoutPanel3.Controls.Add(label4);
            flowLayoutPanel3.Controls.Add(txtConfirPassword);
            flowLayoutPanel3.Controls.Add(label2);
            flowLayoutPanel3.Controls.Add(cbCargo);
            flowLayoutPanel3.Dock = DockStyle.Fill;
            flowLayoutPanel3.FlowDirection = FlowDirection.TopDown;
            flowLayoutPanel3.Location = new Point(3, 23);
            flowLayoutPanel3.Name = "flowLayoutPanel3";
            flowLayoutPanel3.Padding = new Padding(10);
            flowLayoutPanel3.Size = new Size(355, 374);
            flowLayoutPanel3.TabIndex = 0;
            // 
            // txtCorreo
            // 
            txtCorreo.Font = new Font("SF Pro Display", 12F);
            txtCorreo.Location = new Point(13, 112);
            txtCorreo.Name = "txtCorreo";
            txtCorreo.Size = new Size(314, 27);
            txtCorreo.TabIndex = 22;
            // 
            // txtPassword
            // 
            txtPassword.BackColor = SystemColors.ButtonHighlight;
            txtPassword.Font = new Font("SF Pro Display", 12F);
            txtPassword.Location = new Point(13, 183);
            txtPassword.Margin = new Padding(3, 2, 3, 2);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(314, 27);
            txtPassword.TabIndex = 15;
            txtPassword.TextChanged += txt_TextChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("SF Pro Display", 12F);
            label4.Location = new Point(13, 212);
            label4.Name = "label4";
            label4.Padding = new Padding(0, 10, 0, 10);
            label4.Size = new Size(141, 39);
            label4.TabIndex = 23;
            label4.Text = "Confirmar Password";
            // 
            // txtConfirPassword
            // 
            txtConfirPassword.BackColor = SystemColors.ButtonHighlight;
            txtConfirPassword.Font = new Font("SF Pro Display", 12F);
            txtConfirPassword.Location = new Point(13, 253);
            txtConfirPassword.Margin = new Padding(3, 2, 3, 2);
            txtConfirPassword.Name = "txtConfirPassword";
            txtConfirPassword.Size = new Size(314, 27);
            txtConfirPassword.TabIndex = 24;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("SF Pro Display", 12F);
            label2.Location = new Point(13, 282);
            label2.Name = "label2";
            label2.Padding = new Padding(0, 10, 0, 10);
            label2.Size = new Size(50, 39);
            label2.TabIndex = 21;
            label2.Text = "Cargo";
            label2.Click += label2_Click;
            // 
            // cbCargo
            // 
            cbCargo.Font = new Font("SF Pro Display", 12F);
            cbCargo.FormattingEnabled = true;
            cbCargo.Items.AddRange(new object[] { "Software", "Tecnologia de la Informacion", "Sistemas", "Ciencia de Datos" });
            cbCargo.Location = new Point(13, 324);
            cbCargo.Name = "cbCargo";
            cbCargo.Size = new Size(314, 27);
            cbCargo.TabIndex = 21;
            // 
            // flowLayoutPanel5
            // 
            flowLayoutPanel5.Controls.Add(btnCancelar);
            flowLayoutPanel5.Controls.Add(btnActualizar);
            flowLayoutPanel5.Dock = DockStyle.Bottom;
            flowLayoutPanel5.FlowDirection = FlowDirection.RightToLeft;
            flowLayoutPanel5.Location = new Point(0, 549);
            flowLayoutPanel5.Name = "flowLayoutPanel5";
            flowLayoutPanel5.Padding = new Padding(100, 10, 10, 100);
            flowLayoutPanel5.Size = new Size(1022, 69);
            flowLayoutPanel5.TabIndex = 26;
            // 
            // btnCancelar
            // 
            btnCancelar.Font = new Font("Segoe UI", 12F);
            btnCancelar.Location = new Point(743, 13);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(166, 30);
            btnCancelar.TabIndex = 4;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // btnActualizar
            // 
            btnActualizar.Font = new Font("Segoe UI", 12F);
            btnActualizar.Location = new Point(544, 13);
            btnActualizar.Margin = new Padding(3, 3, 30, 3);
            btnActualizar.Name = "btnActualizar";
            btnActualizar.Size = new Size(166, 30);
            btnActualizar.TabIndex = 5;
            btnActualizar.Text = "Actualizar tu cuenta";
            btnActualizar.UseVisualStyleBackColor = true;
            btnActualizar.Click += btnRegistrarCandidata_Click;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(btnSubirFoto);
            groupBox2.Controls.Add(pictureSubirImagen);
            groupBox2.Font = new Font("SF Pro Display", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox2.Location = new Point(458, 61);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(10);
            groupBox2.Size = new Size(281, 400);
            groupBox2.TabIndex = 27;
            groupBox2.TabStop = false;
            groupBox2.Text = "Foto de Perfil";
            // 
            // btnSubirFoto
            // 
            btnSubirFoto.Font = new Font("SF Pro Display", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnSubirFoto.Location = new Point(13, 347);
            btnSubirFoto.Name = "btnSubirFoto";
            btnSubirFoto.Size = new Size(255, 40);
            btnSubirFoto.TabIndex = 1;
            btnSubirFoto.Text = "Subir Foto";
            btnSubirFoto.UseVisualStyleBackColor = true;
            btnSubirFoto.Click += btnSubirFoto_Click;
            // 
            // pictureSubirImagen
            // 
            pictureSubirImagen.Location = new Point(13, 30);
            pictureSubirImagen.Name = "pictureSubirImagen";
            pictureSubirImagen.Size = new Size(255, 301);
            pictureSubirImagen.TabIndex = 0;
            pictureSubirImagen.TabStop = false;
            // 
            // labelError
            // 
            labelError.Font = new Font("Segoe UI", 11F);
            labelError.ForeColor = Color.FromArgb(255, 128, 128);
            labelError.Location = new Point(768, 74);
            labelError.Name = "labelError";
            labelError.Size = new Size(226, 138);
            labelError.TabIndex = 28;
            // 
            // UEditarAdministrador
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BackColor = Color.FromArgb(250, 250, 250);
            Controls.Add(labelError);
            Controls.Add(groupBox2);
            Controls.Add(flowLayoutPanel5);
            Controls.Add(groupBox1);
            Controls.Add(flowLayoutPanel1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "UEditarAdministrador";
            Size = new Size(1022, 618);
            Load += UEditarAdministrador_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            flowLayoutPanel1.ResumeLayout(false);
            flowLayoutPanel1.PerformLayout();
            groupBox1.ResumeLayout(false);
            flowLayoutPanel3.ResumeLayout(false);
            flowLayoutPanel3.PerformLayout();
            flowLayoutPanel5.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureSubirImagen).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private PictureBox pictureBox1;
        private Button btnSubirImagen;
        private OpenFileDialog openFileDialog1;
        private ImageList imageList1;
        private Label label3;
        private Label lCorreo;
        private Label label5;
        private TextBox txtNombres;
        private GroupBox groupBox1;
        private FlowLayoutPanel flowLayoutPanel3;
        private Label label2;
        private ComboBox cbCargo;
        private FlowLayoutPanel flowLayoutPanel5;
        private Button btnCancelar;
        private Button btnActualizar;
        private FlowLayoutPanel flowLayoutPanel1;
        public GroupBox gBoxImage;
        private GroupBox groupBox2;
        private Button btnSubirFoto;
        private PictureBox pictureSubirImagen;
        private TextBox txtPassword;
        private TextBox txtCorreo;
        private Label label4;
        private TextBox txtConfirPassword;
        private Label labelError;
    }
}