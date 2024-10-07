using redTaller.Controlador;
using redTaller.Modelo;
using System.Windows.Forms;

namespace redTaller.Vista.VistaProvincia
{
    public partial class VistaFormProvincia : Form
    {
        int modo; // modo de edición 1 - Añadir  2 - Editar  3 - Consultar

        VistaListaProvincia lista;
        Provincia provincia;

        public VistaFormProvincia(VistaListaProvincia lista, int modo, Provincia provincia)
        {
            InitializeComponent();
            this.lista = lista;
            this.modo = modo;
            this.provincia = provincia;
            if (modo == 2)
            {
                textCodigo.Enabled = false;
                textCodigo.Text = provincia.Codigo;
                textNombre.Text = provincia.Nombre;
            }
        }

        private void btnAceptar_Click(object sender, System.EventArgs e)
        {
            provincia.Codigo = textCodigo.Text;
            provincia.Nombre = textNombre.Text;
            ControladorProvincia controlador = new ControladorProvincia();
            this.Close();
            controlador.guardar(provincia, modo, lista);
        }

        private void btnCancelar_Click(object sender, System.EventArgs e)
        {
            this.Close();
        }
    }
}