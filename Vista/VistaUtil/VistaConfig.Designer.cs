namespace redTaller.Vista.VistaUtil
{
    partial class VistaConfig
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupEmail = new System.Windows.Forms.GroupBox();
            this.textEmail_password = new System.Windows.Forms.TextBox();
            this.labEmailPass = new System.Windows.Forms.Label();
            this.textEmail_usuario = new System.Windows.Forms.TextBox();
            this.labelEmailUser = new System.Windows.Forms.Label();
            this.textEmail_smtp_port = new System.Windows.Forms.MaskedTextBox();
            this.labelPuerto = new System.Windows.Forms.Label();
            this.textEmail_smtp_server = new System.Windows.Forms.TextBox();
            this.labelServidor = new System.Windows.Forms.Label();
            this.textEmail_cuenta = new System.Windows.Forms.TextBox();
            this.labCuenta = new System.Windows.Forms.Label();
            this.textMasterPassword = new System.Windows.Forms.TextBox();
            this.labelPasswordMaster = new System.Windows.Forms.Label();
            this.panelButton.SuspendLayout();
            this.panelPrincipal.SuspendLayout();
            this.groupEmail.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelButton
            // 
            this.panelButton.Location = new System.Drawing.Point(0, 358);
            this.panelButton.Size = new System.Drawing.Size(808, 94);
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(484, 8);
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(642, 8);
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // panelPrincipal
            // 
            this.panelPrincipal.Controls.Add(this.textMasterPassword);
            this.panelPrincipal.Controls.Add(this.labelPasswordMaster);
            this.panelPrincipal.Controls.Add(this.groupEmail);
            this.panelPrincipal.Size = new System.Drawing.Size(808, 452);
            // 
            // groupEmail
            // 
            this.groupEmail.Controls.Add(this.textEmail_password);
            this.groupEmail.Controls.Add(this.labEmailPass);
            this.groupEmail.Controls.Add(this.textEmail_usuario);
            this.groupEmail.Controls.Add(this.labelEmailUser);
            this.groupEmail.Controls.Add(this.textEmail_smtp_port);
            this.groupEmail.Controls.Add(this.labelPuerto);
            this.groupEmail.Controls.Add(this.textEmail_smtp_server);
            this.groupEmail.Controls.Add(this.labelServidor);
            this.groupEmail.Controls.Add(this.textEmail_cuenta);
            this.groupEmail.Controls.Add(this.labCuenta);
            this.groupEmail.Location = new System.Drawing.Point(26, 21);
            this.groupEmail.Name = "groupEmail";
            this.groupEmail.Size = new System.Drawing.Size(508, 237);
            this.groupEmail.TabIndex = 0;
            this.groupEmail.TabStop = false;
            this.groupEmail.Text = "Configuración Correo Electrónico";
            // 
            // textEmail_password
            // 
            this.textEmail_password.Location = new System.Drawing.Point(146, 181);
            this.textEmail_password.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textEmail_password.MaxLength = 255;
            this.textEmail_password.Name = "textEmail_password";
            this.textEmail_password.Size = new System.Drawing.Size(323, 26);
            this.textEmail_password.TabIndex = 24;
            // 
            // labEmailPass
            // 
            this.labEmailPass.AutoSize = true;
            this.labEmailPass.Location = new System.Drawing.Point(20, 185);
            this.labEmailPass.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labEmailPass.Name = "labEmailPass";
            this.labEmailPass.Size = new System.Drawing.Size(96, 20);
            this.labEmailPass.TabIndex = 25;
            this.labEmailPass.Text = "Contraseña:";
            // 
            // textEmail_usuario
            // 
            this.textEmail_usuario.Location = new System.Drawing.Point(146, 145);
            this.textEmail_usuario.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textEmail_usuario.MaxLength = 255;
            this.textEmail_usuario.Name = "textEmail_usuario";
            this.textEmail_usuario.Size = new System.Drawing.Size(323, 26);
            this.textEmail_usuario.TabIndex = 22;
            // 
            // labelEmailUser
            // 
            this.labelEmailUser.AutoSize = true;
            this.labelEmailUser.Location = new System.Drawing.Point(20, 149);
            this.labelEmailUser.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelEmailUser.Name = "labelEmailUser";
            this.labelEmailUser.Size = new System.Drawing.Size(68, 20);
            this.labelEmailUser.TabIndex = 23;
            this.labelEmailUser.Text = "Usuario:";
            // 
            // textEmail_smtp_port
            // 
            this.textEmail_smtp_port.Location = new System.Drawing.Point(146, 111);
            this.textEmail_smtp_port.Mask = "99999";
            this.textEmail_smtp_port.Name = "textEmail_smtp_port";
            this.textEmail_smtp_port.Size = new System.Drawing.Size(74, 26);
            this.textEmail_smtp_port.TabIndex = 21;
            this.textEmail_smtp_port.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // labelPuerto
            // 
            this.labelPuerto.AutoSize = true;
            this.labelPuerto.Location = new System.Drawing.Point(20, 117);
            this.labelPuerto.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelPuerto.Name = "labelPuerto";
            this.labelPuerto.Size = new System.Drawing.Size(60, 20);
            this.labelPuerto.TabIndex = 20;
            this.labelPuerto.Text = "Puerto:";
            // 
            // textEmail_smtp_server
            // 
            this.textEmail_smtp_server.Location = new System.Drawing.Point(146, 77);
            this.textEmail_smtp_server.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textEmail_smtp_server.MaxLength = 255;
            this.textEmail_smtp_server.Name = "textEmail_smtp_server";
            this.textEmail_smtp_server.Size = new System.Drawing.Size(323, 26);
            this.textEmail_smtp_server.TabIndex = 16;
            // 
            // labelServidor
            // 
            this.labelServidor.AutoSize = true;
            this.labelServidor.Location = new System.Drawing.Point(20, 81);
            this.labelServidor.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelServidor.Name = "labelServidor";
            this.labelServidor.Size = new System.Drawing.Size(118, 20);
            this.labelServidor.TabIndex = 18;
            this.labelServidor.Text = "Servidor SMTP:";
            // 
            // textEmail_cuenta
            // 
            this.textEmail_cuenta.Location = new System.Drawing.Point(146, 41);
            this.textEmail_cuenta.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textEmail_cuenta.MaxLength = 255;
            this.textEmail_cuenta.Name = "textEmail_cuenta";
            this.textEmail_cuenta.Size = new System.Drawing.Size(323, 26);
            this.textEmail_cuenta.TabIndex = 15;
            // 
            // labCuenta
            // 
            this.labCuenta.AutoSize = true;
            this.labCuenta.Location = new System.Drawing.Point(20, 45);
            this.labCuenta.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labCuenta.Name = "labCuenta";
            this.labCuenta.Size = new System.Drawing.Size(65, 20);
            this.labCuenta.TabIndex = 17;
            this.labCuenta.Text = "Cuenta:";
            // 
            // textMasterPassword
            // 
            this.textMasterPassword.Location = new System.Drawing.Point(205, 293);
            this.textMasterPassword.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textMasterPassword.MaxLength = 255;
            this.textMasterPassword.Name = "textMasterPassword";
            this.textMasterPassword.Size = new System.Drawing.Size(329, 26);
            this.textMasterPassword.TabIndex = 26;
            // 
            // labelPasswordMaster
            // 
            this.labelPasswordMaster.AutoSize = true;
            this.labelPasswordMaster.Location = new System.Drawing.Point(29, 296);
            this.labelPasswordMaster.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelPasswordMaster.Name = "labelPasswordMaster";
            this.labelPasswordMaster.Size = new System.Drawing.Size(155, 20);
            this.labelPasswordMaster.TabIndex = 27;
            this.labelPasswordMaster.Text = "Contraseña \'master\':";
            // 
            // VistaConfig
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.ClientSize = new System.Drawing.Size(808, 452);
            this.Name = "VistaConfig";
            this.Text = "Configuración";
            this.Load += new System.EventHandler(this.VistaConfig_Load);
            this.panelButton.ResumeLayout(false);
            this.panelPrincipal.ResumeLayout(false);
            this.panelPrincipal.PerformLayout();
            this.groupEmail.ResumeLayout(false);
            this.groupEmail.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupEmail;
        private System.Windows.Forms.TextBox textEmail_smtp_server;
        private System.Windows.Forms.Label labelServidor;
        private System.Windows.Forms.TextBox textEmail_cuenta;
        private System.Windows.Forms.Label labCuenta;
        private System.Windows.Forms.MaskedTextBox textEmail_smtp_port;
        private System.Windows.Forms.Label labelPuerto;
        private System.Windows.Forms.TextBox textEmail_password;
        private System.Windows.Forms.Label labEmailPass;
        private System.Windows.Forms.TextBox textEmail_usuario;
        private System.Windows.Forms.Label labelEmailUser;
        private System.Windows.Forms.TextBox textMasterPassword;
        private System.Windows.Forms.Label labelPasswordMaster;
    }
}
