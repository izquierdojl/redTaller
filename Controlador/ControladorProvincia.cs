using redTaller.Database;
using redTaller.Modelo;
using redTaller.Vista.VistaCodigoPostal;
using redTaller.Vista.VistaProvincia;
using redTaller.Vista.VistaUtil;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace redTaller.Controlador
{
    internal class ControladorProvincia
    {

        private ProvinciaDB provinciaDB;

        public ControladorProvincia() {
            provinciaDB = new ProvinciaDB();
        }

        public void mostrar(Form parent)
        {
            VistaListaProvincia vistaListaProvincia = new VistaListaProvincia(provinciaDB.extraeDT());
            vistaListaProvincia.MdiParent = parent;
            vistaListaProvincia.Show();
        }

        public void nuevo(VistaListaProvincia vistaListaProvincia)
        {
            VistaFormProvincia vistaFormProvincia = new VistaFormProvincia(vistaListaProvincia, 1, new Provincia());
            vistaFormProvincia.ShowDialog();
        }

        public void modificar(VistaListaProvincia vistaListaProvincia, string key)
        {
            Provincia provincia = provinciaDB.CargaElemento(key);
            if (provincia != null)
            {
                VistaFormProvincia vistaFormProvincia = new VistaFormProvincia(vistaListaProvincia, 2, provincia);
                vistaFormProvincia.ShowDialog();
            }
        }

        public void borrar(VistaListaProvincia vistaListaProvincia, List<string> keys)
        {
            if (provinciaDB.delete(keys) > 0)
            {
                VistaUtil.MsgInfo("Se ha borrado " + keys.Count.ToString() + " registro(s)", "Información");
            }
            else
            {
                VistaUtil.MsgInfo("No se han podido borrar", "Información");
            }
        }

        public void buscar(VistaListaProvincia vistaListaProvincia, string filtro, string campo)
        {
            vistaListaProvincia.recargaGrid(provinciaDB.extraeDTFiltro(filtro, campo), null);
        }


        public void guardar(Provincia provincia, int modo, VistaListaProvincia vistaListaProvincia)
        {
            if (modo == 1)
            {
                provinciaDB.insert(provincia);
            }
            else
            {
                provinciaDB.update(provincia);
            }
            if( string.IsNullOrEmpty(vistaListaProvincia.textSearch.Text) )
               vistaListaProvincia.recargaGrid(provinciaDB.extraeDT(), provincia.codigo);
            else
               vistaListaProvincia.recargaGrid(provinciaDB.extraeDTFiltro(vistaListaProvincia.textSearch.Text,vistaListaProvincia.comboSearch.SelectedValue.ToString()), provincia.codigo);
        }

        public List<Provincia> listar()
        {
            return provinciaDB.lista();
        }

        public bool valida(string key)
        {
            return provinciaDB.validaKey(key);
        }

    }
}
