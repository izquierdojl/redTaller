using MySqlConnector;
using redTaller.Modelo;
using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace redTaller.Database
{
    internal class MatriculaDB : GeneralDB
    {

        public MatriculaDB()
        {
            tabla = "matricula";
            key = "matricula";
            dc = new Dictionary<string, CampoInfo>()
            {
                { "matricula", new CampoInfo { SelectCampo = tabla + ".matricula", VisibleTabla = true, VisibleFiltro = true , Header = "Matrícula"  } },
                { "modelo", new CampoInfo { SelectCampo = tabla + ".modelo", VisibleTabla = true, VisibleFiltro = true , Header = "Modelo"  } },
                { "marca", new CampoInfo { SelectCampo = tabla + ".marca", VisibleTabla = true, VisibleFiltro = true , Header = "Marca"  } },
                { "id", new CampoInfo { SelectCampo = tabla + ".id", VisibleTabla = false } },
            };

        }

        public Matricula CargaElemento(int id, string queryEsp = null)
        {
            Matricula matricula = new Matricula();  
            try
            {
                db.Conectar();
                string query;
                if (queryEsp != null)
                {
                    query = queryEsp;
                }
                else
                {
                    query = $@"
                            SELECT {DatabaseUtil.selectColumns(dc)}
                            FROM {tabla}
                            WHERE id=@key";
                }
                using (MySqlCommand cmd = new MySqlCommand(query, db.DbConn))
                {
                    cmd.Parameters.AddWithValue("@key", id);
                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            matricula.id = id;
                            matricula.matricula = reader.GetString("matricula");
                            matricula.marca = reader.GetString("marca");
                            matricula.modelo = reader.GetString("modelo");
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
            return matricula;
        }

        public int insert(Matricula matricula)
        {
            int nuevas = 0;
            int lastId = 0;
            try
            {
                db.Conectar();
                string query = $"INSERT INTO {tabla} SET matricula=@matricula, marca=@marca, modelo=@modelo";
                using (MySqlCommand cmd = new MySqlCommand(query, db.DbConn))
                {
                    cmd.Parameters.AddWithValue("@matricula", matricula.matricula);
                    cmd.Parameters.AddWithValue("@marca", matricula.marca);
                    cmd.Parameters.AddWithValue("@modelo", matricula.modelo);
                    nuevas = cmd.ExecuteNonQuery();
                    if (nuevas > 0)
                    {
                        cmd.CommandText = "SELECT LAST_INSERT_ID()";
                        lastId = Convert.ToInt32(cmd.ExecuteScalar());
                        matricula.id = lastId;
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

        public int update(Matricula matricula)
        {
            int modificadas = 0;
            try
            {
                db.Conectar();
                string query = $"UPDATE {tabla} SET  matricula=@matricula, marca=@marca, imagen=@imagen WHERE id=@id";
                using (MySqlCommand cmd = new MySqlCommand(query, db.DbConn))
                {
                    cmd.Parameters.AddWithValue("@id", matricula.id);
                    cmd.Parameters.AddWithValue("@marca", matricula.marca);
                    cmd.Parameters.AddWithValue("@modelo", matricula.modelo);
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

        public List<Matricula> lista()
        {
            List<Matricula> list = new List<Matricula>();
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
                            Matricula matricula = new Matricula();
                            matricula.id = reader.GetInt32("id"); ;
                            matricula.matricula = reader.GetString("matricula");
                            matricula.marca = reader.GetString("marca");
                            matricula.modelo = reader.GetString("modelo");
                            list.Add(matricula);
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
