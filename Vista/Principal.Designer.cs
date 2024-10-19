namespace redTaller
{
    partial class Principal
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
            this.menuFicheros = new System.Windows.Forms.MenuStrip();
            this.ficherosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuFicherosProvincias = new System.Windows.Forms.ToolStripMenuItem();
            this.menuFicherosCodigosPostales = new System.Windows.Forms.ToolStripMenuItem();
            this.barStatus = new System.Windows.Forms.StatusStrip();
            this.barLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.menuFicheros.SuspendLayout();
            this.barStatus.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuFicheros
            // 
            this.menuFicheros.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ficherosToolStripMenuItem});
            this.menuFicheros.Location = new System.Drawing.Point(0, 0);
            this.menuFicheros.Name = "menuFicheros";
            this.menuFicheros.Size = new System.Drawing.Size(1476, 24);
            this.menuFicheros.TabIndex = 1;
            this.menuFicheros.Text = "menuStrip1";
            // 
            // ficherosToolStripMenuItem
            // 
            this.ficherosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuFicherosProvincias,
            this.menuFicherosCodigosPostales});
            this.ficherosToolStripMenuItem.Name = "ficherosToolStripMenuItem";
            this.ficherosToolStripMenuItem.ShowShortcutKeys = false;
            this.ficherosToolStripMenuItem.Size = new System.Drawing.Size(63, 20);
            this.ficherosToolStripMenuItem.Text = "Ficheros";
            // 
            // menuFicherosProvincias
            // 
            this.menuFicherosProvincias.Name = "menuFicherosProvincias";
            this.menuFicherosProvincias.Size = new System.Drawing.Size(222, 22);
            this.menuFicherosProvincias.Text = "Fichero de &Provincias";
            this.menuFicherosProvincias.Click += new System.EventHandler(this.menuFicherosProvincias_Click);
            // 
            // menuFicherosCodigosPostales
            // 
            this.menuFicherosCodigosPostales.Name = "menuFicherosCodigosPostales";
            this.menuFicherosCodigosPostales.Size = new System.Drawing.Size(222, 22);
            this.menuFicherosCodigosPostales.Text = "Fichero de Códigos &Postales";
            this.menuFicherosCodigosPostales.Click += new System.EventHandler(this.menuFicherosCodigosPostales_Click);
            // 
            // barStatus
            // 
            this.barStatus.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.barLabel1});
            this.barStatus.Location = new System.Drawing.Point(0, 616);
            this.barStatus.Name = "barStatus";
            this.barStatus.Size = new System.Drawing.Size(1476, 22);
            this.barStatus.TabIndex = 3;
            this.barStatus.Text = "statusStrip1";
            // 
            // barLabel1
            // 
            this.barLabel1.Name = "barLabel1";
            this.barLabel1.Size = new System.Drawing.Size(51, 17);
            this.barLabel1.Text = "redTaller";
            this.barLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1476, 638);
            this.Controls.Add(this.barStatus);
            this.Controls.Add(this.menuFicheros);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuFicheros;
            this.Name = "Principal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "redTaller";
            this.menuFicheros.ResumeLayout(false);
            this.menuFicheros.PerformLayout();
            this.barStatus.ResumeLayout(false);
            this.barStatus.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuFicheros;
        private System.Windows.Forms.ToolStripMenuItem ficherosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem menuFicherosProvincias;
        private System.Windows.Forms.ToolStripMenuItem menuFicherosCodigosPostales;
        private System.Windows.Forms.StatusStrip barStatus;
        private System.Windows.Forms.ToolStripStatusLabel barLabel1;
    }
}

