using redTaller.Controlador;
using redTaller.Database;
using redTaller.Modelo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Text;
using System.Windows.Controls;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;
using static System.Net.Mime.MediaTypeNames;

namespace redTaller.Vista.VistaActuacion
{
    public partial class VistaFormActuacion : redTaller.Vista.VistaBase.VistaFormBase
    {

        int modo; // modo de edición 1 - Añadir  2 - Editar  3 - Consultar

        VistaListaActuacion lista;
        Actuacion actuacion;
        ControladorActuacion controlador = new ControladorActuacion();

        public VistaFormActuacion(VistaListaActuacion lista, int modo, Actuacion actuacion)
        {
            
            InitializeComponent();
            this.lista = lista;
            this.modo = modo;
            this.actuacion = actuacion;
            if ( modo == 1 )
              Text = "Nueva Actuación";
            else
              Text = "Detalle Actuación " + actuacion.id;

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
                actuacion.km = 0;
            }

        }

        private void btnAceptar_Click(object sender, System.EventArgs e)
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
            this.Close();
            controlador.guardar(actuacion, modo, lista);
        }

        private void btnCancelar_Click(object sender, System.EventArgs e)
        {
            this.Close();
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
            controlador.asignaCliente(this);
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
            controlador.asignaMatricula(this);
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

    }

}
