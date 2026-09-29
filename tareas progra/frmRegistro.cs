using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tareas_progra
{
    public partial class mostrar : Form
    {
        public mostrar()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void limpiar_Click(object sender, EventArgs e)
        {
            txtnombre.Clear();
        }

        private void mos_Click(object sender, EventArgs e)
        {
            string nombre = txtnombre.Text;
            MessageBox.Show("Bienvenido a la base " + nombre);
        }

        private void salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtnombre_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
