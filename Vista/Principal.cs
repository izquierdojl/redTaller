using redTaller.Controlador;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls.Primitives;
using System.Windows.Forms;

namespace redTaller
{
    public partial class Principal : Form
    {

        ControladorLogin controladorLogin;

        public Principal()
        {
            InitializeComponent();
            controladorLogin = new ControladorLogin(this);
            Login();
        }

        private void menuFicherosProvincias_Click(object sender, EventArgs e)
        {
            ControladorProvincia controladorProvincia = new ControladorProvincia();
            controladorProvincia.mostrar(this);
        }

        private void menuFicherosCodigosPostales_Click(object sender, EventArgs e)
        {
            ControladorCodigoPostal controladorCodigoPostal = new ControladorCodigoPostal();    
            controladorCodigoPostal.mostrar(this);
        }

        private void menuFicherosTalleres_Click(object sender, EventArgs e)
        {
            ControladorTaller controladorTaller = new ControladorTaller();
            controladorTaller.mostrar(this);
        }

        private void Login()
        {
            controladorLogin.mostrar();
        }

        private void menuFicherosClientes_Click(object sender, EventArgs e)
        {
            ControladorCliente controlladorCliente = new ControladorCliente();
            controlladorCliente.mostrar(this);
        }

        private void menuConfiguración_Click(object sender, EventArgs e)
        {
            ControladorConfig controladorConfig = new ControladorConfig(this);
            controladorConfig.mostrar();
        }

        public void ActualizaStatusBarUser(string text)
        {
            this.statusUser.Text = text;
        }


    }

}
