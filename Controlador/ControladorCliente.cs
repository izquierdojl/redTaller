using redTaller.Database;
using redTaller.Database.Util;
using redTaller.Modelo;
using redTaller.Util;
using redTaller.Vista.VistaCliente;
using redTaller.Vista.VistaUtil;
using System.Collections.Generic;
using System.Text;
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

        public void nuevo(Cliente cliente)
        {
            VistaFormCliente vistaFormCliente = new VistaFormCliente(null, 1, cliente);
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

        public bool borrar(VistaListaCliente vistaListaCliente, List<int> ids)
        {
            if (clienteDB.delete(ids) > 0)
            {
                VistaUtil.MsgInfo("Se ha borrado " + ids.Count.ToString() + " registro(s)", "Información");
                return true;
            }
            else
            {
                VistaUtil.MsgInfo("No se han podido borrar", "Información");
                return false;
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
            if (vistaListaCliente != null)
            {
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
        public Cliente Id(int id)
        {
            return clienteDB.CargaElemento(id);
        }

        public void enviaCorreoActivacion(Cliente cliente)
        {
            ClienteDB db = new ClienteDB();
            string randomPassword = Password.RandomPassword(8);
            cliente.password = Encoding.UTF8.GetBytes(randomPassword);
            if (db.updateActivacion(cliente) )
            {
                Email email = new Email();
                string body = $@"
                                Estimado, {cliente.nombre} 
                                A continuación, se le envía la contraseña para poder acceder a la aplicación REDTALLER
                                Contraseña:
                                {randomPassword}
                                Atentamente,
                                ";

                if (email.EnviarEmail(cliente.email, "REDTALLER - Activación de Cuenta de Cliente", body))
                {
                    VistaUtil.MsgInfo("Mensaje enviado correctamente", "Envío correcto");
                }
                else
                {
                    VistaUtil.MsgInfo("No se ha podido realizar el envío del correo electrónico, inténtelo en unos instantes.", "Envio incorrecto");
                }

            }

        }


    }
}
