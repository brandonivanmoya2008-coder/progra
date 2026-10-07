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

namespace tarea_listboxcolores
{
    public partial class listboxcolores : Form
    {
        public listboxcolores()
        {
            InitializeComponent();
        }

        private void listboxcolores_Load(object sender, EventArgs e)
        {
            listBox1.Items.Add("rojo");
            listBox1.Items.Add("verde");
            listBox1.Items.Add("azul");
 
            listBox1.BackColor = Color.LightCoral;
            this.BackColor = Color.LightYellow;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void evaluar_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txtNumero1.Text, out int numero1) && int.TryParse(txtNumero2.Text, out int numero2))
            {
                if (numero1 > numero2)
                {
                    MessageBox.Show(numero1 + " es mayor que " + numero2);
                }
                else if (numero2 > numero1)
                {
                    MessageBox.Show(numero2 + " es mayor que " + numero1);
                }
                else
                {
                    MessageBox.Show("Los números son iguales");
                }
            }
            else
            {
                MessageBox.Show("por favor ingrese un numero valido");
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            {
                if (listBox1.SelectedItem == null)
                    return;

                if (listBox1.SelectedItem.ToString() == "rojo")
                {
                    listBox1.BackColor = Color.Red;
                }
                else if (listBox1.SelectedItem.ToString() == "verde")
                {
                    listBox1.BackColor = Color.Green;
                }
                else if (listBox1.SelectedItem.ToString() == "azul")
                {
                    listBox1.BackColor = Color.Blue;
                }
            }

        }

        private void btnazul_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.Blue;
            listBox1.Items.Add("se selecciono azul");
        }

        private void btnrojo_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.Red;
            listBox1.Items.Add("se selecciono rojo");
        }

        private void btnverde_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.Green;
            listBox1.Items.Add("se selecciono verde");
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cambiarColorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                this.BackColor = colorDialog1.Color;
            }
        }
    }
}
