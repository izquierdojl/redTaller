using redTaller.Controlador;
using redTaller.Modelo;
using redTaller.Vista.VistaCodigoPostal;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace redTaller.Vista.VistaProvincia
{
    public partial class VistaFormProvincia : redTaller.Vista.VistaBase.VistaFormBase
    {

        int modo; // modo de edición 1 - Añadir  2 - Editar  3 - Consultar

        VistaListaProvincia lista;
        Provincia provincia;
        ControladorProvincia controlador = new ControladorProvincia();

        public VistaFormProvincia(VistaListaProvincia lista, int modo, Provincia provincia)
        {
            InitializeComponent();
            this.lista = lista;
            this.modo = modo;
            this.provincia = provincia;
            this.Text = "Detalle Provincia";

            // configuración combo
            ControladorProvincia controladorProvincia = new ControladorProvincia();
            if (modo == 2)
            {
                textCodigo.Enabled = false;
                textCodigo.Text = provincia.codigo;
                textNombre.Text = provincia.nombre;
            }

        }


        private void btnAceptar_Click(object sender, System.EventArgs e)
        {
            provincia.codigo = textCodigo.Text;
            provincia.nombre = textNombre.Text;
            this.Close();
            controlador.guardar(provincia, modo, lista);
        }

        private void btnCancelar_Click(object sender, System.EventArgs e)
        {
            this.Close();
        }

        private void textCodigo_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (!controlador.valida(textCodigo.Text))
            {
                MessageBox.Show("El código ya existe o es inválido.");
                textCodigo.Select();
            }

        }
    }

}
