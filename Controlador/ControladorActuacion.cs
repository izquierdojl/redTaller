using redTaller.Database;
using redTaller.Modelo;
using redTaller.Vista.VistaActuacion;
using redTaller.Vista.VistaUtil;
using System.Collections.Generic;
using System.Windows.Forms;

namespace redTaller.Controlador
{
    internal class ControladorActuacion
    {

        private ActuacionDB actuacionDB;

        public ControladorActuacion()
        {
            this.actuacionDB = new ActuacionDB();
        }

        public void mostrar(Form parent)
        {
            VistaListaActuacion vistaListaActuacion = new VistaListaActuacion(actuacionDB.Load(), actuacionDB.dc );
            vistaListaActuacion.MdiParent = parent;
            vistaListaActuacion.Show();
        }

        public void buscar(VistaListaActuacion vistaListaActuacion, string filtro, string campo)
        {

            Dictionary<string, object> filtros = new Dictionary<string, object>();
            filtros.Add(vistaListaActuacion.comboSearch.SelectedValue.ToString(), vistaListaActuacion.textSearch.Text);  // Filtro
            vistaListaActuacion.recargaGrid(actuacionDB.Load(filtros));
        }

        public void nuevo(VistaListaActuacion vistaListaActuacion)
        {
            VistaFormActuacion vistaFormActuacion = new VistaFormActuacion(vistaListaActuacion, 1, new Actuacion());
            vistaFormActuacion.ShowDialog();
        }

        public void modificar(VistaListaActuacion vistaListaActuacion, int id)
        {
            Actuacion actuacion = actuacionDB.CargaElemento(id);
            if (actuacion != null)
            {
                VistaFormActuacion vistaFormActuacion = new VistaFormActuacion(vistaListaActuacion, 2, actuacion);
                vistaFormActuacion.ShowDialog();
            }
        }

        public void borrar(VistaListaActuacion vistaListaActuacion, List<int> ids)
        {
            if (actuacionDB.delete(ids) > 0)
            {
                VistaUtil.MsgInfo("Se ha borrado " + ids.Count.ToString() + " registro(s)", "Información");
            }
            else
            {
                VistaUtil.MsgInfo("No se han podido borrar", "Información");
            }
        }

    }

}
