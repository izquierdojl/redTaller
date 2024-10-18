using MySqlConnector;
using redTaller.Modelo;
using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Linq;

namespace redTaller.Database
{
    internal class ProvinciaDB
    {

        private readonly DatabaseUtil db;
        private string tabla;
        private string key;
        private Dictionary<string, CampoInfo> dc;

        public ProvinciaDB()
        {
            db = new DatabaseUtil();
            tabla = "provincia";
            key = "codigo";
            Dc = new Dictionary<string, CampoInfo>()
            {
                { "codigo", new CampoInfo { SelectCampo = tabla + ".codigo", VisibleTabla = true } },
                { "nombre", new CampoInfo { SelectCampo = tabla + ".nombre", VisibleTabla = true } },
            };

        }

        public Provincia CargaElemento(string key)
        {
            Provincia provincia = new Provincia();
            try
            {
                db.Conectar();
                string query = $@"
                                SELECT {DatabaseUtil.selectColumns(Dc, true)}
                                FROM {tabla}  
                                WHERE {dc["codigo"].SelectCampo}=@key";

                using (MySqlCommand cmd = new MySqlCommand(query, db.DbConn))
                {
                    cmd.Parameters.AddWithValue("@key", key);
                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            provincia.codigo = reader.GetString("codigo");
                            provincia.nombre = reader.GetString("nombre");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine($"Error al obtener Provincia: {ex.Message}");
            }
            finally
            {
                db.Desconectar();
            }

            return provincia;
        }

        public int insert(Provincia provincia)
        {
            int nuevas = 0;
            try
            {
                db.Conectar();
                string query = $"INSERT INTO {tabla} set codigo=@codigo, nombre=@nombre";

                using (MySqlCommand cmd = new MySqlCommand(query, db.DbConn))
                {
                    cmd.Parameters.AddWithValue("@codigo", provincia.codigo);
                    cmd.Parameters.AddWithValue("@nombre", provincia.nombre);
                    nuevas = cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine($"Error al insertar Provincia: {ex.Message}");
            }
            finally
            {
                db.Desconectar();
            }
            return nuevas;
        }

        public int update(Provincia provincia)
        {
            int modificadas = 0;
            try
            {
                db.Conectar();
                string query = $"UPDATE {tabla} set nombre=@nombre WHERE {key}=@codigo";

                using (MySqlCommand cmd = new MySqlCommand(query, db.DbConn))
                {
                    cmd.Parameters.AddWithValue("@codigo", provincia.codigo);
                    cmd.Parameters.AddWithValue("@nombre", provincia.nombre);
                    modificadas = cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine($"Error al modificar Provincia: {ex.Message}");
            }
            finally
            {
                db.Desconectar();
            }
            return modificadas;
        }

        public int delete(List<string> provincias)
        {
            int borradas = 0;
            try
            {
                db.Conectar();
                string query = $"DELETE FROM {tabla} WHERE {key} IN ({string.Join(",", provincias.Select(p => "'" + p + "'"))})";
                using (MySqlCommand cmd = new MySqlCommand(query, db.DbConn))
                {
                    borradas = cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine($"Error al borrar Provincias: {ex.Message}");
            }
            finally
            {
                db.Desconectar();
            }
            return borradas;
        }

        public DataTable extraeDT()
        {
            DataTable dataTable = new DataTable();

            try
            {
                db.Conectar();
                string query = $"SELECT {DatabaseUtil.selectColumns(Dc, false)} FROM {tabla} ";
                using (MySqlDataAdapter adapter = new MySqlDataAdapter(query, db.DbConn))
                {
                    adapter.Fill(dataTable);
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine($"Error al obtener CodigoPostals: {ex.Message}");
            }
            finally
            {
                db.Desconectar();
            }

            return dataTable;
        }

        public DataTable extraeDTFiltro(string filtro, string campo)
        {
            DataTable dataTable = new DataTable();

            try
            {
                db.Conectar();

                string query = $"SELECT {DatabaseUtil.selectColumns(Dc, false)} FROM {tabla} WHERE {Dc[campo].SelectCampo} LIKE @filtro ";
                using (MySqlDataAdapter adapter = new MySqlDataAdapter(query, db.DbConn))
                {
                    adapter.SelectCommand.Parameters.AddWithValue("@filtro", "%" + filtro + "%");
                    adapter.Fill(dataTable);
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine($"Error al obtener CodigoPostals: {ex.Message}");
            }
            finally
            {
                db.Desconectar(); // Cerrar la conexión
            }

            return dataTable;
        }

        public List<Provincia> lista()
        {
            List<Provincia> list = new List<Provincia>();

            try
            {
                db.Conectar();

                string query = $"SELECT {DatabaseUtil.selectColumns(Dc, true)} FROM {tabla} ";
                using (MySqlCommand cmd = new MySqlCommand(query, db.DbConn))
                {
                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Provincia provincia = new Provincia();
                            provincia.codigo = reader["codigo"].ToString();
                            provincia.nombre = reader["nombre"].ToString();
                            list.Add(provincia);
                        }
                    }
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

            return list;
        }

        public bool validaKey(string key)
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
                Debug.WriteLine($"Error al Validar Provincia: {ex.Message}");
            }
            finally
            {
                db.Desconectar(); // Cerrar la conexión
            }

            return true; // correcto, podemos continuar
        }

        public Dictionary<string, CampoInfo> Dc { get => dc; set => dc = value; }
    }
}
