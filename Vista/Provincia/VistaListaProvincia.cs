using System.Data;
using System.Windows.Forms;

namespace redTaller.Vista
{
    public partial class VistaListaProvincia : Form
    {

        public VistaListaProvincia(DataTable data)
        {
            InitializeComponent();
            gridProvincias.DataSource = data;
        }

    }
}
