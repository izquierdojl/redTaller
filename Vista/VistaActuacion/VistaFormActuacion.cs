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

            comboTipo.Items.Add(new KeyValuePair<string, string>("R", "Reparación"));
            comboTipo.Items.Add(new KeyValuePair<string, string>("M", "Mantenimiento"));
            comboTipo.Items.Add(new KeyValuePair<string, string>("G", "Garantía"));
            comboTipo.Items.Add(new KeyValuePair<string, string>("S", "Seguro"));
            comboTipo.SelectedIndex = 0;

            if (modo > 1)
            {
                textNif_Taller.Text = actuacion.taller.nif;
                labelNomTaller.Text = actuacion.taller.nombre;
                textNif_Cliente.Text = actuacion.cliente.nif;
                labelNomCliente.Text = actuacion.taller.nombre;
                textMatricula.Text = actuacion.matricula.matricula;
                labelNombreMatricula.Text = actuacion.matricula.marca + " " + actuacion.matricula.modelo;
                dateFecha.Text = actuacion.fecha.ToString();
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
            actuacion.km = int.Parse(textKm.Text);
            actuacion.tipo = (char)comboTipo.SelectedValue;
            this.Close();
            //controlador.guardar(cliente, modo, lista);
        }

        private void btnCancelar_Click(object sender, System.EventArgs e)
        {
            this.Close();
        }

    }

}
