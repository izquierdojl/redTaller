using redTaller.Database;
using redTaller.Modelo;
using redTaller.Vista.VistaCodigoPostal;
using redTaller.Vista.VistaUtil;
using System.Collections.Generic;
using System.Windows.Forms;

namespace redTaller.Controlador
{
    internal class ControladorCodigoPostal
    {

        public ControladorCodigoPostal()
        {
        }
        
        public void mostrar(Form parent)
        {
            
            CodigoPostalDB codigoPostalDB = new CodigoPostalDB();
            VistaListaCodigoPostal visCodigoPostal = new VistaListaCodigoPostal(codigoPostalDB.extraeCodigosPostal());
            visCodigoPostal.MdiParent = parent;
            visCodigoPostal.Show();
            
        }
        
        public void nuevo(VistaListaCodigoPostal vistaListaCodigoPostal)
        {
            VistaFormCodigoPostal vistaFormCodigoPostal = new VistaFormCodigoPostal(vistaListaCodigoPostal, 1 , new CodigoPostal() );
            vistaFormCodigoPostal.ShowDialog();
        }

        public void modificar(VistaListaCodigoPostal vistaListaCodigoPostal, string key)
        {
            CodigoPostalDB CodigoPostalDB = new CodigoPostalDB();
            CodigoPostal CodigoPostal = CodigoPostalDB.CargaCodigoPostal(key);
            if (CodigoPostal != null)
            {
                VistaFormCodigoPostal vistaFormCodigoPostal = new VistaFormCodigoPostal(vistaListaCodigoPostal, 2, CodigoPostal);
                vistaFormCodigoPostal.ShowDialog();
            }
        }
        
        public void borrar( VistaListaCodigoPostal vistaListaCodigoPostal, List<string> keys )
        {
            CodigoPostalDB CodigoPostalDB = new CodigoPostalDB();
            if (CodigoPostalDB.deleteCodigoPostals(keys) > 0)
            {
                VistaUtil.MsgInfo("Se ha borrado " + keys.Count.ToString() + " registro(s)"  , "Información" );
            }
            else
            {
                VistaUtil.MsgInfo("No se han podido borrar", "Información");
            }
        }

        public void buscar( VistaListaCodigoPostal vistaListaCodigoPostal, string filtro, string campo )
        {
            CodigoPostalDB CodigoPostalDB = new CodigoPostalDB();
            vistaListaCodigoPostal.recargaGrid(CodigoPostalDB.extraeCodigoPostalsFiltro(filtro,campo),null);
        }
        

        public void guardar(CodigoPostal CodigoPostal,int modo,VistaListaCodigoPostal vistaListaCodigoPostal)
        {
            CodigoPostalDB CodigoPostalDB = new CodigoPostalDB();
            if ( modo == 1 )
            {
                CodigoPostalDB.insertCodigoPostal(CodigoPostal);
            }
            else
            {
                CodigoPostalDB.updateCodigoPostal(CodigoPostal);
            }
            vistaListaCodigoPostal.recargaGrid(CodigoPostalDB.extraeCodigosPostal(), CodigoPostal.Codigo);
        }

        public bool valida(string key)
        {
            CodigoPostalDB CodigoPostalDB = new CodigoPostalDB();
            return CodigoPostalDB.validaKey(key);
        }

    }

}
