using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace confirmacion_de_accion
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnsalir_Click(object sender, EventArgs e)
        {
            DialogResult resultado = MessageBox.Show("Desea salir del programa?", "confirmacion", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
        
             if (resultado == DialogResult.Yes)
            {
                this.Close();
            }
        }
    }
}
