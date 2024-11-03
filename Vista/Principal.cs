using redTaller.Controlador;
using redTaller.Util;
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

        public Principal()
        {
            InitializeComponent();
            this.FormClosing += new FormClosingEventHandler(PrincipalForm_FormClosing);
            this.Load += new EventHandler(PrincipalForm_Load);
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

        private void PrincipalForm_Load(object sender, EventArgs e)
        {
            this.statusUser.Text = "Usuario : " + Session.Instance.User;

            if( Session.Instance.Profile == "taller" )
            {
                this.menuConfiguración.Visible = false;
                this.menuFicherosTalleres.Visible = false;
                this.menuFicherosCodigosPostales.Visible = false;
                this.menuFicherosProvincias.Visible = false;
            }

        }


        private void PrincipalForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

    }

}
