﻿namespace Views.App.Session
{
    partial class UHomePanel
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
            label1 = new Label();
            label2 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("SF Pro Display", 17F, FontStyle.Bold);
            label1.Location = new Point(38, 40);
            label1.Margin = new Padding(0);
            label1.Name = "label1";
            label1.Size = new Size(421, 27);
            label1.TabIndex = 7;
            label1.Text = "Bienvenido a la Aplicacion de VoteQueen";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("SF Pro Display", 15F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(38, 93);
            label2.Margin = new Padding(0);
            label2.Name = "label2";
            label2.Size = new Size(663, 24);
            label2.TabIndex = 8;
            label2.Text = "En esta aplicacion podras encontrar la lista de candidatas y votar por tu favorita";
            // 
            // UHomePanel
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(250, 250, 250);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "UHomePanel";
            Size = new Size(1022, 621);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
    }
}
