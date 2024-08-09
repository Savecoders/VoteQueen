namespace Views.App.CandidatasView
{
    partial class UEditarCandidata
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
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            labelIntereses = new Label();
            label8 = new Label();
            txtNombres = new TextBox();
            txtTelefono = new TextBox();
            txtHabilidades = new TextBox();
            txtIntereses = new TextBox();
            txtPasatiempos = new TextBox();
            label9 = new Label();
            flowLayoutPanel1 = new FlowLayoutPanel();
            gBoxInfo = new GroupBox();
            flowLayoutPanel2 = new FlowLayoutPanel();
            label10 = new Label();
            txtAspiraciones = new TextBox();
            groupBox1 = new GroupBox();
            flowLayoutPanel3 = new FlowLayoutPanel();
            numEdad = new NumericUpDown();
            label2 = new Label();
            dateTimerNacimiento = new DateTimePicker();
            gBDatosAcademicos = new GroupBox();
            flowLayoutPanel4 = new FlowLayoutPanel();
            cbCarrera = new ComboBox();
            label11 = new Label();
            cbNivel = new ComboBox();
            flowLayoutPanel5 = new FlowLayoutPanel();
            btnCancelar = new Button();
            btnRegistrarCandidata = new Button();
            groupBox2 = new GroupBox();
            btnSubirFoto = new Button();
            pictureSubirImagen = new PictureBox();
            labelError = new Label();
            labelNombreCandidata = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            flowLayoutPanel1.SuspendLayout();
            gBoxInfo.SuspendLayout();
            flowLayoutPanel2.SuspendLayout();
            groupBox1.SuspendLayout();
            flowLayoutPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numEdad).BeginInit();
            gBDatosAcademicos.SuspendLayout();
            flowLayoutPanel4.SuspendLayout();
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
            label1.Size = new Size(148, 23);
            label1.TabIndex = 3;
            label1.Text = "Editar Candidata";
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
            label3.Location = new Point(13, 10);
            label3.Name = "label3";
            label3.Padding = new Padding(0, 0, 0, 10);
            label3.Size = new Size(56, 25);
            label3.TabIndex = 7;
            label3.Text = "Nombres";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(13, 62);
            label4.Name = "label4";
            label4.Padding = new Padding(0, 10, 0, 10);
            label4.Size = new Size(33, 35);
            label4.TabIndex = 8;
            label4.Text = "Edad";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(13, 126);
            label5.Name = "label5";
            label5.Padding = new Padding(0, 10, 0, 10);
            label5.Size = new Size(52, 35);
            label5.TabIndex = 9;
            label5.Text = "Telefono";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(13, 10);
            label6.Name = "label6";
            label6.Padding = new Padding(0, 0, 0, 10);
            label6.Size = new Size(72, 25);
            label6.TabIndex = 10;
            label6.Text = "Habilidades ";
            // 
            // labelIntereses
            // 
            labelIntereses.AutoSize = true;
            labelIntereses.Location = new Point(13, 109);
            labelIntereses.Name = "labelIntereses";
            labelIntereses.Padding = new Padding(0, 0, 0, 10);
            labelIntereses.Size = new Size(56, 25);
            labelIntereses.TabIndex = 11;
            labelIntereses.Text = "Intereses ";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(13, 208);
            label8.Name = "label8";
            label8.Padding = new Padding(0, 0, 0, 10);
            label8.Size = new Size(74, 25);
            label8.TabIndex = 12;
            label8.Text = "Pasatiempos";
            // 
            // txtNombres
            // 
            txtNombres.BackColor = SystemColors.ButtonHighlight;
            txtNombres.Dock = DockStyle.Fill;
            txtNombres.Location = new Point(13, 37);
            txtNombres.Margin = new Padding(3, 2, 3, 2);
            txtNombres.Name = "txtNombres";
            txtNombres.Size = new Size(265, 23);
            txtNombres.TabIndex = 13;
            // 
            // txtTelefono
            // 
            txtTelefono.BackColor = SystemColors.ButtonHighlight;
            txtTelefono.Dock = DockStyle.Fill;
            txtTelefono.Location = new Point(13, 163);
            txtTelefono.Margin = new Padding(3, 2, 3, 2);
            txtTelefono.Name = "txtTelefono";
            txtTelefono.Size = new Size(265, 23);
            txtTelefono.TabIndex = 15;
            txtTelefono.TextChanged += txt_TextChanged;
            // 
            // txtHabilidades
            // 
            txtHabilidades.BackColor = SystemColors.ButtonHighlight;
            txtHabilidades.Dock = DockStyle.Fill;
            txtHabilidades.Location = new Point(13, 45);
            txtHabilidades.Margin = new Padding(3, 10, 3, 10);
            txtHabilidades.Multiline = true;
            txtHabilidades.Name = "txtHabilidades";
            txtHabilidades.Size = new Size(304, 54);
            txtHabilidades.TabIndex = 16;
            // 
            // txtIntereses
            // 
            txtIntereses.BackColor = SystemColors.ButtonHighlight;
            txtIntereses.Dock = DockStyle.Fill;
            txtIntereses.Location = new Point(13, 144);
            txtIntereses.Margin = new Padding(3, 10, 3, 10);
            txtIntereses.Multiline = true;
            txtIntereses.Name = "txtIntereses";
            txtIntereses.Size = new Size(304, 54);
            txtIntereses.TabIndex = 17;
            // 
            // txtPasatiempos
            // 
            txtPasatiempos.BackColor = SystemColors.ButtonHighlight;
            txtPasatiempos.Location = new Point(13, 243);
            txtPasatiempos.Margin = new Padding(3, 10, 3, 10);
            txtPasatiempos.Multiline = true;
            txtPasatiempos.Name = "txtPasatiempos";
            txtPasatiempos.Size = new Size(304, 54);
            txtPasatiempos.TabIndex = 18;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(13, 10);
            label9.Name = "label9";
            label9.Padding = new Padding(0, 0, 0, 10);
            label9.Size = new Size(45, 25);
            label9.TabIndex = 19;
            label9.Text = "Carrera";
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Controls.Add(label1);
            flowLayoutPanel1.Controls.Add(labelNombreCandidata);
            flowLayoutPanel1.Location = new Point(0, 0);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Padding = new Padding(30, 10, 10, 10);
            flowLayoutPanel1.Size = new Size(1022, 42);
            flowLayoutPanel1.TabIndex = 22;
            // 
            // gBoxInfo
            // 
            gBoxInfo.Controls.Add(flowLayoutPanel2);
            gBoxInfo.Location = new Point(356, 57);
            gBoxInfo.Name = "gBoxInfo";
            gBoxInfo.Size = new Size(337, 463);
            gBoxInfo.TabIndex = 23;
            gBoxInfo.TabStop = false;
            gBoxInfo.Text = "Informacion Personal";
            // 
            // flowLayoutPanel2
            // 
            flowLayoutPanel2.Controls.Add(label6);
            flowLayoutPanel2.Controls.Add(txtHabilidades);
            flowLayoutPanel2.Controls.Add(labelIntereses);
            flowLayoutPanel2.Controls.Add(txtIntereses);
            flowLayoutPanel2.Controls.Add(label8);
            flowLayoutPanel2.Controls.Add(txtPasatiempos);
            flowLayoutPanel2.Controls.Add(label10);
            flowLayoutPanel2.Controls.Add(txtAspiraciones);
            flowLayoutPanel2.Dock = DockStyle.Fill;
            flowLayoutPanel2.FlowDirection = FlowDirection.TopDown;
            flowLayoutPanel2.Location = new Point(3, 19);
            flowLayoutPanel2.Margin = new Padding(0);
            flowLayoutPanel2.Name = "flowLayoutPanel2";
            flowLayoutPanel2.Padding = new Padding(10);
            flowLayoutPanel2.Size = new Size(331, 441);
            flowLayoutPanel2.TabIndex = 0;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(13, 307);
            label10.Name = "label10";
            label10.Padding = new Padding(0, 0, 0, 10);
            label10.Size = new Size(74, 25);
            label10.TabIndex = 19;
            label10.Text = "Aspiraciones";
            // 
            // txtAspiraciones
            // 
            txtAspiraciones.BackColor = SystemColors.ButtonHighlight;
            txtAspiraciones.Location = new Point(13, 342);
            txtAspiraciones.Margin = new Padding(3, 10, 3, 10);
            txtAspiraciones.Multiline = true;
            txtAspiraciones.Name = "txtAspiraciones";
            txtAspiraciones.Size = new Size(304, 54);
            txtAspiraciones.TabIndex = 20;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(flowLayoutPanel3);
            groupBox1.Location = new Point(28, 61);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(307, 292);
            groupBox1.TabIndex = 24;
            groupBox1.TabStop = false;
            groupBox1.Text = "Datos Personales";
            // 
            // flowLayoutPanel3
            // 
            flowLayoutPanel3.Controls.Add(label3);
            flowLayoutPanel3.Controls.Add(txtNombres);
            flowLayoutPanel3.Controls.Add(label4);
            flowLayoutPanel3.Controls.Add(numEdad);
            flowLayoutPanel3.Controls.Add(label5);
            flowLayoutPanel3.Controls.Add(txtTelefono);
            flowLayoutPanel3.Controls.Add(label2);
            flowLayoutPanel3.Controls.Add(dateTimerNacimiento);
            flowLayoutPanel3.Dock = DockStyle.Fill;
            flowLayoutPanel3.FlowDirection = FlowDirection.TopDown;
            flowLayoutPanel3.Location = new Point(3, 19);
            flowLayoutPanel3.Name = "flowLayoutPanel3";
            flowLayoutPanel3.Padding = new Padding(10);
            flowLayoutPanel3.Size = new Size(301, 270);
            flowLayoutPanel3.TabIndex = 0;
            // 
            // numEdad
            // 
            numEdad.Location = new Point(13, 100);
            numEdad.Name = "numEdad";
            numEdad.Size = new Size(265, 23);
            numEdad.TabIndex = 28;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(13, 188);
            label2.Name = "label2";
            label2.Padding = new Padding(0, 10, 0, 10);
            label2.Size = new Size(119, 35);
            label2.TabIndex = 21;
            label2.Text = "Fecha de Nacimiento";
            label2.Click += label2_Click;
            // 
            // dateTimerNacimiento
            // 
            dateTimerNacimiento.Dock = DockStyle.Fill;
            dateTimerNacimiento.Location = new Point(13, 226);
            dateTimerNacimiento.Name = "dateTimerNacimiento";
            dateTimerNacimiento.Size = new Size(265, 23);
            dateTimerNacimiento.TabIndex = 22;
            // 
            // gBDatosAcademicos
            // 
            gBDatosAcademicos.Controls.Add(flowLayoutPanel4);
            gBDatosAcademicos.Location = new Point(28, 359);
            gBDatosAcademicos.Name = "gBDatosAcademicos";
            gBDatosAcademicos.Size = new Size(307, 164);
            gBDatosAcademicos.TabIndex = 25;
            gBDatosAcademicos.TabStop = false;
            gBDatosAcademicos.Text = "Datos Academicos";
            // 
            // flowLayoutPanel4
            // 
            flowLayoutPanel4.Controls.Add(label9);
            flowLayoutPanel4.Controls.Add(cbCarrera);
            flowLayoutPanel4.Controls.Add(label11);
            flowLayoutPanel4.Controls.Add(cbNivel);
            flowLayoutPanel4.Dock = DockStyle.Fill;
            flowLayoutPanel4.FlowDirection = FlowDirection.TopDown;
            flowLayoutPanel4.Location = new Point(3, 19);
            flowLayoutPanel4.Name = "flowLayoutPanel4";
            flowLayoutPanel4.Padding = new Padding(10);
            flowLayoutPanel4.Size = new Size(301, 142);
            flowLayoutPanel4.TabIndex = 0;
            // 
            // cbCarrera
            // 
            cbCarrera.FormattingEnabled = true;
            cbCarrera.Items.AddRange(new object[] { "Software", "Tecnologia de la Informacion", "Sistemas", "Ciencia de Datos" });
            cbCarrera.Location = new Point(13, 38);
            cbCarrera.Name = "cbCarrera";
            cbCarrera.Size = new Size(265, 23);
            cbCarrera.TabIndex = 21;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(13, 64);
            label11.Name = "label11";
            label11.Padding = new Padding(0, 10, 0, 10);
            label11.Size = new Size(34, 35);
            label11.TabIndex = 20;
            label11.Text = "Nivel";
            // 
            // cbNivel
            // 
            cbNivel.Dock = DockStyle.Fill;
            cbNivel.FormattingEnabled = true;
            cbNivel.Items.AddRange(new object[] { "Nivel 1", "Nivel 2", "Nivel 3", "Nivel 4", "Nivel 5", "Nivel 6", "Nivel 7", "Nivel 8", "Nivel 9", "Nivel 10" });
            cbNivel.Location = new Point(13, 102);
            cbNivel.Name = "cbNivel";
            cbNivel.Size = new Size(265, 23);
            cbNivel.TabIndex = 22;
            // 
            // flowLayoutPanel5
            // 
            flowLayoutPanel5.Controls.Add(btnCancelar);
            flowLayoutPanel5.Controls.Add(btnRegistrarCandidata);
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
            btnCancelar.Location = new Point(749, 13);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(160, 30);
            btnCancelar.TabIndex = 4;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // btnRegistrarCandidata
            // 
            btnRegistrarCandidata.Location = new Point(556, 13);
            btnRegistrarCandidata.Margin = new Padding(3, 3, 30, 3);
            btnRegistrarCandidata.Name = "btnRegistrarCandidata";
            btnRegistrarCandidata.Size = new Size(160, 30);
            btnRegistrarCandidata.TabIndex = 5;
            btnRegistrarCandidata.Text = "Registrar Candidata";
            btnRegistrarCandidata.UseVisualStyleBackColor = true;
            btnRegistrarCandidata.Click += btnRegistrarCandidata_Click;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(btnSubirFoto);
            groupBox2.Controls.Add(pictureSubirImagen);
            groupBox2.Location = new Point(710, 61);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(10);
            groupBox2.Size = new Size(281, 362);
            groupBox2.TabIndex = 27;
            groupBox2.TabStop = false;
            groupBox2.Text = "Foto de Perfil";
            // 
            // btnSubirFoto
            // 
            btnSubirFoto.Location = new Point(13, 307);
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
            pictureSubirImagen.Size = new Size(255, 262);
            pictureSubirImagen.TabIndex = 0;
            pictureSubirImagen.TabStop = false;
            // 
            // labelError
            // 
            labelError.Font = new Font("Segoe UI", 11F);
            labelError.ForeColor = Color.FromArgb(255, 128, 128);
            labelError.Location = new Point(710, 442);
            labelError.Name = "labelError";
            labelError.Size = new Size(281, 75);
            labelError.TabIndex = 30;
            // 
            // labelNombreCandidata
            // 
            labelNombreCandidata.AutoSize = true;
            labelNombreCandidata.Font = new Font("SF Pro Display", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelNombreCandidata.Location = new Point(187, 10);
            labelNombreCandidata.Name = "labelNombreCandidata";
            labelNombreCandidata.Size = new Size(92, 23);
            labelNombreCandidata.TabIndex = 4;
            labelNombreCandidata.Text = "candidata";
            // 
            // UEditarCandidata
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BackColor = Color.FromArgb(250, 250, 250);
            Controls.Add(labelError);
            Controls.Add(groupBox2);
            Controls.Add(flowLayoutPanel5);
            Controls.Add(gBDatosAcademicos);
            Controls.Add(groupBox1);
            Controls.Add(gBoxInfo);
            Controls.Add(flowLayoutPanel1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "UEditarCandidata";
            Size = new Size(1022, 618);
            Load += UEditarCandidata_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            flowLayoutPanel1.ResumeLayout(false);
            flowLayoutPanel1.PerformLayout();
            gBoxInfo.ResumeLayout(false);
            flowLayoutPanel2.ResumeLayout(false);
            flowLayoutPanel2.PerformLayout();
            groupBox1.ResumeLayout(false);
            flowLayoutPanel3.ResumeLayout(false);
            flowLayoutPanel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numEdad).EndInit();
            gBDatosAcademicos.ResumeLayout(false);
            flowLayoutPanel4.ResumeLayout(false);
            flowLayoutPanel4.PerformLayout();
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
        private Label label4;
        private Label label5;
        private Label label6;
        private Label labelIntereses;
        private Label label8;
        private TextBox txtNombres;
        private TextBox txtTelefono;
        private TextBox txtHabilidades;
        private TextBox txtIntereses;
        private TextBox txtPasatiempos;
        private Label label9;
        private GroupBox gBoxInfo;
        private FlowLayoutPanel flowLayoutPanel2;
        private GroupBox groupBox1;
        private FlowLayoutPanel flowLayoutPanel3;
        private Label label2;
        private Label label10;
        private TextBox txtAspiraciones;
        private DateTimePicker dateTimerNacimiento;
        private GroupBox gBDatosAcademicos;
        private FlowLayoutPanel flowLayoutPanel4;
        private Label label11;
        private ComboBox cbCarrera;
        private ComboBox cbNivel;
        private FlowLayoutPanel flowLayoutPanel5;
        private Button btnCancelar;
        private Button btnRegistrarCandidata;
        private FlowLayoutPanel flowLayoutPanel1;
        public GroupBox gBoxImage;
        private GroupBox groupBox2;
        private Button btnSubirFoto;
        private PictureBox pictureSubirImagen;
        private NumericUpDown numEdad;
        private Label labelError;
        private Label labelNombreCandidata;
    }
}