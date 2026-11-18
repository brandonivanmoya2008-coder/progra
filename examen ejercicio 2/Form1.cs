using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace examen_ejercicio_2
{
    public partial class Form1 : Form
    {
        List<Actividad> actividades = new List<Actividad>();
        public Form1()
        {
            InitializeComponent();
            dgvActividades.AutoGenerateColumns = false;
            dgvActividades.Columns.Clear();

            dgvActividades.Columns.Add("Informacion", "Información");
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            string descripcion = txtDescripcion.Text;
            string responsable = txtResponsable.Text;

            if (descripcion == "" || responsable == "")
            {
                MessageBox.Show("Complete todos los campos");
                return;
            }

            // Crear objeto Actividad
            Actividad actividad = new Actividad(descripcion, responsable);

            // Guardar en la lista
            actividades.Add(actividad);

            MessageBox.Show("Actividad registrada correctamente");

            txtDescripcion.Clear();
            txtResponsable.Clear();
        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            dgvActividades.Rows.Clear();

            foreach (Actividad actividad in actividades)
            {
                dgvActividades.Rows.Add(actividad.Informacion);
            }
        }
    }
}


