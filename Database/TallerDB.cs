using MySqlConnector;
using redTaller.Database.Util;
using redTaller.Modelo;
using redTaller.Util;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;
using System.Windows.Documents;

namespace redTaller.Database
{
    internal class TallerDB : GeneralDB
    {

        private readonly ServicioCifrado servicioCifrado;

        public TallerDB()
        {
            servicioCifrado = new ServicioCifrado(Session.Instance.User, Session.Instance.Password);
            tabla = "taller";
            key = "nif";
            dc = new Dictionary<string, CampoInfo>()
            {
                { "nif", new CampoInfo { SelectCampo = tabla + ".nif", VisibleTabla = true, VisibleFiltro = true , Header = "NIF"  } },
                { "nombre", new CampoInfo { SelectCampo = tabla + ".nombre", VisibleTabla = true, VisibleFiltro = true , Header = "Nombre"  } },
                { "domicilio", new CampoInfo { SelectCampo = tabla + ".domicilio", VisibleTabla = false, VisibleFiltro = false , Header = "Domicilio"  } },
                { "cp", new CampoInfo { SelectCampo = tabla + ".cp", VisibleTabla = true, VisibleFiltro = true , Header = "Código Postal"  } },
                { "pob", new CampoInfo { SelectCampo = tabla + ".pob", VisibleTabla = true, VisibleFiltro = true , Header = "Población"  } },
                { "pro", new CampoInfo { SelectCampo = tabla + ".pro", VisibleTabla = true, VisibleFiltro = true , Header = "Provincia"  } },
                { "tel", new CampoInfo { SelectCampo = tabla + ".tel", VisibleTabla = true, VisibleFiltro = false , Header = "Teléfono"  } },
                { "email", new CampoInfo { SelectCampo = tabla + ".email", VisibleTabla = true, VisibleFiltro = true , Header = "Correo Electrónico"  } },
                { "movil", new CampoInfo { SelectCampo = tabla + ".movil", VisibleTabla = true, VisibleFiltro = false , Header = "Número de Móvil"  } },
                { "password", new CampoInfo { SelectCampo = tabla + ".password", VisibleTabla = false, VisibleFiltro = false } },
                { "activo", new CampoInfo { SelectCampo = tabla + ".activo", VisibleTabla = true, VisibleFiltro = false , Header = "Cuenta Activa"  } },
                { "bloqueado", new CampoInfo { SelectCampo = tabla + ".bloqueado", VisibleTabla = true, VisibleFiltro = false , Header = "Cuenta Bloqueada"  } },
                { "id", new CampoInfo { SelectCampo = tabla + ".id", VisibleTabla = false } }
            };

        }

        public Taller CargaElemento(int id, string queryEsp = null, string nif=null )
        {
            Taller taller = new Taller();
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
                    if (nif == null)
                    {
                        query = $@"
                                SELECT {DatabaseUtil.selectColumns(dc)}
                                FROM {tabla}
                                WHERE id=@key";
                    }
                    else
                    {
                        query = $@"
                                SELECT {DatabaseUtil.selectColumns(dc)}
                                FROM {tabla}
                                WHERE nif=@key";
                    }
                }
                using (MySqlCommand cmd = new MySqlCommand(query, db.DbConn))
                {
                    if( nif == null )
                        cmd.Parameters.AddWithValue("@key", id);
                    else
                        cmd.Parameters.AddWithValue("@key", nif);

                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            taller.id = id;
                            taller.nif = reader.GetString("nif");
                            taller.nombre = reader.GetString("nombre");
                            taller.domicilio = reader.GetString("domicilio");
                            taller.cp = reader.GetString("cp");
                            taller.pob = reader.GetString("pob");
                            taller.pro = reader.GetString("pro");
                            taller.tel = reader.GetString("tel");
                            taller.email = reader.GetString("email");
                            taller.movil = reader.GetString("movil");
                            taller.password = Encoding.UTF8.GetBytes(reader.GetString("password"));
                            taller.activo = Convert.ToBoolean(reader.GetInt32("activo"));
                            taller.bloqueado = Convert.ToBoolean(reader.GetInt32("bloqueado"));
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
            return taller;
        }

        public int insert(Taller taller)
        {
            int nuevas = 0;
            int lastId = 0;
            try
            {
                db.Conectar();
                string query = $"INSERT INTO {tabla} SET nif=@nif, nombre=@nombre, domicilio=@domicilio, cp=@cp, pob=@pob, pro=@pro, tel=@tel, email=@correo, movil=@movil, password=@password, activo=@activo, bloqueado=@bloqueado";
                using (MySqlCommand cmd = new MySqlCommand(query, db.DbConn))
                {
                    cmd.Parameters.AddWithValue("@nif", taller.nif);
                    cmd.Parameters.AddWithValue("@nombre", taller.nombre);
                    cmd.Parameters.AddWithValue("@domicilio", taller.domicilio);
                    cmd.Parameters.AddWithValue("@cp", taller.cp);
                    cmd.Parameters.AddWithValue("@pob", taller.pob);
                    cmd.Parameters.AddWithValue("@pro", taller.pro);
                    cmd.Parameters.AddWithValue("@tel", taller.tel);
                    cmd.Parameters.AddWithValue("@correo", taller.email);
                    cmd.Parameters.AddWithValue("@movil", taller.movil);
                    cmd.Parameters.AddWithValue("@activo", taller.activo);
                    cmd.Parameters.AddWithValue("@bloqueado", taller.bloqueado);
                    nuevas = cmd.ExecuteNonQuery();
                    if (nuevas > 0)
                    {
                        cmd.CommandText = "SELECT LAST_INSERT_ID()";
                        lastId = Convert.ToInt32(cmd.ExecuteScalar());
                        taller.id = lastId;
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

        public int update(Taller taller)
        {
            int modificadas = 0;
            try
            {
                db.Conectar();
                string query = $"UPDATE {tabla} SET nif=@nif, nombre=@nombre, domicilio=@domicilio, cp=@cp, pob=@pob, pro=@pro, tel=@tel, email=@correo, movil=@movil, activo=@activo, bloqueado=@bloqueado WHERE id=@id";
                using (MySqlCommand cmd = new MySqlCommand(query, db.DbConn))
                {
                    cmd.Parameters.AddWithValue("@id", taller.id);
                    cmd.Parameters.AddWithValue("@nif", taller.nif);
                    cmd.Parameters.AddWithValue("@nombre", taller.nombre);
                    cmd.Parameters.AddWithValue("@domicilio", taller.domicilio);
                    cmd.Parameters.AddWithValue("@cp", taller.cp);
                    cmd.Parameters.AddWithValue("@pob", taller.pob);
                    cmd.Parameters.AddWithValue("@pro", taller.pro);
                    cmd.Parameters.AddWithValue("@tel", taller.tel);
                    cmd.Parameters.AddWithValue("@correo", taller.email);
                    cmd.Parameters.AddWithValue("@movil", taller.movil);
                    cmd.Parameters.AddWithValue("@activo", taller.activo);
                    cmd.Parameters.AddWithValue("@bloqueado", taller.bloqueado);
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

        public int updateActivacion(Taller taller)
        {
            int modificadas = 0;
            try
            {
                db.Conectar();
                string query = $"UPDATE {tabla} SET activo=0,bloqueado=0,password=SHA2(@password,256) WHERE id=@id";
                using (MySqlCommand cmd = new MySqlCommand(query, db.DbConn))
                {
                    cmd.Parameters.AddWithValue("@id", taller.id);
                    cmd.Parameters.AddWithValue("@password", Encoding.UTF8.GetString(taller.password));
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

        public int updateActivacionPassword(string nif, string password)
        {
            int modificadas = 0;
            try
            {
                db.Conectar();
                string query = $"UPDATE {tabla} SET activo=1,bloqueado=0,password=SHA2(@password,256) WHERE nif=@nif";
                using (MySqlCommand cmd = new MySqlCommand(query, db.DbConn))
                {
                    cmd.Parameters.AddWithValue("@nif", nif );
                    cmd.Parameters.AddWithValue("@password", password );
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

        public List<Taller> lista()
        {
            List<Taller> list = new List<Taller>();

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
                            Taller taller = new Taller();
                            taller.id = reader.GetInt32("id");
                            taller.nif = reader.GetString("nif");
                            taller.nombre = reader.GetString("nombre");
                            taller.domicilio = reader.GetString("domicilio");
                            taller.cp = reader.GetString("cp");
                            taller.pob = reader.GetString("pob");
                            taller.pro = reader.GetString("pro");
                            taller.tel = reader.GetString("tel");
                            taller.email = reader.GetString("email");
                            taller.movil = reader.GetString("movil");
                            if (!reader.IsDBNull(reader.GetOrdinal("password")))
                            {
                                taller.password = (byte[])reader["password"];
                            }
                            taller.activo = reader.GetBoolean("activo");
                            taller.bloqueado = reader.GetBoolean("bloqueado");
                            list.Add(taller);
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

        public bool checkLogin(string nif, string password)
        {

            try
            {
                db.Conectar();
                string query = $@"
                                SELECT id
                                FROM {tabla}
                                WHERE nif=@nif and password=@password";
                using (MySqlCommand cmd = new MySqlCommand(query, db.DbConn))
                {
                    cmd.Parameters.AddWithValue("@nif", nif);
                    cmd.Parameters.AddWithValue("@password", Password.HashPassword(password) );
                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                            return true;
                    }
                    return false;
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine($"Error al obtener provincias: {ex.Message}");
                return false;
            }
            finally
            {
                db.Desconectar(); // Cerrar la conexión
            }
        }

    }
}
