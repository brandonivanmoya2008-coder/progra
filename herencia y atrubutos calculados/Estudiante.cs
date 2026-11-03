using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace herencia_y_atrubutos_calculados
{

    public class Estudiante : Persona
    {
        public string Nombre { get; set; }

        public int EdadCalculada
        {
            get
            {
                return DateTime.Now.Year - AñoNacimiento;
            }
        }

        public Estudiante(string nombre, int añoNacimiento)
            : base(añoNacimiento)
        {
            Nombre = nombre;
        }
    }
}





