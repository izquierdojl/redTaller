using redTaller.Database.Provincia;
using redTaller.Modelo;
using redTaller.Vista;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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

        public void nuevo( Provincia provincia , Form parent )
        {
        }

        public void modificar()
        {
        }

        public void borrar()
        {
        }

        // para buscar por provincia
        public void buscar()
        {
        }

    }

}
