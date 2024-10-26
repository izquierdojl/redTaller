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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.labDomicilio = new System.Windows.Forms.Label();
            this.textCp = new System.Windows.Forms.TextBox();
            this.labPoblacion = new System.Windows.Forms.Label();
            this.textPob = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.labProvincia = new System.Windows.Forms.Label();
            this.textTeléfono = new System.Windows.Forms.TextBox();
            this.labTelefono = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.labelMovil = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.labelEmail = new System.Windows.Forms.Label();
            this.checkActivo = new System.Windows.Forms.CheckBox();
            this.checkBloqueado = new System.Windows.Forms.CheckBox();
            this.panelButton.SuspendLayout();
            this.panelPrincipal.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelButton
            // 
            this.panelButton.Location = new System.Drawing.Point(0, 305);
            this.panelButton.Size = new System.Drawing.Size(1150, 94);
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(826, 8);
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(984, 8);
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // panelPrincipal
            // 
            this.panelPrincipal.Controls.Add(this.checkBloqueado);
            this.panelPrincipal.Controls.Add(this.checkActivo);
            this.panelPrincipal.Controls.Add(this.textBox4);
            this.panelPrincipal.Controls.Add(this.labelEmail);
            this.panelPrincipal.Controls.Add(this.textBox3);
            this.panelPrincipal.Controls.Add(this.labelMovil);
            this.panelPrincipal.Controls.Add(this.textTeléfono);
            this.panelPrincipal.Controls.Add(this.labTelefono);
            this.panelPrincipal.Controls.Add(this.textBox2);
            this.panelPrincipal.Controls.Add(this.labProvincia);
            this.panelPrincipal.Controls.Add(this.textPob);
            this.panelPrincipal.Controls.Add(this.textCp);
            this.panelPrincipal.Controls.Add(this.labPoblacion);
            this.panelPrincipal.Controls.Add(this.textBox1);
            this.panelPrincipal.Controls.Add(this.labDomicilio);
            this.panelPrincipal.Controls.Add(this.textNombre);
            this.panelPrincipal.Controls.Add(this.labelNombre);
            this.panelPrincipal.Controls.Add(this.textNif);
            this.panelPrincipal.Controls.Add(this.labNif);
            this.panelPrincipal.Size = new System.Drawing.Size(1150, 399);
            // 
            // textNombre
            // 
            this.textNombre.Location = new System.Drawing.Point(137, 64);
            this.textNombre.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textNombre.MaxLength = 80;
            this.textNombre.Name = "textNombre";
            this.textNombre.Size = new System.Drawing.Size(630, 26);
            this.textNombre.TabIndex = 16;
            // 
            // labelNombre
            // 
            this.labelNombre.AutoSize = true;
            this.labelNombre.Location = new System.Drawing.Point(35, 68);
            this.labelNombre.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelNombre.Name = "labelNombre";
            this.labelNombre.Size = new System.Drawing.Size(69, 20);
            this.labelNombre.TabIndex = 18;
            this.labelNombre.Text = "Nombre:";
            // 
            // textNif
            // 
            this.textNif.Location = new System.Drawing.Point(137, 28);
            this.textNif.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textNif.MaxLength = 2;
            this.textNif.Name = "textNif";
            this.textNif.Size = new System.Drawing.Size(192, 26);
            this.textNif.TabIndex = 15;
            // 
            // labNif
            // 
            this.labNif.AutoSize = true;
            this.labNif.Location = new System.Drawing.Point(35, 32);
            this.labNif.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labNif.Name = "labNif";
            this.labNif.Size = new System.Drawing.Size(51, 20);
            this.labNif.TabIndex = 17;
            this.labNif.Text = "N.I.F.:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(137, 100);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBox1.MaxLength = 80;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(630, 26);
            this.textBox1.TabIndex = 19;
            // 
            // labDomicilio
            // 
            this.labDomicilio.AutoSize = true;
            this.labDomicilio.Location = new System.Drawing.Point(35, 104);
            this.labDomicilio.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labDomicilio.Name = "labDomicilio";
            this.labDomicilio.Size = new System.Drawing.Size(76, 20);
            this.labDomicilio.TabIndex = 20;
            this.labDomicilio.Text = "Domicilio:";
            // 
            // textCp
            // 
            this.textCp.Location = new System.Drawing.Point(137, 136);
            this.textCp.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textCp.MaxLength = 80;
            this.textCp.Name = "textCp";
            this.textCp.Size = new System.Drawing.Size(110, 26);
            this.textCp.TabIndex = 21;
            // 
            // labPoblacion
            // 
            this.labPoblacion.AutoSize = true;
            this.labPoblacion.Location = new System.Drawing.Point(35, 140);
            this.labPoblacion.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labPoblacion.Name = "labPoblacion";
            this.labPoblacion.Size = new System.Drawing.Size(82, 20);
            this.labPoblacion.TabIndex = 22;
            this.labPoblacion.Text = "Población:";
            // 
            // textPob
            // 
            this.textPob.Location = new System.Drawing.Point(255, 137);
            this.textPob.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textPob.MaxLength = 80;
            this.textPob.Name = "textPob";
            this.textPob.Size = new System.Drawing.Size(512, 26);
            this.textPob.TabIndex = 23;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(137, 172);
            this.textBox2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBox2.MaxLength = 80;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(630, 26);
            this.textBox2.TabIndex = 24;
            // 
            // labProvincia
            // 
            this.labProvincia.AutoSize = true;
            this.labProvincia.Location = new System.Drawing.Point(35, 176);
            this.labProvincia.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labProvincia.Name = "labProvincia";
            this.labProvincia.Size = new System.Drawing.Size(76, 20);
            this.labProvincia.TabIndex = 25;
            this.labProvincia.Text = "Provincia:";
            // 
            // textTeléfono
            // 
            this.textTeléfono.Location = new System.Drawing.Point(137, 208);
            this.textTeléfono.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textTeléfono.MaxLength = 80;
            this.textTeléfono.Name = "textTeléfono";
            this.textTeléfono.Size = new System.Drawing.Size(192, 26);
            this.textTeléfono.TabIndex = 26;
            // 
            // labTelefono
            // 
            this.labTelefono.AutoSize = true;
            this.labTelefono.Location = new System.Drawing.Point(35, 212);
            this.labTelefono.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labTelefono.Name = "labTelefono";
            this.labTelefono.Size = new System.Drawing.Size(75, 20);
            this.labTelefono.TabIndex = 27;
            this.labTelefono.Text = "Teléfono:";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(451, 208);
            this.textBox3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBox3.MaxLength = 80;
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(192, 26);
            this.textBox3.TabIndex = 28;
            // 
            // labelMovil
            // 
            this.labelMovil.AutoSize = true;
            this.labelMovil.Location = new System.Drawing.Point(349, 212);
            this.labelMovil.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelMovil.Name = "labelMovil";
            this.labelMovil.Size = new System.Drawing.Size(48, 20);
            this.labelMovil.TabIndex = 29;
            this.labelMovil.Text = "Móvil:";
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(137, 244);
            this.textBox4.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBox4.MaxLength = 80;
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(506, 26);
            this.textBox4.TabIndex = 30;
            // 
            // labelEmail
            // 
            this.labelEmail.AutoSize = true;
            this.labelEmail.Location = new System.Drawing.Point(35, 248);
            this.labelEmail.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelEmail.Name = "labelEmail";
            this.labelEmail.Size = new System.Drawing.Size(50, 20);
            this.labelEmail.TabIndex = 31;
            this.labelEmail.Text = "eMail:";
            // 
            // checkActivo
            // 
            this.checkActivo.AutoSize = true;
            this.checkActivo.Location = new System.Drawing.Point(911, 32);
            this.checkActivo.Name = "checkActivo";
            this.checkActivo.Size = new System.Drawing.Size(71, 24);
            this.checkActivo.TabIndex = 32;
            this.checkActivo.Text = "Activo";
            this.checkActivo.UseVisualStyleBackColor = true;
            // 
            // checkBloqueado
            // 
            this.checkBloqueado.AutoSize = true;
            this.checkBloqueado.Location = new System.Drawing.Point(911, 68);
            this.checkBloqueado.Name = "checkBloqueado";
            this.checkBloqueado.Size = new System.Drawing.Size(105, 24);
            this.checkBloqueado.TabIndex = 33;
            this.checkBloqueado.Text = "Bloqueado";
            this.checkBloqueado.UseVisualStyleBackColor = true;
            // 
            // VistaFormTaller
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.ClientSize = new System.Drawing.Size(1150, 399);
            this.Name = "VistaFormTaller";
            this.panelButton.ResumeLayout(false);
            this.panelPrincipal.ResumeLayout(false);
            this.panelPrincipal.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox textCp;
        private System.Windows.Forms.Label labPoblacion;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label labDomicilio;
        private System.Windows.Forms.TextBox textNombre;
        private System.Windows.Forms.Label labelNombre;
        private System.Windows.Forms.TextBox textNif;
        private System.Windows.Forms.Label labNif;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label labelMovil;
        private System.Windows.Forms.TextBox textTeléfono;
        private System.Windows.Forms.Label labTelefono;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label labProvincia;
        private System.Windows.Forms.TextBox textPob;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label labelEmail;
        private System.Windows.Forms.CheckBox checkBloqueado;
        private System.Windows.Forms.CheckBox checkActivo;
    }
}
