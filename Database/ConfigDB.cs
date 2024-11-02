using MySqlConnector;
using redTaller.Modelo;
using System;
using System.Diagnostics;

namespace redTaller.Database
{
    internal class ConfigDB : GeneralDB
    {

        private readonly ServicioCifrado servicioCifrado;

        public ConfigDB()
        {
            tabla = "config";
            servicioCifrado = new ServicioCifrado();
        }

        public Config Carga()
        {
            Config config = new Config();
            try
            {
                db.Conectar();
                string query;
                query = $@"
                        SELECT *
                        FROM {tabla}
                        LIMIT 1";
                using (MySqlCommand cmd = new MySqlCommand(query, db.DbConn))
                {
                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {

                            config.EmailCuenta = reader.IsDBNull(reader.GetOrdinal("email_cuenta")) ? null : reader.GetString("email_cuenta");
                            config.EmailSmtpServer = reader.IsDBNull(reader.GetOrdinal("email_smtp_server")) ? null : reader.GetString("email_smtp_server");
                            config.EmailSmtpPort = reader.IsDBNull(reader.GetOrdinal("email_smtp_port")) ? 0 : reader.GetInt32("email_smtp_port");
                            config.EmailUser = reader.IsDBNull(reader.GetOrdinal("email_user")) ? null : reader.GetString("email_user");

                            string passwordCifrada = reader.IsDBNull(reader.GetOrdinal("email_password")) ? null : reader.GetString("email_password");
                            config.EmailPassword = passwordCifrada != null ? servicioCifrado.Descifrar(passwordCifrada) : null;

                            passwordCifrada = reader.IsDBNull(reader.GetOrdinal("master_password")) ? null : reader.GetString("master_password");
                            config.MasterPassword = passwordCifrada != null ? servicioCifrado.Descifrar(passwordCifrada) : null;

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
            return config;
        }

        public int Guarda(Config config)
        {
            int modificadas = 0;
            try
            {
                string query;
                string queryAct = "";
                db.Conectar();
                query = $@"
                        SELECT COUNT(*) as cuenta
                        FROM {tabla}";
                using (MySqlCommand cmd = new MySqlCommand(query, db.DbConn))
                {
                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            if (reader.GetInt32("cuenta") == 0)
                                queryAct = $"INSERT INTO {tabla} SET ";
                            else
                                queryAct = $"UPDATE {tabla} SET ";
                        }
                    }

                    queryAct += @" email_cuenta = @email_cuenta,
                                   email_user = @email_user,
                                   email_password = @email_password,
                                   email_smtp_server = @email_smtp_server,
                                   email_smtp_port = @email_smtp_port, 
                                   master_password = @master_password ";

                    using (MySqlCommand cmdAct = new MySqlCommand(queryAct, db.DbConn))
                    {

                        cmdAct.Parameters.AddWithValue("@email_cuenta", config.EmailCuenta );
                        cmdAct.Parameters.AddWithValue("@email_user", config.EmailUser);
                        cmdAct.Parameters.AddWithValue("@email_smtp_server", config.EmailSmtpServer);
                        cmdAct.Parameters.AddWithValue("@email_smtp_port", config.EmailSmtpPort);
                        string passwordCifrada = servicioCifrado.Cifrar(config.EmailPassword);
                        cmdAct.Parameters.AddWithValue("@email_password", passwordCifrada);
                        passwordCifrada = servicioCifrado.Cifrar(config.MasterPassword);
                        cmdAct.Parameters.AddWithValue("@master_password", passwordCifrada);
                        modificadas = cmdAct.ExecuteNonQuery();
                    }

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

    }
}
