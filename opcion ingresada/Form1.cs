using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace opcion_ingresada
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnseleccionar_Click(object sender, EventArgs e)
        {
            string v = txtOpcion.Text.ToLower();
            using opcion n= v;
              switch (opcion)
            {
                case "opcion 1":
                    MessageBox.Show("elegiste la opcion 1");
                    break;
                case"opcion 2":
                 MessageBox.Show ("elegiste la opcion 2");
                    break;
                case "opcion 3":
                    MessageBox.Show("elegiste la opcion 3");
                    break;
                default:
                    MessageBox.Show("opcion invalida");
                    break;
                         
            }

        }
    }
}
