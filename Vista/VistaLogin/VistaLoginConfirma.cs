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
    public partial class VistaLoginConfirma : Form
    {

        ControladorLogin controladorLogin;
        public VistaLoginConfirma(ControladorLogin controladorLogin)
        {
            InitializeComponent();
            this.controladorLogin = controladorLogin;
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (textPassword.Text.Length >= 8)
            {
                if (textPassword.Text.Equals(textPassword2.Text))
                {
                    controladorLogin.aceptar_confirma(this);
                }
                else
                {
                    VistaUtil.VistaUtil.MsgInfo("La contraseñas no coinciden","Contraseña incorrecta");
                }
            }
            else 
            {
                VistaUtil.VistaUtil.MsgInfo("La contraseña debe tener al menos 8 carácteres o números, revise su información", "Contraseña incorrecta");
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            controladorLogin.cancelar_confirma(this);
        }
    }
}
