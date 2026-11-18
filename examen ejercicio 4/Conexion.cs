using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
namespace examen_ejercicio_4
{
    

        public class Conexion
    {
        public static MySqlConnection ObtenerConexion()
        {
            string cadena = "Server=localhost;Database=Tienda;Uid=root;Pwd=123456789;";

            MySqlConnection conexion = new MySqlConnection(cadena);

            return conexion;
        }
    }
}

