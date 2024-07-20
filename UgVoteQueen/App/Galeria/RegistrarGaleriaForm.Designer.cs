namespace Views.App.Galeria
{
    partial class RegistrarGaleriaForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            tabControlRegistrar = new TabControl();
            tabPageFotos = new TabPage();
            label_subir_imagen = new Label();
            btnSiguiente = new Button();
            flowLayoutPanelFotos = new FlowLayoutPanel();
            tabPageDatos = new TabPage();
            btnAnterior = new Button();
            btnGuardar = new Button();
            cmbCandidata = new ComboBox();
            txtTitulo = new TextBox();
            txtDescripcion = new TextBox();
            tabControlRegistrar.SuspendLayout();
            tabPageFotos.SuspendLayout();
            tabPageDatos.SuspendLayout();
            SuspendLayout();
            // 
            // tabControlRegistrar
            // 
            tabControlRegistrar.Controls.Add(tabPageFotos);
            tabControlRegistrar.Controls.Add(tabPageDatos);
            tabControlRegistrar.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tabControlRegistrar.Location = new Point(12, 15);
            tabControlRegistrar.Margin = new Padding(3, 4, 3, 4);
            tabControlRegistrar.Name = "tabControlRegistrar";
            tabControlRegistrar.SelectedIndex = 0;
            tabControlRegistrar.Size = new Size(776, 532);
            tabControlRegistrar.TabIndex = 0;
            // 
            // tabPageFotos
            // 
            tabPageFotos.BackColor = Color.Gold;
            tabPageFotos.Controls.Add(label_subir_imagen);
            tabPageFotos.Controls.Add(btnSiguiente);
            tabPageFotos.Controls.Add(flowLayoutPanelFotos);
            tabPageFotos.Location = new Point(4, 37);
            tabPageFotos.Margin = new Padding(3, 4, 3, 4);
            tabPageFotos.Name = "tabPageFotos";
            tabPageFotos.Padding = new Padding(3, 4, 3, 4);
            tabPageFotos.Size = new Size(768, 491);
            tabPageFotos.TabIndex = 0;
            tabPageFotos.Text = "Fotos";
            // 
            // label_subir_imagen
            // 
            label_subir_imagen.AutoSize = true;
            label_subir_imagen.Font = new Font("Arial Rounded MT Bold", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label_subir_imagen.Location = new Point(225, 49);
            label_subir_imagen.Name = "label_subir_imagen";
            label_subir_imagen.Size = new Size(329, 32);
            label_subir_imagen.TabIndex = 2;
            label_subir_imagen.Text = "Arrastra tus fotos aqui:";
            label_subir_imagen.TextAlign = ContentAlignment.TopCenter;
            label_subir_imagen.UseMnemonic = false;
            // 
            // btnSiguiente
            // 
            btnSiguiente.Font = new Font("American Signs", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnSiguiente.Location = new Point(283, 426);
            btnSiguiente.Margin = new Padding(3, 4, 3, 4);
            btnSiguiente.Name = "btnSiguiente";
            btnSiguiente.Size = new Size(191, 56);
            btnSiguiente.TabIndex = 1;
            btnSiguiente.Text = "Pagina Siguiente";
            btnSiguiente.UseVisualStyleBackColor = true;
            btnSiguiente.Click += btnSiguiente_Click;
            // 
            // flowLayoutPanelFotos
            // 
            flowLayoutPanelFotos.AllowDrop = true;
            flowLayoutPanelFotos.BackColor = Color.White;
            flowLayoutPanelFotos.ForeColor = Color.Black;
            flowLayoutPanelFotos.Location = new Point(96, 85);
            flowLayoutPanelFotos.Margin = new Padding(3, 4, 3, 4);
            flowLayoutPanelFotos.Name = "flowLayoutPanelFotos";
            flowLayoutPanelFotos.Size = new Size(570, 333);
            flowLayoutPanelFotos.TabIndex = 0;
            flowLayoutPanelFotos.DragDrop += flowLayoutPanelFotos_DragDrop;
            flowLayoutPanelFotos.DragEnter += flowLayoutPanelFotos_DragEnter;
            flowLayoutPanelFotos.Paint += flowLayoutPanelFotos_Paint;
            // 
            // tabPageDatos
            // 
            tabPageDatos.BackColor = Color.Gold;
            tabPageDatos.Controls.Add(btnAnterior);
            tabPageDatos.Controls.Add(btnGuardar);
            tabPageDatos.Controls.Add(cmbCandidata);
            tabPageDatos.Controls.Add(txtTitulo);
            tabPageDatos.Controls.Add(txtDescripcion);
            tabPageDatos.Location = new Point(4, 37);
            tabPageDatos.Margin = new Padding(3, 4, 3, 4);
            tabPageDatos.Name = "tabPageDatos";
            tabPageDatos.Padding = new Padding(3, 4, 3, 4);
            tabPageDatos.Size = new Size(768, 491);
            tabPageDatos.TabIndex = 1;
            tabPageDatos.Text = "Datos";
            // 
            // btnAnterior
            // 
            btnAnterior.Font = new Font("American Signs", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnAnterior.Location = new Point(22, 427);
            btnAnterior.Margin = new Padding(3, 4, 3, 4);
            btnAnterior.Name = "btnAnterior";
            btnAnterior.Size = new Size(219, 56);
            btnAnterior.TabIndex = 4;
            btnAnterior.Text = "Pagina Anterior";
            btnAnterior.UseVisualStyleBackColor = true;
            btnAnterior.Click += btnAnterior_Click;
            // 
            // btnGuardar
            // 
            btnGuardar.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnGuardar.Location = new Point(560, 354);
            btnGuardar.Margin = new Padding(3, 4, 3, 4);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(188, 56);
            btnGuardar.TabIndex = 3;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // cmbCandidata
            // 
            cmbCandidata.FormattingEnabled = true;
            cmbCandidata.Location = new Point(6, 8);
            cmbCandidata.Margin = new Padding(3, 4, 3, 4);
            cmbCandidata.Name = "cmbCandidata";
            cmbCandidata.Size = new Size(756, 36);
            cmbCandidata.TabIndex = 2;
            cmbCandidata.Text = "Seleccionar Candidata";
            // 
            // txtTitulo
            // 
            txtTitulo.Location = new Point(6, 45);
            txtTitulo.Margin = new Padding(3, 4, 3, 4);
            txtTitulo.Name = "txtTitulo";
            txtTitulo.Size = new Size(756, 34);
            txtTitulo.TabIndex = 1;
            txtTitulo.Text = "Título de la Galería";
            // 
            // txtDescripcion
            // 
            txtDescripcion.Location = new Point(22, 87);
            txtDescripcion.Margin = new Padding(3, 4, 3, 4);
            txtDescripcion.Multiline = true;
            txtDescripcion.Name = "txtDescripcion";
            txtDescripcion.Size = new Size(740, 259);
            txtDescripcion.TabIndex = 0;
            txtDescripcion.Text = "Descripción de la Galería";
            // 
            // RegistrarGaleriaForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 562);
            Controls.Add(tabControlRegistrar);
            Margin = new Padding(3, 4, 3, 4);
            Name = "RegistrarGaleriaForm";
            Text = "Registrar Galería de Fotos";
            tabControlRegistrar.ResumeLayout(false);
            tabPageFotos.ResumeLayout(false);
            tabPageFotos.PerformLayout();
            tabPageDatos.ResumeLayout(false);
            tabPageDatos.PerformLayout();
            ResumeLayout(false);
        }

        private System.Windows.Forms.TabControl tabControlRegistrar;
        private System.Windows.Forms.TabPage tabPageFotos;
        private System.Windows.Forms.Button btnSiguiente;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelFotos;
        private System.Windows.Forms.TabPage tabPageDatos;
        private System.Windows.Forms.Button btnAnterior;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.ComboBox cmbCandidata;
        private System.Windows.Forms.TextBox txtTitulo;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.DragEventHandler DragDrop;
        private System.Windows.Forms.DragEventHandler DragEnter;
        private Label label_subir_imagen;
    }
}

