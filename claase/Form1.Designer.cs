namespace claase
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
            this.btninfo = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btninfo
            // 
            this.btninfo.Location = new System.Drawing.Point(434, 177);
            this.btninfo.Name = "btninfo";
            this.btninfo.Size = new System.Drawing.Size(75, 23);
            this.btninfo.TabIndex = 0;
            this.btninfo.Text = "mostrar";
            this.btninfo.UseVisualStyleBackColor = true;
            this.btninfo.Click += new System.EventHandler(this.btninfo_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btninfo);
            this.Name = "Form1";
            this.Text = "producto POO";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btninfo;
    }
}

