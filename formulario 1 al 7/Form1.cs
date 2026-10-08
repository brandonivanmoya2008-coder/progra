using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace formulario_1_al_7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btndiasemana_Click(object sender, EventArgs e)
        {
            int dia;
            int.TryParse(txtdiasemana.Text, out dia);
            switch (dia)
            {
                case 1:
                    MessageBox.Show("lunaes");
                    break;
                case 2:
                    MessageBox.Show("martes");
                    break;
                case 3:
                    MessageBox.Show("miercoles");
                    break;
                case 4:
                    MessageBox.Show("jueves");
                    break;
                case 5:
                    MessageBox.Show("viernes");
                    break;
                case 6:
                    MessageBox.Show("sabado");
                    break;
                case 7:
                    MessageBox.Show("domingo");
                    break;
                default:
                    MessageBox.Show("error ingresa un numero del 1 al 7");
                    break;
            }
  
            
        }
        private void btnsalir_Click(object sender, EventArgs e)
        {
            DialogResult salir = MessageBox.Show("¿Desea salir?", "salir", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (salir == DialogResult.Yes)
            {
                this.Close();

            }
        }
    }
}
