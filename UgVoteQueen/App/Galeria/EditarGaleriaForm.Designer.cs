namespace Views.App.Galeria
{
    partial class EditarGaleriaForm
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
            tabControlEditar = new TabControl();
            tabPageEliminarFotos = new TabPage();
            flowLayoutPanelFotos = new FlowLayoutPanel();
            btnEliminarFoto = new Button();
            btnSiguiente1 = new Button();
            tabPageEditarDatos = new TabPage();
            btnSiguiente2 = new Button();
            btnAnterior1 = new Button();
            cmbCandidata = new ComboBox();
            txtTitulo = new TextBox();
            txtDescripcion = new TextBox();
            tabPageGuardar = new TabPage();
            label_guardar_galeria = new Label();
            btnGuardar = new Button();
            btnAnterior2 = new Button();
            tabControlEditar.SuspendLayout();
            tabPageEliminarFotos.SuspendLayout();
            tabPageEditarDatos.SuspendLayout();
            tabPageGuardar.SuspendLayout();
            SuspendLayout();
            // 
            // tabControlEditar
            // 
            tabControlEditar.Appearance = TabAppearance.FlatButtons;
            tabControlEditar.Controls.Add(tabPageEliminarFotos);
            tabControlEditar.Controls.Add(tabPageEditarDatos);
            tabControlEditar.Controls.Add(tabPageGuardar);
            tabControlEditar.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tabControlEditar.Location = new Point(12, 30);
            tabControlEditar.Margin = new Padding(3, 4, 3, 4);
            tabControlEditar.Name = "tabControlEditar";
            tabControlEditar.SelectedIndex = 0;
            tabControlEditar.Size = new Size(776, 517);
            tabControlEditar.TabIndex = 0;
            // 
            // tabPageEliminarFotos
            // 
            tabPageEliminarFotos.BackColor = Color.Turquoise;
            tabPageEliminarFotos.Controls.Add(flowLayoutPanelFotos);
            tabPageEliminarFotos.Controls.Add(btnEliminarFoto);
            tabPageEliminarFotos.Controls.Add(btnSiguiente1);
            tabPageEliminarFotos.Location = new Point(4, 40);
            tabPageEliminarFotos.Margin = new Padding(3, 4, 3, 4);
            tabPageEliminarFotos.Name = "tabPageEliminarFotos";
            tabPageEliminarFotos.Padding = new Padding(3, 4, 3, 4);
            tabPageEliminarFotos.Size = new Size(768, 473);
            tabPageEliminarFotos.TabIndex = 0;
            tabPageEliminarFotos.Text = "Eliminar Fotos";
            // 
            // flowLayoutPanelFotos
            // 
            flowLayoutPanelFotos.AutoScroll = true;
            flowLayoutPanelFotos.Location = new Point(20, 20);
            flowLayoutPanelFotos.Name = "flowLayoutPanelFotos";
            flowLayoutPanelFotos.Size = new Size(400, 300);
            flowLayoutPanelFotos.TabIndex = 0;
            // 
            // btnEliminarFoto
            // 
            btnEliminarFoto.Location = new Point(478, 129);
            btnEliminarFoto.Name = "btnEliminarFoto";
            btnEliminarFoto.Size = new Size(264, 46);
            btnEliminarFoto.TabIndex = 1;
            btnEliminarFoto.Text = "Eliminar de la galería";
            btnEliminarFoto.UseVisualStyleBackColor = true;
            btnEliminarFoto.Click += btnEliminarFoto_Click;
            // 
            // btnSiguiente1
            // 
            btnSiguiente1.Font = new Font("American Signs", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnSiguiente1.Location = new Point(288, 366);
            btnSiguiente1.Margin = new Padding(3, 4, 3, 4);
            btnSiguiente1.Name = "btnSiguiente1";
            btnSiguiente1.Size = new Size(196, 55);
            btnSiguiente1.TabIndex = 1;
            btnSiguiente1.Text = "Pagina Siguiente";
            btnSiguiente1.UseVisualStyleBackColor = true;
            btnSiguiente1.Click += btnSiguiente_Click;
            // 
            // tabPageEditarDatos
            // 
            tabPageEditarDatos.BackColor = Color.Turquoise;
            tabPageEditarDatos.Controls.Add(btnSiguiente2);
            tabPageEditarDatos.Controls.Add(btnAnterior1);
            tabPageEditarDatos.Controls.Add(cmbCandidata);
            tabPageEditarDatos.Controls.Add(txtTitulo);
            tabPageEditarDatos.Controls.Add(txtDescripcion);
            tabPageEditarDatos.Location = new Point(4, 40);
            tabPageEditarDatos.Margin = new Padding(3, 4, 3, 4);
            tabPageEditarDatos.Name = "tabPageEditarDatos";
            tabPageEditarDatos.Padding = new Padding(3, 4, 3, 4);
            tabPageEditarDatos.Size = new Size(768, 473);
            tabPageEditarDatos.TabIndex = 1;
            tabPageEditarDatos.Text = "Editar Datos";
            // 
            // btnSiguiente2
            // 
            btnSiguiente2.Font = new Font("American Signs", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnSiguiente2.Location = new Point(456, 371);
            btnSiguiente2.Margin = new Padding(3, 4, 3, 4);
            btnSiguiente2.Name = "btnSiguiente2";
            btnSiguiente2.Size = new Size(201, 51);
            btnSiguiente2.TabIndex = 4;
            btnSiguiente2.Text = "Pagina Siguiente";
            btnSiguiente2.UseVisualStyleBackColor = true;
            btnSiguiente2.Click += btnSiguiente_Click;
            // 
            // btnAnterior1
            // 
            btnAnterior1.Font = new Font("American Signs", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnAnterior1.Location = new Point(99, 371);
            btnAnterior1.Margin = new Padding(3, 4, 3, 4);
            btnAnterior1.Name = "btnAnterior1";
            btnAnterior1.Size = new Size(198, 51);
            btnAnterior1.TabIndex = 3;
            btnAnterior1.Text = "Pagina Anterior";
            btnAnterior1.UseVisualStyleBackColor = true;
            btnAnterior1.Click += btnAnterior_Click;
            // 
            // cmbCandidata
            // 
            cmbCandidata.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cmbCandidata.FormattingEnabled = true;
            cmbCandidata.Location = new Point(3, 20);
            cmbCandidata.Margin = new Padding(3, 4, 3, 4);
            cmbCandidata.Name = "cmbCandidata";
            cmbCandidata.Size = new Size(756, 36);
            cmbCandidata.TabIndex = 2;
            cmbCandidata.Text = "Seleccionar Candidata";
            // 
            // txtTitulo
            // 
            txtTitulo.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtTitulo.Location = new Point(3, 75);
            txtTitulo.Margin = new Padding(3, 4, 3, 4);
            txtTitulo.Name = "txtTitulo";
            txtTitulo.Size = new Size(756, 34);
            txtTitulo.TabIndex = 1;
            txtTitulo.Text = "Título de la Galería";
            // 
            // txtDescripcion
            // 
            txtDescripcion.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtDescripcion.Location = new Point(6, 155);
            txtDescripcion.Margin = new Padding(3, 4, 3, 4);
            txtDescripcion.Multiline = true;
            txtDescripcion.Name = "txtDescripcion";
            txtDescripcion.Size = new Size(756, 208);
            txtDescripcion.TabIndex = 0;
            txtDescripcion.Text = "Descripción de la Galería";
            // 
            // tabPageGuardar
            // 
            tabPageGuardar.BackColor = Color.Turquoise;
            tabPageGuardar.Controls.Add(label_guardar_galeria);
            tabPageGuardar.Controls.Add(btnGuardar);
            tabPageGuardar.Controls.Add(btnAnterior2);
            tabPageGuardar.Location = new Point(4, 40);
            tabPageGuardar.Margin = new Padding(3, 4, 3, 4);
            tabPageGuardar.Name = "tabPageGuardar";
            tabPageGuardar.Padding = new Padding(3, 4, 3, 4);
            tabPageGuardar.Size = new Size(768, 473);
            tabPageGuardar.TabIndex = 2;
            tabPageGuardar.Text = "Guardar";
            // 
            // label_guardar_galeria
            // 
            label_guardar_galeria.BackColor = Color.FloralWhite;
            label_guardar_galeria.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label_guardar_galeria.Location = new Point(223, 90);
            label_guardar_galeria.Name = "label_guardar_galeria";
            label_guardar_galeria.Size = new Size(300, 78);
            label_guardar_galeria.TabIndex = 2;
            label_guardar_galeria.Text = "Desea guardar esta informacion?";
            label_guardar_galeria.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnGuardar
            // 
            btnGuardar.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnGuardar.Location = new Point(298, 172);
            btnGuardar.Margin = new Padding(3, 4, 3, 4);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(140, 68);
            btnGuardar.TabIndex = 1;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // btnAnterior2
            // 
            btnAnterior2.Font = new Font("American Signs", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnAnterior2.Location = new Point(33, 357);
            btnAnterior2.Margin = new Padding(3, 4, 3, 4);
            btnAnterior2.Name = "btnAnterior2";
            btnAnterior2.Size = new Size(137, 87);
            btnAnterior2.TabIndex = 0;
            btnAnterior2.Text = "Pagina Anterior";
            btnAnterior2.UseVisualStyleBackColor = true;
            btnAnterior2.Click += btnAnterior_Click;
            // 
            // EditarGaleriaForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 562);
            Controls.Add(tabControlEditar);
            Margin = new Padding(3, 4, 3, 4);
            Name = "EditarGaleriaForm";
            Text = "Editar Álbumes de Fotos";
            Load += EditarGaleriaForm_Load;
            tabControlEditar.ResumeLayout(false);
            tabPageEliminarFotos.ResumeLayout(false);
            tabPageEditarDatos.ResumeLayout(false);
            tabPageEditarDatos.PerformLayout();
            tabPageGuardar.ResumeLayout(false);
            ResumeLayout(false);
        }

        private System.Windows.Forms.TabControl tabControlEditar;
        private System.Windows.Forms.TabPage tabPageEliminarFotos;
        private System.Windows.Forms.Button btnSiguiente1;
        private System.Windows.Forms.TabPage tabPageEditarDatos;
        private System.Windows.Forms.Button btnSiguiente2;
        private System.Windows.Forms.Button btnAnterior1;
        private System.Windows.Forms.ComboBox cmbCandidata;
        private System.Windows.Forms.TextBox txtTitulo;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.TabPage tabPageGuardar;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnAnterior2;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelFotos;
        private System.Windows.Forms.Button btnEliminarFoto;
        private Label label_guardar_galeria;
    }
}
