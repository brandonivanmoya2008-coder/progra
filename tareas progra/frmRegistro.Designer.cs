namespace tareas_progra
{
    partial class mostrar
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
            this.mos = new System.Windows.Forms.Button();
            this.limpiar = new System.Windows.Forms.Button();
            this.txtnombre = new System.Windows.Forms.TextBox();
            this.nombre = new System.Windows.Forms.Label();
            this.salir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // mos
            // 
            this.mos.Location = new System.Drawing.Point(368, 151);
            this.mos.Name = "mos";
            this.mos.Size = new System.Drawing.Size(75, 23);
            this.mos.TabIndex = 0;
            this.mos.Text = "mostrar";
            this.mos.UseVisualStyleBackColor = true;
            this.mos.Click += new System.EventHandler(this.mos_Click);
            // 
            // limpiar
            // 
            this.limpiar.Location = new System.Drawing.Point(487, 122);
            this.limpiar.Name = "limpiar";
            this.limpiar.Size = new System.Drawing.Size(75, 23);
            this.limpiar.TabIndex = 1;
            this.limpiar.Text = "limpiar";
            this.limpiar.UseVisualStyleBackColor = true;
            this.limpiar.Click += new System.EventHandler(this.limpiar_Click);
            // 
            // txtnombre
            // 
            this.txtnombre.Location = new System.Drawing.Point(368, 125);
            this.txtnombre.Name = "txtnombre";
            this.txtnombre.Size = new System.Drawing.Size(104, 20);
            this.txtnombre.TabIndex = 2;
            // 
            // nombre
            // 
            this.nombre.AutoSize = true;
            this.nombre.Location = new System.Drawing.Point(365, 109);
            this.nombre.Name = "nombre";
            this.nombre.Size = new System.Drawing.Size(91, 13);
            this.nombre.TabIndex = 3;
            this.nombre.Text = "ingresa tu nombre";
            // 
            // salir
            // 
            this.salir.Location = new System.Drawing.Point(251, 122);
            this.salir.Name = "salir";
            this.salir.Size = new System.Drawing.Size(75, 23);
            this.salir.TabIndex = 4;
            this.salir.Text = "salir";
            this.salir.UseVisualStyleBackColor = true;
            this.salir.Click += new System.EventHandler(this.salir_Click);
            // 
            // mostrar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.salir);
            this.Controls.Add(this.nombre);
            this.Controls.Add(this.txtnombre);
            this.Controls.Add(this.limpiar);
            this.Controls.Add(this.mos);
            this.Name = "mostrar";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button mos;
        private System.Windows.Forms.Button limpiar;
        private System.Windows.Forms.TextBox txtnombre;
        private System.Windows.Forms.Label nombre;
        private System.Windows.Forms.Button salir;
    }
}

