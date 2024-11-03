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
        public VistaLogin()
        {
            InitializeComponent();
            this.conroladorLogin = new ControladorLogin();
            this.textPassword.UseSystemPasswordChar = true;
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if( conroladorLogin.aceptar(this) )
            {
                this.Hide();
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            conroladorLogin.cancelar(this);
        }
    }
}
