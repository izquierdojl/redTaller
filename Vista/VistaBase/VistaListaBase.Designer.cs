namespace redTaller.Vista.VistaBase
{
    partial class VistaListaBase
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
            this.panelSearch = new System.Windows.Forms.Panel();
            this.btnInitSearch = new System.Windows.Forms.Button();
            this.comboSearch = new System.Windows.Forms.ComboBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.textSearch = new System.Windows.Forms.TextBox();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.toolBotones = new System.Windows.Forms.ToolTip(this.components);
            this.panelCenter = new System.Windows.Forms.Panel();
            this.panelTop.SuspendLayout();
            this.panelSearch.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelTop
            // 
            this.panelTop.Controls.Add(this.panelSearch);
            this.panelTop.Controls.Add(this.btnSalir);
            this.panelTop.Controls.Add(this.btnDelete);
            this.panelTop.Controls.Add(this.btnEdit);
            this.panelTop.Controls.Add(this.btnAdd);
            this.panelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop.Location = new System.Drawing.Point(0, 0);
            this.panelTop.Name = "panelTop";
            this.panelTop.Padding = new System.Windows.Forms.Padding(10);
            this.panelTop.Size = new System.Drawing.Size(800, 81);
            this.panelTop.TabIndex = 3;
            // 
            // panelSearch
            // 
            this.panelSearch.Controls.Add(this.btnInitSearch);
            this.panelSearch.Controls.Add(this.comboSearch);
            this.panelSearch.Controls.Add(this.btnSearch);
            this.panelSearch.Controls.Add(this.textSearch);
            this.panelSearch.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelSearch.Location = new System.Drawing.Point(383, 10);
            this.panelSearch.Name = "panelSearch";
            this.panelSearch.Size = new System.Drawing.Size(407, 61);
            this.panelSearch.TabIndex = 10;
            // 
            // btnInitSearch
            // 
            this.btnInitSearch.AutoSize = true;
            this.btnInitSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInitSearch.Image = global::redTaller.Properties.Resources.iniciar;
            this.btnInitSearch.Location = new System.Drawing.Point(372, 1);
            this.btnInitSearch.Name = "btnInitSearch";
            this.btnInitSearch.Size = new System.Drawing.Size(32, 32);
            this.btnInitSearch.TabIndex = 10;
            this.toolBotones.SetToolTip(this.btnInitSearch, "Inicializa la búsqueda");
            this.btnInitSearch.UseVisualStyleBackColor = true;
            // 
            // comboSearch
            // 
            this.comboSearch.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboSearch.FormattingEnabled = true;
            this.comboSearch.Location = new System.Drawing.Point(0, 2);
            this.comboSearch.Name = "comboSearch";
            this.comboSearch.Size = new System.Drawing.Size(115, 21);
            this.comboSearch.TabIndex = 5;
            // 
            // btnSearch
            // 
            this.btnSearch.AutoSize = true;
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.Image = global::redTaller.Properties.Resources.buscar;
            this.btnSearch.Location = new System.Drawing.Point(335, 1);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(32, 32);
            this.btnSearch.TabIndex = 9;
            this.toolBotones.SetToolTip(this.btnSearch, "Busca por el texto indicado");
            this.btnSearch.UseVisualStyleBackColor = true;
            // 
            // textSearch
            // 
            this.textSearch.Location = new System.Drawing.Point(121, 3);
            this.textSearch.Name = "textSearch";
            this.textSearch.Size = new System.Drawing.Size(208, 20);
            this.textSearch.TabIndex = 8;
            this.toolBotones.SetToolTip(this.textSearch, "Introduzca texto a buscar.");
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
            // 
            // btnDelete
            // 
            this.btnDelete.Image = global::redTaller.Properties.Resources.borrar;
            this.btnDelete.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnDelete.Location = new System.Drawing.Point(203, 10);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(57, 58);
            this.btnDelete.TabIndex = 3;
            this.btnDelete.Text = "Eliminar";
            this.btnDelete.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.toolBotones.SetToolTip(this.btnDelete, "Elimina los registros seleccionados (Supr)");
            this.btnDelete.UseVisualStyleBackColor = true;
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
            // 
            // toolBotones
            // 
            this.toolBotones.Tag = "Añade un Registro";
            // 
            // panelCenter
            // 
            this.panelCenter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelCenter.Location = new System.Drawing.Point(0, 81);
            this.panelCenter.Name = "panelCenter";
            this.panelCenter.Size = new System.Drawing.Size(800, 369);
            this.panelCenter.TabIndex = 4;
            // 
            // VistaListaBase
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panelCenter);
            this.Controls.Add(this.panelTop);
            this.Name = "VistaListaBase";
            this.panelTop.ResumeLayout(false);
            this.panelSearch.ResumeLayout(false);
            this.panelSearch.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        protected System.Windows.Forms.Button btnInitSearch;
        protected System.Windows.Forms.ComboBox comboSearch;
        protected System.Windows.Forms.Button btnSearch;
        protected System.Windows.Forms.TextBox textSearch;
        protected System.Windows.Forms.Button btnSalir;
        protected System.Windows.Forms.Button btnDelete;
        protected System.Windows.Forms.Button btnEdit;
        protected System.Windows.Forms.Button btnAdd;
        protected System.Windows.Forms.Panel panelTop;
        protected System.Windows.Forms.Panel panelSearch;
        protected System.Windows.Forms.ToolTip toolBotones;
        protected System.Windows.Forms.Panel panelCenter;
    }
}