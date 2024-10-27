using MySqlConnector;
using redCliente.Modelo;
using redTaller.Modelo;
using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Documents;

namespace redTaller.Database
{
    internal class ClienteDB : GeneralDB
    {
        public ClienteDB()
        {
            tabla = "cliente";
            key = "nif";
            dc = new Dictionary<string, CampoInfo>()
            {
                { "nif", new CampoInfo { SelectCampo = tabla + ".nif", VisibleTabla = true, VisibleFiltro = true , Header = "NIF"  } },
                { "nombre", new CampoInfo { SelectCampo = tabla + ".nombre", VisibleTabla = true, VisibleFiltro = true , Header = "Nombre"  } },
                { "domicilio", new CampoInfo { SelectCampo = tabla + ".domicilio", VisibleTabla = false, VisibleFiltro = false , Header = "Domicilio"  } },
                { "cp", new CampoInfo { SelectCampo = tabla + ".cp", VisibleTabla = false, VisibleFiltro = true , Header = "Código Postal"  } },
                { "pob", new CampoInfo { SelectCampo = tabla + ".pob", VisibleTabla = false, VisibleFiltro = true , Header = "Población"  } },
                { "pro", new CampoInfo { SelectCampo = tabla + ".pro", VisibleTabla = true, VisibleFiltro = true , Header = "Provincia"  } },
                { "tel", new CampoInfo { SelectCampo = tabla + ".tel", VisibleTabla = false, VisibleFiltro = false , Header = "Teléfono"  } },
                { "email", new CampoInfo { SelectCampo = tabla + ".email", VisibleTabla = false, VisibleFiltro = false , Header = "Correo Electrónico"  } },
                { "movil", new CampoInfo { SelectCampo = tabla + ".movil", VisibleTabla = true, VisibleFiltro = false , Header = "Número de Móvil"  } },
                { "password", new CampoInfo { SelectCampo = tabla + ".password", VisibleTabla = false, VisibleFiltro = false } },
                { "activo", new CampoInfo { SelectCampo = tabla + ".activo", VisibleTabla = true, VisibleFiltro = false , Header = "Cuenta Activa"  } },
                { "bloqueado", new CampoInfo { SelectCampo = tabla + ".bloqueado", VisibleTabla = true, VisibleFiltro = false , Header = "Cuenta Bloqueada"  } },
                { "nif_taller_alta", new CampoInfo { SelectCampo = tabla + ".nif_taller_alta", VisibleTabla = true, VisibleFiltro = true , Header = "Taller Alta"  } },
                { "id", new CampoInfo { SelectCampo = tabla + ".id", VisibleTabla = false } }
            };

        }

        public Cliente CargaElemento(int id)
        {
            Cliente cliente = new Cliente();
            try
            {
                db.Conectar();
                string query = $@"
                        SELECT {DatabaseUtil.selectColumns(dc)}
                        FROM {tabla}
                        WHERE id=@key";
                using (MySqlCommand cmd = new MySqlCommand(query, db.DbConn))
                {
                    cmd.Parameters.AddWithValue("@key", id);
                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            cliente.id = id;
                            cliente.nif = reader.GetString("nif");
                            cliente.nombre = reader.GetString("nombre");
                            cliente.domicilio = reader.GetString("domicilio");
                            cliente.cp = reader.GetString("cp");
                            cliente.pob = reader.GetString("pob");
                            cliente.pro = reader.GetString("pro");
                            cliente.tel = reader.GetString("tel");
                            cliente.email = reader.GetString("email");
                            cliente.movil = reader.GetString("movil");
                            if (!reader.IsDBNull(reader.GetOrdinal("password")))
                            {
                                cliente.password = (byte[])reader["password"];
                            }
                            cliente.activo = Convert.ToBoolean(reader.GetInt32("activo"));
                            cliente.bloqueado = Convert.ToBoolean(reader.GetInt32("bloqueado"));
                            TallerDB tallerDB = new TallerDB();
                            cliente.nif_taller_alta = tallerDB.CargaElemento(0, $"SELECT * FROM taller WHERE taller.nif={reader.GetString("nif_taller_alta")}");
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
            return cliente;
        }

        public int insert(Cliente cliente)
        {
            int nuevas = 0;
            int lastId = 0;
            try
            {
                db.Conectar();
                string query = $"INSERT INTO {tabla} SET nif=@nif, nombre=@nombre, domicilio=@domicilio, cp=@cp, pob=@pob, pro=@pro, tel=@tel, email=@correo, movil=@movil, password=@password, activo=@activo, bloqueado=@bloqueado, nif_taller_alta=@nif_taller_alta";
                using (MySqlCommand cmd = new MySqlCommand(query, db.DbConn))
                {
                    cmd.Parameters.AddWithValue("@nif", cliente.nif);
                    cmd.Parameters.AddWithValue("@nombre", cliente.nombre);
                    cmd.Parameters.AddWithValue("@domicilio", cliente.domicilio);
                    cmd.Parameters.AddWithValue("@cp", cliente.cp);
                    cmd.Parameters.AddWithValue("@pob", cliente.pob);
                    cmd.Parameters.AddWithValue("@pro", cliente.pro);
                    cmd.Parameters.AddWithValue("@tel", cliente.tel);
                    cmd.Parameters.AddWithValue("@correo", cliente.email);
                    cmd.Parameters.AddWithValue("@movil", cliente.movil);
                    cmd.Parameters.AddWithValue("@password", cliente.password);
                    cmd.Parameters.AddWithValue("@activo", cliente.activo);
                    cmd.Parameters.AddWithValue("@bloqueado", cliente.bloqueado);
                    cmd.Parameters.AddWithValue("@nif_taller_alta", cliente.nif_taller_alta.nif);
                    nuevas = cmd.ExecuteNonQuery();
                    if (nuevas > 0)
                    {
                        cmd.CommandText = "SELECT LAST_INSERT_ID()";
                        lastId = Convert.ToInt32(cmd.ExecuteScalar());
                        cliente.id = lastId;
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

        public int update(Cliente cliente)
        {
            int modificadas = 0;
            try
            {
                db.Conectar();
                string query = $"UPDATE {tabla} SET nif=@nif, nombre=@nombre, domicilio=@domicilio, cp=@cp, pob=@pob, pro=@pro, tel=@tel, email=@correo, movil=@movil, password=@password, activo=@activo, bloqueado=@bloqueado WHERE id=@id";
                using (MySqlCommand cmd = new MySqlCommand(query, db.DbConn))
                {
                    cmd.Parameters.AddWithValue("@id", cliente.id);
                    cmd.Parameters.AddWithValue("@nif", cliente.nif);
                    cmd.Parameters.AddWithValue("@nombre", cliente.nombre);
                    cmd.Parameters.AddWithValue("@domicilio", cliente.domicilio);
                    cmd.Parameters.AddWithValue("@cp", cliente.cp);
                    cmd.Parameters.AddWithValue("@pob", cliente.pob);
                    cmd.Parameters.AddWithValue("@pro", cliente.pro);
                    cmd.Parameters.AddWithValue("@tel", cliente.tel);
                    cmd.Parameters.AddWithValue("@correo", cliente.email);
                    cmd.Parameters.AddWithValue("@movil", cliente.movil);
                    cmd.Parameters.AddWithValue("@password", cliente.password);
                    cmd.Parameters.AddWithValue("@activo", cliente.activo);
                    cmd.Parameters.AddWithValue("@bloqueado", cliente.bloqueado);
                    cmd.Parameters.AddWithValue("@nif_taller_alta", cliente.nif_taller_alta.nif);
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

        public List<Cliente> lista()
        {
            List<Cliente> list = new List<Cliente>();

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
                            Cliente cliente = new Cliente();   
                            cliente.id = reader.GetInt32("id");
                            cliente.nif = reader.GetString("nif");
                            cliente.nombre = reader.GetString("nombre");
                            cliente.domicilio = reader.GetString("domicilio");
                            cliente.cp = reader.GetString("cp");
                            cliente.pob = reader.GetString("pob");
                            cliente.pro = reader.GetString("pro");
                            cliente.tel = reader.GetString("tel");
                            cliente.email = reader.GetString("email");
                            cliente.movil = reader.GetString("movil");
                            if (!reader.IsDBNull(reader.GetOrdinal("password")))
                            {
                                cliente.password = (byte[])reader["password"];
                            }
                            cliente.activo = reader.GetBoolean("activo");
                            cliente.bloqueado = reader.GetBoolean("bloqueado");
                            TallerDB tallerDB = new TallerDB();
                            cliente.nif_taller_alta = tallerDB.CargaElemento(0, $"SELECT * FROM taller WHERE taller.nif={reader.GetString("nif_taller_alta")}");
                            list.Add(cliente);
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
