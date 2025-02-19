﻿using Google.Protobuf.WellKnownTypes;
using redTaller.Controlador;
using redTaller.Modelo;
using redTaller.Vista.VistaCliente;
using System.Windows.Forms;

namespace redTaller.Vista.VistaTaller
{
    public partial class VistaFormTaller : redTaller.Vista.VistaBase.VistaFormBase
    {

        int modo; // modo de edición 1 - Añadir  2 - Editar  3 - Consultar

        VistaListaTaller lista;
        Taller taller;
        ControladorTaller controlador = new ControladorTaller();

        public VistaFormTaller(VistaListaTaller lista, int modo, Taller taller)
        {
            InitializeComponent();

            this.lista = lista;
            this.modo = modo;
            this.taller = taller;
            Text = "Detalle Taller";

            checkActivo.Enabled = false;

            if (modo == 2)
            {
                textNif.Enabled = false;
                textNif.Text = taller.nif;
                textNombre.Text = taller.nombre;
                textDomicilio.Text = taller.domicilio;
                textCp.Text = taller.cp;
                textPoblacion.Text = taller.pob;
                textProvincia.Text = taller.pro;
                textTelefono.Text = taller.tel;
                textMovil.Text = taller.movil;
                textEmail.Text = taller.email;
                checkBloqueado.Checked = taller.bloqueado;
                checkActivo.Checked = taller.activo;
            }

        }

        private void btnAceptar_Click(object sender, System.EventArgs e)
        {
            guardar();
        }

        private void guardar()
        {
            taller.nif = textNif.Text;
            taller.nombre = textNombre.Text;
            taller.domicilio = textDomicilio.Text;
            taller.cp = textCp.Text;
            taller.pob = textPoblacion.Text;
            taller.pro = textProvincia.Text;
            taller.tel = textTelefono.Text;
            taller.movil = textMovil.Text;
            taller.email = textEmail.Text;
            taller.bloqueado = checkBloqueado.Checked;
            this.Close();
            controlador.guardar(taller, modo, lista);
        }

        private void btnCancelar_Click(object sender, System.EventArgs e)
        {
            this.Close();
        }

        private void textNif_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {

            if (string.IsNullOrEmpty(textNif.Text))
            {
                MessageBox.Show("Campo Obligatorio");
                textNif.Select();
            }
            else
            {
                if (!VistaUtil.VistaUtil.ValidaNIF(textNif.Text))
                {
                    MessageBox.Show("Error de formato de NIF.");
                    textNif.Select();
                }
                else
                {
                    if (!controlador.valida(textNif.Text))
                    {
                        MessageBox.Show("El nif ya existe o es inválido.");
                        textNif.Select();
                    }
                }
            }

        }

        private void textCp_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            controlador.asignaCodigoPostal(this);
        }

        private void busca_Cp()
        {
            ControladorSearch controladorSearch = new ControladorSearch("CodigoPostal", "codigopostal");
            int id = controladorSearch.Load();
            if (id != 0)
            {
                ControladorCodigoPostal controladorCodigoPostal = new ControladorCodigoPostal();
                CodigoPostal codigoPostal = controladorCodigoPostal.Id(id);
                if (codigoPostal != null)
                {
                    textCp.Text = codigoPostal.codigo;
                    textPoblacion.Text = codigoPostal.nombre;
                    textProvincia.Text = codigoPostal.provincia.nombre;
                    textCp.Focus();
                }
            }
        }

        private void btnSearchCp_Click(object sender, System.EventArgs e)
        {
            busca_Cp();
        }

        private void textCp_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control && e.KeyCode == Keys.B)
            {
                busca_Cp();
            }
        }

        private void correoActivacion()
        {
            taller.email = this.textEmail.Text;
            if (!string.IsNullOrEmpty(taller.email))
            { 
                if (MessageBox.Show("¿ Seguro de enviar correo de activación a " + taller.email + " ?", "Activación", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    taller.activo = false;
                    guardar();
                    controlador.enviaCorreoActivacion(taller);
                }
            }

        }

        private void btnActivación_Click(object sender, System.EventArgs e)
        {
            correoActivacion();
        }
    }

}
