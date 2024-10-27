using redCliente.Modelo;
using redTaller.Database;
using redTaller.Modelo;
using redTaller.Vista.VistaCliente;
using redTaller.Vista.VistaTaller;
using redTaller.Vista.VistaUtil;
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

        public void nuevo(VistaListaCliente vistaListaCliente)
        {
            VistaFormCliente vistaFormCliente = new VistaFormCliente(vistaListaCliente, 1, new Cliente());
            vistaFormCliente.ShowDialog();
        }

        public void modificar(VistaListaCliente vistaListaCliente, int id)
        {
            Cliente cliente = clienteDB.CargaElemento(id);
            if (cliente != null)
            {
                VistaFormCliente vistaFormCliente = new VistaFormCliente(vistaListaCliente, 2, cliente);
                vistaFormCliente.ShowDialog();
            }
        }

        public void borrar(VistaListaCliente vistaListaCliente, List<int> ids)
        {
            if (clienteDB.delete(ids) > 0)
            {
                VistaUtil.MsgInfo("Se ha borrado " + ids.Count.ToString() + " registro(s)", "Información");
            }
            else
            {
                VistaUtil.MsgInfo("No se han podido borrar", "Información");
            }
        }


        public void guardar(Cliente cliente, int modo, VistaListaCliente vistaListaCliente)
        {
            if (modo == 1)
            {
                clienteDB.insert(cliente);
            }
            else
            {
                clienteDB.update(cliente);
            }
            if (string.IsNullOrEmpty(vistaListaCliente.textSearch.Text))
            {
                vistaListaCliente.recargaGrid(clienteDB.Load(null), cliente.id);
            }
            else
            {
                Dictionary<string, object> filtros = new Dictionary<string, object>();
                filtros.Add(vistaListaCliente.comboSearch.SelectedValue.ToString(), vistaListaCliente.textSearch.Text);  // Filtro
                vistaListaCliente.recargaGrid(clienteDB.Load(filtros), cliente.id);
            }
        }


        public bool valida(string key)
        {
            return clienteDB.ValidaKey(key);
        }

        public void asignaCodigoPostal(VistaFormCliente vistaFormCliente )
        {
            CodigoPostalDB db = new CodigoPostalDB();
            CodigoPostal codigoPostal = db.CargaElemento(0, vistaFormCliente.textCp.Text);
            if (codigoPostal != null)
            {
                if (string.IsNullOrEmpty(vistaFormCliente.textPoblacion.Text))
                    vistaFormCliente.textPoblacion.Text = codigoPostal.nombre;
                if (string.IsNullOrEmpty(vistaFormCliente.textProvincia.Text))
                    vistaFormCliente.textProvincia.Text = codigoPostal.provincia.nombre;
            }

        }

    }
}
