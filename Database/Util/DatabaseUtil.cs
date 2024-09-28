using MySql.Data.MySqlClient;
using System;
using System.Configuration;
using System.Diagnostics;

namespace redTaller.Database
{
    /// <summary>
    /// Clase DababaseUtils, para gestionar conexiones y rutinas de la base de datos
    /// </summary>
    internal class DatabaseUtil
    {
        MySqlConnection dbConn;

        /// <summary>
        /// Método constructor 
        /// </summary>
        public DatabaseUtil()
        {
            string connectionString = ConfigurationManager.ConnectionStrings["dbTaller"].ConnectionString;
            dbConn = new MySqlConnection(connectionString);
        }

        /// <summary>
        /// Conecta a la base de datos
        /// </summary>
        public void Conectar()
        {
            try
            {
                if (DbConn.State == System.Data.ConnectionState.Closed)
                {
                    DbConn.Open();
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine($"Error al conectar: {ex.Message}");
            }
        }

        /// <summary>
        /// Desconecta de la base de datos
        /// </summary>
        public void Desconectar()
        {
            try
            {
                if (DbConn.State == System.Data.ConnectionState.Open)
                {
                    DbConn.Close();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine();
                Debug.WriteLine($"Error al desconectar: {ex.Message}");
            }
        }

        public MySqlConnection DbConn { get => dbConn; set => dbConn = value; }

    }

}
