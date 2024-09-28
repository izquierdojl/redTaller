using MySql.Data.MySqlClient;
using redTaller.Database;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace redTaller.Vista
{
    public partial class VistaListaProvincia : Form
    {
        public VistaListaProvincia()
        {
            InitializeComponent();
            CargarProvincias();
        }

        private void CargarProvincias()
        {

           DatabaseUtil db = new DatabaseUtil();
            try
            {
                // Abrir la conexión a la base de datos
                db.Conectar();
                string query = "SELECT codigo, nombre FROM provincia";
                MySqlDataAdapter adapter = new MySqlDataAdapter( query, db.DbConn );
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);
                gridProvincias.DataSource = dataTable;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
    }
}
