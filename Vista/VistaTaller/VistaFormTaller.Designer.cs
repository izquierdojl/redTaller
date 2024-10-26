namespace redTaller.Vista.VistaTaller
{
    partial class VistaFormTaller
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
            this.textNombre = new System.Windows.Forms.TextBox();
            this.labelNombre = new System.Windows.Forms.Label();
            this.textNif = new System.Windows.Forms.TextBox();
            this.labNif = new System.Windows.Forms.Label();
            this.textDomicilio = new System.Windows.Forms.TextBox();
            this.labDomicilio = new System.Windows.Forms.Label();
            this.textCp = new System.Windows.Forms.TextBox();
            this.labPoblacion = new System.Windows.Forms.Label();
            this.textPoblacion = new System.Windows.Forms.TextBox();
            this.textProvincia = new System.Windows.Forms.TextBox();
            this.labProvincia = new System.Windows.Forms.Label();
            this.labTelefono = new System.Windows.Forms.Label();
            this.labelMovil = new System.Windows.Forms.Label();
            this.textEmail = new System.Windows.Forms.TextBox();
            this.labelEmail = new System.Windows.Forms.Label();
            this.checkActivo = new System.Windows.Forms.CheckBox();
            this.checkBloqueado = new System.Windows.Forms.CheckBox();
            this.textTelefono = new System.Windows.Forms.MaskedTextBox();
            this.TextMovil = new System.Windows.Forms.MaskedTextBox();
            this.panelButton.SuspendLayout();
            this.panelPrincipal.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelButton
            // 
            this.panelButton.Location = new System.Drawing.Point(0, 198);
            this.panelButton.Margin = new System.Windows.Forms.Padding(2);
            this.panelButton.Padding = new System.Windows.Forms.Padding(3);
            this.panelButton.Size = new System.Drawing.Size(767, 61);
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(554, 3);
            this.btnAceptar.Margin = new System.Windows.Forms.Padding(2);
            this.btnAceptar.Padding = new System.Windows.Forms.Padding(3);
            this.btnAceptar.Size = new System.Drawing.Size(105, 55);
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(659, 3);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(2);
            this.btnCancelar.Padding = new System.Windows.Forms.Padding(3);
            this.btnCancelar.Size = new System.Drawing.Size(105, 55);
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // panelPrincipal
            // 
            this.panelPrincipal.Controls.Add(this.TextMovil);
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
            this.panelPrincipal.Margin = new System.Windows.Forms.Padding(2);
            this.panelPrincipal.Size = new System.Drawing.Size(767, 259);
            // 
            // textNombre
            // 
            this.textNombre.Location = new System.Drawing.Point(91, 42);
            this.textNombre.MaxLength = 150;
            this.textNombre.Name = "textNombre";
            this.textNombre.Size = new System.Drawing.Size(421, 20);
            this.textNombre.TabIndex = 16;
            // 
            // labelNombre
            // 
            this.labelNombre.AutoSize = true;
            this.labelNombre.Location = new System.Drawing.Point(23, 44);
            this.labelNombre.Name = "labelNombre";
            this.labelNombre.Size = new System.Drawing.Size(47, 13);
            this.labelNombre.TabIndex = 18;
            this.labelNombre.Text = "Nombre:";
            // 
            // textNif
            // 
            this.textNif.Location = new System.Drawing.Point(91, 18);
            this.textNif.MaxLength = 15;
            this.textNif.Name = "textNif";
            this.textNif.Size = new System.Drawing.Size(129, 20);
            this.textNif.TabIndex = 15;
            this.textNif.Validating += new System.ComponentModel.CancelEventHandler(this.textNif_Validating);
            // 
            // labNif
            // 
            this.labNif.AutoSize = true;
            this.labNif.Location = new System.Drawing.Point(23, 21);
            this.labNif.Name = "labNif";
            this.labNif.Size = new System.Drawing.Size(36, 13);
            this.labNif.TabIndex = 17;
            this.labNif.Text = "N.I.F.:";
            // 
            // textDomicilio
            // 
            this.textDomicilio.Location = new System.Drawing.Point(91, 65);
            this.textDomicilio.MaxLength = 150;
            this.textDomicilio.Name = "textDomicilio";
            this.textDomicilio.Size = new System.Drawing.Size(421, 20);
            this.textDomicilio.TabIndex = 19;
            // 
            // labDomicilio
            // 
            this.labDomicilio.AutoSize = true;
            this.labDomicilio.Location = new System.Drawing.Point(23, 68);
            this.labDomicilio.Name = "labDomicilio";
            this.labDomicilio.Size = new System.Drawing.Size(52, 13);
            this.labDomicilio.TabIndex = 20;
            this.labDomicilio.Text = "Domicilio:";
            // 
            // textCp
            // 
            this.textCp.Location = new System.Drawing.Point(91, 88);
            this.textCp.MaxLength = 7;
            this.textCp.Name = "textCp";
            this.textCp.Size = new System.Drawing.Size(75, 20);
            this.textCp.TabIndex = 21;
            // 
            // labPoblacion
            // 
            this.labPoblacion.AutoSize = true;
            this.labPoblacion.Location = new System.Drawing.Point(23, 91);
            this.labPoblacion.Name = "labPoblacion";
            this.labPoblacion.Size = new System.Drawing.Size(57, 13);
            this.labPoblacion.TabIndex = 22;
            this.labPoblacion.Text = "Población:";
            // 
            // textPoblacion
            // 
            this.textPoblacion.Location = new System.Drawing.Point(170, 89);
            this.textPoblacion.MaxLength = 80;
            this.textPoblacion.Name = "textPoblacion";
            this.textPoblacion.Size = new System.Drawing.Size(343, 20);
            this.textPoblacion.TabIndex = 23;
            // 
            // textProvincia
            // 
            this.textProvincia.Location = new System.Drawing.Point(91, 112);
            this.textProvincia.MaxLength = 80;
            this.textProvincia.Name = "textProvincia";
            this.textProvincia.Size = new System.Drawing.Size(421, 20);
            this.textProvincia.TabIndex = 24;
            // 
            // labProvincia
            // 
            this.labProvincia.AutoSize = true;
            this.labProvincia.Location = new System.Drawing.Point(23, 114);
            this.labProvincia.Name = "labProvincia";
            this.labProvincia.Size = new System.Drawing.Size(54, 13);
            this.labProvincia.TabIndex = 25;
            this.labProvincia.Text = "Provincia:";
            // 
            // labTelefono
            // 
            this.labTelefono.AutoSize = true;
            this.labTelefono.Location = new System.Drawing.Point(23, 138);
            this.labTelefono.Name = "labTelefono";
            this.labTelefono.Size = new System.Drawing.Size(52, 13);
            this.labTelefono.TabIndex = 27;
            this.labTelefono.Text = "Teléfono:";
            // 
            // labelMovil
            // 
            this.labelMovil.AutoSize = true;
            this.labelMovil.Location = new System.Drawing.Point(233, 138);
            this.labelMovil.Name = "labelMovil";
            this.labelMovil.Size = new System.Drawing.Size(35, 13);
            this.labelMovil.TabIndex = 29;
            this.labelMovil.Text = "Móvil:";
            // 
            // textEmail
            // 
            this.textEmail.Location = new System.Drawing.Point(91, 159);
            this.textEmail.MaxLength = 100;
            this.textEmail.Name = "textEmail";
            this.textEmail.Size = new System.Drawing.Size(339, 20);
            this.textEmail.TabIndex = 30;
            // 
            // labelEmail
            // 
            this.labelEmail.AutoSize = true;
            this.labelEmail.Location = new System.Drawing.Point(23, 161);
            this.labelEmail.Name = "labelEmail";
            this.labelEmail.Size = new System.Drawing.Size(35, 13);
            this.labelEmail.TabIndex = 31;
            this.labelEmail.Text = "eMail:";
            // 
            // checkActivo
            // 
            this.checkActivo.AutoSize = true;
            this.checkActivo.Location = new System.Drawing.Point(607, 21);
            this.checkActivo.Margin = new System.Windows.Forms.Padding(2);
            this.checkActivo.Name = "checkActivo";
            this.checkActivo.Size = new System.Drawing.Size(56, 17);
            this.checkActivo.TabIndex = 32;
            this.checkActivo.Text = "Activo";
            this.checkActivo.UseVisualStyleBackColor = true;
            // 
            // checkBloqueado
            // 
            this.checkBloqueado.AutoSize = true;
            this.checkBloqueado.Location = new System.Drawing.Point(607, 44);
            this.checkBloqueado.Margin = new System.Windows.Forms.Padding(2);
            this.checkBloqueado.Name = "checkBloqueado";
            this.checkBloqueado.Size = new System.Drawing.Size(77, 17);
            this.checkBloqueado.TabIndex = 33;
            this.checkBloqueado.Text = "Bloqueado";
            this.checkBloqueado.UseVisualStyleBackColor = true;
            // 
            // textTelefono
            // 
            this.textTelefono.Location = new System.Drawing.Point(91, 135);
            this.textTelefono.Mask = "000 00 00 00";
            this.textTelefono.Name = "textTelefono";
            this.textTelefono.Size = new System.Drawing.Size(129, 20);
            this.textTelefono.TabIndex = 34;
            // 
            // TextMovil
            // 
            this.TextMovil.Location = new System.Drawing.Point(301, 135);
            this.TextMovil.Mask = "000 00 00 00";
            this.TextMovil.Name = "TextMovil";
            this.TextMovil.Size = new System.Drawing.Size(129, 20);
            this.TextMovil.TabIndex = 35;
            // 
            // VistaFormTaller
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(767, 259);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "VistaFormTaller";
            this.panelButton.ResumeLayout(false);
            this.panelPrincipal.ResumeLayout(false);
            this.panelPrincipal.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox textCp;
        private System.Windows.Forms.Label labPoblacion;
        private System.Windows.Forms.TextBox textDomicilio;
        private System.Windows.Forms.Label labDomicilio;
        private System.Windows.Forms.TextBox textNombre;
        private System.Windows.Forms.Label labelNombre;
        private System.Windows.Forms.TextBox textNif;
        private System.Windows.Forms.Label labNif;
        private System.Windows.Forms.Label labelMovil;
        private System.Windows.Forms.Label labTelefono;
        private System.Windows.Forms.TextBox textProvincia;
        private System.Windows.Forms.Label labProvincia;
        private System.Windows.Forms.TextBox textPoblacion;
        private System.Windows.Forms.TextBox textEmail;
        private System.Windows.Forms.Label labelEmail;
        private System.Windows.Forms.CheckBox checkBloqueado;
        private System.Windows.Forms.CheckBox checkActivo;
        private System.Windows.Forms.MaskedTextBox textTelefono;
        private System.Windows.Forms.MaskedTextBox TextMovil;
    }
}
