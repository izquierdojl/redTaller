using redTaller.Database.Provincia;
using redTaller.Modelo;
using redTaller.Vista;
using System.Collections;
using System.Collections.Generic;
using System.Windows.Forms;

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

        public void nuevo( Provincia provincia , Form parent )
        {
        }

        public void modificar()
        {
        }

        public void borrar( VistaListaProvincia vistaListaProvincia, List<string> keys )
        {
            ProvinciaDB provinciaDB = new ProvinciaDB();
            if (provinciaDB.borraProvincias(keys) > 0)
            {
                vistaListaProvincia.msgInfo("Se han borrido " + keys.Count.ToString() + "provincias" );
                vistaListaProvincia.recarga(provinciaDB.extraeProvincias());
            }
            else
            {
                vistaListaProvincia.msgInfo("No se han podido borrar provincias");

            }

        }

        public void buscar( VistaListaProvincia vistaListaProvincia, string filtro )
        {
            ProvinciaDB provinciaDB = new ProvinciaDB();
            vistaListaProvincia.recarga(provinciaDB.extraeProvinciasFiltro(filtro));
        }

    }

}
