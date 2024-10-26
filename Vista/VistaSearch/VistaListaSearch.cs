using redTaller.Controlador;
using redTaller.Database;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Forms;

namespace redTaller.Vista.VistaSearch
{
    internal partial class VistaListaSearch : Form
    {

        ControladorSearch controlador;
        public Dictionary<string, CampoInfo> dc;
        public int SelectedId { get; private set; }

        public VistaListaSearch(DataTable data, Dictionary<string, CampoInfo> dc, ControladorSearch controlador)
        {
            InitializeComponent();
            this.controlador = controlador;
            gridPrincipal.AutoGenerateColumns = true;
            this.dc = dc;
            recargaGrid(data);
            gridPrincipal.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
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

        private void filtrar()
        {
            controlador.filtrar(this, this.textSearch.Text);
        }

        private void seleccionar()
        {
            if (gridPrincipal.SelectedRows.Count > 0)
            {
                if (gridPrincipal.SelectedRows.Count > 0)
                {
                    SelectedId = Convert.ToInt32(gridPrincipal.SelectedRows[0].Cells["id"].Value);
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
            }
        }

        private void textSearch_TextChanged(object sender, EventArgs e)
        {
            filtrar();
        }

        private void gridPrincipal_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                seleccionar();
            }
            else if (e.Control && e.KeyCode == Keys.B)
            {
                textSearch.Focus();
            }
        }

        private void textSearch_Leave(object sender, EventArgs e)
        {
            gridPrincipal.Focus();
        }

        private void textSearch_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                gridPrincipal.Focus();
            }
        }

    }
}
