using redTaller.Controlador;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace redTaller.Vista.VistaCodigoPostal
{
    public partial class VistaListaCodigoPostal : redTaller.Vista.VistaBase.VistaListaBase
    {

        ControladorCodigoPostal controlador = new ControladorCodigoPostal();

        public VistaListaCodigoPostal(DataTable data)
        {
            InitializeComponent();
            panelCenter.BackColor = Color.LightBlue; // Temporal para verificar si el panel es visible
            recargaGrid(data, "");
            foreach (DataGridViewColumn column in gridPrincipal.Columns)
            {
                comboSearch.Items.Add(column.HeaderText);
            }
            comboSearch.SelectedIndex = 0;
        }

        public void recargaGrid(DataTable data, string keyPosiciona)
        {

            gridPrincipal.AutoGenerateColumns = true;
            gridPrincipal.DataSource = data;
            gridPrincipal.Columns["codigo"].HeaderText = "Código";
            gridPrincipal.Columns["nombre"].HeaderText = "Nombre";
            gridPrincipal.Columns["nombre_provincia"].HeaderText = "Provincia";

            if (keyPosiciona != null)
            {
                int index = gridPrincipal.Rows
                    .Cast<DataGridViewRow>()
                    .FirstOrDefault(row => (string)row.Cells["codigo"].Value == keyPosiciona)?.Index ?? -1;
                if (index != -1)
                {
                    gridPrincipal.ClearSelection();
                    gridPrincipal.Rows[index].Selected = true;
                    gridPrincipal.CurrentCell = gridPrincipal.Rows[index].Cells[0];
                }
            }
            
        }

        private void vistaBorrar()
        {
            if (gridPrincipal.SelectedRows.Count > 0)
            {
                if (MessageBox.Show("¿ Seguro de borrar las CodigoPostals seleccionadas ?", "Eliminar Registros", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    List<string> recs = new List<string>();
                    foreach (DataGridViewRow row in gridPrincipal.SelectedRows)
                    {
                        recs.Add((string)row.Cells["codigo"].Value);
                        gridPrincipal.Rows.Remove(row);
                    }
                    controlador.borrar(this, recs);
                }
            }
        }
               
        private void vistaAnadir()
        {
            controlador.nuevo(this);
        }

        private void vistaEditar()
        {
            string key = gridPrincipal.Rows[gridPrincipal.CurrentRow.Index].Cells["codigo"].Value.ToString();
            controlador.modificar(this, key);
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

        public void msgInfo(string msg)
        {
            MessageBox.Show(msg, "Información - CodigoPostals");
            gridPrincipal.Focus();
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

        private void VistaListaCodigoPostal_Load(object sender, EventArgs e)
        {
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
