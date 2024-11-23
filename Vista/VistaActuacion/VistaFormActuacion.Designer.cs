namespace redTaller.Vista.VistaActuacion
{
    partial class VistaFormActuacion
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
            this.btnSearchTaller = new System.Windows.Forms.Button();
            this.textNif_Taller = new System.Windows.Forms.TextBox();
            this.labTaller = new System.Windows.Forms.Label();
            this.labelNomTaller = new System.Windows.Forms.Label();
            this.labelNomCliente = new System.Windows.Forms.Label();
            this.btnSearchCliente = new System.Windows.Forms.Button();
            this.textNif_Cliente = new System.Windows.Forms.TextBox();
            this.labCliente = new System.Windows.Forms.Label();
            this.labelNombreMatricula = new System.Windows.Forms.Label();
            this.btnSearchMatricula = new System.Windows.Forms.Button();
            this.textMatricula = new System.Windows.Forms.TextBox();
            this.labMatricula = new System.Windows.Forms.Label();
            this.dateFecha = new System.Windows.Forms.DateTimePicker();
            this.labelFecha = new System.Windows.Forms.Label();
            this.labelKm = new System.Windows.Forms.Label();
            this.textKm = new System.Windows.Forms.MaskedTextBox();
            this.panelBottom = new System.Windows.Forms.Panel();
            this.panelGridCenter = new System.Windows.Forms.Panel();
            this.gridActuacionDetalle = new System.Windows.Forms.DataGridView();
            this.panelGridTop = new System.Windows.Forms.Panel();
            this.labCaptionActuaciones = new System.Windows.Forms.Label();
            this.btnGridDel = new System.Windows.Forms.Button();
            this.btnGridEdit = new System.Windows.Forms.Button();
            this.btnGridAdd = new System.Windows.Forms.Button();
            this.comboTipo = new System.Windows.Forms.ComboBox();
            this.labelTipo = new System.Windows.Forms.Label();
            this.panelButton.SuspendLayout();
            this.panelPrincipal.SuspendLayout();
            this.panelBottom.SuspendLayout();
            this.panelGridCenter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridActuacionDetalle)).BeginInit();
            this.panelGridTop.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelButton
            // 
            this.panelButton.Location = new System.Drawing.Point(0, 482);
            this.panelButton.Size = new System.Drawing.Size(752, 61);
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(537, 5);
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(642, 5);
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // panelPrincipal
            // 
            this.panelPrincipal.Controls.Add(this.comboTipo);
            this.panelPrincipal.Controls.Add(this.labelTipo);
            this.panelPrincipal.Controls.Add(this.panelBottom);
            this.panelPrincipal.Controls.Add(this.textKm);
            this.panelPrincipal.Controls.Add(this.labelKm);
            this.panelPrincipal.Controls.Add(this.labelFecha);
            this.panelPrincipal.Controls.Add(this.dateFecha);
            this.panelPrincipal.Controls.Add(this.labelNombreMatricula);
            this.panelPrincipal.Controls.Add(this.btnSearchMatricula);
            this.panelPrincipal.Controls.Add(this.textMatricula);
            this.panelPrincipal.Controls.Add(this.labMatricula);
            this.panelPrincipal.Controls.Add(this.labelNomCliente);
            this.panelPrincipal.Controls.Add(this.btnSearchCliente);
            this.panelPrincipal.Controls.Add(this.textNif_Cliente);
            this.panelPrincipal.Controls.Add(this.labCliente);
            this.panelPrincipal.Controls.Add(this.labelNomTaller);
            this.panelPrincipal.Controls.Add(this.btnSearchTaller);
            this.panelPrincipal.Controls.Add(this.textNif_Taller);
            this.panelPrincipal.Controls.Add(this.labTaller);
            this.panelPrincipal.Size = new System.Drawing.Size(752, 543);
            // 
            // btnSearchTaller
            // 
            this.btnSearchTaller.BackgroundImage = global::redTaller.Properties.Resources.buscar;
            this.btnSearchTaller.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSearchTaller.FlatAppearance.BorderSize = 0;
            this.btnSearchTaller.Location = new System.Drawing.Point(230, 38);
            this.btnSearchTaller.Name = "btnSearchTaller";
            this.btnSearchTaller.Size = new System.Drawing.Size(23, 20);
            this.btnSearchTaller.TabIndex = 58;
            this.btnSearchTaller.TabStop = false;
            this.btnSearchTaller.UseVisualStyleBackColor = true;
            this.btnSearchTaller.Click += new System.EventHandler(this.btnSearchNif_Taller_Click);
            // 
            // textNif_Taller
            // 
            this.textNif_Taller.Location = new System.Drawing.Point(89, 38);
            this.textNif_Taller.MaxLength = 15;
            this.textNif_Taller.Name = "textNif_Taller";
            this.textNif_Taller.Size = new System.Drawing.Size(135, 20);
            this.textNif_Taller.TabIndex = 55;
            this.textNif_Taller.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textNif_Taller_KeyDown);
            this.textNif_Taller.Validating += new System.ComponentModel.CancelEventHandler(this.textNif_Taller_Validating);
            // 
            // labTaller
            // 
            this.labTaller.Location = new System.Drawing.Point(27, 41);
            this.labTaller.Name = "labTaller";
            this.labTaller.Size = new System.Drawing.Size(43, 20);
            this.labTaller.TabIndex = 57;
            this.labTaller.Text = "Taller:";
            // 
            // labelNomTaller
            // 
            this.labelNomTaller.Location = new System.Drawing.Point(259, 41);
            this.labelNomTaller.Name = "labelNomTaller";
            this.labelNomTaller.Size = new System.Drawing.Size(454, 20);
            this.labelNomTaller.TabIndex = 59;
            // 
            // labelNomCliente
            // 
            this.labelNomCliente.Location = new System.Drawing.Point(259, 71);
            this.labelNomCliente.Name = "labelNomCliente";
            this.labelNomCliente.Size = new System.Drawing.Size(454, 20);
            this.labelNomCliente.TabIndex = 63;
            // 
            // btnSearchCliente
            // 
            this.btnSearchCliente.BackgroundImage = global::redTaller.Properties.Resources.buscar;
            this.btnSearchCliente.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSearchCliente.FlatAppearance.BorderSize = 0;
            this.btnSearchCliente.Location = new System.Drawing.Point(230, 68);
            this.btnSearchCliente.Name = "btnSearchCliente";
            this.btnSearchCliente.Size = new System.Drawing.Size(23, 20);
            this.btnSearchCliente.TabIndex = 62;
            this.btnSearchCliente.TabStop = false;
            this.btnSearchCliente.UseVisualStyleBackColor = true;
            this.btnSearchCliente.Click += new System.EventHandler(this.btnSearchNif_Cliente_Click);
            // 
            // textNif_Cliente
            // 
            this.textNif_Cliente.Location = new System.Drawing.Point(89, 68);
            this.textNif_Cliente.MaxLength = 15;
            this.textNif_Cliente.Name = "textNif_Cliente";
            this.textNif_Cliente.Size = new System.Drawing.Size(135, 20);
            this.textNif_Cliente.TabIndex = 60;
            this.textNif_Cliente.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textNif_Cliente_KeyDown);
            this.textNif_Cliente.Validating += new System.ComponentModel.CancelEventHandler(this.textNif_Cliente_Validating);
            // 
            // labCliente
            // 
            this.labCliente.Location = new System.Drawing.Point(27, 71);
            this.labCliente.Name = "labCliente";
            this.labCliente.Size = new System.Drawing.Size(43, 20);
            this.labCliente.TabIndex = 61;
            this.labCliente.Text = "Cliente:";
            // 
            // labelNombreMatricula
            // 
            this.labelNombreMatricula.Location = new System.Drawing.Point(259, 102);
            this.labelNombreMatricula.Name = "labelNombreMatricula";
            this.labelNombreMatricula.Size = new System.Drawing.Size(454, 20);
            this.labelNombreMatricula.TabIndex = 67;
            // 
            // btnSearchMatricula
            // 
            this.btnSearchMatricula.BackgroundImage = global::redTaller.Properties.Resources.buscar;
            this.btnSearchMatricula.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSearchMatricula.FlatAppearance.BorderSize = 0;
            this.btnSearchMatricula.Location = new System.Drawing.Point(230, 99);
            this.btnSearchMatricula.Name = "btnSearchMatricula";
            this.btnSearchMatricula.Size = new System.Drawing.Size(23, 20);
            this.btnSearchMatricula.TabIndex = 66;
            this.btnSearchMatricula.TabStop = false;
            this.btnSearchMatricula.UseVisualStyleBackColor = true;
            this.btnSearchMatricula.Click += new System.EventHandler(this.btnSearchMatricula_Click);
            // 
            // textMatricula
            // 
            this.textMatricula.Location = new System.Drawing.Point(89, 99);
            this.textMatricula.MaxLength = 20;
            this.textMatricula.Name = "textMatricula";
            this.textMatricula.Size = new System.Drawing.Size(135, 20);
            this.textMatricula.TabIndex = 64;
            this.textMatricula.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textMatricula_KeyDown);
            this.textMatricula.Validating += new System.ComponentModel.CancelEventHandler(this.textMatricula_Validating);
            // 
            // labMatricula
            // 
            this.labMatricula.Location = new System.Drawing.Point(27, 102);
            this.labMatricula.Name = "labMatricula";
            this.labMatricula.Size = new System.Drawing.Size(56, 20);
            this.labMatricula.TabIndex = 65;
            this.labMatricula.Text = "Matrícula:";
            // 
            // dateFecha
            // 
            this.dateFecha.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateFecha.Location = new System.Drawing.Point(89, 132);
            this.dateFecha.Name = "dateFecha";
            this.dateFecha.Size = new System.Drawing.Size(135, 20);
            this.dateFecha.TabIndex = 68;
            // 
            // labelFecha
            // 
            this.labelFecha.Location = new System.Drawing.Point(27, 135);
            this.labelFecha.Name = "labelFecha";
            this.labelFecha.Size = new System.Drawing.Size(56, 20);
            this.labelFecha.TabIndex = 69;
            this.labelFecha.Text = "Fecha:";
            // 
            // labelKm
            // 
            this.labelKm.Location = new System.Drawing.Point(27, 167);
            this.labelKm.Name = "labelKm";
            this.labelKm.Size = new System.Drawing.Size(71, 20);
            this.labelKm.TabIndex = 70;
            this.labelKm.Text = "Kilómetros:";
            // 
            // textKm
            // 
            this.textKm.Location = new System.Drawing.Point(90, 165);
            this.textKm.Name = "textKm";
            this.textKm.PromptChar = ' ';
            this.textKm.Size = new System.Drawing.Size(100, 20);
            this.textKm.TabIndex = 71;
            this.textKm.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.textKm.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            this.textKm.TextChanged += new System.EventHandler(this.textKm_TextChanged);
            // 
            // panelBottom
            // 
            this.panelBottom.Controls.Add(this.panelGridCenter);
            this.panelBottom.Controls.Add(this.panelGridTop);
            this.panelBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelBottom.Location = new System.Drawing.Point(0, 222);
            this.panelBottom.Name = "panelBottom";
            this.panelBottom.Size = new System.Drawing.Size(752, 321);
            this.panelBottom.TabIndex = 72;
            // 
            // panelGridCenter
            // 
            this.panelGridCenter.Controls.Add(this.gridActuacionDetalle);
            this.panelGridCenter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelGridCenter.Location = new System.Drawing.Point(0, 45);
            this.panelGridCenter.Name = "panelGridCenter";
            this.panelGridCenter.Size = new System.Drawing.Size(752, 276);
            this.panelGridCenter.TabIndex = 1;
            // 
            // gridActuacionDetalle
            // 
            this.gridActuacionDetalle.AllowUserToAddRows = false;
            this.gridActuacionDetalle.AllowUserToDeleteRows = false;
            this.gridActuacionDetalle.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridActuacionDetalle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridActuacionDetalle.Location = new System.Drawing.Point(0, 0);
            this.gridActuacionDetalle.Name = "gridActuacionDetalle";
            this.gridActuacionDetalle.ReadOnly = true;
            this.gridActuacionDetalle.RowHeadersWidth = 62;
            this.gridActuacionDetalle.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridActuacionDetalle.Size = new System.Drawing.Size(752, 276);
            this.gridActuacionDetalle.TabIndex = 1;
            // 
            // panelGridTop
            // 
            this.panelGridTop.Controls.Add(this.labCaptionActuaciones);
            this.panelGridTop.Controls.Add(this.btnGridDel);
            this.panelGridTop.Controls.Add(this.btnGridEdit);
            this.panelGridTop.Controls.Add(this.btnGridAdd);
            this.panelGridTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelGridTop.Location = new System.Drawing.Point(0, 0);
            this.panelGridTop.Name = "panelGridTop";
            this.panelGridTop.Size = new System.Drawing.Size(752, 45);
            this.panelGridTop.TabIndex = 0;
            // 
            // labCaptionActuaciones
            // 
            this.labCaptionActuaciones.AutoSize = true;
            this.labCaptionActuaciones.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labCaptionActuaciones.Location = new System.Drawing.Point(165, 12);
            this.labCaptionActuaciones.Name = "labCaptionActuaciones";
            this.labCaptionActuaciones.Size = new System.Drawing.Size(162, 18);
            this.labCaptionActuaciones.TabIndex = 76;
            this.labCaptionActuaciones.Text = "Detalle de Actuación";
            // 
            // btnGridDel
            // 
            this.btnGridDel.Image = global::redTaller.Properties.Resources.borrar;
            this.btnGridDel.Location = new System.Drawing.Point(105, 4);
            this.btnGridDel.Name = "btnGridDel";
            this.btnGridDel.Size = new System.Drawing.Size(42, 37);
            this.btnGridDel.TabIndex = 75;
            this.btnGridDel.UseVisualStyleBackColor = true;
            this.btnGridDel.Click += new System.EventHandler(this.btnGridDel_Click);
            // 
            // btnGridEdit
            // 
            this.btnGridEdit.Image = global::redTaller.Properties.Resources.editar;
            this.btnGridEdit.Location = new System.Drawing.Point(56, 4);
            this.btnGridEdit.Name = "btnGridEdit";
            this.btnGridEdit.Size = new System.Drawing.Size(42, 37);
            this.btnGridEdit.TabIndex = 74;
            this.btnGridEdit.UseVisualStyleBackColor = true;
            // 
            // btnGridAdd
            // 
            this.btnGridAdd.Image = global::redTaller.Properties.Resources.anadir;
            this.btnGridAdd.Location = new System.Drawing.Point(8, 4);
            this.btnGridAdd.Name = "btnGridAdd";
            this.btnGridAdd.Size = new System.Drawing.Size(42, 37);
            this.btnGridAdd.TabIndex = 73;
            this.btnGridAdd.UseVisualStyleBackColor = true;
            // 
            // comboTipo
            // 
            this.comboTipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboTipo.FormattingEnabled = true;
            this.comboTipo.Location = new System.Drawing.Point(313, 164);
            this.comboTipo.Name = "comboTipo";
            this.comboTipo.Size = new System.Drawing.Size(164, 21);
            this.comboTipo.TabIndex = 74;
            // 
            // labelTipo
            // 
            this.labelTipo.AutoSize = true;
            this.labelTipo.Location = new System.Drawing.Point(210, 168);
            this.labelTipo.Name = "labelTipo";
            this.labelTipo.Size = new System.Drawing.Size(97, 13);
            this.labelTipo.TabIndex = 73;
            this.labelTipo.Text = "Tipo de Actuación:";
            // 
            // VistaFormActuacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(752, 543);
            this.Name = "VistaFormActuacion";
            this.panelButton.ResumeLayout(false);
            this.panelPrincipal.ResumeLayout(false);
            this.panelPrincipal.PerformLayout();
            this.panelBottom.ResumeLayout(false);
            this.panelGridCenter.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridActuacionDetalle)).EndInit();
            this.panelGridTop.ResumeLayout(false);
            this.panelGridTop.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnSearchTaller;
        public System.Windows.Forms.TextBox textNif_Taller;
        private System.Windows.Forms.Label labTaller;
        private System.Windows.Forms.Button btnSearchMatricula;
        public System.Windows.Forms.TextBox textMatricula;
        private System.Windows.Forms.Label labMatricula;
        private System.Windows.Forms.Button btnSearchCliente;
        public System.Windows.Forms.TextBox textNif_Cliente;
        private System.Windows.Forms.Label labCliente;
        private System.Windows.Forms.MaskedTextBox textKm;
        private System.Windows.Forms.Label labelKm;
        private System.Windows.Forms.Label labelFecha;
        private System.Windows.Forms.DateTimePicker dateFecha;
        private System.Windows.Forms.Panel panelBottom;
        private System.Windows.Forms.Panel panelGridCenter;
        private System.Windows.Forms.Panel panelGridTop;
        private System.Windows.Forms.Label labCaptionActuaciones;
        private System.Windows.Forms.Button btnGridDel;
        private System.Windows.Forms.Button btnGridEdit;
        private System.Windows.Forms.Button btnGridAdd;
        private System.Windows.Forms.ComboBox comboTipo;
        private System.Windows.Forms.Label labelTipo;
        public System.Windows.Forms.Label labelNomTaller;
        public System.Windows.Forms.Label labelNombreMatricula;
        public System.Windows.Forms.Label labelNomCliente;
        protected System.Windows.Forms.DataGridView gridActuacionDetalle;
    }
}
