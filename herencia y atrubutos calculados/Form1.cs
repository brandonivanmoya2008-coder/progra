using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace herencia_y_atrubutos_calculados
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnmostrar_Click(object sender, EventArgs e)
        {
            Estudiante estudiante = new Estudiante("Carlos", 2005);

            MessageBox.Show(
                "Nombre: " + estudiante.Nombre +
                "\nAño de nacimiento: " + estudiante.AñoNacimiento +
                "\nEdad: " + estudiante.EdadCalculada
            );
        }
    }
}
