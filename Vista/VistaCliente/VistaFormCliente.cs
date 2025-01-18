using redTaller.Controlador;
using redTaller.Modelo;
using System.Windows.Forms;

namespace redTaller.Vista.VistaCliente
{
    public partial class VistaFormCliente : redTaller.Vista.VistaBase.VistaFormBase
    {

        int modo; // modo de edición 1 - Añadir  2 - Editar  3 - Consultar

        VistaListaCliente lista;
        Cliente cliente;
        ControladorCliente controlador = new ControladorCliente();

        public VistaFormCliente(VistaListaCliente lista, int modo, Cliente cliente )
        {

            InitializeComponent();
            this.lista = lista;
            this.modo = modo;
            this.cliente = cliente;
            Text = "Detalle Cliente";

            checkActivo.Enabled = false;

            if (modo == 2)
            {
                textNif.Enabled = false;
                textNif.Text = cliente.nif;
                textNombre.Text = cliente.nombre;
                textDomicilio.Text = cliente.domicilio;
                textCp.Text = cliente.cp;
                textPoblacion.Text = cliente.pob;
                textProvincia.Text = cliente.pro;
                textTelefono.Text = cliente.tel;
                textMovil.Text = cliente.movil;
                textEmail.Text = cliente.email;
                checkBloqueado.Checked = cliente.bloqueado;
                checkActivo.Checked = cliente.activo;
                //VistaUtil.VistaUtil.MakeFormReadOnly(this);   
            }
            else
            {
                if (!string.IsNullOrEmpty(cliente.nif))
                {
                    textNif.Text = cliente.nif;
                    textNif.Enabled = false;
                }

            }

        }

        private void btnAceptar_Click(object sender, System.EventArgs e)
        {
            guardar();
        }

        private void guardar()
        {
            cliente.nif = textNif.Text;
            cliente.nombre = textNombre.Text;
            cliente.domicilio = textDomicilio.Text;
            cliente.cp = textCp.Text;
            cliente.pob = textPoblacion.Text;
            cliente.pro = textProvincia.Text;
            cliente.tel = textTelefono.Text;
            cliente.movil = textMovil.Text;
            cliente.email = textEmail.Text;
            cliente.bloqueado = checkBloqueado.Checked;
            cliente.nif_taller_alta = new Taller();
            this.Close();
            controlador.guardar(cliente, modo, lista);
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
            cliente.email = this.textEmail.Text;
            if (!string.IsNullOrEmpty(cliente.email))
            {
                if (MessageBox.Show("¿ Seguro de enviar correo de activación a " + cliente.email + " ?", "Activación", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    cliente.activo = true;
                    guardar();
                    controlador.enviaCorreoActivacion(cliente);
                }
            }

        }

        private void btnActivación_Click(object sender, System.EventArgs e)
        {
            correoActivacion();
        }
    }
}
