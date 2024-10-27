using redTaller.Controlador;
using redTaller.Database;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace redTaller.Vista.VistaCliente
{
    public partial class VistaListaCliente : redTaller.Vista.VistaBase.VistaListaBase
    {

        ControladorCliente controlador = new ControladorCliente();
        Dictionary<string, CampoInfo> dc;

        public VistaListaCliente(DataTable data, Dictionary<string, CampoInfo> dc)
        {

            InitializeComponent();
            gridPrincipal.AutoGenerateColumns = true;
            this.dc = dc;

            recargaGrid(data);

            gridPrincipal.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            this.Text = "Clientes";
            var listaColumnas = new List<object>();
            comboSearch.DisplayMember = "Nombre";
            comboSearch.ValueMember = "Codigo";

            foreach (string key in dc.Keys)
            {
                if (dc[key].VisibleFiltro)
                    listaColumnas.Add(new { Nombre = dc[key].Header, Codigo = dc[key].SelectCampo });
            }

            comboSearch.DataSource = listaColumnas;

        }

        public void recargaGrid(DataTable data, int idPosiciona = 0)
        {

            gridPrincipal.DataSource = null;
            gridPrincipal.DataSource = data;

            if (idPosiciona != 0)
            {
                int index = gridPrincipal.Rows
                    .Cast<DataGridViewRow>()
                    .FirstOrDefault(row => (int)row.Cells["id"].Value == idPosiciona)?.Index ?? -1;
                if (index != -1)
                {
                    gridPrincipal.ClearSelection();
                    gridPrincipal.Rows[index].Selected = true;
                    gridPrincipal.CurrentCell = gridPrincipal.Rows[index].Cells[0];
                }
            }

            foreach (string key in dc.Keys)
            {
                gridPrincipal.Columns[key].HeaderText = dc[key].Header;
                if (dc[key].VisibleTabla == false)
                {
                    gridPrincipal.Columns[key].Visible = false;
                }
            }

        }


    }
}
