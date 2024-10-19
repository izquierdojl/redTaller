using MySqlConnector;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace redTaller.Database
{
    internal class GeneralDB
    {

        protected DatabaseUtil db;
        protected string tabla;
        protected string key;
        public Dictionary<string, CampoInfo> dc { get; set; }

        public GeneralDB()
        {
            db = new DatabaseUtil();
        }
        public int delete(List<int> ids)
        {
            int borradas = 0;
            try
            {
                db.Conectar();
                string query = $"DELETE FROM {tabla} WHERE id IN ({string.Join(",", ids.Select(id => "'" + id + "'"))})";
                using (MySqlCommand cmd = new MySqlCommand(query, db.DbConn))
                {
                    borradas = cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine($"Error al borrar {tabla}: {ex.Message}");
            }
            finally
            {
                db.Desconectar();
            }
            return borradas;
        }

        public bool ValidaKey(string key)
        {
            try
            {
                db.Conectar();

                string query = $"SELECT {this.key} FROM {tabla} WHERE {this.key}=@key ";
                using (MySqlCommand cmd = new MySqlCommand(query, db.DbConn))
                {
                    cmd.Parameters.AddWithValue("@key", key);
                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            return false;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine($"Error al Validar {tabla}: {ex.Message}");
            }
            finally
            {
                db.Desconectar(); // Cerrar la conexión
            }

            return true; // correcto, podemos continuar
        }

    }
}
