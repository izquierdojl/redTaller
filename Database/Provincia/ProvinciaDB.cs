using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;

namespace redTaller.Database.Provincia
{
    internal class ProvinciaDB
    {

        private readonly DatabaseUtil db;

        public ProvinciaDB()
        {
            db = new DatabaseUtil();
        }

        public DataTable extraeProvincias()
        {

            DataTable dataTable = new DataTable();

            try
            {
                db.Conectar();
                string query = "SELECT codigo, nombre FROM provincia";
                using (MySqlDataAdapter adapter = new MySqlDataAdapter(query, db.DbConn))
                {
                    adapter.Fill(dataTable);
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine($"Error al obtener provincias: {ex.Message}");
            }
            finally
            {
                db.Desconectar();
            }

            return dataTable;
        }

        public DataTable extraeProvinciasFiltro(string filtro)
        {

            DataTable dataTable = new DataTable();

            try
            {
                db.Conectar();

                string query = "SELECT codigo, nombre FROM provincia WHERE nombre LIKE @Filtro";

                using (MySqlDataAdapter adapter = new MySqlDataAdapter(query, db.DbConn))
                {
                    adapter.SelectCommand.Parameters.AddWithValue("@Filtro", "%" + filtro + "%");
                    adapter.Fill(dataTable);
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine($"Error al obtener provincias: {ex.Message}");
            }
            finally
            {
                db.Desconectar(); // Cerrar la conexión
            }

            return dataTable;
        }

        public int borraProvincias( List<string> provincias )
        {
            int borradas = 0;
            try
            {
                db.Conectar();
                string query = "DELETE FROM provincia WHERE codigo IN (" + string.Join(",", provincias) + ")";

                using ( MySqlCommand cmd = new MySqlCommand(query, db.DbConn ))
                {

                    borradas = cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine($"Error al borrar provincias: {ex.Message}");
            }
            finally
            {
                db.Desconectar();
            }
            return borradas;
        }
    }
}
