using redTaller.Database;
using redTaller.Modelo;
using redTaller.Vista.VistaCliente;
using redTaller.Vista.VistaTaller;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace redTaller.Controlador
{
    internal class ControladorCliente
    {

        private ClienteDB clienteDB;

        public ControladorCliente()
        {
            this.clienteDB = new ClienteDB();
        }

        public void mostrar(Form parent)
        {
            VistaListaCliente vistaListaCliente = new VistaListaCliente(clienteDB.Load(), clienteDB.dc);
            vistaListaCliente.MdiParent = parent;
            vistaListaCliente.Show();
        }

        public void buscar(VistaListaCliente vistaListaCliente, string filtro, string campo)
        {

            Dictionary<string, object> filtros = new Dictionary<string, object>();
            filtros.Add(vistaListaCliente.comboSearch.SelectedValue.ToString(), vistaListaCliente.textSearch.Text);  // Filtro
            vistaListaCliente.recargaGrid(clienteDB.Load(filtros));
        }

    }
}
