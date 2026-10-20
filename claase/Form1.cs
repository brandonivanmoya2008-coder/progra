using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace claase
{
    public partial class Form1 : Form
    {
        public Form1()
        {
          InitializeComponent();
        }
       
        private void btninfo_Click(object sender, EventArgs e)
        {
            produc producto1 = new produc();

            producto1.Nombre = "ranchitas";
            producto1.Precio = 150;

            producto1.mostrardatos();

        }
    }
}
