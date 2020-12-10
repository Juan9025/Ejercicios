using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;


namespace Proyecto_2
{
    public class ConexionMySql
{
        private static MySqlConnection ObjetoConexion;
        private static string error;

        public static MySqlConnection getConexion()
        {
            if (ObjetoConexion != null)
                return ObjetoConexion;

            ObjetoConexion = new MySqlConnection("Server=localhost;Database=sena2020;Uid=userSena;Pwd=sena2020;");

            try
            {
                ObjetoConexion.Open();
                return ObjetoConexion;
            }
            catch (Exception e)
            {
                error = e.Message;
                return null;

            }
        }

        public static void cerrarConexion()
        {
            if (ObjetoConexion != null)
                ObjetoConexion.Close();

        }
    }
}