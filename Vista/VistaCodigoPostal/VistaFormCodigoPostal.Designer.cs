namespace redTaller.Vista.VistaCodigoPostal
{
    partial class VistaFormCodigoPostal
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
            this.textCodigo = new System.Windows.Forms.TextBox();
            this.labCodigo = new System.Windows.Forms.Label();
            this.labelProvincia = new System.Windows.Forms.Label();
            this.comboProvincia = new System.Windows.Forms.ComboBox();
            this.panelButton.SuspendLayout();
            this.panelPrincipal.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelButton
            // 
            this.panelButton.Location = new System.Drawing.Point(0, 133);
            // 
            // btnAceptar
            // 
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // panelPrincipal
            // 
            this.panelPrincipal.Controls.Add(this.comboProvincia);
            this.panelPrincipal.Controls.Add(this.labelProvincia);
            this.panelPrincipal.Controls.Add(this.textNombre);
            this.panelPrincipal.Controls.Add(this.labelNombre);
            this.panelPrincipal.Controls.Add(this.textCodigo);
            this.panelPrincipal.Controls.Add(this.labCodigo);
            this.panelPrincipal.Size = new System.Drawing.Size(575, 194);
            // 
            // textNombre
            // 
            this.textNombre.Location = new System.Drawing.Point(88, 58);
            this.textNombre.Name = "textNombre";
            this.textNombre.Size = new System.Drawing.Size(395, 20);
            this.textNombre.TabIndex = 8;
            // 
            // labelNombre
            // 
            this.labelNombre.AutoSize = true;
            this.labelNombre.Location = new System.Drawing.Point(18, 65);
            this.labelNombre.Name = "labelNombre";
            this.labelNombre.Size = new System.Drawing.Size(47, 13);
            this.labelNombre.TabIndex = 10;
            this.labelNombre.Text = "Nombre:";
            // 
            // textCodigo
            // 
            this.textCodigo.Location = new System.Drawing.Point(88, 25);
            this.textCodigo.Name = "textCodigo";
            this.textCodigo.Size = new System.Drawing.Size(81, 20);
            this.textCodigo.TabIndex = 7;
            // 
            // labCodigo
            // 
            this.labCodigo.AutoSize = true;
            this.labCodigo.Location = new System.Drawing.Point(18, 32);
            this.labCodigo.Name = "labCodigo";
            this.labCodigo.Size = new System.Drawing.Size(43, 13);
            this.labCodigo.TabIndex = 9;
            this.labCodigo.Text = "Código:";
            // 
            // labelProvincia
            // 
            this.labelProvincia.AutoSize = true;
            this.labelProvincia.Location = new System.Drawing.Point(18, 99);
            this.labelProvincia.Name = "labelProvincia";
            this.labelProvincia.Size = new System.Drawing.Size(54, 13);
            this.labelProvincia.TabIndex = 11;
            this.labelProvincia.Text = "Provincia:";
            this.labelProvincia.Click += new System.EventHandler(this.label1_Click);
            // 
            // comboProvincia
            // 
            this.comboProvincia.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboProvincia.FormattingEnabled = true;
            this.comboProvincia.Location = new System.Drawing.Point(88, 91);
            this.comboProvincia.Name = "comboProvincia";
            this.comboProvincia.Size = new System.Drawing.Size(203, 21);
            this.comboProvincia.TabIndex = 12;
            // 
            // VistaFormCodigoPostal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(575, 194);
            this.Name = "VistaFormCodigoPostal";
            this.panelButton.ResumeLayout(false);
            this.panelPrincipal.ResumeLayout(false);
            this.panelPrincipal.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox textNombre;
        private System.Windows.Forms.Label labelNombre;
        private System.Windows.Forms.TextBox textCodigo;
        private System.Windows.Forms.Label labCodigo;
        private System.Windows.Forms.Label labelProvincia;
        private System.Windows.Forms.ComboBox comboProvincia;
    }
}
