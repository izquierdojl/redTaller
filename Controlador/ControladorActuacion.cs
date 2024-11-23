using redTaller.Database;
using redTaller.Modelo;
using redTaller.Vista.VistaActuacion;
using redTaller.Vista.VistaUtil;
using System.Collections.Generic;
using System.Data;
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
            VistaFormActuacion vistaFormActuacion = new VistaFormActuacion(vistaListaActuacion, 1, new Actuacion() , actuacionDB.dcDetalle );
            vistaFormActuacion.ShowDialog();
        }

        public void modificar(VistaListaActuacion vistaListaActuacion, int id)
        {
            Actuacion actuacion = actuacionDB.CargaElemento(id);
            if (actuacion != null)
            {
                VistaFormActuacion vistaFormActuacion = new VistaFormActuacion(vistaListaActuacion, 2, actuacion , actuacionDB.dcDetalle );
                vistaFormActuacion.ShowDialog();
            }
        }

        public bool borrar(VistaListaActuacion vistaListaActuacion, List<int> ids)
        {
            if (actuacionDB.delete(ids) > 0)
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

        public void guardar(Actuacion actuacion, int modo, VistaListaActuacion vistaListaActuacion)
        {
            if (modo == 1)
            {
                actuacionDB.Insert(actuacion);
            }
            else
            {
                actuacionDB.Update(actuacion);
            }
            if (string.IsNullOrEmpty(vistaListaActuacion.textSearch.Text))
            {
                vistaListaActuacion.recargaGrid(actuacionDB.Load(), actuacion.id);
            }
            else
            {
                Dictionary<string, object> filtros = new Dictionary<string, object>();
                filtros.Add(vistaListaActuacion.comboSearch.SelectedValue.ToString(), vistaListaActuacion.textSearch.Text);  // Filtro
                vistaListaActuacion.recargaGrid(actuacionDB.Load(filtros), actuacion.id);
            }
            if (modo == 1)
                modificar(vistaListaActuacion, actuacion.id);
        }

        public void asignaTaller(VistaFormActuacion vistaFormActuacion)
        {
            TallerDB db = new TallerDB();
            Taller taller = db.CargaElemento( 0, null, vistaFormActuacion.textNif_Taller.Text);
            if (taller != null)
                vistaFormActuacion.labelNomTaller.Text = taller.nombre;
        }

        public bool asignaCliente(VistaFormActuacion vistaFormActuacion)
        {
            ClienteDB db = new ClienteDB();
            Cliente cliente = db.CargaElemento(0, null, vistaFormActuacion.textNif_Cliente.Text);
            if (cliente.nif != null)
            {
                vistaFormActuacion.labelNomCliente.Text = cliente.nombre;
                return true;
            }
            else
                return false; 
            
        }

        public bool asignaMatricula(VistaFormActuacion vistaFormActuacion)
        {
            MatriculaDB db = new MatriculaDB();
            Matricula matricula = db.CargaElemento(0, null, vistaFormActuacion.textMatricula.Text);
            if (matricula.matricula != null)
            {
                vistaFormActuacion.labelNombreMatricula.Text = matricula.marca + " " + matricula.modelo;
                return true;
            }else return false;
        }

        public DataTable loadDetalle(Actuacion actuacion)
        {
            return actuacionDB.LoadDetalle(actuacion);
        }

        public void nuevoDetalle(VistaFormActuacion vistaFormActuacion, int idActuacion)
        {
            VistaFormActuacionDetalle vistaFormActuacionDetalle = new VistaFormActuacionDetalle(vistaFormActuacion, 1, idActuacion, new ActuacionDetalle());
            vistaFormActuacionDetalle.ShowDialog();
        }

        public void modificarDetalle(VistaFormActuacion vistaFormActuacion, int idActuacionDetalle)
        {
            ActuacionDetalle actuacionDetalle = actuacionDB.CargaActuacionDetalle( vistaFormActuacion.actuacion, idActuacionDetalle );
            if (actuacionDetalle != null)
            {
                VistaFormActuacionDetalle vistaFormActuacionDetalle = new VistaFormActuacionDetalle(vistaFormActuacion, 2, vistaFormActuacion.actuacion.id, actuacionDetalle );
                vistaFormActuacionDetalle.ShowDialog();
            }
        }

        public bool borrarDetalle(List<int> lineas, Actuacion actuacion)
        {
            if (actuacionDB.DeleteDetalle(lineas,actuacion) > 0)
            {
                VistaUtil.MsgInfo("Se ha borrado " + lineas.Count.ToString() + " registro(s)", "Información");
                return true;
            }
            else
            {
                VistaUtil.MsgInfo("No se han podido borrar", "Información");
                return false;
            }
        }

        public void guardarDetalle(ActuacionDetalle actuacionDetalle, int modo, VistaFormActuacion vistaFormActuacion, VistaFormActuacionDetalle vistaFormActuacionDetalle)
        {
            if (modo == 1)
            {
                actuacionDB.InsertDetalle(vistaFormActuacion.actuacion, actuacionDetalle);
            }
            else
            {
                actuacionDB.UpdateDetalle(vistaFormActuacion.actuacion, actuacionDetalle);
            }
        }

    }

}
