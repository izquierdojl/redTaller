namespace redTaller.Vista.VistaCliente
{
    partial class VistaFormCliente
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
            this.btnSearchCp = new System.Windows.Forms.Button();
            this.textMovil = new System.Windows.Forms.MaskedTextBox();
            this.textTelefono = new System.Windows.Forms.MaskedTextBox();
            this.checkBloqueado = new System.Windows.Forms.CheckBox();
            this.checkActivo = new System.Windows.Forms.CheckBox();
            this.textEmail = new System.Windows.Forms.TextBox();
            this.labelEmail = new System.Windows.Forms.Label();
            this.labelMovil = new System.Windows.Forms.Label();
            this.labTelefono = new System.Windows.Forms.Label();
            this.textProvincia = new System.Windows.Forms.TextBox();
            this.labProvincia = new System.Windows.Forms.Label();
            this.textPoblacion = new System.Windows.Forms.TextBox();
            this.textCp = new System.Windows.Forms.TextBox();
            this.labPoblacion = new System.Windows.Forms.Label();
            this.textDomicilio = new System.Windows.Forms.TextBox();
            this.labDomicilio = new System.Windows.Forms.Label();
            this.textNombre = new System.Windows.Forms.TextBox();
            this.labelNombre = new System.Windows.Forms.Label();
            this.textNif = new System.Windows.Forms.TextBox();
            this.labNif = new System.Windows.Forms.Label();
            this.panelButton.SuspendLayout();
            this.panelPrincipal.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelButton
            // 
            this.panelButton.Location = new System.Drawing.Point(0, 366);
            this.panelButton.Size = new System.Drawing.Size(1042, 94);
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(718, 8);
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(876, 8);
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // panelPrincipal
            // 
            this.panelPrincipal.Controls.Add(this.btnSearchCp);
            this.panelPrincipal.Controls.Add(this.textMovil);
            this.panelPrincipal.Controls.Add(this.textTelefono);
            this.panelPrincipal.Controls.Add(this.checkBloqueado);
            this.panelPrincipal.Controls.Add(this.checkActivo);
            this.panelPrincipal.Controls.Add(this.textEmail);
            this.panelPrincipal.Controls.Add(this.labelEmail);
            this.panelPrincipal.Controls.Add(this.labelMovil);
            this.panelPrincipal.Controls.Add(this.labTelefono);
            this.panelPrincipal.Controls.Add(this.textProvincia);
            this.panelPrincipal.Controls.Add(this.labProvincia);
            this.panelPrincipal.Controls.Add(this.textPoblacion);
            this.panelPrincipal.Controls.Add(this.textCp);
            this.panelPrincipal.Controls.Add(this.labPoblacion);
            this.panelPrincipal.Controls.Add(this.textDomicilio);
            this.panelPrincipal.Controls.Add(this.labDomicilio);
            this.panelPrincipal.Controls.Add(this.textNombre);
            this.panelPrincipal.Controls.Add(this.labelNombre);
            this.panelPrincipal.Controls.Add(this.textNif);
            this.panelPrincipal.Controls.Add(this.labNif);
            this.panelPrincipal.Size = new System.Drawing.Size(1042, 460);
            // 
            // btnSearchCp
            // 
            this.btnSearchCp.BackgroundImage = global::redTaller.Properties.Resources.buscar;
            this.btnSearchCp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSearchCp.FlatAppearance.BorderSize = 0;
            this.btnSearchCp.Location = new System.Drawing.Point(252, 132);
            this.btnSearchCp.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnSearchCp.Name = "btnSearchCp";
            this.btnSearchCp.Size = new System.Drawing.Size(34, 31);
            this.btnSearchCp.TabIndex = 54;
            this.btnSearchCp.TabStop = false;
            this.btnSearchCp.UseVisualStyleBackColor = true;
            this.btnSearchCp.Click += new System.EventHandler(this.btnSearchCp_Click);
            // 
            // textMovil
            // 
            this.textMovil.Location = new System.Drawing.Point(572, 206);
            this.textMovil.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textMovil.Mask = "000 00 00 00";
            this.textMovil.Name = "textMovil";
            this.textMovil.Size = new System.Drawing.Size(192, 26);
            this.textMovil.TabIndex = 43;
            // 
            // textTelefono
            // 
            this.textTelefono.Location = new System.Drawing.Point(134, 206);
            this.textTelefono.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textTelefono.Mask = "000 00 00 00";
            this.textTelefono.Name = "textTelefono";
            this.textTelefono.Size = new System.Drawing.Size(192, 26);
            this.textTelefono.TabIndex = 42;
            // 
            // checkBloqueado
            // 
            this.checkBloqueado.AutoSize = true;
            this.checkBloqueado.Location = new System.Drawing.Point(908, 66);
            this.checkBloqueado.Name = "checkBloqueado";
            this.checkBloqueado.Size = new System.Drawing.Size(105, 24);
            this.checkBloqueado.TabIndex = 53;
            this.checkBloqueado.Text = "Bloqueado";
            this.checkBloqueado.UseVisualStyleBackColor = true;
            // 
            // checkActivo
            // 
            this.checkActivo.AutoSize = true;
            this.checkActivo.Location = new System.Drawing.Point(908, 30);
            this.checkActivo.Name = "checkActivo";
            this.checkActivo.Size = new System.Drawing.Size(71, 24);
            this.checkActivo.TabIndex = 52;
            this.checkActivo.Text = "Activo";
            this.checkActivo.UseVisualStyleBackColor = true;
            // 
            // textEmail
            // 
            this.textEmail.Location = new System.Drawing.Point(134, 243);
            this.textEmail.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textEmail.MaxLength = 100;
            this.textEmail.Name = "textEmail";
            this.textEmail.Size = new System.Drawing.Size(506, 26);
            this.textEmail.TabIndex = 44;
            // 
            // labelEmail
            // 
            this.labelEmail.AutoSize = true;
            this.labelEmail.Location = new System.Drawing.Point(32, 246);
            this.labelEmail.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelEmail.Name = "labelEmail";
            this.labelEmail.Size = new System.Drawing.Size(50, 20);
            this.labelEmail.TabIndex = 51;
            this.labelEmail.Text = "eMail:";
            // 
            // labelMovil
            // 
            this.labelMovil.AutoSize = true;
            this.labelMovil.Location = new System.Drawing.Point(470, 210);
            this.labelMovil.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelMovil.Name = "labelMovil";
            this.labelMovil.Size = new System.Drawing.Size(48, 20);
            this.labelMovil.TabIndex = 50;
            this.labelMovil.Text = "Móvil:";
            // 
            // labTelefono
            // 
            this.labTelefono.AutoSize = true;
            this.labTelefono.Location = new System.Drawing.Point(32, 210);
            this.labTelefono.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labTelefono.Name = "labTelefono";
            this.labTelefono.Size = new System.Drawing.Size(75, 20);
            this.labTelefono.TabIndex = 35;
            this.labTelefono.Text = "Teléfono:";
            // 
            // textProvincia
            // 
            this.textProvincia.Location = new System.Drawing.Point(134, 170);
            this.textProvincia.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textProvincia.MaxLength = 80;
            this.textProvincia.Name = "textProvincia";
            this.textProvincia.Size = new System.Drawing.Size(630, 26);
            this.textProvincia.TabIndex = 41;
            // 
            // labProvincia
            // 
            this.labProvincia.AutoSize = true;
            this.labProvincia.Location = new System.Drawing.Point(32, 173);
            this.labProvincia.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labProvincia.Name = "labProvincia";
            this.labProvincia.Size = new System.Drawing.Size(76, 20);
            this.labProvincia.TabIndex = 49;
            this.labProvincia.Text = "Provincia:";
            // 
            // textPoblacion
            // 
            this.textPoblacion.Location = new System.Drawing.Point(301, 135);
            this.textPoblacion.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textPoblacion.MaxLength = 80;
            this.textPoblacion.Name = "textPoblacion";
            this.textPoblacion.Size = new System.Drawing.Size(464, 26);
            this.textPoblacion.TabIndex = 40;
            // 
            // textCp
            // 
            this.textCp.Location = new System.Drawing.Point(134, 133);
            this.textCp.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textCp.MaxLength = 7;
            this.textCp.Name = "textCp";
            this.textCp.Size = new System.Drawing.Size(110, 26);
            this.textCp.TabIndex = 39;
            this.textCp.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textCp_KeyDown);
            this.textCp.Validating += new System.ComponentModel.CancelEventHandler(this.textCp_Validating);
            // 
            // labPoblacion
            // 
            this.labPoblacion.AutoSize = true;
            this.labPoblacion.Location = new System.Drawing.Point(32, 138);
            this.labPoblacion.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labPoblacion.Name = "labPoblacion";
            this.labPoblacion.Size = new System.Drawing.Size(82, 20);
            this.labPoblacion.TabIndex = 48;
            this.labPoblacion.Text = "Población:";
            // 
            // textDomicilio
            // 
            this.textDomicilio.Location = new System.Drawing.Point(134, 98);
            this.textDomicilio.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textDomicilio.MaxLength = 150;
            this.textDomicilio.Name = "textDomicilio";
            this.textDomicilio.Size = new System.Drawing.Size(630, 26);
            this.textDomicilio.TabIndex = 38;
            // 
            // labDomicilio
            // 
            this.labDomicilio.AutoSize = true;
            this.labDomicilio.Location = new System.Drawing.Point(32, 103);
            this.labDomicilio.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labDomicilio.Name = "labDomicilio";
            this.labDomicilio.Size = new System.Drawing.Size(76, 20);
            this.labDomicilio.TabIndex = 47;
            this.labDomicilio.Text = "Domicilio:";
            // 
            // textNombre
            // 
            this.textNombre.Location = new System.Drawing.Point(134, 63);
            this.textNombre.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textNombre.MaxLength = 150;
            this.textNombre.Name = "textNombre";
            this.textNombre.Size = new System.Drawing.Size(630, 26);
            this.textNombre.TabIndex = 37;
            // 
            // labelNombre
            // 
            this.labelNombre.AutoSize = true;
            this.labelNombre.Location = new System.Drawing.Point(32, 66);
            this.labelNombre.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelNombre.Name = "labelNombre";
            this.labelNombre.Size = new System.Drawing.Size(69, 20);
            this.labelNombre.TabIndex = 46;
            this.labelNombre.Text = "Nombre:";
            // 
            // textNif
            // 
            this.textNif.Location = new System.Drawing.Point(134, 26);
            this.textNif.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textNif.MaxLength = 15;
            this.textNif.Name = "textNif";
            this.textNif.Size = new System.Drawing.Size(192, 26);
            this.textNif.TabIndex = 36;
            this.textNif.Validating += new System.ComponentModel.CancelEventHandler(this.textNif_Validating);
            // 
            // labNif
            // 
            this.labNif.AutoSize = true;
            this.labNif.Location = new System.Drawing.Point(32, 30);
            this.labNif.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labNif.Name = "labNif";
            this.labNif.Size = new System.Drawing.Size(51, 20);
            this.labNif.TabIndex = 45;
            this.labNif.Text = "N.I.F.:";
            // 
            // VistaFormCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.ClientSize = new System.Drawing.Size(1042, 460);
            this.Name = "VistaFormCliente";
            this.panelButton.ResumeLayout(false);
            this.panelPrincipal.ResumeLayout(false);
            this.panelPrincipal.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnSearchCp;
        private System.Windows.Forms.MaskedTextBox textMovil;
        private System.Windows.Forms.MaskedTextBox textTelefono;
        private System.Windows.Forms.CheckBox checkBloqueado;
        private System.Windows.Forms.CheckBox checkActivo;
        private System.Windows.Forms.TextBox textEmail;
        private System.Windows.Forms.Label labelEmail;
        private System.Windows.Forms.Label labelMovil;
        private System.Windows.Forms.Label labTelefono;
        public System.Windows.Forms.TextBox textProvincia;
        private System.Windows.Forms.Label labProvincia;
        public System.Windows.Forms.TextBox textPoblacion;
        public System.Windows.Forms.TextBox textCp;
        private System.Windows.Forms.Label labPoblacion;
        private System.Windows.Forms.TextBox textDomicilio;
        private System.Windows.Forms.Label labDomicilio;
        private System.Windows.Forms.TextBox textNombre;
        private System.Windows.Forms.Label labelNombre;
        private System.Windows.Forms.TextBox textNif;
        private System.Windows.Forms.Label labNif;
    }
}
