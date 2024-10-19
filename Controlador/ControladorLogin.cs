using redTaller.Database;
using redTaller.Vista.VistaCodigoPostal;
using redTaller.Vista.VistaLogin;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace redTaller.Controlador
{
    public class ControladorLogin
    {

        Form principal;

        public ControladorLogin(Form principal)
        {
            this.principal = principal;
        }

        public void mostrar()
        {
            VistaLogin vistaLogin = new VistaLogin(this);
            vistaLogin.ShowDialog();
        }

        public void aceptar(VistaLogin vistaLogin)
        {
            vistaLogin.Close();
            // hacer aquí la lógica de logeo
        }

        public void cancelar(VistaLogin vistaLogin)
        {
            vistaLogin.Close();
            Application.Exit();
        }

    }
}
