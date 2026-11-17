
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace insercion_de_datos_en_la_base
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnInsertar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNombre.Text) ||
        string.IsNullOrWhiteSpace(txtCorreo.Text))
            {
                MessageBox.Show("Debe llenar todos los campos");
                return;
            }

            try
            {
                using (MySqlConnection conexion = Conexion.ObtenerConexion())
                {
                    conexion.Open();

                    string consulta = "INSERT INTO Clientes (Nombre, Correo) VALUES (@Nombre, @Correo)";

                    MySqlCommand comando = new MySqlCommand(consulta, conexion);

                    comando.Parameters.AddWithValue("@Nombre", txtNombre.Text);
                    comando.Parameters.AddWithValue("@Correo", txtCorreo.Text);

                    comando.ExecuteNonQuery();

                    MessageBox.Show("Cliente insertado correctamente");

                    txtNombre.Clear();
                    txtCorreo.Clear();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtBuscarNombre.Text))
            {
                MessageBox.Show("Ingrese un nombre para buscar");
                return;
            }

            try
            {
                using (MySqlConnection conexion = Conexion.ObtenerConexion())
                {
                    conexion.Open();

                    string consulta = "SELECT Correo FROM Clientes WHERE Nombre = @Nombre LIMIT 1";

                    MySqlCommand comando = new MySqlCommand(consulta, conexion);

                    comando.Parameters.AddWithValue("@Nombre", txtBuscarNombre.Text);

                    object resultado = comando.ExecuteScalar();

                    if (resultado != null)
                    {
                        txtCorreoEncontrado.Text = resultado.ToString();

                        MessageBox.Show("Cliente encontrado");
                    }
                    else
                    {
                        txtCorreoEncontrado.Clear();

                        MessageBox.Show("Cliente no encontrado");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtBuscarNombre.Text) ||
        string.IsNullOrWhiteSpace(txtCorreoEncontrado.Text))
            {
                MessageBox.Show("Primero busque un cliente y escriba el nuevo correo");
                return;
            }

            try
            {
                using (MySqlConnection conexion = Conexion.ObtenerConexion())
                {
                    conexion.Open();

                    string consulta = "UPDATE Clientes SET Correo = @Correo WHERE Nombre = @Nombre";

                    MySqlCommand comando = new MySqlCommand(consulta, conexion);

                    comando.Parameters.AddWithValue("@Correo", txtCorreoEncontrado.Text);
                    comando.Parameters.AddWithValue("@Nombre", txtBuscarNombre.Text);

                    int resultado = comando.ExecuteNonQuery();

                    if (resultado > 0)
                    {
                        MessageBox.Show("Correo modificado correctamente");
                    }
                    else
                    {
                        MessageBox.Show("No se encontró el cliente");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNombreEliminar.Text))
            {
                MessageBox.Show("Ingrese el nombre del cliente");
                return;
            }

            DialogResult respuesta = MessageBox.Show(
                "¿Está seguro de eliminar este cliente?",
                "Confirmar eliminación",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning
            );

            if (respuesta == DialogResult.Yes)
            {
                try
                {
                    using (MySqlConnection conexion = Conexion.ObtenerConexion())
                    {
                        conexion.Open();

                        string consulta = "DELETE FROM Clientes WHERE Nombre = @Nombre";

                        MySqlCommand comando = new MySqlCommand(consulta, conexion);

                        comando.Parameters.AddWithValue("@Nombre", txtNombreEliminar.Text);

                        int resultado = comando.ExecuteNonQuery();

                        if (resultado > 0)
                        {
                            MessageBox.Show("Cliente eliminado correctamente");
                            txtNombreEliminar.Clear();
                        }
                        else
                        {
                            MessageBox.Show("No se encontró el cliente");
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }
    }
    }
    
    
    

