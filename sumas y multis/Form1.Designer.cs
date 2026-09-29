namespace sumas_y_multis
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
            this.txtnum1 = new System.Windows.Forms.TextBox();
            this.suma = new System.Windows.Forms.Button();
            this.txtnum2 = new System.Windows.Forms.TextBox();
            this.multi = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtnum1
            // 
            this.txtnum1.Location = new System.Drawing.Point(315, 143);
            this.txtnum1.Name = "txtnum1";
            this.txtnum1.Size = new System.Drawing.Size(100, 22);
            this.txtnum1.TabIndex = 0;
            // 
            // suma
            // 
            this.suma.Location = new System.Drawing.Point(325, 194);
            this.suma.Name = "suma";
            this.suma.Size = new System.Drawing.Size(75, 23);
            this.suma.TabIndex = 1;
            this.suma.Text = "suma";
            this.suma.UseVisualStyleBackColor = true;
            this.suma.Click += new System.EventHandler(this.suma_Click);
            // 
            // txtnum2
            // 
            this.txtnum2.Location = new System.Drawing.Point(315, 101);
            this.txtnum2.Name = "txtnum2";
            this.txtnum2.Size = new System.Drawing.Size(100, 22);
            this.txtnum2.TabIndex = 2;
            // 
            // multi
            // 
            this.multi.Location = new System.Drawing.Point(450, 194);
            this.multi.Name = "multi";
            this.multi.Size = new System.Drawing.Size(75, 23);
            this.multi.TabIndex = 3;
            this.multi.Text = "multiplicacion";
            this.multi.UseVisualStyleBackColor = true;
            this.multi.Click += new System.EventHandler(this.multi_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.multi);
            this.Controls.Add(this.txtnum2);
            this.Controls.Add(this.suma);
            this.Controls.Add(this.txtnum1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtnum1;
        private System.Windows.Forms.Button suma;
        private System.Windows.Forms.TextBox txtnum2;
        private System.Windows.Forms.Button multi;
    }
}

