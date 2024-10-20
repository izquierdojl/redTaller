using MySqlConnector;
using redTaller.Modelo;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Diagnostics;
using System.Linq;

namespace redTaller.Database
{
    internal class ProvinciaDB : GeneralDB
    {

        public ProvinciaDB()
        {
            tabla = "provincia";
            key = "codigo";
            dc = new Dictionary<string, CampoInfo>()
            {
                { "codigo", new CampoInfo { SelectCampo = tabla + ".codigo", VisibleTabla = true, VisibleFiltro = true , Header = "Código"  } },
                { "nombre", new CampoInfo { SelectCampo = tabla + ".nombre", VisibleTabla = true, VisibleFiltro = true , Header = "Nombre"  } },
                { "id", new CampoInfo { SelectCampo = tabla + ".id", VisibleTabla = false } },
            };

        }

        public Provincia CargaElemento(int id)
        {
            Provincia provincia = new Provincia();
            try
            {
                db.Conectar();
                string query = $@"
                                SELECT {DatabaseUtil.selectColumns(dc)}
                                FROM {tabla}  
                                WHERE id=@key
                               ";

                using (MySqlCommand cmd = new MySqlCommand(query, db.DbConn))
                {
                    cmd.Parameters.AddWithValue("@key", id);
                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            provincia.id = id;
                            provincia.codigo = reader.GetString("codigo");
                            provincia.nombre = reader.GetString("nombre");
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

            return provincia;
        }

        public int insert(Provincia provincia)
        {
            int nuevas = 0;
            int lastId = 0;

            try
            {
                db.Conectar();
                string query = $"INSERT INTO {tabla} set codigo=@codigo, nombre=@nombre";

                using (MySqlCommand cmd = new MySqlCommand(query, db.DbConn))
                {
                    cmd.Parameters.AddWithValue("@codigo", provincia.codigo);
                    cmd.Parameters.AddWithValue("@nombre", provincia.nombre);
                    nuevas = cmd.ExecuteNonQuery();
                    if (nuevas > 0)
                    {
                        cmd.CommandText = "SELECT LAST_INSERT_ID()";
                        lastId = Convert.ToInt32(cmd.ExecuteScalar());
                        provincia.id = lastId;
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
                Debug.WriteLine($"Error al modificar {tabla}: {ex.Message}");
            }
            finally
            {
                db.Desconectar();
            }
            return modificadas;
        }

        public List<Provincia> lista()
        {
            List<Provincia> list = new List<Provincia>();

            try
            {
                db.Conectar();

                string query = $"SELECT {DatabaseUtil.selectColumns(dc)} FROM {tabla} ";
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

    }

}
