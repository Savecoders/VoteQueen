namespace Views.App.FotoView
{
    partial class FAgregarFoto
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
            txtDescripcion = new TextBox();
            label2 = new Label();
            txtTitulo = new TextBox();
            lTitulo = new Label();
            groupBox1 = new GroupBox();
            flowLayoutPanel1 = new FlowLayoutPanel();
            groupBox2 = new GroupBox();
            btnSubirImagen = new Button();
            pictureImage = new PictureBox();
            flowLayoutPanel5 = new FlowLayoutPanel();
            btnCancelar = new Button();
            btnAgregarFoto = new Button();
            groupBox1.SuspendLayout();
            flowLayoutPanel1.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureImage).BeginInit();
            flowLayoutPanel5.SuspendLayout();
            SuspendLayout();
            // 
            // txtDescripcion
            // 
            txtDescripcion.Font = new Font("SF Pro Display", 9.75F);
            txtDescripcion.Location = new Point(13, 116);
            txtDescripcion.Multiline = true;
            txtDescripcion.Name = "txtDescripcion";
            txtDescripcion.Size = new Size(186, 108);
            txtDescripcion.TabIndex = 8;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold);
            label2.Location = new Point(13, 86);
            label2.Margin = new Padding(3, 10, 3, 10);
            label2.Name = "label2";
            label2.Size = new Size(142, 17);
            label2.TabIndex = 6;
            label2.Text = "Descripcion de la Foto";
            // 
            // txtTitulo
            // 
            txtTitulo.Font = new Font("SF Pro Display", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtTitulo.Location = new Point(13, 50);
            txtTitulo.Name = "txtTitulo";
            txtTitulo.Size = new Size(186, 23);
            txtTitulo.TabIndex = 7;
            // 
            // lTitulo
            // 
            lTitulo.AutoSize = true;
            lTitulo.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold);
            lTitulo.Location = new Point(13, 20);
            lTitulo.Margin = new Padding(3, 10, 3, 10);
            lTitulo.Name = "lTitulo";
            lTitulo.Size = new Size(107, 17);
            lTitulo.TabIndex = 5;
            lTitulo.Text = "Titulo de la Foto";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(flowLayoutPanel1);
            groupBox1.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(226, 268);
            groupBox1.TabIndex = 9;
            groupBox1.TabStop = false;
            groupBox1.Text = "Informacion Basica";
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Controls.Add(lTitulo);
            flowLayoutPanel1.Controls.Add(txtTitulo);
            flowLayoutPanel1.Controls.Add(label2);
            flowLayoutPanel1.Controls.Add(txtDescripcion);
            flowLayoutPanel1.Dock = DockStyle.Fill;
            flowLayoutPanel1.FlowDirection = FlowDirection.TopDown;
            flowLayoutPanel1.Location = new Point(3, 21);
            flowLayoutPanel1.Margin = new Padding(0);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Padding = new Padding(10);
            flowLayoutPanel1.Size = new Size(220, 244);
            flowLayoutPanel1.TabIndex = 0;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(btnSubirImagen);
            groupBox2.Controls.Add(pictureImage);
            groupBox2.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold);
            groupBox2.Location = new Point(254, 12);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(197, 268);
            groupBox2.TabIndex = 10;
            groupBox2.TabStop = false;
            groupBox2.Text = "Foto";
            // 
            // btnSubirImagen
            // 
            btnSubirImagen.Location = new Point(16, 219);
            btnSubirImagen.Name = "btnSubirImagen";
            btnSubirImagen.Size = new Size(165, 32);
            btnSubirImagen.TabIndex = 1;
            btnSubirImagen.Text = "Subir Foto";
            btnSubirImagen.UseVisualStyleBackColor = true;
            btnSubirImagen.Click += btnSubirImagen_Click;
            // 
            // pictureImage
            // 
            pictureImage.Location = new Point(16, 22);
            pictureImage.Name = "pictureImage";
            pictureImage.Size = new Size(165, 183);
            pictureImage.TabIndex = 0;
            pictureImage.TabStop = false;
            // 
            // flowLayoutPanel5
            // 
            flowLayoutPanel5.Controls.Add(btnCancelar);
            flowLayoutPanel5.Controls.Add(btnAgregarFoto);
            flowLayoutPanel5.Dock = DockStyle.Bottom;
            flowLayoutPanel5.FlowDirection = FlowDirection.RightToLeft;
            flowLayoutPanel5.Location = new Point(0, 286);
            flowLayoutPanel5.Name = "flowLayoutPanel5";
            flowLayoutPanel5.Padding = new Padding(0, 5, 10, 0);
            flowLayoutPanel5.Size = new Size(474, 48);
            flowLayoutPanel5.TabIndex = 27;
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(301, 8);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(160, 30);
            btnCancelar.TabIndex = 4;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            // 
            // btnAgregarFoto
            // 
            btnAgregarFoto.Location = new Point(128, 8);
            btnAgregarFoto.Margin = new Padding(3, 3, 10, 3);
            btnAgregarFoto.Name = "btnAgregarFoto";
            btnAgregarFoto.Size = new Size(160, 30);
            btnAgregarFoto.TabIndex = 5;
            btnAgregarFoto.Text = "Agregar Foto";
            btnAgregarFoto.UseVisualStyleBackColor = true;
            btnAgregarFoto.Click += btnAgregarFoto_Click;
            // 
            // FAgregarFoto
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(249, 250, 251);
            ClientSize = new Size(474, 334);
            Controls.Add(flowLayoutPanel5);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "FAgregarFoto";
            ShowIcon = false;
            Text = "Agregar Foto";
            Load += FRegistrarFoto_Load;
            groupBox1.ResumeLayout(false);
            flowLayoutPanel1.ResumeLayout(false);
            flowLayoutPanel1.PerformLayout();
            groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureImage).EndInit();
            flowLayoutPanel5.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TextBox txtDescripcion;
        private Label label2;
        private TextBox txtTitulo;
        private Label lTitulo;
        private GroupBox groupBox1;
        private FlowLayoutPanel flowLayoutPanel1;
        private GroupBox groupBox2;
        private Button btnSubirImagen;
        private PictureBox pictureImage;
        private FlowLayoutPanel flowLayoutPanel5;
        private Button btnCancelar;
        private Button btnAgregarFoto;
    }
}