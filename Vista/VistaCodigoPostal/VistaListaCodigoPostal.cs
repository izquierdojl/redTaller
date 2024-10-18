using redTaller.Controlador;
using redTaller.Modelo;
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

        public VistaListaCodigoPostal(List<CodigoPostal> data)
        {
            InitializeComponent();

            gridPrincipal.AutoGenerateColumns = false;
            gridPrincipal.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill; // Ajusta automáticamente las columnas


            var listaColumnas = new List<object>();

            gridPrincipal.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "codigo", HeaderText = "Código"
            }); 
            listaColumnas.Add(new { Nombre ="Codigo", Codigo = "codigo" });

            gridPrincipal.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "nombre",
                HeaderText = "Nombre"
            });
            listaColumnas.Add(new { Nombre = "Nombre", Codigo = "nombre" });

                gridPrincipal.Columns.Add(new DataGridViewTextBoxColumn
                {
                    Name = "provincia.nombre",
                    DataPropertyName = "provincia.nombre",
                    Visible = true,  
                    HeaderText = "Provinciax",
                    Width = 50      
                });

            listaColumnas.Add(new { Nombre = "Provincia", Codigo = "nombre_provincia" });

            gridPrincipal.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "id",
                DataPropertyName = "id",
                HeaderText = "Id"
            });

            comboSearch.DataSource = listaColumnas;
            comboSearch.DisplayMember = "Nombre";
            comboSearch.ValueMember = "Codigo";

            gridPrincipal.CellFormatting += (s, e) =>
            {
                if (e.ColumnIndex == gridPrincipal.Columns["provincia.nombre"].Index)
                {
                    var codigoPostal = (CodigoPostal)gridPrincipal.Rows[e.RowIndex].DataBoundItem;
                    e.Value = codigoPostal.provincia?.nombre ?? "Sin Provincia"; // Muestra un texto alternativo si es nulo
                }
            };

            recargaGrid(data);

        }

        public void recargaGrid(List<CodigoPostal> data, int idPosiciona = 0 )
        {


            gridPrincipal.DataSource = null; 
            gridPrincipal.DataSource = data;
            gridPrincipal.Refresh();


            if (idPosiciona != 0 )
            {
                
                int index = gridPrincipal.Rows
                    .Cast<DataGridViewRow>()
                    .FirstOrDefault(row => (int)row.Cells[3].Value == idPosiciona)?.Index ?? -1;
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
                        recs.Add((string)row.Cells["id"].Value);
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
            int id = (int)gridPrincipal.Rows[gridPrincipal.CurrentRow.Index].Cells["id"].Value;
            controlador.modificar(this, id);
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
