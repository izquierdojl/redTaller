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
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace redTaller.Vista.VistaMatricula
{
    public partial class VistaFormMatricula : redTaller.Vista.VistaBase.VistaFormBase
    {

        int modo; // modo de edición 1 - Añadir  2 - Editar  3 - Consultar
        Matricula matricula;
        ControladorMatricula controlador = new ControladorMatricula();

        public VistaFormMatricula( int modo , Matricula matricula )
        {
            
            InitializeComponent();
            this.modo = modo;
            this.matricula = matricula;
            Text = "Detalle Matrícula/Vehículo";
            comboMarca.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            comboMarca.AutoCompleteSource = AutoCompleteSource.ListItems;
            comboModelo.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            comboModelo.AutoCompleteSource = AutoCompleteSource.ListItems;


            if ( modo == 1 ) // de momento sólo se puede añadir
            {
                if (!string.IsNullOrEmpty(matricula.matricula))
                {
                    textMatricula.Text = matricula.matricula;
                    textMatricula.Enabled = false;
                }
            }

        }

        private void actualizaComboModelo()
        {
            comboModelo.DataSource = controlador.loadModelos(comboMarca.SelectedItem.ToString());
        }

        private void comboMarca_SelectedValueChanged(object sender, EventArgs e)
        {
            actualizaComboModelo();
        }

        private void btnAceptar_Click(object sender, System.EventArgs e)
        {
            matricula.matricula = textMatricula.Text;
            matricula.marca = comboMarca.Text;
            matricula.modelo = comboModelo.Text;
            this.Close();
            controlador.guardar(matricula, modo);
        }

        private void btnCancelar_Click(object sender, System.EventArgs e)
        {
            this.Close();
        }

        private void VistaFormMatricula_Load(object sender, EventArgs e)
        {

            comboMarca.DataSource = controlador.loadMarcas();
            actualizaComboModelo();

        }
    }

}
