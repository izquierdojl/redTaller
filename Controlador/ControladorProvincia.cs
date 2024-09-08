using redTaller.Vista;
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

        public ControladorProvincia()
        {
        }

        public void mostrar(Form parent)
        {
            VistaProvincia visProvincia = new VistaProvincia();
            visProvincia.MdiParent = parent;
            visProvincia.Show();
        }

        public void nuevo()
        {
        }

        public void modificar()
        {
        }

        public void borrar()
        {
        }

    }
}
