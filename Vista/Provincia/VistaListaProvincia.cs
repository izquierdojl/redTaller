using redTaller.Controlador;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;

namespace redTaller.Vista
{
    public partial class VistaListaProvincia : Form
    {

        public VistaListaProvincia(DataTable data)
        {
            InitializeComponent();
            recarga(data);
        }

        public void recarga(DataTable data)
        {
            gridPrincipal.DataSource = data;
            gridPrincipal.Columns["codigo"].HeaderText = "Código" ;
            gridPrincipal.Columns["nombre"].HeaderText = "Nombre";
        }

        private void textSearch_TextChanged(object sender, System.EventArgs e)
        {
            ControladorProvincia controlador = new ControladorProvincia();
            controlador.buscar(this,textSearch.Text);
        }

        private void btnDelete_Click(object sender, System.EventArgs e)
        {
            if (gridPrincipal.SelectedRows.Count > 0)
            {
                if (MessageBox.Show("¿ Seguro de borrar las provincias seleccionadas ?", "Eliminar Registros" ,MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    List<string> recs = new List<string>();
                    foreach (DataGridViewRow row in gridPrincipal.SelectedRows)
                    {
                        recs.Add((string)row.Cells["codigo"].Value);
                    }
                    ControladorProvincia controlador = new ControladorProvincia();
                    controlador.borrar(this, recs);
                }
            }
        }

        public void msgInfo(string msg)
        {
            MessageBox.Show(msg, "Información - Provincias");
        }

    }
}
