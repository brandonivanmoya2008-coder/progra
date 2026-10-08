namespace formulario_1_al_7
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
            this.btndiasemana = new System.Windows.Forms.Button();
            this.txtdiasemana = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnsalir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btndiasemana
            // 
            this.btndiasemana.Location = new System.Drawing.Point(345, 126);
            this.btndiasemana.Name = "btndiasemana";
            this.btndiasemana.Size = new System.Drawing.Size(75, 23);
            this.btndiasemana.TabIndex = 0;
            this.btndiasemana.Text = "mostrar";
            this.btndiasemana.UseVisualStyleBackColor = true;
            this.btndiasemana.Click += new System.EventHandler(this.btndiasemana_Click);
            // 
            // txtdiasemana
            // 
            this.txtdiasemana.Location = new System.Drawing.Point(332, 98);
            this.txtdiasemana.Name = "txtdiasemana";
            this.txtdiasemana.Size = new System.Drawing.Size(100, 22);
            this.txtdiasemana.TabIndex = 1;
            this.txtdiasemana.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(299, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(176, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "ingresa un numero del 1 al 7 ";
            // 
            // btnsalir
            // 
            this.btnsalir.Location = new System.Drawing.Point(345, 155);
            this.btnsalir.Name = "btnsalir";
            this.btnsalir.Size = new System.Drawing.Size(75, 23);
            this.btnsalir.TabIndex = 3;
            this.btnsalir.Text = "salir";
            this.btnsalir.UseVisualStyleBackColor = true;
            this.btnsalir.Click += new System.EventHandler(this.btnsalir_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnsalir);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtdiasemana);
            this.Controls.Add(this.btndiasemana);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btndiasemana;
        private System.Windows.Forms.TextBox txtdiasemana;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnsalir;
    }
}

