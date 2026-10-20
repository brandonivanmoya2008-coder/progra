using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace validacion_con_errorprovid
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void txtNombre_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNombre.Text))
            {
                
                errorProvider1.SetError(txtNombre, "El nombre no puede estar vacío.");
                e.Cancel = true;
            }
            else
            {
                errorProvider1.SetError(txtNombre, "");
            }
        } 

        private void btnguardar_Click(object sender, EventArgs e)
        {
            string nombre = txtNombre.Text;
            int precio = int.Parse(txtPrecio.Text);
            MessageBox.Show("Nombre: " + nombre + " Precio: " + precio);
        }

        private void txtPrecio_Validating(object sender, CancelEventArgs e)
        {
            if (!int.TryParse(txtPrecio.Text, out int precio) || precio < 0)
            {
                errorProvider1.SetError(txtPrecio, "El precio debe ser un número mayor a 0.");
                e.Cancel = true;
            }
            else
            {
                errorProvider1.SetError(txtPrecio, "");
            }
        }
    }
}
