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
            taller = this.taller;
            this.Text = "Detalle Taller";

            if (modo == 2)
            {
                textNif.Enabled = false;
                textNombre.Text = taller.nombre;
            }

        }

        private void btnAceptar_Click(object sender, System.EventArgs e)
        {
            taller.nif = textNif.Text;
            taller.nombre = textNombre.Text;
            this.Close();
            controlador.guardar(taller, modo, lista);
        }

        private void btnCancelar_Click(object sender, System.EventArgs e)
        {
            this.Close();
        }

        private void textCodigo_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (!controlador.valida(textNif.Text))
            {
                MessageBox.Show("El nif ya existe o es inválido.");
                textNif.Select();
            }
        }

    }

}
