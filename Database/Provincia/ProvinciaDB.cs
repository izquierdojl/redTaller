﻿using MySql.Data.MySqlClient;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace redTaller.Database.Provincia
{
    internal class ProvinciaDB
    {

        private readonly DatabaseUtil db;

        public ProvinciaDB()
        {
            db = new DatabaseUtil();
        }

        public DataTable extraeProvincias()
        {

            MySqlDataAdapter adapter = null;
            DataTable dataTable = new DataTable();

            try
            {
                db.Conectar();
                string query = "SELECT codigo, nombre FROM provincia";
                adapter = new MySqlDataAdapter(query, db.DbConn);
                adapter.Fill(dataTable);
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
    }
}