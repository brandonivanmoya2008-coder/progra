
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
namespace insercion_de_datos_en_la_base
{
    public class Conexion
        {
            public static MySqlConnection ObtenerConexion()
            {
                string cadena = "Server=localhost;Database=practica;Uid=root;Pwd=123456789;";

                MySqlConnection conexion =
                    new MySqlConnection(cadena);

                return conexion;
            }
        }
    }


