using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace examen_ejercicio_2
{
    internal class Actividad
    {
        public string Descripcion { get; set; }
        public string Responsable { get; set; }
        public DateTime Fecha { get; set; }

        // Propiedad calculada
        public string Informacion
        {
            get
            {
                return Descripcion + " - " + Responsable + " - " + Fecha.ToString("dd/MM/yyyy");
            }
        }

        public Actividad(string descripcion, string responsable)
        {
            Descripcion = descripcion;
            Responsable = responsable;
            Fecha = DateTime.Now;
        }
    }
}

