using redTaller.Modelo;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;

namespace redTaller.Database
{
    internal class CodigoPostalDB
    {

        private readonly DatabaseUtil db;

        public CodigoPostalDB()
        {
            db = new DatabaseUtil();
        }

        public CodigoPostal CargaCodigoPostal(string key)
        {
            CodigoPostal CodigoPostal = new Modelo.CodigoPostal();
            try
            {
                db.Conectar();
                string query = "SELECT codigopostal.codigo," +
                               "       codigopostal.nombre, " +
                               " provincia.nombre as nombre_provincia " + 
                               " FROM codigopostal " +
                               "   LEFT JOIN provincia ON provincia.codigo=codigopostal.cod_provincia "+
                               " WHERE codigopostal.codigo=@key" ;
                MySqlCommand cmd = new MySqlCommand(query, db.DbConn);
                cmd.Parameters.AddWithValue("@key", key);
                using (MySqlDataReader reader = cmd.ExecuteReader())
                {
                    if ( reader.Read() ) 
                    {
                        CodigoPostal.Codigo = reader.GetString("codigo");
                        CodigoPostal.Nombre = reader.GetString("nombre");
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
                string query = "INSERT INTO codigopostal set codigo=@codigo, nombre=@nombre";

                using (MySqlCommand cmd = new MySqlCommand(query, db.DbConn))
                {
                    cmd.Parameters.AddWithValue("@codigo",CodigoPostal.Codigo);
                    cmd.Parameters.AddWithValue("@nombre", CodigoPostal.Nombre);
                    nuevas = cmd.ExecuteNonQuery();
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
            return nuevas;

        }

        public int updateCodigoPostal(CodigoPostal CodigoPostal)
        {
            int modificadas = 0;
            try
            {
                db.Conectar();
                string query = "UPDATE codigopostal set nombre=@nombre WHERE codigo=@codigo";

                using (MySqlCommand cmd = new MySqlCommand(query, db.DbConn))
                {
                    cmd.Parameters.AddWithValue("@codigo", CodigoPostal.Codigo);
                    cmd.Parameters.AddWithValue("@nombre", CodigoPostal.Nombre);
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
                string query = "SELECT codigopostal.codigo as codigo," +
                               "       codigopostal.nombre as nombre, " +
                               " provincia.nombre as nombre_provincia " +
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

                string query = "SELECT codigo, nombre FROM codigopostal WHERE " + campo + " LIKE @Filtro";
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

    }
}
