using redTaller.Database;
using redTaller.Modelo;
using redTaller.Vista.VistaCodigoPostal;
using redTaller.Vista.VistaProvincia;
using redTaller.Vista.VistaUtil;
using System.Collections.Generic;
using System.Windows.Forms;

namespace redTaller.Controlador
{
    internal class ControladorCodigoPostal
    {

        CodigoPostalDB codigoPostalDB;

        public ControladorCodigoPostal()
        {
            codigoPostalDB = new CodigoPostalDB();
        }
        
        public void mostrar(Form parent)
        {
            
            VistaListaCodigoPostal visCodigoPostal = new VistaListaCodigoPostal(codigoPostalDB.Load(),codigoPostalDB.dc);
            visCodigoPostal.MdiParent = parent;
            visCodigoPostal.Show();
            
        }
        
        public void nuevo(VistaListaCodigoPostal vistaListaCodigoPostal)
        {
            VistaFormCodigoPostal vistaFormCodigoPostal = new VistaFormCodigoPostal(vistaListaCodigoPostal, 1 , new CodigoPostal() );
            vistaFormCodigoPostal.ShowDialog();
        }

        public void modificar(VistaListaCodigoPostal vistaListaCodigoPostal, int id)
        {
            CodigoPostal CodigoPostal = codigoPostalDB.CargaElemento(id);
            if (CodigoPostal != null)
            {
                VistaFormCodigoPostal vistaFormCodigoPostal = new VistaFormCodigoPostal(vistaListaCodigoPostal, 2, CodigoPostal);
                vistaFormCodigoPostal.ShowDialog();
            }
        }
        
        public bool borrar( VistaListaCodigoPostal vistaListaCodigoPostal, List<int> ids )
        {
            if (codigoPostalDB.delete(ids) > 0)
            {
                VistaUtil.MsgInfo("Se ha borrado " + ids.Count.ToString() + " registro(s)"  , "Información" );
                return true;
            }
            else
            {
                VistaUtil.MsgInfo("No se han podido borrar", "Información");
                return false;
            }
        }

        public void buscar( VistaListaCodigoPostal vistaListaCodigoPostal, string filtro, string campo )
        {
            Dictionary<string, object> filtros = new Dictionary<string, object>();
            filtros.Add(vistaListaCodigoPostal.comboSearch.SelectedValue.ToString(), vistaListaCodigoPostal.textSearch.Text);  // Filtro
            vistaListaCodigoPostal.recargaGrid(codigoPostalDB.Load(filtros));
        }


        public void guardar(CodigoPostal codigoPostal, int modo, VistaListaCodigoPostal vistaListaCodigoPostal)
        {
            if (modo == 1)
            {
                codigoPostalDB.Insert(codigoPostal);
            }
            else
            {
                codigoPostalDB.Update(codigoPostal);
            }
            if (string.IsNullOrEmpty(vistaListaCodigoPostal.textSearch.Text))
            {
                vistaListaCodigoPostal.recargaGrid(codigoPostalDB.Load(), codigoPostal.id);
            }
            else
            {
                Dictionary<string, object> filtros = new Dictionary<string, object>();
                filtros.Add(vistaListaCodigoPostal.comboSearch.SelectedValue.ToString(), vistaListaCodigoPostal.textSearch.Text );  // Filtro
                vistaListaCodigoPostal.recargaGrid(codigoPostalDB.Load(filtros), codigoPostal.id);
            }
        }

        public bool valida(string key)
        {
            return codigoPostalDB.ValidaKey(key);
        }

        public CodigoPostal Id(int id)
        {
            return codigoPostalDB.CargaElemento(id);
        }

    }

}
