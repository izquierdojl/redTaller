﻿using MySqlConnector;
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
    internal class TallerDB : GeneralDB
    {
        public TallerDB()
        {
            tabla = "taller";
            key = "nif";
            dc = new Dictionary<string, CampoInfo>()
            {
                { "nif", new CampoInfo { SelectCampo = tabla + ".nif", VisibleTabla = true, VisibleFiltro = true , Header = "NIF"  } },
                { "nombre", new CampoInfo { SelectCampo = tabla + ".nombre", VisibleTabla = true, VisibleFiltro = true , Header = "Nombre"  } },
                { "domicilio", new CampoInfo { SelectCampo = tabla + ".domicilio", VisibleTabla = true, VisibleFiltro = false , Header = "Domicilio"  } },
                { "cp", new CampoInfo { SelectCampo = tabla + ".cp", VisibleTabla = true, VisibleFiltro = true , Header = "Código Postal"  } },
                { "pob", new CampoInfo { SelectCampo = tabla + ".pob", VisibleTabla = true, VisibleFiltro = true , Header = "Población"  } },
                { "pro", new CampoInfo { SelectCampo = tabla + ".pro", VisibleTabla = true, VisibleFiltro = true , Header = "Provincia"  } },
                { "tel", new CampoInfo { SelectCampo = tabla + ".tel", VisibleTabla = true, VisibleFiltro = false , Header = "Teléfono"  } },
                { "email", new CampoInfo { SelectCampo = tabla + ".email", VisibleTabla = true, VisibleFiltro = true , Header = "Correo Electrónico"  } },
                { "movil", new CampoInfo { SelectCampo = tabla + ".movil", VisibleTabla = true, VisibleFiltro = false , Header = "Número de Móvil"  } },
                { "password", new CampoInfo { SelectCampo = tabla + ".password", VisibleTabla = false, VisibleFiltro = false } },
                { "activo", new CampoInfo { SelectCampo = tabla + ".activo", VisibleTabla = true, VisibleFiltro = true , Header = "Cuenta Activa"  } },
                { "bloqueado", new CampoInfo { SelectCampo = tabla + ".bloqueado", VisibleTabla = true, VisibleFiltro = true , Header = "Cuenta Bloqueada"  } },
                { "id", new CampoInfo { SelectCampo = tabla + ".id", VisibleTabla = false } }
            };

        }

        public Taller CargaElemento(int id)
        {
            Taller taller = new Taller();
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
                            taller.password = reader.GetString("password");
                            taller.activo = reader.GetBoolean("activo");
                            taller.bloqueado = reader.GetBoolean("bloqueado");
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
                    cmd.Parameters.AddWithValue("@password", taller.password);
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
                string query = $"UPDATE {tabla} SET nif=@nif, nombre=@nombre, domicilio=@domicilio, cp=@cp, pob=@pob, pro=@pro, tel=@tel, email=@correo, movil=@movil, password=@password, activo=@activo, bloqueado=@bloqueado WHERE id=@id";
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
                    cmd.Parameters.AddWithValue("@password", taller.password);
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
                            taller.password = reader.GetString("password");
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

    }

}