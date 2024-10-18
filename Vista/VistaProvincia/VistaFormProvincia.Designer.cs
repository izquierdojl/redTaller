namespace redTaller.Vista.VistaProvincia
{
    partial class VistaFormProvincia
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
            this.panelButton.SuspendLayout();
            this.panelPrincipal.SuspendLayout();
            this.SuspendLayout();
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
            this.panelPrincipal.Controls.Add(this.textNombre);
            this.panelPrincipal.Controls.Add(this.labelNombre);
            this.panelPrincipal.Controls.Add(this.textCodigo);
            this.panelPrincipal.Controls.Add(this.labCodigo);
            // 
            // textNombre
            // 
            this.textNombre.Location = new System.Drawing.Point(94, 55);
            this.textNombre.Name = "textNombre";
            this.textNombre.Size = new System.Drawing.Size(395, 20);
            this.textNombre.TabIndex = 12;
            // 
            // labelNombre
            // 
            this.labelNombre.AutoSize = true;
            this.labelNombre.Location = new System.Drawing.Point(26, 58);
            this.labelNombre.Name = "labelNombre";
            this.labelNombre.Size = new System.Drawing.Size(47, 13);
            this.labelNombre.TabIndex = 14;
            this.labelNombre.Text = "Nombre:";
            // 
            // textCodigo
            // 
            this.textCodigo.Location = new System.Drawing.Point(94, 22);
            this.textCodigo.Name = "textCodigo";
            this.textCodigo.Size = new System.Drawing.Size(81, 20);
            this.textCodigo.TabIndex = 11;
            this.textCodigo.Validating += new System.ComponentModel.CancelEventHandler(this.textCodigo_Validating);
            // 
            // labCodigo
            // 
            this.labCodigo.AutoSize = true;
            this.labCodigo.Location = new System.Drawing.Point(26, 25);
            this.labCodigo.Name = "labCodigo";
            this.labCodigo.Size = new System.Drawing.Size(43, 13);
            this.labCodigo.TabIndex = 13;
            this.labCodigo.Text = "Código:";
            // 
            // VistaFormProvincia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(575, 185);
            this.Name = "VistaFormProvincia";
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
    }
}
