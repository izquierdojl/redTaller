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
    internal class SearchDB
    {

        protected DatabaseUtil db;
        public Dictionary<string, CampoInfo> dc { get; set; }

        public SearchDB()
        {
            db = new DatabaseUtil();
        }

        public DataTable Load( string tabla, string filter = null )
        {

            DataTable dataTable = new DataTable();

            try
            {
                db.Conectar();
                string query = $@"
                                SELECT {DatabaseUtil.selectColumns(dc)} 
                                FROM {tabla}
                                ";
                if (!string.IsNullOrEmpty(filter))
                {
                    query += " WHERE ";
                    List<string> whereFiltros = new List<string>();
                    foreach (string key in dc.Keys)
                    {
                        whereFiltros.Add( $"( {dc[key].SelectCampo} LIKE '%{filter}%' )");
                    }
                    query += string.Join(" OR ", whereFiltros);

                }

                using (MySqlDataAdapter adapter = new MySqlDataAdapter(query, db.DbConn))
                {
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


    }
}
