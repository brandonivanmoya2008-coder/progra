using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ejercicio_2_examen
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnevaluar_Click(object sender, EventArgs e)
        {
            int nota;

            if (int.TryParse(txtnota.Text, out nota) &&
                nota >= 0 && nota <= 100)
            {
                string categoria = calcularcategoria(nota);

                lblresultado.Text = categoria;

                if (nota >= 90)
                {
                    lblresultado.BackColor = Color.Green;
                }
                else if (nota < 60)
                {
                    lblresultado.BackColor = Color.Red;
                }
                else
                {
                    lblresultado.BackColor = SystemColors.Control;
                }
            }
            else
            {
                MessageBox.Show("Ingrese una nota válida entre 0 y 100");
            }
        }
        
        private string calcularcategoria(int nota)
        { 
            int result; 
            int.TryParse(txtnota.Text, out result);
            if (result >= 0 && result <= 100)
            {
                if (result >= 90)
                {
                    return "exelente";
                }
                else if (result >= 80)
                {
                      return "muy bueno";
                }
                else if (result>= 70)
                {
                    return "bueno";
                }
                else if (result >= 60)
                {
                        return "regular";
                }
                else
                {
                    return "deficiente";
                }
            }
            else
            {
                MessageBox.Show("Ingrese una nota valida entre 0 y 100");
            }

        }
        private void btnborrar_Click(object sender, EventArgs e)
        {
            this.txtnota.Clear();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
