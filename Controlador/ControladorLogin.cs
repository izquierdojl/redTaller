using redTaller.Database;
using redTaller.Database.Util;
using redTaller.Util;
using redTaller.Vista.VistaCodigoPostal;
using redTaller.Vista.VistaLogin;
using redTaller.Vista.VistaUtil;
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

        Principal principal;

        public ControladorLogin(Principal principal)
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
            DatabaseLogin databaseLogin = new DatabaseLogin(vistaLogin.textUser.Text,vistaLogin.textPassword.Text);
            Session.Instance.SetSession(vistaLogin.textUser.Text, vistaLogin.textPassword.Text);
            if (databaseLogin.checkLogin())
            {
                principal.ActualizaStatusBarUser("Usuario : " + vistaLogin.textUser.Text);
                vistaLogin.Close();
            }
            else
                VistaUtil.MsgInfo("Usuario o password incorrecto", "Incorrecto");
        }

        public void cancelar(VistaLogin vistaLogin)
        {
            vistaLogin.Close();
            Application.Exit();
        }

    }
}
