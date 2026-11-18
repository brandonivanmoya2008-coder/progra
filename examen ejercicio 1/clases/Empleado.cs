using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace examen_ejercicio_1
{
    public class Empleado : Persona
    {
        public decimal Salario { get; set; }

        // Propiedad calculada
        public decimal SalarioAnual
        {
            get { return Salario * 12; }
        }

        public Empleado(string nombre, string identificacion, decimal salario)
            : base(nombre, identificacion)
        {
            Salario = salario;
        }
    }
}
