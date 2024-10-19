using redTaller.Controlador;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace redTaller.Vista.VistaLogin
{
    public partial class VistaLogin : Form
    {

        ControladorLogin conroladorLogin;
        public VistaLogin(ControladorLogin controladorLogin)
        {
            InitializeComponent();
            this.conroladorLogin = controladorLogin;
            this.textPassword.UseSystemPasswordChar = true;
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            conroladorLogin.aceptar(this);
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            conroladorLogin.cancelar(this);
        }
    }
}
