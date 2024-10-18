using redTaller.Modelo;
using MySqlConnector; // Cambiar la importación aquí
using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace redTaller.Database
{
    internal class CodigoPostalDB
    {
        private readonly DatabaseUtil db;
        private string tabla;
        private string key;
        private Dictionary<string, CampoInfo> dc;

        public CodigoPostalDB()
        {
            db = new DatabaseUtil();
            tabla = "codigopostal";
            key = "id";
            dc = new Dictionary<string, CampoInfo>()
            {
                { "codigo", new CampoInfo { SelectCampo = "codigopostal.codigo", VisibleTabla = true } },
                { "nombre", new CampoInfo { SelectCampo = "codigopostal.nombre", VisibleTabla = true } },
                { "nombre_provincia", new CampoInfo { SelectCampo = "provincia.nombre", VisibleTabla = true } },
                { "codigo_provincia", new CampoInfo { SelectCampo = "codigopostal.cod_provincia", VisibleTabla = true } },
                { "id", new CampoInfo { SelectCampo = "codigopostal.id", VisibleTabla = true } }
            };
        }

        public CodigoPostal CargaElemento(int id)
        {
            CodigoPostal codigoPostal = new Modelo.CodigoPostal();
            try
            {
                db.Conectar();

                string query = $@"
                               SELECT {DatabaseUtil.selectColumns(dc, true)}
                               FROM {tabla}
                               LEFT JOIN provincia ON provincia.codigo=codigopostal.cod_provincia 
                               WHERE id=@key
                                ";
                using (MySqlCommand cmd = new MySqlCommand(query, db.DbConn))
                {
                    cmd.Parameters.AddWithValue("@key", key);
                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            codigoPostal.codigo = reader.GetString("codigo");
                            codigoPostal.nombre = reader.GetString("nombre");
                            codigoPostal.provincia = new Provincia(reader.GetString("codigo_provincia"), reader.GetString("nombre_provincia"));
                        }
                    }
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

            return codigoPostal;
        }

        public int Insert(CodigoPostal codigoPostal)
        {
            int nuevas = 0;
            try
            {
                db.Conectar();
                string query = $"INSERT INTO {tabla} set codigo=@codigo, nombre=@nombre, cod_provincia=@cod_provincia";

                using (MySqlCommand cmd = new MySqlCommand(query, db.DbConn))
                {
                    cmd.Parameters.AddWithValue("@codigo", codigoPostal.codigo);
                    cmd.Parameters.AddWithValue("@nombre", codigoPostal.nombre);
                    cmd.Parameters.AddWithValue("@cod_provincia", codigoPostal.provincia.codigo);
                    nuevas = cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine($"Error al insertar código Postal: {ex.Message}");
            }
            finally
            {
                db.Desconectar();
            }
            return nuevas;
        }

        public int Update(CodigoPostal codigoPostal)
        {
            int modificadas = 0;
            try
            {
                db.Conectar();
                string query = $"UPDATE {tabla} set nombre=@nombre, cod_provincia=@cod_provincia WHERE {key}=@codigo";

                using (MySqlCommand cmd = new MySqlCommand(query, db.DbConn))
                {
                    cmd.Parameters.AddWithValue("@codigo", codigoPostal.codigo);
                    cmd.Parameters.AddWithValue("@nombre", codigoPostal.nombre);
                    cmd.Parameters.AddWithValue("@cod_provincia", codigoPostal.provincia.codigo);
                    modificadas = cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine($"Error al modificar CodigoPostals: {ex.Message}");
            }
            finally
            {
                db.Desconectar();
            }
            return modificadas;
        }

        public int Delete(List<string> codigosPostales)
        {
            int borradas = 0;
            try
            {
                db.Conectar();
                string query = $"DELETE FROM {tabla} WHERE {key} IN ({string.Join(",", codigosPostales)})";

                using (MySqlCommand cmd = new MySqlCommand(query, db.DbConn))
                {
                    borradas = cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine($"Error al borrar CodigoPostals: {ex.Message}");
            }
            finally
            {
                db.Desconectar();
            }
            return borradas;
        }

        public List<CodigoPostal> Load(Dictionary<string, object> filtros = null)
        {
            List<CodigoPostal> codigosPostales = new List<CodigoPostal>();

            try
            {
                db.Conectar();
                string query = $@"
                                SELECT {DatabaseUtil.selectColumns(dc, true)} 
                                FROM {tabla}
                                LEFT JOIN provincia ON provincia.codigo=codigopostal.cod_provincia
                                ";

                if (filtros != null && filtros.Count > 0)
                {
                    List<string> whereFiltros = new List<string>();
                    foreach (var filtro in filtros)
                    {
                        whereFiltros.Add($"{filtro.Key} LIKE @{filtro.Key}");
                    }
                    query += " WHERE " + string.Join(" AND ", whereFiltros);
                }

                using (MySqlCommand command = new MySqlCommand(query, db.DbConn))
                {
                    if (filtros != null && filtros.Count > 0)
                    {
                        foreach (var filtro in filtros)
                            command.Parameters.AddWithValue($"@{filtro.Key}", "%" + filtro.Value.ToString() + "%");
                    }

                    Debug.WriteLine(query); // Para ver la consulta final generada

                    using (MySqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {

                            CodigoPostal codigoPostal = new CodigoPostal();
                            codigoPostal.codigo = reader["codigo"] as string;
                            codigoPostal.nombre = reader["nombre"] as string;
                            codigoPostal.id = GetInt32(reader, "id");

                            Provincia provincia = new Provincia();
                            provincia.codigo = reader["codigo_provincia"] as string;
                            provincia.nombre = reader["nombre_provincia"] as string;
                            codigoPostal.provincia = provincia;

                            codigosPostales.Add(codigoPostal);

                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine($"Error al obtener CodigoPostals: {ex.GetType()} - {ex.Message}");
            }
            finally
            {
                db.Desconectar();
            }

            return codigosPostales;
        }

        public List<CodigoPostal> Lista()
        {
            List<CodigoPostal> list = new List<CodigoPostal>();

            try
            {
                db.Conectar();

                string query = $@"
                                SELECT {DatabaseUtil.selectColumns(dc, true)} 
                                FROM {tabla}
                                LEFT JOIN provincia ON provincia.codigo=codigopostal.cod_provincia
                                ";
                using (MySqlCommand cmd = new MySqlCommand(query, db.DbConn))
                {
                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            CodigoPostal codigoPostal = new CodigoPostal();
                            codigoPostal.codigo = reader["codigo"].ToString();
                            codigoPostal.nombre = reader["nombre"].ToString();
                            codigoPostal.provincia = new Provincia(reader["codigo_provincia"].ToString(), reader["nombre_provincia"].ToString());
                            list.Add(codigoPostal);
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

        public static Int32 GetInt32(MySqlDataReader rdr, string column)
        {
            return Convert.ToInt32(rdr[column]);
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

        public Dictionary<string, CampoInfo> Dc { get => dc; set => dc = value; }
    }
}
