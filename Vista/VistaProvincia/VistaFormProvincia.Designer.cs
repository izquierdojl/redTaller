namespace redTaller.Vista.VistaProvincia
{
    partial class VistaFormProvincia
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panelDialog = new System.Windows.Forms.SplitContainer();
            this.textNombre = new System.Windows.Forms.TextBox();
            this.labelNombre = new System.Windows.Forms.Label();
            this.textCodigo = new System.Windows.Forms.TextBox();
            this.labCodigo = new System.Windows.Forms.Label();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnAceptar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.panelDialog)).BeginInit();
            this.panelDialog.Panel1.SuspendLayout();
            this.panelDialog.Panel2.SuspendLayout();
            this.panelDialog.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelDialog
            // 
            this.panelDialog.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDialog.Location = new System.Drawing.Point(0, 0);
            this.panelDialog.Name = "panelDialog";
            this.panelDialog.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // panelDialog.Panel1
            // 
            this.panelDialog.Panel1.Controls.Add(this.textNombre);
            this.panelDialog.Panel1.Controls.Add(this.labelNombre);
            this.panelDialog.Panel1.Controls.Add(this.textCodigo);
            this.panelDialog.Panel1.Controls.Add(this.labCodigo);
            // 
            // panelDialog.Panel2
            // 
            this.panelDialog.Panel2.Controls.Add(this.btnCancelar);
            this.panelDialog.Panel2.Controls.Add(this.btnAceptar);
            this.panelDialog.Size = new System.Drawing.Size(640, 132);
            this.panelDialog.SplitterDistance = 81;
            this.panelDialog.TabIndex = 0;
            // 
            // textNombre
            // 
            this.textNombre.Location = new System.Drawing.Point(93, 44);
            this.textNombre.Name = "textNombre";
            this.textNombre.Size = new System.Drawing.Size(452, 20);
            this.textNombre.TabIndex = 3;
            // 
            // labelNombre
            // 
            this.labelNombre.AutoSize = true;
            this.labelNombre.Location = new System.Drawing.Point(23, 47);
            this.labelNombre.Name = "labelNombre";
            this.labelNombre.Size = new System.Drawing.Size(47, 13);
            this.labelNombre.TabIndex = 2;
            this.labelNombre.Text = "Nombre:";
            // 
            // textCodigo
            // 
            this.textCodigo.Location = new System.Drawing.Point(93, 18);
            this.textCodigo.Name = "textCodigo";
            this.textCodigo.Size = new System.Drawing.Size(81, 20);
            this.textCodigo.TabIndex = 1;
            // 
            // labCodigo
            // 
            this.labCodigo.AutoSize = true;
            this.labCodigo.Location = new System.Drawing.Point(23, 21);
            this.labCodigo.Name = "labCodigo";
            this.labCodigo.Size = new System.Drawing.Size(43, 13);
            this.labCodigo.TabIndex = 0;
            this.labCodigo.Text = "Código:";
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(544, 7);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(79, 32);
            this.btnCancelar.TabIndex = 1;
            this.btnCancelar.Text = "&Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(450, 7);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(79, 32);
            this.btnAceptar.TabIndex = 0;
            this.btnAceptar.Text = "&Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // VistaFormProvincia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(640, 132);
            this.ControlBox = false;
            this.Controls.Add(this.panelDialog);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "VistaFormProvincia";
            this.ShowIcon = false;
            this.Text = "Detalle Provincia";
            this.TopMost = true;
            this.panelDialog.Panel1.ResumeLayout(false);
            this.panelDialog.Panel1.PerformLayout();
            this.panelDialog.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.panelDialog)).EndInit();
            this.panelDialog.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer panelDialog;
        private System.Windows.Forms.TextBox textCodigo;
        private System.Windows.Forms.Label labCodigo;
        private System.Windows.Forms.TextBox textNombre;
        private System.Windows.Forms.Label labelNombre;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnAceptar;
    }
}