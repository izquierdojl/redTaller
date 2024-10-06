using redTaller.Database;
using redTaller.Modelo;
using redTaller.Vista;
using redTaller.Vista.VistaProvincia;
using System.Collections.Generic;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace redTaller.Controlador
{
    internal class ControladorProvincia
    {

        public ControladorProvincia()
        {
        }

        public void mostrar(Form parent)
        {
            ProvinciaDB provinciaDB = new ProvinciaDB();
            VistaListaProvincia visProvincia = new VistaListaProvincia( provinciaDB.extraeProvincias() );
            visProvincia.MdiParent = parent;
            visProvincia.Show();
        }

        public void nuevo(VistaListaProvincia vistaListaProvincia)
        {
            VistaFormProvincia vistaFormProvincia = new VistaFormProvincia(vistaListaProvincia, 1 , new Provincia() );
            vistaFormProvincia.ShowDialog();
        }

        public void modificar(VistaListaProvincia vistaListaProvincia, string key)
        {
            ProvinciaDB provinciaDB = new ProvinciaDB();
            Provincia provincia = provinciaDB.CargaProvincia(key);
            if (provincia != null)
            {
                VistaFormProvincia vistaFormProvincia = new VistaFormProvincia(vistaListaProvincia, 2, provincia);
                vistaFormProvincia.ShowDialog();
            }
        }

        public void borrar( VistaListaProvincia vistaListaProvincia, List<string> keys )
        {
            ProvinciaDB provinciaDB = new ProvinciaDB();
            if (provinciaDB.deleteProvincias(keys) > 0)
            {
                vistaListaProvincia.msgInfo("Se ha borrido " + keys.Count.ToString() + " provincia(s)" );
            }
            else
            {
                vistaListaProvincia.msgInfo("No se han podido borrar provincias");
            }
        }

        public void buscar( VistaListaProvincia vistaListaProvincia, string filtro )
        {
            ProvinciaDB provinciaDB = new ProvinciaDB();
            vistaListaProvincia.recargaGrid(provinciaDB.extraeProvinciasFiltro(filtro),null);
        }

        public void guardar(Provincia provincia,int modo,VistaListaProvincia vistaListaProvincia)
        {
            ProvinciaDB provinciaDB = new ProvinciaDB();
            if ( modo == 1 )
            {
                provinciaDB.insertProvincia(provincia);
            }
            else
            {
                provinciaDB.updateProvincia(provincia);
            }
            vistaListaProvincia.recargaGrid(provinciaDB.extraeProvincias(), provincia.Codigo);
        }

    }

}
