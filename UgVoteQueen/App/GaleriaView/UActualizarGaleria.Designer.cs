namespace Views.App.GaleriaView
{
    partial class UActualizarGaleria
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
            flowLayoutPanel5 = new FlowLayoutPanel();
            btnCancelar = new Button();
            btnRegistrar = new Button();
            flowLayoutPanel1 = new FlowLayoutPanel();
            label1 = new Label();
            groupBox2 = new GroupBox();
            btnSubirFoto = new Button();
            pictureSubirImagen = new PictureBox();
            groupBox1 = new GroupBox();
            flowLayoutPanel2 = new FlowLayoutPanel();
            lTitulo = new Label();
            txtTitulo = new TextBox();
            lDescripcion = new Label();
            txtDescripcion = new TextBox();
            label2 = new Label();
            panel1 = new Panel();
            btnAgregarFotos = new Button();
            flFotos = new FlowLayoutPanel();
            flowLayoutPanel5.SuspendLayout();
            flowLayoutPanel1.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureSubirImagen).BeginInit();
            groupBox1.SuspendLayout();
            flowLayoutPanel2.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // flowLayoutPanel5
            // 
            flowLayoutPanel5.Controls.Add(btnCancelar);
            flowLayoutPanel5.Controls.Add(btnRegistrar);
            flowLayoutPanel5.Dock = DockStyle.Bottom;
            flowLayoutPanel5.FlowDirection = FlowDirection.RightToLeft;
            flowLayoutPanel5.Location = new Point(0, 562);
            flowLayoutPanel5.Name = "flowLayoutPanel5";
            flowLayoutPanel5.Padding = new Padding(100, 10, 10, 100);
            flowLayoutPanel5.Size = new Size(1022, 59);
            flowLayoutPanel5.TabIndex = 27;
            // 
            // btnCancelar
            // 
            btnCancelar.Font = new Font("Segoe UI", 12F);
            btnCancelar.Location = new Point(743, 10);
            btnCancelar.Margin = new Padding(3, 0, 3, 3);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(166, 41);
            btnCancelar.TabIndex = 4;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            // 
            // btnRegistrar
            // 
            btnRegistrar.Font = new Font("Segoe UI", 12F);
            btnRegistrar.Location = new Point(544, 10);
            btnRegistrar.Margin = new Padding(3, 0, 30, 3);
            btnRegistrar.Name = "btnRegistrar";
            btnRegistrar.Size = new Size(166, 41);
            btnRegistrar.TabIndex = 5;
            btnRegistrar.Text = "Actualizar Galeria";
            btnRegistrar.UseVisualStyleBackColor = true;
            btnRegistrar.Click += btnRegistrar_Click;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Controls.Add(label1);
            flowLayoutPanel1.Dock = DockStyle.Top;
            flowLayoutPanel1.Location = new Point(0, 0);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Padding = new Padding(30, 10, 10, 10);
            flowLayoutPanel1.Size = new Size(1022, 42);
            flowLayoutPanel1.TabIndex = 28;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("SF Pro Display", 15F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(9, 9, 11);
            label1.Location = new Point(33, 10);
            label1.Name = "label1";
            label1.Size = new Size(170, 24);
            label1.TabIndex = 3;
            label1.Text = "Actualizar Galeria";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(btnSubirFoto);
            groupBox2.Controls.Add(pictureSubirImagen);
            groupBox2.Font = new Font("SF Pro Display", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox2.Location = new Point(663, 8);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(10);
            groupBox2.Size = new Size(298, 220);
            groupBox2.TabIndex = 29;
            groupBox2.TabStop = false;
            groupBox2.Text = "Foto de Portada";
            // 
            // btnSubirFoto
            // 
            btnSubirFoto.Font = new Font("SF Pro Display", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnSubirFoto.Location = new Point(13, 178);
            btnSubirFoto.Name = "btnSubirFoto";
            btnSubirFoto.Size = new Size(272, 32);
            btnSubirFoto.TabIndex = 1;
            btnSubirFoto.Text = "Subir Portada";
            btnSubirFoto.UseVisualStyleBackColor = true;
            btnSubirFoto.Click += btnSubirFoto_Click;
            // 
            // pictureSubirImagen
            // 
            pictureSubirImagen.Location = new Point(13, 30);
            pictureSubirImagen.Name = "pictureSubirImagen";
            pictureSubirImagen.Size = new Size(272, 139);
            pictureSubirImagen.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureSubirImagen.TabIndex = 0;
            pictureSubirImagen.TabStop = false;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(flowLayoutPanel2);
            groupBox1.Font = new Font("SF Pro Display", 12F, FontStyle.Bold);
            groupBox1.Location = new Point(41, 8);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(10);
            groupBox1.Size = new Size(602, 220);
            groupBox1.TabIndex = 30;
            groupBox1.TabStop = false;
            groupBox1.Text = "Informacion";
            groupBox1.Enter += groupBox1_Enter;
            // 
            // flowLayoutPanel2
            // 
            flowLayoutPanel2.Controls.Add(lTitulo);
            flowLayoutPanel2.Controls.Add(txtTitulo);
            flowLayoutPanel2.Controls.Add(lDescripcion);
            flowLayoutPanel2.Controls.Add(txtDescripcion);
            flowLayoutPanel2.Dock = DockStyle.Fill;
            flowLayoutPanel2.FlowDirection = FlowDirection.TopDown;
            flowLayoutPanel2.Location = new Point(10, 30);
            flowLayoutPanel2.Name = "flowLayoutPanel2";
            flowLayoutPanel2.Padding = new Padding(10, 5, 5, 5);
            flowLayoutPanel2.Size = new Size(582, 180);
            flowLayoutPanel2.TabIndex = 0;
            // 
            // lTitulo
            // 
            lTitulo.AutoSize = true;
            lTitulo.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold);
            lTitulo.ForeColor = Color.FromArgb(39, 39, 42);
            lTitulo.Location = new Point(13, 5);
            lTitulo.Margin = new Padding(3, 0, 3, 10);
            lTitulo.Name = "lTitulo";
            lTitulo.Size = new Size(137, 20);
            lTitulo.TabIndex = 0;
            lTitulo.Text = "Titulo de la Galeria";
            // 
            // txtTitulo
            // 
            txtTitulo.Font = new Font("SF Pro Display", 12F);
            txtTitulo.Location = new Point(13, 38);
            txtTitulo.Name = "txtTitulo";
            txtTitulo.Size = new Size(550, 27);
            txtTitulo.TabIndex = 2;
            // 
            // lDescripcion
            // 
            lDescripcion.AutoSize = true;
            lDescripcion.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold);
            lDescripcion.ForeColor = Color.FromArgb(39, 39, 42);
            lDescripcion.Location = new Point(13, 78);
            lDescripcion.Margin = new Padding(3, 10, 3, 10);
            lDescripcion.Name = "lDescripcion";
            lDescripcion.Size = new Size(162, 20);
            lDescripcion.TabIndex = 1;
            lDescripcion.Text = "Descripcion de Galeria";
            // 
            // txtDescripcion
            // 
            txtDescripcion.Font = new Font("SF Pro Display", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtDescripcion.Location = new Point(13, 111);
            txtDescripcion.Multiline = true;
            txtDescripcion.Name = "txtDescripcion";
            txtDescripcion.Size = new Size(550, 61);
            txtDescripcion.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("SF Pro Display", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.FromArgb(9, 9, 11);
            label2.Location = new Point(41, 242);
            label2.Margin = new Padding(3, 0, 3, 10);
            label2.Name = "label2";
            label2.Size = new Size(140, 23);
            label2.TabIndex = 4;
            label2.Text = "Fotos del Albun";
            // 
            // panel1
            // 
            panel1.AutoScroll = true;
            panel1.BackColor = Color.FromArgb(249, 250, 251);
            panel1.Controls.Add(groupBox1);
            panel1.Controls.Add(btnAgregarFotos);
            panel1.Controls.Add(flFotos);
            panel1.Controls.Add(groupBox2);
            panel1.Controls.Add(label2);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 42);
            panel1.Name = "panel1";
            panel1.Size = new Size(1022, 520);
            panel1.TabIndex = 31;
            // 
            // btnAgregarFotos
            // 
            btnAgregarFotos.BackColor = Color.FromArgb(17, 24, 39);
            btnAgregarFotos.BackgroundImageLayout = ImageLayout.Center;
            btnAgregarFotos.Cursor = Cursors.Hand;
            btnAgregarFotos.FlatAppearance.BorderSize = 0;
            btnAgregarFotos.FlatStyle = FlatStyle.Flat;
            btnAgregarFotos.Font = new Font("SF Pro Text", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnAgregarFotos.ForeColor = Color.WhiteSmoke;
            btnAgregarFotos.Location = new Point(193, 241);
            btnAgregarFotos.Margin = new Padding(0);
            btnAgregarFotos.Name = "btnAgregarFotos";
            btnAgregarFotos.Size = new Size(100, 30);
            btnAgregarFotos.TabIndex = 15;
            btnAgregarFotos.Text = "Agregar";
            btnAgregarFotos.TextImageRelation = TextImageRelation.ImageAboveText;
            btnAgregarFotos.UseVisualStyleBackColor = false;
            btnAgregarFotos.Click += btnAgregarFotos_Click;
            // 
            // flFotos
            // 
            flFotos.AutoScroll = true;
            flFotos.Location = new Point(41, 284);
            flFotos.Name = "flFotos";
            flFotos.Padding = new Padding(5);
            flFotos.Size = new Size(920, 230);
            flFotos.TabIndex = 30;
            flFotos.Paint += flFotos_Paint;
            // 
            // UActualizarGaleria
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(250, 250, 250);
            Controls.Add(panel1);
            Controls.Add(flowLayoutPanel1);
            Controls.Add(flowLayoutPanel5);
            Name = "UActualizarGaleria";
            Size = new Size(1022, 621);
            flowLayoutPanel5.ResumeLayout(false);
            flowLayoutPanel1.ResumeLayout(false);
            flowLayoutPanel1.PerformLayout();
            groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureSubirImagen).EndInit();
            groupBox1.ResumeLayout(false);
            flowLayoutPanel2.ResumeLayout(false);
            flowLayoutPanel2.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private FlowLayoutPanel flowLayoutPanel5;
        private Button btnCancelar;
        private Button btnRegistrar;
        private FlowLayoutPanel flowLayoutPanel1;
        private Label label1;
        private GroupBox groupBox2;
        private Button btnSubirFoto;
        private PictureBox pictureSubirImagen;
        private GroupBox groupBox1;
        private FlowLayoutPanel flowLayoutPanel2;
        private Label lTitulo;
        private TextBox txtTitulo;
        private Label lDescripcion;
        private TextBox txtDescripcion;
        private Label label2;
        private Panel panel1;
        private FlowLayoutPanel flFotos;
        private Button btnAgregarFotos;
    }
}
