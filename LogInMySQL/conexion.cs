using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogInMySQL
{
    class Conexion
    {
        public static MySqlConnection getConexion() 
        {
            String servidor = "localhost";
            String puerto = "3306";
            String usuario = "root";
            String password = "1234";
            String bd = "log_in";

            String cadenaConexion = "server=" + servidor + "; port=" + puerto + "; user id=" + usuario + "; password=" + password + "; database=" + bd;

            MySqlConnection conexion = new MySqlConnection(cadenaConexion);

            return conexion;
        }

    }
}
