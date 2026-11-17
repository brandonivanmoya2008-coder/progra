using MySql.Data.MySqlClient;

namespace biblioteca_clases
{
    internal class Conexion
    {
        private string cadenaConexion = "server=localhost;database=Tienda;user=root;password=123456789;";
        public MySqlConnection ObtenerConexion()
        {
            return new MySqlConnection(cadenaConexion);
        }
    }
}
       

