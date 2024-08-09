namespace Views.App.CandidatasView
{
    partial class UComentariosFoto
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            txtComentario = new TextBox();
            btnEnviarComentario = new Button();
            lblcandidata = new Label();
            lcandidata = new Label();
            pictureFoto = new PictureBox();
            flContainerComentarios = new FlowLayoutPanel();
            label1 = new Label();
            lTitulo = new Label();
            flowLayoutPanel2 = new FlowLayoutPanel();
            btnRegresar = new Button();
            label3 = new Label();
            lDescripcion = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureFoto).BeginInit();
            flowLayoutPanel2.SuspendLayout();
            SuspendLayout();
            // 
            // txtComentario
            // 
            txtComentario.Location = new Point(327, 120);
            txtComentario.Multiline = true;
            txtComentario.Name = "txtComentario";
            txtComentario.Size = new Size(564, 66);
            txtComentario.TabIndex = 1;
            // 
            // btnEnviarComentario
            // 
            btnEnviarComentario.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnEnviarComentario.Location = new Point(897, 120);
            btnEnviarComentario.Name = "btnEnviarComentario";
            btnEnviarComentario.Size = new Size(95, 66);
            btnEnviarComentario.TabIndex = 2;
            btnEnviarComentario.Text = "Enviar";
            btnEnviarComentario.UseVisualStyleBackColor = true;
            btnEnviarComentario.Click += button1_Click;
            // 
            // lblcandidata
            // 
            lblcandidata.AutoSize = true;
            lblcandidata.Font = new Font("SF Pro Display", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblcandidata.Location = new Point(36, 513);
            lblcandidata.Name = "lblcandidata";
            lblcandidata.Size = new Size(57, 19);
            lblcandidata.TabIndex = 5;
            lblcandidata.Text = "Fecha:";
            // 
            // lcandidata
            // 
            lcandidata.AutoSize = true;
            lcandidata.Font = new Font("Segoe UI", 11F);
            lcandidata.Location = new Point(36, 540);
            lcandidata.Name = "lcandidata";
            lcandidata.Size = new Size(136, 20);
            lcandidata.TabIndex = 6;
            lcandidata.Text = "Nombre Candidata";
            // 
            // pictureFoto
            // 
            pictureFoto.Location = new Point(36, 120);
            pictureFoto.Name = "pictureFoto";
            pictureFoto.Size = new Size(257, 275);
            pictureFoto.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureFoto.TabIndex = 7;
            pictureFoto.TabStop = false;
            // 
            // flContainerComentarios
            // 
            flContainerComentarios.AutoScroll = true;
            flContainerComentarios.Location = new Point(327, 215);
            flContainerComentarios.Name = "flContainerComentarios";
            flContainerComentarios.Padding = new Padding(0, 10, 0, 10);
            flContainerComentarios.Size = new Size(665, 340);
            flContainerComentarios.TabIndex = 8;
            flContainerComentarios.Paint += flContainerComentarios_Paint;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("SF Pro Rounded", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(327, 81);
            label1.Name = "label1";
            label1.Size = new Size(164, 23);
            label1.TabIndex = 9;
            label1.Text = "Enviar Comentario";
            // 
            // lTitulo
            // 
            lTitulo.AutoSize = true;
            lTitulo.Font = new Font("SF Pro Rounded", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lTitulo.Location = new Point(36, 81);
            lTitulo.Name = "lTitulo";
            lTitulo.Size = new Size(99, 23);
            lTitulo.TabIndex = 10;
            lTitulo.Text = "Titulo Foto";
            // 
            // flowLayoutPanel2
            // 
            flowLayoutPanel2.Controls.Add(btnRegresar);
            flowLayoutPanel2.Controls.Add(label3);
            flowLayoutPanel2.Dock = DockStyle.Top;
            flowLayoutPanel2.Location = new Point(0, 0);
            flowLayoutPanel2.Name = "flowLayoutPanel2";
            flowLayoutPanel2.Padding = new Padding(30, 10, 10, 10);
            flowLayoutPanel2.Size = new Size(1022, 42);
            flowLayoutPanel2.TabIndex = 23;
            // 
            // btnRegresar
            // 
            btnRegresar.BackColor = Color.FromArgb(250, 250, 250);
            btnRegresar.FlatAppearance.BorderSize = 0;
            btnRegresar.FlatStyle = FlatStyle.Flat;
            btnRegresar.ForeColor = Color.FromArgb(9, 9, 11);
            btnRegresar.Location = new Point(30, 10);
            btnRegresar.Margin = new Padding(0);
            btnRegresar.Name = "btnRegresar";
            btnRegresar.Size = new Size(37, 23);
            btnRegresar.TabIndex = 4;
            btnRegresar.Text = "<<";
            btnRegresar.UseVisualStyleBackColor = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("SF Pro Display", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(70, 10);
            label3.Name = "label3";
            label3.Size = new Size(184, 23);
            label3.TabIndex = 3;
            label3.Text = "Comentarios de Foto";
            // 
            // lDescripcion
            // 
            lDescripcion.Font = new Font("Segoe UI", 11F);
            lDescripcion.Location = new Point(38, 415);
            lDescripcion.Name = "lDescripcion";
            lDescripcion.Size = new Size(255, 73);
            lDescripcion.TabIndex = 24;
            lDescripcion.Text = "lDescripcion";
            // 
            // UComentariosFoto
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(250, 250, 250);
            Controls.Add(lDescripcion);
            Controls.Add(flowLayoutPanel2);
            Controls.Add(lTitulo);
            Controls.Add(label1);
            Controls.Add(flContainerComentarios);
            Controls.Add(pictureFoto);
            Controls.Add(lcandidata);
            Controls.Add(lblcandidata);
            Controls.Add(btnEnviarComentario);
            Controls.Add(txtComentario);
            Name = "UComentariosFoto";
            Size = new Size(1022, 618);
            Load += vtn_Load;
            ((System.ComponentModel.ISupportInitialize)pictureFoto).EndInit();
            flowLayoutPanel2.ResumeLayout(false);
            flowLayoutPanel2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox txtComentario;
        private Button btnEnviarComentario;
        private PictureBox pictureFoto;
        private Label lblcandidata;
        private Label lcandidata;
        private FlowLayoutPanel flContainerComentarios;
        private Label label1;
        private Label lTitulo;
        private FlowLayoutPanel flowLayoutPanel2;
        private Label label3;
        private Button btnRegresar;
        private Label lDescripcion;
    }
}
