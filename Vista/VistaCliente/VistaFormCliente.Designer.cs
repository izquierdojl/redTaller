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
            this.btnActivación = new System.Windows.Forms.Button();
            this.panelButton.SuspendLayout();
            this.panelPrincipal.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelButton
            // 
            this.panelButton.Controls.Add(this.btnActivación);
            this.panelButton.Location = new System.Drawing.Point(0, 238);
            this.panelButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panelButton.Padding = new System.Windows.Forms.Padding(3, 3, 3, 3);
            this.panelButton.Size = new System.Drawing.Size(695, 61);
            this.panelButton.Controls.SetChildIndex(this.btnCancelar, 0);
            this.panelButton.Controls.SetChildIndex(this.btnAceptar, 0);
            this.panelButton.Controls.SetChildIndex(this.btnActivación, 0);
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(482, 3);
            this.btnAceptar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnAceptar.Padding = new System.Windows.Forms.Padding(3, 3, 3, 3);
            this.btnAceptar.Size = new System.Drawing.Size(105, 55);
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(587, 3);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnCancelar.Padding = new System.Windows.Forms.Padding(3, 3, 3, 3);
            this.btnCancelar.Size = new System.Drawing.Size(105, 55);
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
            this.panelPrincipal.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panelPrincipal.Size = new System.Drawing.Size(695, 299);
            // 
            // btnSearchCp
            // 
            this.btnSearchCp.BackgroundImage = global::redTaller.Properties.Resources.buscar;
            this.btnSearchCp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSearchCp.FlatAppearance.BorderSize = 0;
            this.btnSearchCp.Location = new System.Drawing.Point(168, 86);
            this.btnSearchCp.Name = "btnSearchCp";
            this.btnSearchCp.Size = new System.Drawing.Size(23, 20);
            this.btnSearchCp.TabIndex = 54;
            this.btnSearchCp.TabStop = false;
            this.btnSearchCp.UseVisualStyleBackColor = true;
            this.btnSearchCp.Click += new System.EventHandler(this.btnSearchCp_Click);
            // 
            // textMovil
            // 
            this.textMovil.Location = new System.Drawing.Point(381, 134);
            this.textMovil.Mask = "000 00 00 00";
            this.textMovil.Name = "textMovil";
            this.textMovil.Size = new System.Drawing.Size(129, 20);
            this.textMovil.TabIndex = 43;
            // 
            // textTelefono
            // 
            this.textTelefono.Location = new System.Drawing.Point(89, 134);
            this.textTelefono.Mask = "000 00 00 00";
            this.textTelefono.Name = "textTelefono";
            this.textTelefono.Size = new System.Drawing.Size(129, 20);
            this.textTelefono.TabIndex = 42;
            // 
            // checkBloqueado
            // 
            this.checkBloqueado.AutoSize = true;
            this.checkBloqueado.Location = new System.Drawing.Point(605, 43);
            this.checkBloqueado.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.checkBloqueado.Name = "checkBloqueado";
            this.checkBloqueado.Size = new System.Drawing.Size(77, 17);
            this.checkBloqueado.TabIndex = 53;
            this.checkBloqueado.Text = "Bloqueado";
            this.checkBloqueado.UseVisualStyleBackColor = true;
            // 
            // checkActivo
            // 
            this.checkActivo.AutoSize = true;
            this.checkActivo.Location = new System.Drawing.Point(605, 20);
            this.checkActivo.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.checkActivo.Name = "checkActivo";
            this.checkActivo.Size = new System.Drawing.Size(56, 17);
            this.checkActivo.TabIndex = 52;
            this.checkActivo.Text = "Activo";
            this.checkActivo.UseVisualStyleBackColor = true;
            // 
            // textEmail
            // 
            this.textEmail.Location = new System.Drawing.Point(89, 158);
            this.textEmail.MaxLength = 100;
            this.textEmail.Name = "textEmail";
            this.textEmail.Size = new System.Drawing.Size(339, 20);
            this.textEmail.TabIndex = 44;
            // 
            // labelEmail
            // 
            this.labelEmail.AutoSize = true;
            this.labelEmail.Location = new System.Drawing.Point(21, 160);
            this.labelEmail.Name = "labelEmail";
            this.labelEmail.Size = new System.Drawing.Size(35, 13);
            this.labelEmail.TabIndex = 51;
            this.labelEmail.Text = "eMail:";
            // 
            // labelMovil
            // 
            this.labelMovil.AutoSize = true;
            this.labelMovil.Location = new System.Drawing.Point(313, 136);
            this.labelMovil.Name = "labelMovil";
            this.labelMovil.Size = new System.Drawing.Size(35, 13);
            this.labelMovil.TabIndex = 50;
            this.labelMovil.Text = "Móvil:";
            // 
            // labTelefono
            // 
            this.labTelefono.AutoSize = true;
            this.labTelefono.Location = new System.Drawing.Point(21, 136);
            this.labTelefono.Name = "labTelefono";
            this.labTelefono.Size = new System.Drawing.Size(52, 13);
            this.labTelefono.TabIndex = 35;
            this.labTelefono.Text = "Teléfono:";
            // 
            // textProvincia
            // 
            this.textProvincia.Location = new System.Drawing.Point(89, 110);
            this.textProvincia.MaxLength = 80;
            this.textProvincia.Name = "textProvincia";
            this.textProvincia.Size = new System.Drawing.Size(421, 20);
            this.textProvincia.TabIndex = 41;
            // 
            // labProvincia
            // 
            this.labProvincia.AutoSize = true;
            this.labProvincia.Location = new System.Drawing.Point(21, 112);
            this.labProvincia.Name = "labProvincia";
            this.labProvincia.Size = new System.Drawing.Size(54, 13);
            this.labProvincia.TabIndex = 49;
            this.labProvincia.Text = "Provincia:";
            // 
            // textPoblacion
            // 
            this.textPoblacion.Location = new System.Drawing.Point(201, 88);
            this.textPoblacion.MaxLength = 80;
            this.textPoblacion.Name = "textPoblacion";
            this.textPoblacion.Size = new System.Drawing.Size(311, 20);
            this.textPoblacion.TabIndex = 40;
            // 
            // textCp
            // 
            this.textCp.Location = new System.Drawing.Point(89, 86);
            this.textCp.MaxLength = 7;
            this.textCp.Name = "textCp";
            this.textCp.Size = new System.Drawing.Size(75, 20);
            this.textCp.TabIndex = 39;
            this.textCp.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textCp_KeyDown);
            this.textCp.Validating += new System.ComponentModel.CancelEventHandler(this.textCp_Validating);
            // 
            // labPoblacion
            // 
            this.labPoblacion.AutoSize = true;
            this.labPoblacion.Location = new System.Drawing.Point(21, 90);
            this.labPoblacion.Name = "labPoblacion";
            this.labPoblacion.Size = new System.Drawing.Size(57, 13);
            this.labPoblacion.TabIndex = 48;
            this.labPoblacion.Text = "Población:";
            // 
            // textDomicilio
            // 
            this.textDomicilio.Location = new System.Drawing.Point(89, 64);
            this.textDomicilio.MaxLength = 150;
            this.textDomicilio.Name = "textDomicilio";
            this.textDomicilio.Size = new System.Drawing.Size(421, 20);
            this.textDomicilio.TabIndex = 38;
            // 
            // labDomicilio
            // 
            this.labDomicilio.AutoSize = true;
            this.labDomicilio.Location = new System.Drawing.Point(21, 67);
            this.labDomicilio.Name = "labDomicilio";
            this.labDomicilio.Size = new System.Drawing.Size(52, 13);
            this.labDomicilio.TabIndex = 47;
            this.labDomicilio.Text = "Domicilio:";
            // 
            // textNombre
            // 
            this.textNombre.Location = new System.Drawing.Point(89, 41);
            this.textNombre.MaxLength = 150;
            this.textNombre.Name = "textNombre";
            this.textNombre.Size = new System.Drawing.Size(421, 20);
            this.textNombre.TabIndex = 37;
            // 
            // labelNombre
            // 
            this.labelNombre.AutoSize = true;
            this.labelNombre.Location = new System.Drawing.Point(21, 43);
            this.labelNombre.Name = "labelNombre";
            this.labelNombre.Size = new System.Drawing.Size(47, 13);
            this.labelNombre.TabIndex = 46;
            this.labelNombre.Text = "Nombre:";
            // 
            // textNif
            // 
            this.textNif.Location = new System.Drawing.Point(89, 17);
            this.textNif.MaxLength = 15;
            this.textNif.Name = "textNif";
            this.textNif.Size = new System.Drawing.Size(129, 20);
            this.textNif.TabIndex = 36;
            this.textNif.Validating += new System.ComponentModel.CancelEventHandler(this.textNif_Validating);
            // 
            // labNif
            // 
            this.labNif.AutoSize = true;
            this.labNif.Location = new System.Drawing.Point(21, 20);
            this.labNif.Name = "labNif";
            this.labNif.Size = new System.Drawing.Size(36, 13);
            this.labNif.TabIndex = 45;
            this.labNif.Text = "N.I.F.:";
            // 
            // btnActivación
            // 
            this.btnActivación.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnActivación.Image = global::redTaller.Properties.Resources.email;
            this.btnActivación.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnActivación.Location = new System.Drawing.Point(3, 3);
            this.btnActivación.Margin = new System.Windows.Forms.Padding(2);
            this.btnActivación.Name = "btnActivación";
            this.btnActivación.Size = new System.Drawing.Size(143, 55);
            this.btnActivación.TabIndex = 36;
            this.btnActivación.Text = "Activación...";
            this.btnActivación.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnActivación.UseVisualStyleBackColor = true;
            this.btnActivación.Click += new System.EventHandler(this.btnActivación_Click);
            // 
            // VistaFormCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(695, 299);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
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
        private System.Windows.Forms.Button btnActivación;
    }
}
