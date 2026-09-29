using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sumas_y_multis
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void suma_Click(object sender, EventArgs e)
        {
            int suma = int.Parse(txtnum1.Text) + int.Parse(txtnum2.Text);
            MessageBox.Show("el resultado es " + suma);
        }

        private void multi_Click(object sender, EventArgs e)
        {
            int multi = int.Parse(txtnum1.Text) * int.Parse(txtnum2.Text);
            MessageBox.Show("el resultado es " + multi);
        }
    }
}
