using System;

namespace claase
{
    public class producto
    {
        private string nombre;
        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }

        private int precio;
        public int Precio
        {
            get { return precio; }
            set { precio = value; }
        }

        public void MostrarDatos()
        {
            Console.WriteLine($"Nombre: {Nombre}, Precio: {Precio}");
        }
    }
}
