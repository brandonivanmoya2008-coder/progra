using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace examen_ejercicio_1
{
    public partial class Form1 : Form
    {
        List<Empleado> empleados = new List<Empleado>();
        public Form1()
        {
            InitializeComponent();
            dgvEmpleados.AutoGenerateColumns = false;
            dgvEmpleados.Columns.Clear();

            dgvEmpleados.Columns.Add("Identificacion", "Identificación");
            dgvEmpleados.Columns.Add("Nombre", "Nombre");
            dgvEmpleados.Columns.Add("Salario", "Salario");
            dgvEmpleados.Columns.Add("SalarioAnual", "Salario anual");
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            string identificacion = txtIdentificacion.Text;
            string nombre = txtNombre.Text;

            decimal salario;

            if (identificacion == "" || nombre == "")
            {
                MessageBox.Show("Complete todos los campos");
                return;
            }

            if (!decimal.TryParse(txtSalario.Text, out salario) || salario < 0)
            {
                MessageBox.Show("Ingrese un salario válido");
                return;
            }

            
            Empleado empleado = new Empleado(
                nombre,
                identificacion,
                salario
            );

            
            empleados.Add(empleado);

            MessageBox.Show("Empleado agregado correctamente");

            txtIdentificacion.Clear();
            txtNombre.Clear();
            txtSalario.Clear();
        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            dgvEmpleados.Rows.Clear();

            foreach (Empleado empleado in empleados)
            {
                dgvEmpleados.Rows.Add(
                    empleado.Identificacion,
                    empleado.Nombre,
                    empleado.Salario,
                    empleado.SalarioAnual
                );
            }
        }
    }
   
}


