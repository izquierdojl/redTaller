using MySqlConnector;
using redTaller.Util;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Diagnostics;

namespace redTaller.Database
{
    /// <summary>
    /// Clase DatabaseUtils, para gestionar conexiones y rutinas de la base de datos
    /// </summary>
    internal class DatabaseUtil
    {
        MySqlConnection dbConn;

        /// <summary>
        /// Método constructor 
        /// </summary>
        public DatabaseUtil()
        {
            //string connectionString = ConfigurationManager.ConnectionStrings["dbTaller"].ConnectionString;
            // se sustituye guardado en preferencias por clave de conexión otorgada por el servidor
            string connectionString = Session.Instance.ConnectionString;
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

        static public string selectColumns(Dictionary<string, CampoInfo> dc)
        {
            string select = "";
            foreach (string key in dc.Keys)
            {
                select += " " + dc[key].SelectCampo + " as " + key + ",";
            }
            if (dc.Count > 0)
            {
                select = select.Substring(0, select.Length - 1);
            }
            return select;
        }

    }

    public class CampoInfo
    {
        public string SelectCampo { get; set; }
        public bool VisibleTabla { get; set; }
        public bool VisibleFiltro { get; set; }
        public string Header { get; set; }
    }
}
