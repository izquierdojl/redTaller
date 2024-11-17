using MySqlConnector;
using redTaller.Modelo;
using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Linq;

namespace redTaller.Database
{
    internal class ActuacionDB : GeneralDB
    {

        public Dictionary<string, CampoInfo> dcDetalle { get; set; }

        public ActuacionDB()
        {
            tabla = "actuacion";
            key = "id";
            dc = new Dictionary<string, CampoInfo>()
            {
                { "id", new CampoInfo { SelectCampo = "actuacion.id", VisibleTabla = true , VisibleFiltro = true , Header = "Id" } },
                { "taller", new CampoInfo { SelectCampo = "taller.nif", VisibleTabla = true , VisibleFiltro = true , Header = "NIF Taller" } },
                { "nombre_taller", new CampoInfo { SelectCampo = "taller.nombre", VisibleTabla = true , VisibleFiltro = true , Header = "Nombre Taller" } },
                { "cliente", new CampoInfo { SelectCampo = "cliente.nif", VisibleTabla = true , VisibleFiltro = true , Header = "NIF Cliente" } },
                { "nombre_cliente", new CampoInfo { SelectCampo = "cliente.nombre", VisibleTabla = true , VisibleFiltro = true , Header = "Nombre Cliente" } },
                { "matricula", new CampoInfo { SelectCampo = "actuacion.matricula", VisibleTabla = true , VisibleFiltro = true , Header = "Matrícula" } },
                { "km", new CampoInfo { SelectCampo = "actuacion.km", VisibleTabla = false , VisibleFiltro = false , Header = "Kilómetros" } },
                { "tipo", new CampoInfo { SelectCampo = "actuacion.tipo", VisibleTabla = true , VisibleFiltro = true , Header = "Tipo" } },
                { "fecha", new CampoInfo { SelectCampo = "actuacion.fecha", VisibleTabla = true , VisibleFiltro = true , Header = "Fecha" } },
            };
            this.dcDetalle = new Dictionary<string, CampoInfo>()
            {
                { "id", new CampoInfo { SelectCampo = "actuacion_detalle.id", VisibleTabla = false , VisibleFiltro = false , Header = "Id" } },
                { "id_actuacion", new CampoInfo { SelectCampo = "actuacion_detalle.id_actuacion", VisibleTabla = false , VisibleFiltro = false , Header = "ID Actuación" } },
                { "linea", new CampoInfo { SelectCampo = "actuacion_detalle.linea", VisibleTabla = false , VisibleFiltro = false , Header = "Orden" } },
                { "detalle", new CampoInfo { SelectCampo = "actuacion_detalle.detalle", VisibleTabla = true , VisibleFiltro = true , Header = "Descripción" } },
            };

        }

        public Actuacion CargaElemento(int id)
        {

            Actuacion actuacion = new Actuacion();

            string query;
            try
            {
                db.Conectar();

                query = $@"
                        SELECT {DatabaseUtil.selectColumns(dc)}
                        FROM {tabla}
                        INNER JOIN taller ON taller.nif=actuacion.nif_taller
                        INNER JOIN cliente ON cliente.nif=actuacion.nif_cliente
                        LEFT JOIN matricula ON matricula.matricula=actuacion.matricula
                        WHERE {tabla}.id=@key
                        ";
                using (MySqlCommand cmd = new MySqlCommand(query, db.DbConn))
                {

                    cmd.Parameters.AddWithValue("@key", id);
                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            actuacion.id = id;
                            actuacion.taller = new TallerDB().CargaElemento(0, "SELECT * FROM taller WHERE nif='" + reader.GetString("taller") + "'");
                            actuacion.cliente = new ClienteDB().CargaElemento(0, "SELECT * FROM cliente WHERE nif='" + reader.GetString("cliente") + "'");
                            actuacion.matricula = new MatriculaDB().CargaElemento(0, "SELECT * FROM matricula WHERE matricula='" + reader.GetString("matricula") + "'");
                            actuacion.fecha = reader.GetDateTime("fecha");
                            actuacion.km = reader.GetInt32("km");
                            actuacion.tipo = reader.GetString(reader.GetOrdinal("tipo"));
                        }
                    }
                }

                query = $@"
                        SELECT *
                        FROM actuacion_detalle
                        WHERE actuacion_detalle.id_actuacion=@id
                        ORDER BY linea
                        WHERE actuacion_detalle.id=@key
                        ";
                using (MySqlCommand cmd = new MySqlCommand(query, db.DbConn))
                {

                    cmd.Parameters.AddWithValue("@key", id);
                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            ActuacionDetalle actuacionDetalle = new ActuacionDetalle();
                            actuacionDetalle.id = reader.GetInt32("id");
                            actuacionDetalle.id_actuacion = reader.GetInt32("id_actuacion");
                            actuacionDetalle.descripcion = reader.GetString("descripcion");
                            if (!reader.IsDBNull(reader.GetOrdinal("imagen")))
                            {
                                actuacionDetalle.imagen = (byte[])reader["imagen"];
                            }

                            actuacion.actuacionDetalle.Add(actuacionDetalle);
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

            return actuacion;
        }

        public int Insert(Actuacion actuacion)
        {
            int nuevas = 0;
            int lastId = 0;
            try
            {
                db.Conectar();

                using (var transaction = db.DbConn.BeginTransaction())
                {
                    try
                    {
                        // Insertar en la tabla actuacion
                        string query = $"INSERT INTO {tabla} SET nif_taller=@nif_taller, nif_cliente=@nif_cliente, matricula=@matricula, fecha=@fecha, km=@km, tipo=@tipo";

                        using (MySqlCommand cmd = new MySqlCommand(query, db.DbConn, transaction))
                        {
                            cmd.Parameters.AddWithValue("@nif_taller", actuacion.taller.nif);
                            cmd.Parameters.AddWithValue("@nif_cliente", actuacion.cliente.nif);
                            cmd.Parameters.AddWithValue("@matricula", actuacion.matricula.matricula);
                            cmd.Parameters.AddWithValue("@fecha", actuacion.fecha);
                            cmd.Parameters.AddWithValue("@km", actuacion.km);
                            cmd.Parameters.AddWithValue("@tipo", actuacion.tipo);
                            nuevas = cmd.ExecuteNonQuery();
                            if (nuevas > 0)
                            {
                                cmd.CommandText = "SELECT LAST_INSERT_ID()";
                                lastId = Convert.ToInt32(cmd.ExecuteScalar());
                                actuacion.id = lastId;
                            }
                        }

                        if (actuacion.actuacionDetalle != null)
                        {
                            foreach (ActuacionDetalle actuacionDetalle in actuacion.actuacionDetalle)
                            {
                                query = $"INSERT INTO actuacion_detalle SET id_actuacion=@id_actuacion, orden=@orden, descripcion=@descripcion, imagen=@imagen";
                                using (MySqlCommand cmd = new MySqlCommand(query, db.DbConn, transaction))
                                {
                                    cmd.Parameters.AddWithValue("@id_actuacion", actuacion.id);
                                    cmd.Parameters.AddWithValue("@orden", actuacionDetalle.orden);
                                    cmd.Parameters.AddWithValue("@descripcion", actuacionDetalle.descripcion);
                                    cmd.Parameters.AddWithValue("@imagen", actuacionDetalle.imagen);
                                    nuevas += cmd.ExecuteNonQuery();
                                }
                            }
                        }

                        transaction.Commit();
                    }
                    catch (Exception ex)
                    {
                        // Revertir la transacción en caso de error
                        transaction.Rollback();
                        Debug.WriteLine($"Error al insertar {tabla}: {ex.Message}");
                        throw;
                    }
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine($"Error al conectar la base de datos: {ex.Message}");
            }
            finally
            {
                db.Desconectar();
            }
            return lastId;
        }

        public int Update(Actuacion actuacion)
        {
            int modificadas = 0;
            try
            {
                db.Conectar();

                using (var transaction = db.DbConn.BeginTransaction())
                {
                    try
                    {
                        // Actualizar la tabla actuacion
                        string query = $"UPDATE {tabla} SET nif_taller=@nif_taller, nif_cliente=@nif_cliente, matricula=@matricula, fecha=@fecha, km=@km, tipo=@tipo WHERE {key}=@id";

                        using (MySqlCommand cmd = new MySqlCommand(query, db.DbConn, transaction))
                        {
                            cmd.Parameters.AddWithValue("@id", actuacion.id);
                            cmd.Parameters.AddWithValue("@nif_taller", actuacion.taller.nif);
                            cmd.Parameters.AddWithValue("@nif_cliente", actuacion.cliente.nif);
                            cmd.Parameters.AddWithValue("@matricula", actuacion.matricula.matricula);
                            cmd.Parameters.AddWithValue("@fecha", actuacion.fecha);
                            cmd.Parameters.AddWithValue("@km", actuacion.km);
                            cmd.Parameters.AddWithValue("@tipo", actuacion.tipo);
                            modificadas = cmd.ExecuteNonQuery();
                        }

                        query = "DELETE FROM actuacion_detalle WHERE id_actuacion=@id_actuacion";
                        using (MySqlCommand cmd = new MySqlCommand(query, db.DbConn, transaction))
                        {
                            cmd.Parameters.AddWithValue("@id_actuacion", actuacion.id);
                            modificadas += cmd.ExecuteNonQuery();
                        }

                        if (actuacion.actuacionDetalle != null)
                        {
                            foreach (ActuacionDetalle actuacionDetalle in actuacion.actuacionDetalle)
                            {
                                query = $"INSERT INTO actuacion_detalle (id_actuacion, orden, descripcion, imagen) VALUES (@id_actuacion, @orden, @descripcion, @imagen)";
                                using (MySqlCommand cmd = new MySqlCommand(query, db.DbConn, transaction))
                                {
                                    cmd.Parameters.AddWithValue("@id_actuacion", actuacion.id);
                                    cmd.Parameters.AddWithValue("@orden", actuacionDetalle.orden);
                                    cmd.Parameters.AddWithValue("@descripcion", actuacionDetalle.descripcion);
                                    cmd.Parameters.AddWithValue("@imagen", actuacionDetalle.imagen);
                                    modificadas += cmd.ExecuteNonQuery();
                                }
                            }
                        }

                        transaction.Commit();
                    }
                    catch (Exception ex)
                    {
                        transaction.Rollback();
                        Debug.WriteLine($"Error al modificar {tabla}: {ex.Message}");
                        throw;
                    }
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine($"Error al conectar la base de datos: {ex.Message}");
            }
            finally
            {
                db.Desconectar();
            }
            return modificadas;
        }

        public DataTable Load(Dictionary<string, object> filtros = null)
        {
            DataTable dataTable = new DataTable();

            try
            {
                db.Conectar();
                string query = $@"
                                SELECT {DatabaseUtil.selectColumns(dc)} 
                                FROM {tabla}
                                INNER JOIN taller ON taller.nif=actuacion.nif_taller
                                INNER JOIN cliente ON cliente.nif=actuacion.nif_cliente
                                LEFT JOIN matricula ON matricula.matricula=actuacion.matricula
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

        public DataTable LoadDetalle(int id, Dictionary<string, object> filtros = null)
        {
            DataTable dataTable = new DataTable();

            try
            {
                db.Conectar();
                string query = $@"
                        SELECT {DatabaseUtil.selectColumns(dcDetalle)} 
                        FROM actuacion_detalle
                        WHERE actuacion_detalle.id_actuacion=@id
                        ";

                if (filtros != null && filtros.Count > 0)
                {
                    List<string> whereFiltros = new List<string>();
                    foreach (var filtro in filtros)
                    {
                        whereFiltros.Add($"{filtro.Key} LIKE @{filtro.Key}");
                    }
                    query += " AND " + string.Join(" AND ", whereFiltros);
                }

                using (MySqlCommand cmd = new MySqlCommand(query, db.DbConn))
                {
                    cmd.Parameters.AddWithValue("@id", id);
                    if (filtros != null && filtros.Count > 0)
                    {
                        foreach (var filtro in filtros)
                        {
                            cmd.Parameters.AddWithValue($"@{filtro.Key}", "%" + filtro.Value.ToString() + "%");
                        }
                    }
                    using (MySqlDataAdapter adapter = new MySqlDataAdapter(cmd))
                    {
                        adapter.Fill(dataTable);
                    }
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine($"Error al obtener Detalle de Actuación: {ex.Message}");
            }
            finally
            {
                db.Desconectar();
            }

            return dataTable;
        }

        public List<Actuacion> Lista()
        {
            List<Actuacion> list = new List<Actuacion>();

            try
            {
                db.Conectar();

                string query = $@"
                                SELECT {DatabaseUtil.selectColumns(dc)} 
                                FROM {tabla}
                                INNER JOIN taller ON taller.nif=actuacion.nif_taller
                                INNER JOIN cliente ON cliente.nif=actuacion.nif_cliente
                                LEFT JOIN matricula ON matricula.matricula=actuacion.matricula
                                ";
                using (MySqlCommand cmd = new MySqlCommand(query, db.DbConn))
                {
                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Actuacion actuacion = new Actuacion();
                            actuacion.id = reader.GetInt32("id");
                            actuacion.taller = new TallerDB().CargaElemento(0, "SELECT nif FROM taller WHERE nif='" + reader.GetString("nif_taller") + "'");
                            actuacion.cliente = new ClienteDB().CargaElemento(0, "SELECT nif FROM cliente WHERE nif='" + reader.GetString("nif_cliente") + "'");
                            actuacion.fecha = reader.GetDateTime("fecha");
                            actuacion.km = reader.GetInt32("km");
                            actuacion.tipo = reader.GetString(reader.GetOrdinal("tipo"));
                            list.Add(actuacion);
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

        public int Delete(List<int> ids)
        {
            int borradas = 0;
            try
            {
                db.Conectar();
                using (var transaction = db.DbConn.BeginTransaction())
                {
                    try
                    {

                        string queryDetalle = $"DELETE FROM actuacion_detalle WHERE id_actuacion IN ({string.Join(",", ids.Select(id => "'" + id + "'"))})";
                        using (var cmd = new MySqlCommand(queryDetalle, db.DbConn, transaction))
                        {
                            borradas += cmd.ExecuteNonQuery();
                        }

                        string queryActuacion = $"DELETE FROM {tabla} WHERE id IN ({string.Join(",", ids.Select(id => "'" + id + "'"))})";
                        using (var cmd = new MySqlCommand(queryActuacion, db.DbConn, transaction))
                        {
                            borradas += cmd.ExecuteNonQuery();
                        }

                        transaction.Commit();

                    }

                    catch (Exception ex)
                    {
                        transaction.Rollback();
                        Debug.WriteLine($"Error al borrar {tabla}: {ex.Message}");
                        throw;
                    }
                }

            }

            catch (Exception ex)
            {
                Debug.WriteLine($"Error al conectar la base de datos: {ex.Message}");
            }
            finally
            {
                db.Desconectar();
            }
            return borradas;
        }

    }

}
