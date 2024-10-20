using MySqlConnector;
using System;
using System.Collections.Generic;
using System.Data;
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

        public DataTable Load(Dictionary<string, object> filtros = null)
        {
            DataTable dataTable = new DataTable();

            try
            {
                db.Conectar();
                string query = $"SELECT {DatabaseUtil.selectColumns(dc)} FROM {tabla} ";
                if (filtros != null && filtros.Count > 0)
                {
                    List<string> whereFiltros = new List<string>();
                    foreach (var filtro in filtros)
                    {
                        whereFiltros.Add($"{filtro.Key} LIKE @{filtro.Key}");
                    }
                    query += " WHERE " + string.Join(" AND ", whereFiltros);
                }

                using (MySqlDataAdapter adapter = new MySqlDataAdapter(query, db.DbConn))
                {
                    if (filtros != null && filtros.Count > 0)
                    {
                        foreach (var filtro in filtros)
                            adapter.SelectCommand.Parameters.AddWithValue($"@{filtro.Key}", "%" + filtro.Value.ToString() + "%");
                    }
                    adapter.Fill(dataTable);
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine($"Error al obtener {tabla}: {ex.Message}");
            }
            finally
            {
                db.Desconectar();
            }

            return dataTable;
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
