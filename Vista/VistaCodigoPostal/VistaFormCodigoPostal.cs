using redTaller.Controlador;
using redTaller.Modelo;
using System.Collections.Generic;
using System.Windows;
using System.Windows.Controls;

namespace redTaller.Vista.VistaCodigoPostal
{
    public partial class VistaFormCodigoPostal : redTaller.Vista.VistaBase.VistaFormBase
    {
        int modo; // modo de edición 1 - Añadir  2 - Editar  3 - Consultar

        VistaListaCodigoPostal lista;
        CodigoPostal codigoPostal;
        ControladorCodigoPostal controlador = new ControladorCodigoPostal();

        public VistaFormCodigoPostal(VistaListaCodigoPostal lista, int modo, CodigoPostal codigoPostal)
        {
            InitializeComponent();
            this.lista = lista;
            this.modo = modo;
            this.codigoPostal = codigoPostal;

            // configuración combo
            ControladorProvincia controladorProvincia = new ControladorProvincia();
            List<Provincia> provincias = controladorProvincia.listProvincias();
            comboProvincia.DisplayMember = "nombre";
            comboProvincia.ValueMember = "codigo";
            comboProvincia.DataSource = provincias;

            if (modo == 2)
            {
                textCodigo.Enabled = false;
                textCodigo.Text = codigoPostal.Codigo;
                textNombre.Text = codigoPostal.Nombre;
                comboProvincia.SelectedValue = codigoPostal.Provincia.Codigo;
            }

        }


        private void btnAceptar_Click(object sender, System.EventArgs e)
        {
            codigoPostal.Codigo = textCodigo.Text;
            codigoPostal.Nombre = textNombre.Text;
            codigoPostal.Provincia = new Provincia(comboProvincia.SelectedValue.ToString());
            this.Close();
            controlador.guardar(codigoPostal, modo, lista);
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

