namespace redTaller.Vista.VistaCliente
{
    partial class VistaListaCliente
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
            this.gridPrincipal = new System.Windows.Forms.DataGridView();
            this.panelTop.SuspendLayout();
            this.panelSearch.SuspendLayout();
            this.panelCenter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridPrincipal)).BeginInit();
            this.SuspendLayout();
            // 
            // btnInitSearch
            // 
            this.toolBotones.SetToolTip(this.btnInitSearch, "Inicializa la búsqueda");
            // 
            // btnSearch
            // 
            this.toolBotones.SetToolTip(this.btnSearch, "Busca por el texto indicado");
            // 
            // btnSalir
            // 
            this.toolBotones.SetToolTip(this.btnSalir, "Añade un Registro (Ins)");
            // 
            // btnDelete
            // 
            this.toolBotones.SetToolTip(this.btnDelete, "Elimina los registros seleccionados (Supr)");
            // 
            // btnEdit
            // 
            this.toolBotones.SetToolTip(this.btnEdit, "Edita un Registro (ENTER)");
            // 
            // btnAdd
            // 
            this.toolBotones.SetToolTip(this.btnAdd, "Añade un Registro (Ins)");
            // 
            // panelCenter
            // 
            this.panelCenter.Controls.Add(this.gridPrincipal);
            // 
            // gridPrincipal
            // 
            this.gridPrincipal.AllowUserToAddRows = false;
            this.gridPrincipal.AllowUserToDeleteRows = false;
            this.gridPrincipal.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridPrincipal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridPrincipal.Location = new System.Drawing.Point(0, 0);
            this.gridPrincipal.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gridPrincipal.Name = "gridPrincipal";
            this.gridPrincipal.ReadOnly = true;
            this.gridPrincipal.RowHeadersWidth = 62;
            this.gridPrincipal.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridPrincipal.Size = new System.Drawing.Size(1200, 567);
            this.gridPrincipal.TabIndex = 2;
            // 
            // VistaListaCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.ClientSize = new System.Drawing.Size(1200, 692);
            this.Name = "VistaListaCliente";
            this.panelTop.ResumeLayout(false);
            this.panelSearch.ResumeLayout(false);
            this.panelSearch.PerformLayout();
            this.panelCenter.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridPrincipal)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        protected System.Windows.Forms.DataGridView gridPrincipal;
    }
}
