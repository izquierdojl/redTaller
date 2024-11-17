namespace redTaller.Vista.VistaMatricula
{
    partial class VistaFormMatricula
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
            this.labMarca = new System.Windows.Forms.Label();
            this.textMatricula = new System.Windows.Forms.TextBox();
            this.labCodigo = new System.Windows.Forms.Label();
            this.labModelo = new System.Windows.Forms.Label();
            this.comboMarca = new System.Windows.Forms.ComboBox();
            this.comboModelo = new System.Windows.Forms.ComboBox();
            this.panelButton.SuspendLayout();
            this.panelPrincipal.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelButton
            // 
            this.panelButton.Location = new System.Drawing.Point(0, 153);
            this.panelButton.Size = new System.Drawing.Size(381, 61);
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(166, 5);
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancelar.Location = new System.Drawing.Point(271, 5);
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // panelPrincipal
            // 
            this.panelPrincipal.Controls.Add(this.comboModelo);
            this.panelPrincipal.Controls.Add(this.comboMarca);
            this.panelPrincipal.Controls.Add(this.labModelo);
            this.panelPrincipal.Controls.Add(this.labMarca);
            this.panelPrincipal.Controls.Add(this.textMatricula);
            this.panelPrincipal.Controls.Add(this.labCodigo);
            this.panelPrincipal.Size = new System.Drawing.Size(381, 214);
            // 
            // labMarca
            // 
            this.labMarca.AutoSize = true;
            this.labMarca.Location = new System.Drawing.Point(21, 67);
            this.labMarca.Name = "labMarca";
            this.labMarca.Size = new System.Drawing.Size(40, 13);
            this.labMarca.TabIndex = 18;
            this.labMarca.Text = "Marca:";
            // 
            // textMatricula
            // 
            this.textMatricula.Location = new System.Drawing.Point(92, 30);
            this.textMatricula.MaxLength = 2;
            this.textMatricula.Name = "textMatricula";
            this.textMatricula.Size = new System.Drawing.Size(130, 20);
            this.textMatricula.TabIndex = 15;
            // 
            // labCodigo
            // 
            this.labCodigo.AutoSize = true;
            this.labCodigo.Location = new System.Drawing.Point(21, 33);
            this.labCodigo.Name = "labCodigo";
            this.labCodigo.Size = new System.Drawing.Size(55, 13);
            this.labCodigo.TabIndex = 17;
            this.labCodigo.Text = "Matrícula:";
            // 
            // labModelo
            // 
            this.labModelo.AutoSize = true;
            this.labModelo.Location = new System.Drawing.Point(21, 101);
            this.labModelo.Name = "labModelo";
            this.labModelo.Size = new System.Drawing.Size(45, 13);
            this.labModelo.TabIndex = 20;
            this.labModelo.Text = "Modelo:";
            // 
            // comboMarca
            // 
            this.comboMarca.FormattingEnabled = true;
            this.comboMarca.Location = new System.Drawing.Point(92, 63);
            this.comboMarca.Name = "comboMarca";
            this.comboMarca.Size = new System.Drawing.Size(254, 21);
            this.comboMarca.TabIndex = 21;
            this.comboMarca.SelectedValueChanged += new System.EventHandler(this.comboMarca_SelectedValueChanged);
            // 
            // comboModelo
            // 
            this.comboModelo.FormattingEnabled = true;
            this.comboModelo.Location = new System.Drawing.Point(92, 97);
            this.comboModelo.Name = "comboModelo";
            this.comboModelo.Size = new System.Drawing.Size(254, 21);
            this.comboModelo.TabIndex = 22;
            // 
            // VistaFormMatricula
            // 
            this.AcceptButton = this.btnAceptar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.CancelButton = this.btnCancelar;
            this.ClientSize = new System.Drawing.Size(381, 214);
            this.Name = "VistaFormMatricula";
            this.Load += new System.EventHandler(this.VistaFormMatricula_Load);
            this.panelButton.ResumeLayout(false);
            this.panelPrincipal.ResumeLayout(false);
            this.panelPrincipal.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label labMarca;
        private System.Windows.Forms.TextBox textMatricula;
        private System.Windows.Forms.Label labCodigo;
        private System.Windows.Forms.Label labModelo;
        private System.Windows.Forms.ComboBox comboModelo;
        private System.Windows.Forms.ComboBox comboMarca;
    }
}
