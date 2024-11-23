namespace redTaller.Vista.VistaActuacion
{
    partial class VistaFormActuacionDetalle
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
            this.labDetalle = new System.Windows.Forms.Label();
            this.labOrden = new System.Windows.Forms.Label();
            this.textOrden = new System.Windows.Forms.NumericUpDown();
            this.textDescripcion = new System.Windows.Forms.TextBox();
            this.pictureImagen = new System.Windows.Forms.PictureBox();
            this.btnLoadImage = new System.Windows.Forms.Button();
            this.labImagen = new System.Windows.Forms.Label();
            this.btnDelImage = new System.Windows.Forms.Button();
            this.openFileDialogImage = new System.Windows.Forms.OpenFileDialog();
            this.panelButton.SuspendLayout();
            this.panelPrincipal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.textOrden)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureImagen)).BeginInit();
            this.SuspendLayout();
            // 
            // panelButton
            // 
            this.panelButton.Location = new System.Drawing.Point(0, 597);
            this.panelButton.Size = new System.Drawing.Size(770, 61);
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(555, 5);
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancelar.Location = new System.Drawing.Point(660, 5);
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // panelPrincipal
            // 
            this.panelPrincipal.Controls.Add(this.btnDelImage);
            this.panelPrincipal.Controls.Add(this.labImagen);
            this.panelPrincipal.Controls.Add(this.btnLoadImage);
            this.panelPrincipal.Controls.Add(this.pictureImagen);
            this.panelPrincipal.Controls.Add(this.textDescripcion);
            this.panelPrincipal.Controls.Add(this.textOrden);
            this.panelPrincipal.Controls.Add(this.labOrden);
            this.panelPrincipal.Controls.Add(this.labDetalle);
            this.panelPrincipal.Size = new System.Drawing.Size(770, 658);
            // 
            // labDetalle
            // 
            this.labDetalle.AutoSize = true;
            this.labDetalle.Location = new System.Drawing.Point(28, 61);
            this.labDetalle.Name = "labDetalle";
            this.labDetalle.Size = new System.Drawing.Size(43, 13);
            this.labDetalle.TabIndex = 0;
            this.labDetalle.Text = "Detalle:";
            // 
            // labOrden
            // 
            this.labOrden.AutoSize = true;
            this.labOrden.Location = new System.Drawing.Point(28, 31);
            this.labOrden.Name = "labOrden";
            this.labOrden.Size = new System.Drawing.Size(39, 13);
            this.labOrden.TabIndex = 1;
            this.labOrden.Text = "Orden:";
            // 
            // textOrden
            // 
            this.textOrden.Location = new System.Drawing.Point(91, 28);
            this.textOrden.Name = "textOrden";
            this.textOrden.Size = new System.Drawing.Size(69, 20);
            this.textOrden.TabIndex = 2;
            // 
            // textDescripcion
            // 
            this.textDescripcion.Location = new System.Drawing.Point(91, 61);
            this.textDescripcion.Multiline = true;
            this.textDescripcion.Name = "textDescripcion";
            this.textDescripcion.Size = new System.Drawing.Size(640, 135);
            this.textDescripcion.TabIndex = 3;
            // 
            // pictureImagen
            // 
            this.pictureImagen.Location = new System.Drawing.Point(91, 211);
            this.pictureImagen.Name = "pictureImagen";
            this.pictureImagen.Size = new System.Drawing.Size(640, 360);
            this.pictureImagen.TabIndex = 4;
            this.pictureImagen.TabStop = false;
            this.pictureImagen.Click += new System.EventHandler(this.pictureImagen_Click);
            // 
            // btnLoadImage
            // 
            this.btnLoadImage.Image = global::redTaller.Properties.Resources.subir;
            this.btnLoadImage.Location = new System.Drawing.Point(49, 535);
            this.btnLoadImage.Name = "btnLoadImage";
            this.btnLoadImage.Size = new System.Drawing.Size(36, 36);
            this.btnLoadImage.TabIndex = 5;
            this.btnLoadImage.UseVisualStyleBackColor = true;
            this.btnLoadImage.Click += new System.EventHandler(this.btnLoadImage_Click);
            // 
            // labImagen
            // 
            this.labImagen.AutoSize = true;
            this.labImagen.Location = new System.Drawing.Point(28, 211);
            this.labImagen.Name = "labImagen";
            this.labImagen.Size = new System.Drawing.Size(45, 13);
            this.labImagen.TabIndex = 6;
            this.labImagen.Text = "Imagen:";
            // 
            // btnDelImage
            // 
            this.btnDelImage.Image = global::redTaller.Properties.Resources.borrar;
            this.btnDelImage.Location = new System.Drawing.Point(49, 493);
            this.btnDelImage.Name = "btnDelImage";
            this.btnDelImage.Size = new System.Drawing.Size(36, 36);
            this.btnDelImage.TabIndex = 7;
            this.btnDelImage.UseVisualStyleBackColor = true;
            this.btnDelImage.Click += new System.EventHandler(this.btnDelImage_Click);
            // 
            // openFileDialogImage
            // 
            this.openFileDialogImage.FileName = "openFileDialogImage";
            // 
            // VistaFormActuacionDetalle
            // 
            this.AcceptButton = this.btnAceptar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.CancelButton = this.btnCancelar;
            this.ClientSize = new System.Drawing.Size(770, 658);
            this.Name = "VistaFormActuacionDetalle";
            this.panelButton.ResumeLayout(false);
            this.panelPrincipal.ResumeLayout(false);
            this.panelPrincipal.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.textOrden)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureImagen)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.NumericUpDown textOrden;
        private System.Windows.Forms.Label labOrden;
        private System.Windows.Forms.Label labDetalle;
        private System.Windows.Forms.TextBox textDescripcion;
        private System.Windows.Forms.PictureBox pictureImagen;
        private System.Windows.Forms.Button btnLoadImage;
        private System.Windows.Forms.Label labImagen;
        private System.Windows.Forms.Button btnDelImage;
        private System.Windows.Forms.OpenFileDialog openFileDialogImage;
    }
}
