using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Validaciones_y_Dialogresult
{

    public partial class Form1 : Form
    {

        
        public Form1()
        {
            InitializeComponent();
        }

        private void btnguardar_Click(object sender, EventArgs e)
        {
            DialogResult resultado = MessageBox.Show("¿Desea guardar los cambios?", "confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Error);
            if (resultado == DialogResult.Yes)
            {
                MessageBox.Show("Los cambios se han guardado correctamente ");
            }
            else
            {
                MessageBox.Show("No se guardaron los cambios ");
            }
        }

        private void btnrecorrer_Click(object sender, EventArgs e)
        {
            List<Estudiante> estudiantes = new List<Estudiante>();

            estudiantes.Add(new Estudiante("Carlos", 2005));
            estudiantes.Add(new Estudiante("Ana", 2004));
            estudiantes.Add(new Estudiante("Pedro", 2006));

            foreach (Estudiante estudiante in estudiantes)
            {
                MessageBox.Show(
                    "Nombre: " + estudiante.Nombre +
                    "\nEdad: " + estudiante.EdadCalculada);
            }

        }
    }
}




