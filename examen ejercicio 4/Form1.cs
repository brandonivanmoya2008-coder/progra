using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace examen_ejercicio_4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void MostrarProductos()
        {
            try
            {
                using (MySqlConnection conexion = Conexion.ObtenerConexion())
                {
                    conexion.Open();

                    string consulta = "SELECT Codigo, Nombre, Precio, Cantidad, Categoria FROM Producto";

                    MySqlDataAdapter adaptador =
                        new MySqlDataAdapter(consulta, conexion);

                    DataTable tabla = new DataTable();

                    adaptador.Fill(tabla);

                    dgvProductos.DataSource = tabla;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            MostrarProductos();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            string nombre = txtNombre.Text;
            decimal precio;
            int cantidad;

            if (nombre == "" ||
                !decimal.TryParse(txtPrecio.Text, out precio) ||
                !int.TryParse(txtCantidad.Text, out cantidad) ||
                precio < 0 || cantidad < 0)
            {
                MessageBox.Show("Ingrese datos válidos");
                return;
            }

            try
            {
                using (MySqlConnection conexion = Conexion.ObtenerConexion())
                {
                    conexion.Open();

                    string consulta = "INSERT INTO Producto " +
                        "(Nombre, Precio, Cantidad, Categoria) " +
                        "VALUES (@nombre, @precio, @cantidad, @categoria)";

                    MySqlCommand comando = new MySqlCommand(consulta, conexion);

                    comando.Parameters.AddWithValue("@nombre", nombre);
                    comando.Parameters.AddWithValue("@precio", precio);
                    comando.Parameters.AddWithValue("@cantidad", cantidad);

                    // Categoría Electrónica (código 1)
                    comando.Parameters.AddWithValue("@categoria", 1);

                    comando.ExecuteNonQuery();

                    MessageBox.Show("Producto agregado correctamente");
                }

                txtNombre.Clear();
                txtPrecio.Clear();
                txtCantidad.Clear();

                MostrarProductos();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void BtnMostrar_Click(object sender, EventArgs e)
        {

        }

        private void dgvProductos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                txtCodigo.Text =
                    dgvProductos.Rows[e.RowIndex].Cells["Codigo"].Value.ToString();
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            int codigo;

            if (!int.TryParse(txtCodigo.Text, out codigo))
            {
                MessageBox.Show("Seleccione un producto");
                return;
            }

            DialogResult resultado = MessageBox.Show(
                "¿Está seguro de eliminar este producto?",
                "Confirmar eliminación",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (resultado == DialogResult.Yes)
            {
                try
                {
                    using (MySqlConnection conexion = Conexion.ObtenerConexion())
                    {
                        conexion.Open();

                        string consulta =
                            "DELETE FROM Producto WHERE Codigo = @codigo";

                        MySqlCommand comando =
                            new MySqlCommand(consulta, conexion);

                        comando.Parameters.AddWithValue("@codigo", codigo);

                        int filas = comando.ExecuteNonQuery();

                        if (filas > 0)
                        {
                            MessageBox.Show("Producto eliminado correctamente");
                        }
                        else
                        {
                            MessageBox.Show("No se encontró el producto");
                        }
                    }

                    txtCodigo.Clear();
                    MostrarProductos();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }
    }
}



