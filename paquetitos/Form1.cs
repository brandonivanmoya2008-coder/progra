using paquetitos.clase_productos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace paquetitos
{
    public partial class Form1 : Form
     { 
        public Form1()
        {
            InitializeComponent();
        }

        private void btnguardar_Click(object sender, EventArgs e)
        {
          
            
            
            productoss producto = new productoss();
       
            
            
            
            producto.Nombre = txtnombre.Text;
            producto.Precio = int.Parse(txtprecio.Text);
            producto.mostrardatos();
           
           
        }
    }
}
