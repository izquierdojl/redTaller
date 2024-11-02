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
            this.components = new System.ComponentModel.Container();
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
            this.textMovil = new System.Windows.Forms.MaskedTextBox();
            this.btnSearchCp = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.btnActivación = new System.Windows.Forms.Button();
            this.panelButton.SuspendLayout();
            this.panelPrincipal.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelButton
            // 
            this.panelButton.Controls.Add(this.btnActivación);
            this.panelButton.Location = new System.Drawing.Point(0, 304);
            this.panelButton.Margin = new System.Windows.Forms.Padding(3);
            this.panelButton.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panelButton.Size = new System.Drawing.Size(1150, 94);
            this.panelButton.Controls.SetChildIndex(this.btnCancelar, 0);
            this.panelButton.Controls.SetChildIndex(this.btnAceptar, 0);
            this.panelButton.Controls.SetChildIndex(this.btnActivación, 0);
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(830, 5);
            this.btnAceptar.Margin = new System.Windows.Forms.Padding(3);
            this.btnAceptar.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnAceptar.Size = new System.Drawing.Size(158, 84);
            this.btnAceptar.TabIndex = 0;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(988, 5);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(3);
            this.btnCancelar.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnCancelar.Size = new System.Drawing.Size(158, 84);
            this.btnCancelar.TabIndex = 1;
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
            this.panelPrincipal.Margin = new System.Windows.Forms.Padding(3);
            this.panelPrincipal.Size = new System.Drawing.Size(1150, 398);
            // 
            // textNombre
            // 
            this.textNombre.Location = new System.Drawing.Point(136, 65);
            this.textNombre.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textNombre.MaxLength = 150;
            this.textNombre.Name = "textNombre";
            this.textNombre.Size = new System.Drawing.Size(630, 26);
            this.textNombre.TabIndex = 2;
            // 
            // labelNombre
            // 
            this.labelNombre.AutoSize = true;
            this.labelNombre.Location = new System.Drawing.Point(34, 68);
            this.labelNombre.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelNombre.Name = "labelNombre";
            this.labelNombre.Size = new System.Drawing.Size(69, 20);
            this.labelNombre.TabIndex = 18;
            this.labelNombre.Text = "Nombre:";
            // 
            // textNif
            // 
            this.textNif.Location = new System.Drawing.Point(136, 28);
            this.textNif.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textNif.MaxLength = 15;
            this.textNif.Name = "textNif";
            this.textNif.Size = new System.Drawing.Size(192, 26);
            this.textNif.TabIndex = 1;
            this.textNif.Validating += new System.ComponentModel.CancelEventHandler(this.textNif_Validating);
            // 
            // labNif
            // 
            this.labNif.AutoSize = true;
            this.labNif.Location = new System.Drawing.Point(34, 32);
            this.labNif.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labNif.Name = "labNif";
            this.labNif.Size = new System.Drawing.Size(51, 20);
            this.labNif.TabIndex = 17;
            this.labNif.Text = "N.I.F.:";
            // 
            // textDomicilio
            // 
            this.textDomicilio.Location = new System.Drawing.Point(136, 100);
            this.textDomicilio.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textDomicilio.MaxLength = 150;
            this.textDomicilio.Name = "textDomicilio";
            this.textDomicilio.Size = new System.Drawing.Size(630, 26);
            this.textDomicilio.TabIndex = 3;
            // 
            // labDomicilio
            // 
            this.labDomicilio.AutoSize = true;
            this.labDomicilio.Location = new System.Drawing.Point(34, 105);
            this.labDomicilio.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labDomicilio.Name = "labDomicilio";
            this.labDomicilio.Size = new System.Drawing.Size(76, 20);
            this.labDomicilio.TabIndex = 20;
            this.labDomicilio.Text = "Domicilio:";
            // 
            // textCp
            // 
            this.textCp.Location = new System.Drawing.Point(136, 135);
            this.textCp.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textCp.MaxLength = 7;
            this.textCp.Name = "textCp";
            this.textCp.Size = new System.Drawing.Size(110, 26);
            this.textCp.TabIndex = 4;
            this.textCp.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textCp_KeyDown);
            this.textCp.Validating += new System.ComponentModel.CancelEventHandler(this.textCp_Validating);
            // 
            // labPoblacion
            // 
            this.labPoblacion.AutoSize = true;
            this.labPoblacion.Location = new System.Drawing.Point(34, 140);
            this.labPoblacion.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labPoblacion.Name = "labPoblacion";
            this.labPoblacion.Size = new System.Drawing.Size(82, 20);
            this.labPoblacion.TabIndex = 22;
            this.labPoblacion.Text = "Población:";
            // 
            // textPoblacion
            // 
            this.textPoblacion.Location = new System.Drawing.Point(303, 137);
            this.textPoblacion.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textPoblacion.MaxLength = 80;
            this.textPoblacion.Name = "textPoblacion";
            this.textPoblacion.Size = new System.Drawing.Size(464, 26);
            this.textPoblacion.TabIndex = 5;
            // 
            // textProvincia
            // 
            this.textProvincia.Location = new System.Drawing.Point(136, 172);
            this.textProvincia.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textProvincia.MaxLength = 80;
            this.textProvincia.Name = "textProvincia";
            this.textProvincia.Size = new System.Drawing.Size(630, 26);
            this.textProvincia.TabIndex = 6;
            // 
            // labProvincia
            // 
            this.labProvincia.AutoSize = true;
            this.labProvincia.Location = new System.Drawing.Point(34, 175);
            this.labProvincia.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labProvincia.Name = "labProvincia";
            this.labProvincia.Size = new System.Drawing.Size(76, 20);
            this.labProvincia.TabIndex = 25;
            this.labProvincia.Text = "Provincia:";
            // 
            // labTelefono
            // 
            this.labTelefono.AutoSize = true;
            this.labTelefono.Location = new System.Drawing.Point(34, 212);
            this.labTelefono.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labTelefono.Name = "labTelefono";
            this.labTelefono.Size = new System.Drawing.Size(75, 20);
            this.labTelefono.TabIndex = 0;
            this.labTelefono.Text = "Teléfono:";
            // 
            // labelMovil
            // 
            this.labelMovil.AutoSize = true;
            this.labelMovil.Location = new System.Drawing.Point(472, 212);
            this.labelMovil.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelMovil.Name = "labelMovil";
            this.labelMovil.Size = new System.Drawing.Size(48, 20);
            this.labelMovil.TabIndex = 29;
            this.labelMovil.Text = "Móvil:";
            // 
            // textEmail
            // 
            this.textEmail.Location = new System.Drawing.Point(136, 245);
            this.textEmail.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textEmail.MaxLength = 100;
            this.textEmail.Name = "textEmail";
            this.textEmail.Size = new System.Drawing.Size(506, 26);
            this.textEmail.TabIndex = 9;
            // 
            // labelEmail
            // 
            this.labelEmail.AutoSize = true;
            this.labelEmail.Location = new System.Drawing.Point(34, 248);
            this.labelEmail.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelEmail.Name = "labelEmail";
            this.labelEmail.Size = new System.Drawing.Size(50, 20);
            this.labelEmail.TabIndex = 31;
            this.labelEmail.Text = "eMail:";
            // 
            // checkActivo
            // 
            this.checkActivo.AutoSize = true;
            this.checkActivo.Location = new System.Drawing.Point(910, 32);
            this.checkActivo.Name = "checkActivo";
            this.checkActivo.Size = new System.Drawing.Size(71, 24);
            this.checkActivo.TabIndex = 32;
            this.checkActivo.Text = "Activo";
            this.checkActivo.UseVisualStyleBackColor = true;
            // 
            // checkBloqueado
            // 
            this.checkBloqueado.AutoSize = true;
            this.checkBloqueado.Location = new System.Drawing.Point(910, 68);
            this.checkBloqueado.Name = "checkBloqueado";
            this.checkBloqueado.Size = new System.Drawing.Size(105, 24);
            this.checkBloqueado.TabIndex = 33;
            this.checkBloqueado.Text = "Bloqueado";
            this.checkBloqueado.UseVisualStyleBackColor = true;
            // 
            // textTelefono
            // 
            this.textTelefono.Location = new System.Drawing.Point(136, 208);
            this.textTelefono.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textTelefono.Mask = "000 00 00 00";
            this.textTelefono.Name = "textTelefono";
            this.textTelefono.Size = new System.Drawing.Size(192, 26);
            this.textTelefono.TabIndex = 7;
            // 
            // textMovil
            // 
            this.textMovil.Location = new System.Drawing.Point(574, 208);
            this.textMovil.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textMovil.Mask = "000 00 00 00";
            this.textMovil.Name = "textMovil";
            this.textMovil.Size = new System.Drawing.Size(192, 26);
            this.textMovil.TabIndex = 8;
            // 
            // btnSearchCp
            // 
            this.btnSearchCp.BackgroundImage = global::redTaller.Properties.Resources.buscar;
            this.btnSearchCp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSearchCp.FlatAppearance.BorderSize = 0;
            this.btnSearchCp.Location = new System.Drawing.Point(254, 134);
            this.btnSearchCp.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnSearchCp.Name = "btnSearchCp";
            this.btnSearchCp.Size = new System.Drawing.Size(34, 31);
            this.btnSearchCp.TabIndex = 34;
            this.btnSearchCp.TabStop = false;
            this.toolTip1.SetToolTip(this.btnSearchCp, "Buscar (Ctrl+B)");
            this.btnSearchCp.UseVisualStyleBackColor = true;
            this.btnSearchCp.Click += new System.EventHandler(this.btnSearchCp_Click);
            // 
            // btnActivación
            // 
            this.btnActivación.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnActivación.Image = global::redTaller.Properties.Resources.email;
            this.btnActivación.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnActivación.Location = new System.Drawing.Point(4, 5);
            this.btnActivación.Name = "btnActivación";
            this.btnActivación.Size = new System.Drawing.Size(214, 84);
            this.btnActivación.TabIndex = 35;
            this.btnActivación.Text = "Activación...";
            this.btnActivación.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.toolTip1.SetToolTip(this.btnActivación, "Envía al taller un correo electrónico para activar su cuenta");
            this.btnActivación.UseVisualStyleBackColor = true;
            this.btnActivación.Click += new System.EventHandler(this.btnActivación_Click);
            // 
            // VistaFormTaller
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.ClientSize = new System.Drawing.Size(1150, 398);
            this.Margin = new System.Windows.Forms.Padding(3);
            this.Name = "VistaFormTaller";
            this.panelButton.ResumeLayout(false);
            this.panelPrincipal.ResumeLayout(false);
            this.panelPrincipal.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label labPoblacion;
        private System.Windows.Forms.TextBox textDomicilio;
        private System.Windows.Forms.Label labDomicilio;
        private System.Windows.Forms.TextBox textNombre;
        private System.Windows.Forms.Label labelNombre;
        private System.Windows.Forms.TextBox textNif;
        private System.Windows.Forms.Label labNif;
        private System.Windows.Forms.Label labelMovil;
        private System.Windows.Forms.Label labTelefono;
        private System.Windows.Forms.Label labProvincia;
        private System.Windows.Forms.TextBox textEmail;
        private System.Windows.Forms.Label labelEmail;
        private System.Windows.Forms.CheckBox checkBloqueado;
        private System.Windows.Forms.CheckBox checkActivo;
        private System.Windows.Forms.MaskedTextBox textTelefono;
        private System.Windows.Forms.MaskedTextBox textMovil;
        public System.Windows.Forms.TextBox textCp;
        public System.Windows.Forms.TextBox textProvincia;
        public System.Windows.Forms.TextBox textPoblacion;
        private System.Windows.Forms.Button btnSearchCp;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Button btnActivación;
    }
}
