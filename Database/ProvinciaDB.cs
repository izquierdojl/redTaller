using redTaller.Modelo;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;

namespace redTaller.Database
{
    internal class ProvinciaDB
    {

        private readonly DatabaseUtil db;

        public ProvinciaDB()
        {
            db = new DatabaseUtil();
        }

        public Provincia CargaProvincia(string key)
        {
            Provincia provincia = new Modelo.Provincia();
            try
            {
                db.Conectar();
                string query = "SELECT * FROM provincia";
                MySqlCommand cmd = new MySqlCommand(query, db.DbConn);
                using (MySqlDataReader reader = cmd.ExecuteReader())
                {
                    if ( reader.Read() ) 
                    {
                        provincia.Codigo = reader.GetString("codigo");
                        provincia.Nombre = reader.GetString("nombre");
                    }
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine($"Error al obtener provincias: {ex.Message}");
            }
            finally
            {
                db.Desconectar();
            }

            return provincia;

        }

        public int insertProvincia(Provincia provincia)
        {
            int nuevas = 0;
            try
            {
                db.Conectar();
                string query = "INSERT INTO provincia set codigo=@codigo, nombre=@nombre";

                using (MySqlCommand cmd = new MySqlCommand(query, db.DbConn))
                {
                    cmd.Parameters.AddWithValue("@codigo",provincia.Codigo);
                    cmd.Parameters.AddWithValue("@nombre", provincia.Nombre);
                    nuevas = cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine($"Error al borrar provincias: {ex.Message}");
            }
            finally
            {
                db.Desconectar();
            }
            return nuevas;

        }

        public int updateProvincia(Provincia provincia)
        {
            int modificadas = 0;
            try
            {
                db.Conectar();
                string query = "UPDATE provincia set nombre=@nombre WHERE codigo=@codigo";

                using (MySqlCommand cmd = new MySqlCommand(query, db.DbConn))
                {
                    cmd.Parameters.AddWithValue("@codigo", provincia.Codigo);
                    cmd.Parameters.AddWithValue("@nombre", provincia.Nombre);
                    modificadas = cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine($"Error al modificar provincias: {ex.Message}");
            }
            finally
            {
                db.Desconectar();
            }
            return modificadas;

        }

        public int deleteProvincias(List<string> provincias)
        {
            int borradas = 0;
            try
            {
                db.Conectar();
                string query = "DELETE FROM provincia WHERE codigo IN (" + string.Join(",", provincias) + ")";

                using (MySqlCommand cmd = new MySqlCommand(query, db.DbConn))
                {

                    borradas = cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine($"Error al borrar provincias: {ex.Message}");
            }
            finally
            {
                db.Desconectar();
            }
            return borradas;
        }

        public DataTable extraeProvincias()
        {

            DataTable dataTable = new DataTable();

            try
            {
                db.Conectar();
                string query = "SELECT codigo, nombre FROM provincia";
                using (MySqlDataAdapter adapter = new MySqlDataAdapter(query, db.DbConn))
                {
                    adapter.Fill(dataTable);
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine($"Error al obtener provincias: {ex.Message}");
            }
            finally
            {
                db.Desconectar();
            }

            return dataTable;
        }

        public DataTable extraeProvinciasFiltro(string filtro)
        {

            DataTable dataTable = new DataTable();

            try
            {
                db.Conectar();

                string query = "SELECT codigo, nombre FROM provincia WHERE nombre LIKE @Filtro";

                using (MySqlDataAdapter adapter = new MySqlDataAdapter(query, db.DbConn))
                {
                    adapter.SelectCommand.Parameters.AddWithValue("@Filtro", "%" + filtro + "%");
                    adapter.Fill(dataTable);
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

            return dataTable;
        }

    }
}
