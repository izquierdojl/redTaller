using redTaller.Controlador;
using redTaller.Modelo;
using System;
using System.Windows.Forms.VisualStyles;

namespace redTaller.Vista.VistaUtil
{
    public partial class VistaConfig : redTaller.Vista.VistaBase.VistaFormBase
    {

        public Config config { get; set; }
        ControladorConfig controladorConfig;

        public VistaConfig(ControladorConfig controladorConfig)
        {
            InitializeComponent();
            //textEmail_password.UseSystemPasswordChar = true;
            this.controladorConfig = controladorConfig;
        }

        private void btnAceptar_Click(object sender, System.EventArgs e)
        {
            config.EmailCuenta = textEmail_cuenta.Text;
            config.EmailSmtpServer = textEmail_smtp_server.Text;
            config.EmailSmtpPort = int.Parse(textEmail_smtp_port.Text);
            config.EmailUser = textEmail_usuario.Text;
            config.EmailPassword = textEmail_password.Text;
            config.MasterPassword = textMasterPassword.Text;
            controladorConfig.aceptar(this);
        }

        private void btnCancelar_Click(object sender, System.EventArgs e)
        {
            controladorConfig.cancelar(this);
        }

        private void VistaConfig_Load(object sender, EventArgs e)
        {
            textEmail_cuenta.Text = config.EmailCuenta;
            textEmail_smtp_server.Text = config.EmailSmtpServer;
            textEmail_smtp_port.Text = config.EmailSmtpPort.ToString();
            textEmail_usuario.Text = config.EmailUser;
            textEmail_password.Text = config.EmailPassword;
            textMasterPassword.Text = config.MasterPassword;
        }
    }
}
