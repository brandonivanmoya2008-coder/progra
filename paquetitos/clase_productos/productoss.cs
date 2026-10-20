using System;
using System.Collections.Generic;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace paquetitos.clase_productos
{
    public class productoss
    {
        private string nombre;
        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }

        private int precio;
        public int Precio
        {
            get { return precio; }
            set
            {
                if (value >= 50)
                    precio = value;
                else
                    MessageBox.Show("numero invalido");
            }
        }
        public void mostrardatos()
        {
            MessageBox.Show("Nombre: " + Nombre + " precio: " + Precio);
        }

    }
}
