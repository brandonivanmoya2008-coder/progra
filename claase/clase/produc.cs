using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace claase
{
    public class produc
    {
        public string Nombre;
       
        public int Precio;
        
        

        public void mostrardatos()
        {
            MessageBox.Show("Nombre: " + Nombre + " precio: " + Precio);
        }
    }
}
