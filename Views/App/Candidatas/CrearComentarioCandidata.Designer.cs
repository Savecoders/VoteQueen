namespace POEcomentarioug
{
    partial class vtn
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
            lblComentario = new Label();
            txtbxcomentario = new TextBox();
            button1 = new Button();
            flowLayoutPanel1 = new FlowLayoutPanel();
            lblcandidata = new Label();
            lblnmbcand = new Label();
            btneditar = new Button();
            SuspendLayout();
            // 
            // lblComentario
            // 
            lblComentario.AutoSize = true;
            lblComentario.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblComentario.Location = new Point(12, 9);
            lblComentario.Name = "lblComentario";
            lblComentario.Size = new Size(279, 21);
            lblComentario.TabIndex = 0;
            lblComentario.Text = "Comenta a la Candidata a Reina UG";
            // 
            // txtbxcomentario
            // 
            txtbxcomentario.Location = new Point(264, 230);
            txtbxcomentario.Multiline = true;
            txtbxcomentario.Name = "txtbxcomentario";
            txtbxcomentario.Size = new Size(508, 155);
            txtbxcomentario.TabIndex = 1;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.Location = new Point(596, 407);
            button1.Name = "button1";
            button1.Size = new Size(176, 31);
            button1.TabIndex = 2;
            button1.Text = "Enviar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Location = new Point(259, 42);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(513, 161);
            flowLayoutPanel1.TabIndex = 3;
            // 
            // lblcandidata
            // 
            lblcandidata.AutoSize = true;
            lblcandidata.Location = new Point(12, 358);
            lblcandidata.Name = "lblcandidata";
            lblcandidata.Size = new Size(64, 15);
            lblcandidata.TabIndex = 5;
            lblcandidata.Text = "Candidata:";
            // 
            // lblnmbcand
            // 
            lblnmbcand.AutoSize = true;
            lblnmbcand.Location = new Point(13, 376);
            lblnmbcand.Name = "lblnmbcand";
            lblnmbcand.Size = new Size(103, 15);
            lblnmbcand.TabIndex = 6;
            lblnmbcand.Text = "Maria Maria Maria";
            // 
            // btneditar
            // 
            btneditar.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btneditar.Location = new Point(264, 407);
            btneditar.Name = "btneditar";
            btneditar.Size = new Size(176, 31);
            btneditar.TabIndex = 7;
            btneditar.Text = "Editar";
            btneditar.UseVisualStyleBackColor = true;
            btneditar.Click += btneditar_Click;
            // 
            // vtn
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(btneditar);
            Controls.Add(lblnmbcand);
            Controls.Add(lblcandidata);
            Controls.Add(flowLayoutPanel1);
            Controls.Add(button1);
            Controls.Add(txtbxcomentario);
            Controls.Add(lblComentario);
            Name = "vtn";
            Size = new Size(800, 450);
            Load += vtn_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblComentario;
        private TextBox txtbxcomentario;
        private Button button1;
        private FlowLayoutPanel flowLayoutPanel1;
        private PictureBox pictureBox1;
        private Label lblcandidata;
        private Label lblnmbcand;
        private Button btneditar;
    }
}
