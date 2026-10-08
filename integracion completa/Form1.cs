using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace integracion_completa
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            int num;
             int.TryParse(txtNumero.Text,out num);
            switch (num)
            {
                case 1:
                    MessageBox.Show("escogiste la opcion 1");
                    break;
                case 2:
                    MessageBox.Show("escogiste la opcion 2");
                    break;
                case 3:
                    MessageBox.Show("escogiste la opcion 3");
                    break;
                case 4:
                    MessageBox.Show("escogiste la opcion 4");
                    break;
                default:
                    MessageBox.Show("opcion invalida");
                    break;

                }
        }
    }
}
