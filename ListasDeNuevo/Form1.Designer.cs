namespace ListasDeNuevo
{
    partial class Form1
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

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtNombreNodo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cmdAgregarPrincipio = new System.Windows.Forms.Button();
            this.cmdAgregarFinal = new System.Windows.Forms.Button();
            this.lstListaEnlazada = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // txtNombreNodo
            // 
            this.txtNombreNodo.Location = new System.Drawing.Point(173, 84);
            this.txtNombreNodo.Name = "txtNombreNodo";
            this.txtNombreNodo.Size = new System.Drawing.Size(158, 20);
            this.txtNombreNodo.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(209, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nombre del Nodo";
            // 
            // cmdAgregarPrincipio
            // 
            this.cmdAgregarPrincipio.Location = new System.Drawing.Point(173, 124);
            this.cmdAgregarPrincipio.Name = "cmdAgregarPrincipio";
            this.cmdAgregarPrincipio.Size = new System.Drawing.Size(158, 60);
            this.cmdAgregarPrincipio.TabIndex = 2;
            this.cmdAgregarPrincipio.Text = "Agregar al principio";
            this.cmdAgregarPrincipio.UseVisualStyleBackColor = true;
            this.cmdAgregarPrincipio.Click += new System.EventHandler(this.cmdAgregarPrincipio_Click);
            // 
            // cmdAgregarFinal
            // 
            this.cmdAgregarFinal.Location = new System.Drawing.Point(173, 203);
            this.cmdAgregarFinal.Name = "cmdAgregarFinal";
            this.cmdAgregarFinal.Size = new System.Drawing.Size(158, 61);
            this.cmdAgregarFinal.TabIndex = 3;
            this.cmdAgregarFinal.Text = "Agregar al final";
            this.cmdAgregarFinal.UseVisualStyleBackColor = true;
            this.cmdAgregarFinal.Click += new System.EventHandler(this.cmdAgregarFinal_Click);
            // 
            // lstListaEnlazada
            // 
            this.lstListaEnlazada.BackColor = System.Drawing.Color.Gray;
            this.lstListaEnlazada.FormattingEnabled = true;
            this.lstListaEnlazada.Location = new System.Drawing.Point(12, 54);
            this.lstListaEnlazada.Name = "lstListaEnlazada";
            this.lstListaEnlazada.Size = new System.Drawing.Size(120, 238);
            this.lstListaEnlazada.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.YellowGreen;
            this.ClientSize = new System.Drawing.Size(350, 341);
            this.Controls.Add(this.lstListaEnlazada);
            this.Controls.Add(this.cmdAgregarFinal);
            this.Controls.Add(this.cmdAgregarPrincipio);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtNombreNodo);
            this.Name = "Form1";
            this.Text = "EjemplosListas";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNombreNodo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button cmdAgregarPrincipio;
        private System.Windows.Forms.Button cmdAgregarFinal;
        private System.Windows.Forms.ListBox lstListaEnlazada;
    }
}

