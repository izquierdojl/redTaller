using redTaller.Database;
using redTaller.Database.Util;
using redTaller.Modelo;
using redTaller.Util;
using redTaller.Vista.VistaLogin;
using redTaller.Vista.VistaUtil;
using System.Windows.Forms;

namespace redTaller.Controlador
{
    public class ControladorLogin
    {

        public ControladorLogin()
        {
        }

        public bool aceptar(VistaLogin vistaLogin)
        {
            bool acceso = false;
            DatabaseLogin databaseLogin = new DatabaseLogin(vistaLogin.textUser.Text,vistaLogin.textPassword.Text);
            Session.Instance.SetSession(vistaLogin.textUser.Text, vistaLogin.textPassword.Text);
            if (databaseLogin.checkLogin())
            {

                acceso = true;

                if (Session.Instance.Profile == "taller") // verificamos si es un taller y está activo
                {
                    Taller taller = new Taller();
                    TallerDB tallerDB = new TallerDB();
                    taller = tallerDB.CargaElemento(0, "SELECT * FROM taller WHERE nif='" + Session.Instance.User + "'");
                    if (taller != null)
                    {
                        if (taller.bloqueado)
                        {
                            VistaUtil.MsgInfo("Usuario bloqueado", "Incorrecto");
                            cancelar(vistaLogin);
                        }
                        if (!taller.activo)
                        {
                            vistaLogin.Hide();
                            VistaLoginConfirma vistaLoginConfirma = new VistaLoginConfirma(this);
                            vistaLoginConfirma.ShowDialog();
                        }
                    }

                }

                Principal principal = new Principal();
                principal.Show();

            }
            else
            {
                VistaUtil.MsgInfo("Usuario o password incorrecto", "Incorrecto");
            }

            return acceso;

        }

        public void cancelar(VistaLogin vistaLogin)
        {
            vistaLogin.Close();
            Application.Exit();
        }
        public void aceptar_confirma(VistaLoginConfirma vistaLoginConfirma)
        {
            TallerDB tallerDB = new TallerDB();
            if( tallerDB.updateActivacionPassword(Session.Instance.User, vistaLoginConfirma.textPassword.Text) > 0 )
            {
                VistaUtil.MsgInfo("Contraseña correctamente actualizada", "Correcto");
                Principal principal = new Principal();
                principal.Show();
           }
        }

        public void cancelar_confirma(VistaLoginConfirma vistaLoginConfirma)
        {
            vistaLoginConfirma.Close();
            Application.Exit();
        }

    }
}
