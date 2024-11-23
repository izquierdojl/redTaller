using redTaller.Controlador;
using redTaller.Database;
using redTaller.Modelo;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace redTaller.Vista.VistaActuacion
{
    public partial class VistaFormActuacion : redTaller.Vista.VistaBase.VistaFormBase
    {

        int modo; // modo de edición 1 - Añadir  2 - Editar  3 - Consultar

        VistaListaActuacion lista;
        Actuacion actuacion;
        ControladorActuacion controlador = new ControladorActuacion();
        Dictionary<string, CampoInfo> dcDetalle;

        public VistaFormActuacion(VistaListaActuacion lista, int modo, Actuacion actuacion, Dictionary<string, CampoInfo> dcDetalle )
        {
            
            InitializeComponent();
            this.lista = lista;
            this.modo = modo;
            this.actuacion = actuacion;
            this.dcDetalle = dcDetalle;
            if (modo == 1)
            {
                Text = "Nueva Actuación";
                panelBottom.Hide();
            }
            else
            {
                Text = "Detalle Actuación " + actuacion.id;
                panelBottom.Show();
            }


            DataTable dataTable = new DataTable();
            dataTable.Columns.Add("codigo", typeof(string));
            dataTable.Columns.Add("nombre", typeof(string));
            dataTable.Rows.Add("R", "Reparación");
            dataTable.Rows.Add("M", "Mantenimiento");
            dataTable.Rows.Add("G", "Garantía");
            dataTable.Rows.Add("S", "Seguro");

            comboTipo.DataSource = dataTable;
            comboTipo.DisplayMember = "nombre";  
            comboTipo.ValueMember = "codigo";  
            comboTipo.SelectedIndex = 0;

            if (modo > 1)
            {
                textNif_Taller.Text = actuacion.taller.nif;
                labelNomTaller.Text = actuacion.taller.nombre;
                textNif_Cliente.Text = actuacion.cliente.nif;
                labelNomCliente.Text = actuacion.cliente.nombre;
                textMatricula.Text = actuacion.matricula.matricula;
                labelNombreMatricula.Text = actuacion.matricula.marca + " " + actuacion.matricula.modelo;
                dateFecha.Value = actuacion.fecha;
                textKm.Text = actuacion.km.ToString();
                comboTipo.SelectedValue = actuacion.tipo;
            }
            else
            {
                textKm.Text = "0";
            }

            gridActuacionDetalle.AutoGenerateColumns = true;
            gridActuacionDetalle.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            recargaGridActuacionDetalle(controlador.loadDetalle( actuacion ));

        }

        private void btnAceptar_Click(object sender, System.EventArgs e)
        {
            if( string.IsNullOrEmpty(textNif_Taller.Text))
            {
                VistaUtil.VistaUtil.MsgInfo("NIF de taller obligatorio", "Atención");
                textNif_Taller.Focus();
                return;
            }
            if (string.IsNullOrEmpty(textNif_Cliente.Text))
            {
                VistaUtil.VistaUtil.MsgInfo("NIF de cliente obligatorio", "Atención");
                textNif_Cliente.Focus();
                return;
            }
            if (string.IsNullOrEmpty(textMatricula.Text))
            {
                VistaUtil.VistaUtil.MsgInfo("Matrícula/Vehículo obligatorio", "Atención");
                textMatricula.Focus();
                return;
            }
            this.Close();
            guardarActuacion();
        }

        private void guardarActuacion()
        {
            actuacion.taller = new Taller();
            actuacion.taller.nif = textNif_Taller.Text;
            actuacion.cliente = new Cliente();
            actuacion.cliente.nif = textNif_Cliente.Text;
            actuacion.matricula = new Matricula();
            actuacion.matricula.matricula = textMatricula.Text;
            actuacion.fecha = DateTime.Parse(dateFecha.Text);
            actuacion.km = int.Parse(textKm.Text.Replace(".", ""));
            actuacion.tipo = comboTipo.SelectedValue.ToString();
            controlador.guardar(actuacion, modo, lista);
        }

        private void btnCancelar_Click(object sender, System.EventArgs e)
        {
            Close();
        }

        private void textKm_TextChanged(object sender, EventArgs e)
        {
            int cursorPosition = textKm.SelectionStart;
            string text = textKm.Text.Replace(".", "").Replace(",", "");
            if (double.TryParse(text, out double value))
            {
                textKm.Text = value.ToString("N0");
                textKm.SelectionStart = Math.Min(cursorPosition, textKm.Text.Length);
            }
        }

        private void textNif_Taller_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if( !string.IsNullOrEmpty(textNif_Taller.Text) )
                controlador.asignaTaller(this);
        }

        private void busca_Taller()
        {
            ControladorSearch controladorSearch = new ControladorSearch("Taller", "taller");
            int id = controladorSearch.Load();
            if (id != 0)
            {
                ControladorTaller controladorTaller = new ControladorTaller();
                Taller taller = controladorTaller.Id(id);
                if (taller != null)
                {
                    textNif_Taller.Text = taller.nif;
                    labelNomTaller.Text = taller.nombre;    
                    textNif_Taller.Focus();
                }
            }
        }

        private void btnSearchNif_Taller_Click(object sender, System.EventArgs e)
        {
            busca_Taller();
        }

        private void textNif_Taller_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control && e.KeyCode == Keys.B)
            {
                busca_Taller();
            }
        }

        private void textNif_Cliente_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (!string.IsNullOrEmpty(textNif_Cliente.Text))
            {
                if (!controlador.asignaCliente(this))
                {
                    if (MessageBox.Show("El NIF no existe, ¿ Desea crear uno nuevo ?", "NIF/Cliente no encontrado", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        ControladorCliente controladorCliente = new ControladorCliente();
                        Cliente cliente = new Cliente();
                        cliente.nif = textNif_Cliente.Text;
                        controladorCliente.nuevo(cliente);
                        textNif_Cliente.Focus();
                    }
                    else
                    {
                        textNif_Cliente.Focus();
                    }
                }
            }
        }

        private void busca_Cliente()
        {
            ControladorSearch controladorSearch = new ControladorSearch("Cliente", "cliente");
            int id = controladorSearch.Load();
            if (id != 0)
            {
                ControladorCliente controladorCliente = new ControladorCliente();
                Cliente cliente = controladorCliente.Id(id);
                if (cliente != null)
                {
                    textNif_Cliente.Text = cliente.nif;
                    labelNomCliente.Text = cliente.nombre;
                    textNif_Cliente.Focus();
                }
            }
        }

        private void btnSearchNif_Cliente_Click(object sender, System.EventArgs e)
        {
            busca_Cliente();
        }

        private void textNif_Cliente_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control && e.KeyCode == Keys.B)
            {
                busca_Cliente();
            }
        }

        //

        private void textMatricula_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (!string.IsNullOrEmpty(textMatricula.Text))
            {
                if (!controlador.asignaMatricula(this))
                {
                    if (MessageBox.Show("La matrícula/vehículo no existe, ¿ Desea crear uno nuevo ?", "Vehículo no encontrado", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        ControladorMatricula controladorMatricula = new ControladorMatricula();
                        Matricula matricula = new Matricula();
                        matricula.matricula = textMatricula.Text;
                        controladorMatricula.nuevo(matricula);
                        textMatricula.Focus();
                    }
                    else
                    {
                        textMatricula.Focus();
                    }
                }
            }
        }

        private void busca_Matricula()
        {
            ControladorSearch controladorSearch = new ControladorSearch("Matricula", "matricula");
            int id = controladorSearch.Load();
            if (id != 0)
            {
                ControladorMatricula controladorMatricula = new ControladorMatricula();
                Matricula matricula = controladorMatricula.Id(id);
                if (matricula != null)
                {
                    textMatricula.Text = matricula.matricula;
                    labelNombreMatricula.Text = matricula.marca + " " + matricula.modelo;
                    textMatricula.Focus();
                }
            }
        }

        private void btnSearchMatricula_Click(object sender, System.EventArgs e)
        {
            busca_Matricula();
        }

        private void textMatricula_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control && e.KeyCode == Keys.B)
            {
                busca_Matricula();
            }
        }


        public void recargaGridActuacionDetalle(DataTable data, int idPosiciona = 0)
        {

            gridActuacionDetalle.DataSource = null;
            gridActuacionDetalle.DataSource = data;

            if (idPosiciona != 0)
            {
                int index = gridActuacionDetalle.Rows
                    .Cast<DataGridViewRow>()
                    .FirstOrDefault(row => (int)row.Cells["id"].Value == idPosiciona)?.Index ?? -1;
                if (index != -1)
                {
                    gridActuacionDetalle.ClearSelection();
                    gridActuacionDetalle.Rows[index].Selected = true;
                    gridActuacionDetalle.CurrentCell = gridActuacionDetalle.Rows[index].Cells[0];
                }
            }

            foreach (string key in dcDetalle.Keys)
            {
                gridActuacionDetalle.Columns[key].HeaderText = dcDetalle[key].Header;
                if (dcDetalle[key].VisibleTabla == false)
                {
                    gridActuacionDetalle.Columns[key].Visible = false;
                }
            }

        }

        private void gridActuacionDetalle_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                vistaDetalleBorrar();
            }
            else if (e.KeyCode == Keys.Insert)
            {
                //vistaAnadir();
            }
            else if (e.KeyCode == Keys.Enter)
            {
                //vistaEditar();
            }
        }


        private void vistaDetalleBorrar()
        {
            if (gridActuacionDetalle.SelectedRows.Count > 0)
            {
                if (MessageBox.Show("¿ Seguro de borrar las líneas seleccionadas ?", "Eliminar Registros", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    List<int> ids = new List<int>();
                    foreach (DataGridViewRow row in gridActuacionDetalle.SelectedRows)
                    {
                        ids.Clear();
                        ids.Add((int)row.Cells["id"].Value);
                        if (controlador.borrarDetalle(ids))
                            gridActuacionDetalle.Rows.Remove(row);
                    }
                }
            }
        }

        private void btnGridDel_Click(object sender, EventArgs e)
        {
            vistaDetalleBorrar();
        }
    }

}
