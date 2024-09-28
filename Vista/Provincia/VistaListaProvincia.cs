using redTaller.Controlador;
using System.Data;
using System.Windows.Forms;

namespace redTaller.Vista
{
    public partial class VistaListaProvincia : Form
    {

        public VistaListaProvincia(DataTable data)
        {
            InitializeComponent();
            recarga(data);
        }

        public void recarga(DataTable data)
        {
            gridPrincipal.DataSource = data;
        }

        private void textSearch_TextChanged(object sender, System.EventArgs e)
        {
            ControladorProvincia controlador = new ControladorProvincia();
            controlador.buscar(this,textSearch.Text);
        }
    }
}
