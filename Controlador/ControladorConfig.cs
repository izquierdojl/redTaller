using redTaller.Database;
using redTaller.Vista.VistaUtil;
using System.Windows.Forms;

namespace redTaller.Controlador
{
    public class ControladorConfig
    {
        Form principal;

        public ControladorConfig(Form principal)
        {
            this.principal = principal;
        }
        public void mostrar()
        {
            VistaConfig vistaConfig = new VistaConfig(this);
            ConfigDB configDB = new ConfigDB();
            vistaConfig.config = configDB.Carga();
            vistaConfig.ShowDialog();
        }

        public void aceptar(VistaConfig vistaConfig)
        {
            ConfigDB configDB = new ConfigDB();
            configDB.Guarda(vistaConfig.config);
            vistaConfig.Close();
        }

        public void cancelar(VistaConfig vistaConfig)
        {
            vistaConfig.Close();
        }

    }
}
