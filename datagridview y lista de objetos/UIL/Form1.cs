using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace datagridview_y_lista_de_objetos
{
    public partial class Form1 : Form
    {
        private Listaclas productos;
        public Form1()
        {
            InitializeComponent();
            productos = new Listaclas();
        }

        private void btnmostrar_Click(object sender, EventArgs e)
        {
            datagrid.DataSource = productos.ObtenerProductos();

        }

        private void datagrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
