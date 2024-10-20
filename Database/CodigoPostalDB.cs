using redTaller.Modelo;
using MySqlConnector; // Cambiar la importación aquí
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Data;
using System.Linq;

namespace redTaller.Database
{
    internal class CodigoPostalDB : GeneralDB
    {

        public CodigoPostalDB()
        {
            tabla = "codigopostal";
            key = "id";
            dc = new Dictionary<string, CampoInfo>()
            {
                { "codigo", new CampoInfo { SelectCampo = "codigopostal.codigo", VisibleTabla = true , VisibleFiltro = true , Header = "Código" } },
                { "nombre", new CampoInfo { SelectCampo = "codigopostal.nombre", VisibleTabla = true , VisibleFiltro = true , Header = "Nombre" } },
                { "codigo_provincia", new CampoInfo { SelectCampo = "provincia.codigo", VisibleTabla = false , VisibleFiltro = false , Header = "CodP" } },
                { "nombre_provincia", new CampoInfo { SelectCampo = "provincia.nombre", VisibleTabla = true,  VisibleFiltro = true , Header = "Provincia" } },
                { "id", new CampoInfo { SelectCampo = "codigopostal.id", VisibleTabla = false } }
            };
        }

        public CodigoPostal CargaElemento(int id)
        {
            CodigoPostal codigoPostal = new Modelo.CodigoPostal();
            try
            {
                db.Conectar();

                string query = $@"
                               SELECT {DatabaseUtil.selectColumns(dc)}
                               FROM {tabla}
                               LEFT JOIN provincia ON provincia.codigo=codigopostal.cod_provincia 
                               WHERE {tabla}.id=@key
                                ";
                using (MySqlCommand cmd = new MySqlCommand(query, db.DbConn))
                {
                    cmd.Parameters.AddWithValue("@key", id);
                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            codigoPostal.id = id;
                            codigoPostal.codigo = reader.GetString("codigo");
                            codigoPostal.nombre = reader.GetString("nombre");
                            codigoPostal.provincia = new Provincia(reader.GetString("codigo_provincia"), reader.GetString("nombre_provincia"));
                        }
                    }
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

            return codigoPostal;
        }

        public int Insert(CodigoPostal codigoPostal)
        {
            int nuevas = 0;
            int lastId = 0;
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
                    if (nuevas > 0)
                    {
                        cmd.CommandText = "SELECT LAST_INSERT_ID()";
                        lastId = Convert.ToInt32(cmd.ExecuteScalar());
                        codigoPostal.id = lastId;
                    }
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine($"Error al insertar {tabla}: {ex.Message}");
            }
            finally
            {
                db.Desconectar();
            }
            return lastId;
        }

        public int Update(CodigoPostal codigoPostal)
        {
            int modificadas = 0;
            try
            {
                db.Conectar();
                string query = $"UPDATE {tabla} set nombre=@nombre, cod_provincia=@cod_provincia WHERE {key}=@id";

                using (MySqlCommand cmd = new MySqlCommand(query, db.DbConn))
                {
                    cmd.Parameters.AddWithValue("@id", codigoPostal.id);
                    cmd.Parameters.AddWithValue("@nombre", codigoPostal.nombre);
                    cmd.Parameters.AddWithValue("@cod_provincia", codigoPostal.provincia.codigo);
                    modificadas = cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine($"Error al modificar {tabla}: {ex.Message}");
            }
            finally
            {
                db.Desconectar();
            }
            return modificadas;
        }

        public new DataTable Load(Dictionary<string, object> filtros = null)
        {
            DataTable dataTable = new DataTable();

            try
            {
                db.Conectar();
                string query = $@"
                                SELECT {DatabaseUtil.selectColumns(dc)} 
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

        public List<CodigoPostal> Lista()
        {
            List<CodigoPostal> list = new List<CodigoPostal>();

            try
            {
                db.Conectar();

                string query = $@"
                                SELECT {DatabaseUtil.selectColumns(dc)} 
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
                Debug.WriteLine($"Error al obtener {tabla}: {ex.Message}");
            }
            finally
            {
                db.Desconectar(); // Cerrar la conexión
            }

            return list;
        }

    }

}
