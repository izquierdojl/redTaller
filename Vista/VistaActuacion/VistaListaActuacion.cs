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

namespace redTaller.Vista.VistaActuacion
{
    public partial class VistaListaActuacion : redTaller.Vista.VistaBase.VistaListaBase
    {

        ControladorActuacion controlador = new ControladorActuacion();
        Dictionary<string, CampoInfo> dc;

        public VistaListaActuacion(DataTable data, Dictionary<string, CampoInfo> dc)
        {
            InitializeComponent();

            InitializeComponent();
            gridPrincipal.AutoGenerateColumns = true;
            this.WindowState = FormWindowState.Maximized;
            this.dc = dc;

            recargaGrid(data);

            gridPrincipal.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            this.Text = "Actuaciones";
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

        private void vistaBorrar()
        {
            if (gridPrincipal.SelectedRows.Count > 0)
            {
                if (MessageBox.Show("¿ Seguro de borrar las Actuaciones seleccionadas ?", "Eliminar Registros", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    List<int> ids = new List<int>();
                    foreach (DataGridViewRow row in gridPrincipal.SelectedRows)
                    {
                        ids.Add((int)row.Cells["id"].Value);
                        gridPrincipal.Rows.Remove(row);
                    }
                    controlador.borrar(this, ids);
                }
            }
        }

        private void vistaAnadir()
        {
            controlador.nuevo(this);
        }

        private void vistaEditar()
        {
            if (gridPrincipal.SelectedRows.Count > 0)
            {
                int id = (int)gridPrincipal.Rows[gridPrincipal.CurrentRow.Index].Cells["id"].Value;
                controlador.modificar(this, id);
            }
        }

        private void vistaBuscar()
        {
            int selected = comboSearch.SelectedIndex;
            string campo = gridPrincipal.Columns[selected].Name;
            controlador.buscar(this, textSearch.Text, campo);
        }

        private void btnDelete_Click(object sender, System.EventArgs e)
        {
            vistaBorrar();
        }

        private void gridPrincipal_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                vistaBorrar();
            }
            else if (e.KeyCode == Keys.Insert)
            {
                vistaAnadir();
            }
            else if (e.KeyCode == Keys.Enter)
            {
                vistaEditar();
            }
        }

        private void btnAdd_Click(object sender, System.EventArgs e)
        {
            vistaAnadir();
        }

        private void btnEdit_Click(object sender, System.EventArgs e)
        {
            vistaEditar();
        }

        private void gridPrincipal_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            vistaEditar();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textSearch_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (e.KeyChar == (char)Keys.Enter)
            {
                vistaBuscar();
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            vistaBuscar();
        }

        private void btnInitSearch_Click(object sender, EventArgs e)
        {
            textSearch.Text = "";
            vistaBuscar();
        }

    }
}
