using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace examen_ejercicio_1
{
    public class Persona
    {
        public string Nombre { get; set; }
        public string Identificacion { get; set; }

        public Persona(string nombre, string identificacion)
        {
            Nombre = nombre;
            Identificacion = identificacion;
        }
    }
}

