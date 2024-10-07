namespace redTaller.Vista
{
    partial class VistaListaProvincia
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
            this.components = new System.ComponentModel.Container();
            this.panelTop = new System.Windows.Forms.Panel();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.textSearch = new System.Windows.Forms.TextBox();
            this.panelCenter = new System.Windows.Forms.Panel();
            this.gridPrincipal = new System.Windows.Forms.DataGridView();
            this.toolBotones = new System.Windows.Forms.ToolTip(this.components);
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.btnSalir = new System.Windows.Forms.Button();
            this.panelTop.SuspendLayout();
            this.panelCenter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridPrincipal)).BeginInit();
            this.SuspendLayout();
            // 
            // panelTop
            // 
            this.panelTop.Controls.Add(this.btnSalir);
            this.panelTop.Controls.Add(this.btnDelete);
            this.panelTop.Controls.Add(this.btnEdit);
            this.panelTop.Controls.Add(this.btnAdd);
            this.panelTop.Controls.Add(this.textSearch);
            this.panelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop.Location = new System.Drawing.Point(0, 0);
            this.panelTop.Name = "panelTop";
            this.panelTop.Padding = new System.Windows.Forms.Padding(10, 10, 10, 10);
            this.panelTop.Size = new System.Drawing.Size(1033, 81);
            this.panelTop.TabIndex = 1;
            // 
            // btnDelete
            // 
            this.btnDelete.Image = global::redTaller.Properties.Resources.borrar;
            this.btnDelete.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnDelete.Location = new System.Drawing.Point(203, 10);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(57, 58);
            this.btnDelete.TabIndex = 3;
            this.btnDelete.Text = "Borrar";
            this.btnDelete.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.toolBotones.SetToolTip(this.btnDelete, "Elimina los registros seleccionados (Supr)");
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Image = global::redTaller.Properties.Resources.editar;
            this.btnEdit.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnEdit.Location = new System.Drawing.Point(139, 10);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(57, 58);
            this.btnEdit.TabIndex = 2;
            this.btnEdit.Text = "Editar";
            this.btnEdit.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.toolBotones.SetToolTip(this.btnEdit, "Edita un Registro (ENTER)");
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.AccessibleDescription = "";
            this.btnAdd.Image = global::redTaller.Properties.Resources.anadir;
            this.btnAdd.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnAdd.Location = new System.Drawing.Point(76, 10);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(57, 58);
            this.btnAdd.TabIndex = 1;
            this.btnAdd.Text = "Añadir";
            this.btnAdd.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.toolBotones.SetToolTip(this.btnAdd, "Añade un Registro (Ins)");
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // textSearch
            // 
            this.textSearch.Dock = System.Windows.Forms.DockStyle.Right;
            this.textSearch.Location = new System.Drawing.Point(780, 10);
            this.textSearch.Name = "textSearch";
            this.textSearch.Size = new System.Drawing.Size(243, 20);
            this.textSearch.TabIndex = 0;
            this.toolBotones.SetToolTip(this.textSearch, "Introduzca texto a buscar.");
            this.textSearch.TextChanged += new System.EventHandler(this.textSearch_TextChanged);
            // 
            // panelCenter
            // 
            this.panelCenter.Controls.Add(this.gridPrincipal);
            this.panelCenter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelCenter.Location = new System.Drawing.Point(0, 81);
            this.panelCenter.Name = "panelCenter";
            this.panelCenter.Size = new System.Drawing.Size(1033, 454);
            this.panelCenter.TabIndex = 2;
            // 
            // gridPrincipal
            // 
            this.gridPrincipal.AllowUserToAddRows = false;
            this.gridPrincipal.AllowUserToDeleteRows = false;
            this.gridPrincipal.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridPrincipal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridPrincipal.Location = new System.Drawing.Point(0, 0);
            this.gridPrincipal.Name = "gridPrincipal";
            this.gridPrincipal.ReadOnly = true;
            this.gridPrincipal.RowHeadersWidth = 62;
            this.gridPrincipal.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridPrincipal.Size = new System.Drawing.Size(1033, 454);
            this.gridPrincipal.TabIndex = 1;
            this.gridPrincipal.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.gridPrincipal_CellMouseDoubleClick);
            this.gridPrincipal.KeyDown += new System.Windows.Forms.KeyEventHandler(this.gridPrincipal_KeyDown);
            // 
            // toolBotones
            // 
            this.toolBotones.Tag = "Añade un Registro";
            // 
            // btnSalir
            // 
            this.btnSalir.AccessibleDescription = "";
            this.btnSalir.Image = global::redTaller.Properties.Resources.salir;
            this.btnSalir.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnSalir.Location = new System.Drawing.Point(13, 10);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(57, 58);
            this.btnSalir.TabIndex = 4;
            this.btnSalir.Text = "Salir";
            this.btnSalir.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.toolBotones.SetToolTip(this.btnSalir, "Añade un Registro (Ins)");
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // VistaListaProvincia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1033, 535);
            this.Controls.Add(this.panelCenter);
            this.Controls.Add(this.panelTop);
            this.Name = "VistaListaProvincia";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Provincia";
            this.panelTop.ResumeLayout(false);
            this.panelTop.PerformLayout();
            this.panelCenter.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridPrincipal)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panelTop;
        private System.Windows.Forms.Panel panelCenter;
        private System.Windows.Forms.DataGridView gridPrincipal;
        private System.Windows.Forms.TextBox textSearch;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.ToolTip toolBotones;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Button btnSalir;
    }
}