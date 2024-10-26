using redTaller.Controlador;
using redTaller.Database;
using redTaller.Modelo;
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
            this.Text = "Detalle Taller";

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
            }

        }

        private void btnAceptar_Click(object sender, System.EventArgs e)
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
            if (!controlador.valida(textNif.Text))
            {
                MessageBox.Show("El nif ya existe o es inválido.");
                textNif.Select();
            }
        }
    }

}
