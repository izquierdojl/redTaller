using redTaller.Controlador;
using redTaller.Modelo;
using System.Windows.Forms;

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
            if (modo == 2)
            {
                textCodigo.Enabled = false;
                textCodigo.Text = codigoPostal.Codigo;
                textNombre.Text = codigoPostal.Nombre;
            }


            comboProvincia.Items.Add("Teruel");
            comboProvincia.Items.Add("Zaragoza");

        }

        private void btnAceptar_Click(object sender, System.EventArgs e)
        {
            codigoPostal.Codigo = textCodigo.Text;
            codigoPostal.Nombre = textNombre.Text;
            this.Close();
            controlador.guardar(codigoPostal, modo, lista);
        }

        private void btnCancelar_Click(object sender, System.EventArgs e)
        {
            this.Close();
        }

        private void label1_Click(object sender, System.EventArgs e)
        {

        }
    }
}

