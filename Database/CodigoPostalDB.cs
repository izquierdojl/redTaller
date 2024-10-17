using redTaller.Modelo;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Windows.Documents;

namespace redTaller.Database
{
    internal class CodigoPostalDB
    {

        private readonly DatabaseUtil db;
        private Dictionary<string, CampoInfo> dc;

        public CodigoPostalDB()
        {
            db = new DatabaseUtil();
            Dc = new Dictionary<string, CampoInfo>()
            {
                { "codigo", new CampoInfo { SelectCampo = "codigopostal.codigo", VisibleTabla = true } },
                { "nombre", new CampoInfo { SelectCampo = "codigopostal.nombre", VisibleTabla = true } },
                { "nombre_provincia", new CampoInfo { SelectCampo = "provincia.nombre", VisibleTabla = true } },
                { "codigo_provincia", new CampoInfo { SelectCampo = "codigopostal.cod_provincia", VisibleTabla = false } }
            };

        }

        public CodigoPostal CargaCodigoPostal(string key)
        {
            CodigoPostal CodigoPostal = new Modelo.CodigoPostal();
            try
            {
                db.Conectar();
                string query = "SELECT " + DatabaseUtil.selectColumns(Dc,true) + 
                               " FROM codigopostal " +
                               "   LEFT JOIN provincia ON provincia.codigo=codigopostal.cod_provincia "+
                               " WHERE " + dc["codigo"].SelectCampo + "=@key" ;
                MySqlCommand cmd = new MySqlCommand(query, db.DbConn);
                cmd.Parameters.AddWithValue("@key", key);
                using (MySqlDataReader reader = cmd.ExecuteReader())
                {
                    if ( reader.Read() ) 
                    {
                        CodigoPostal.Codigo = reader.GetString("codigo");
                        CodigoPostal.Nombre = reader.GetString("nombre");
                        CodigoPostal.Provincia = new Provincia(reader.GetString("codigo_provincia"),reader.GetString("nombre_provincia"));
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

            return CodigoPostal;

        }

        public int insertCodigoPostal(CodigoPostal CodigoPostal)
        {
            int nuevas = 0;
            try
            {
                db.Conectar();
                string query = "INSERT INTO codigopostal set codigo=@codigo, nombre=@nombre, cod_provincia=@cod_provincia";

                using (MySqlCommand cmd = new MySqlCommand(query, db.DbConn))
                {
                    cmd.Parameters.AddWithValue("@codigo",CodigoPostal.Codigo);
                    cmd.Parameters.AddWithValue("@nombre", CodigoPostal.Nombre);
                    cmd.Parameters.AddWithValue("@cod_provincia", CodigoPostal.Provincia.Codigo);
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

        public int updateCodigoPostal(CodigoPostal CodigoPostal)
        {
            int modificadas = 0;
            try
            {
                db.Conectar();
                string query = "UPDATE codigopostal set nombre=@nombre, cod_provincia=@cod_provincia WHERE codigo=@codigo";

                using (MySqlCommand cmd = new MySqlCommand(query, db.DbConn))
                {
                    cmd.Parameters.AddWithValue("@codigo", CodigoPostal.Codigo);
                    cmd.Parameters.AddWithValue("@nombre", CodigoPostal.Nombre);
                    cmd.Parameters.AddWithValue("@cod_provincia", CodigoPostal.Provincia.Codigo);
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

        public int deleteCodigoPostals(List<string> CodigoPostals)
        {
            int borradas = 0;
            try
            {
                db.Conectar();
                string query = "DELETE FROM codigopostal WHERE codigo IN (" + string.Join(",", CodigoPostals) + ")";

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

        public DataTable extraeCodigosPostal()
        {

            DataTable dataTable = new DataTable();

            try
            {
                db.Conectar();
                string query = "SELECT " + DatabaseUtil.selectColumns(Dc,false) + 
                               " FROM codigopostal " +
                               "   LEFT JOIN provincia ON provincia.codigo=codigopostal.cod_provincia ";
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

        public DataTable extraeCodigoPostalsFiltro(string filtro, string campo)
        {

            DataTable dataTable = new DataTable();

            try
            {
                db.Conectar();

                string query = "SELECT " + DatabaseUtil.selectColumns(Dc,false) + 
                               "   FROM codigopostal " +
                               "   LEFT JOIN provincia ON provincia.codigo=codigopostal.cod_provincia " +
                               "   WHERE " + Dc[campo].SelectCampo +" LIKE @filtro ";
                using (MySqlDataAdapter adapter = new MySqlDataAdapter(query, db.DbConn))
                {
                    adapter.SelectCommand.Parameters.AddWithValue("@Filtro", "%" + filtro + "%");
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

        public List<CodigoPostal> listCodigosPostal()
        {
            List<CodigoPostal> list = new List<CodigoPostal>();

            try
            {
                db.Conectar();

                string query = "SELECT " + DatabaseUtil.selectColumns(Dc, true) + 
                               " provincia.nombre as nombre_provincia " +
                               " FROM codigopostal " +
                               "   LEFT JOIN provincia ON provincia.codigo=codigopostal.cod_provincia ";

                MySqlCommand cmd = new MySqlCommand(query, db.DbConn);

                using (MySqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        CodigoPostal codigoPostal = new CodigoPostal();
                        codigoPostal.Codigo = reader["codigo"].ToString();
                        codigoPostal.Nombre = reader["nombre"].ToString();
                        codigoPostal.Provincia = new Provincia(reader["provincia"].ToString(), reader["nombre_provincia"].ToString());
                        list.Add(codigoPostal);
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

        public bool validaKey( string key )
        {

            try
            {
                db.Conectar();

                string query = "SELECT * " +
                               " FROM codigopostal " +
                               " WHERE codigo=@key ";
                MySqlCommand cmd = new MySqlCommand(query, db.DbConn);
                cmd.Parameters.AddWithValue("@key", key);
                using (MySqlDataReader reader = cmd.ExecuteReader())
                {
                    if (reader.Read()) {
                        return false;
                    }
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine($"Error al Validar Código POstal: {ex.Message}");
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
