namespace Tarea2
{
    partial class Principal
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
            this.botonExcepciones = new System.Windows.Forms.Button();
            this.botonControles = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // botonExcepciones
            // 
            this.botonExcepciones.Location = new System.Drawing.Point(41, 91);
            this.botonExcepciones.Name = "botonExcepciones";
            this.botonExcepciones.Size = new System.Drawing.Size(158, 66);
            this.botonExcepciones.TabIndex = 0;
            this.botonExcepciones.Text = "Formulario de Excepciones";
            this.botonExcepciones.UseVisualStyleBackColor = true;
            this.botonExcepciones.Click += new System.EventHandler(this.botonExcepciones_Click);
            // 
            // botonControles
            // 
            this.botonControles.Location = new System.Drawing.Point(236, 91);
            this.botonControles.Name = "botonControles";
            this.botonControles.Size = new System.Drawing.Size(159, 66);
            this.botonControles.TabIndex = 1;
            this.botonControles.Text = "Formulario de Controles";
            this.botonControles.UseVisualStyleBackColor = true;
            this.botonControles.Click += new System.EventHandler(this.botonControles_Click);
            // 
            // Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(443, 261);
            this.Controls.Add(this.botonControles);
            this.Controls.Add(this.botonExcepciones);
            this.Name = "Principal";
            this.Text = "Ventana Principal";
            this.Load += new System.EventHandler(this.Principal_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button botonExcepciones;
        private System.Windows.Forms.Button botonControles;
    }
}

