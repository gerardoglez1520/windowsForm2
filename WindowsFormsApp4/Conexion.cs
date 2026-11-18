using System;
using System.ComponentModel.Design.Serialization;
using MySql.Data.MySqlClient; // Librería oficial de MySQL para conectar C# con bases de datos, necesarios para este proyecto

namespace WindowsFormsApp4
{
    // Clase principal encargada de gestionar la conexión con la base de datos del sistema
    public class Conexion
    {
        private string cadenaConexion =
            "Server=127.0.0.1;" +
            "Port=3308;" +
            "Database=apex_motorsports;" +

            "Uid=root;" +
            "Pwd=;";
        //Se especifica el como va funcionar la clase conexion para conectarse a la base de datos llamada
        //apex_motorsports con el uso de Xampp
        //Se define el puerto 3308 pues era un puerto libre porque Workbrench ya estaba usando el por defecto
        //que es 3306. El usuario es root y la contrasena va vacia

        public MySqlConnection ObtenerConexion()
        {
            return new MySqlConnection(cadenaConexion);
        }
       
    }
}