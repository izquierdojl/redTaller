﻿namespace redTaller
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
            this.menuFicherosTalleres = new System.Windows.Forms.ToolStripMenuItem();
            this.menuFicherosClientes = new System.Windows.Forms.ToolStripMenuItem();
            this.menuFicherosProvincias = new System.Windows.Forms.ToolStripMenuItem();
            this.menuFicherosCodigosPostales = new System.Windows.Forms.ToolStripMenuItem();
            this.barStatus = new System.Windows.Forms.StatusStrip();
            this.barLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.menuHerramientas = new System.Windows.Forms.ToolStripMenuItem();
            this.menuConfiguración = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.menuFicheros.SuspendLayout();
            this.barStatus.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuFicheros
            // 
            this.menuFicheros.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ficherosToolStripMenuItem,
            this.menuHerramientas});
            this.menuFicheros.Location = new System.Drawing.Point(0, 0);
            this.menuFicheros.Name = "menuFicheros";
            this.menuFicheros.Padding = new System.Windows.Forms.Padding(9, 3, 0, 3);
            this.menuFicheros.Size = new System.Drawing.Size(1924, 25);
            this.menuFicheros.TabIndex = 1;
            this.menuFicheros.Text = "menuStrip1";
            // 
            // ficherosToolStripMenuItem
            // 
            this.ficherosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuFicherosTalleres,
            this.menuFicherosClientes,
            this.toolStripSeparator1,
            this.menuFicherosProvincias,
            this.menuFicherosCodigosPostales});
            this.ficherosToolStripMenuItem.Name = "ficherosToolStripMenuItem";
            this.ficherosToolStripMenuItem.ShowShortcutKeys = false;
            this.ficherosToolStripMenuItem.Size = new System.Drawing.Size(63, 19);
            this.ficherosToolStripMenuItem.Text = "Ficheros";
            // 
            // menuFicherosTalleres
            // 
            this.menuFicherosTalleres.Name = "menuFicherosTalleres";
            this.menuFicherosTalleres.Size = new System.Drawing.Size(222, 22);
            this.menuFicherosTalleres.Text = "Fichero de Talleres";
            this.menuFicherosTalleres.Click += new System.EventHandler(this.menuFicherosTalleres_Click);
            // 
            // menuFicherosClientes
            // 
            this.menuFicherosClientes.Name = "menuFicherosClientes";
            this.menuFicherosClientes.Size = new System.Drawing.Size(222, 22);
            this.menuFicherosClientes.Text = "Fichero de &Clientes";
            this.menuFicherosClientes.Click += new System.EventHandler(this.menuFicherosClientes_Click);
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
            this.barStatus.Location = new System.Drawing.Point(0, 960);
            this.barStatus.Name = "barStatus";
            this.barStatus.Padding = new System.Windows.Forms.Padding(2, 0, 21, 0);
            this.barStatus.Size = new System.Drawing.Size(1924, 22);
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
            // menuHerramientas
            // 
            this.menuHerramientas.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuConfiguración});
            this.menuHerramientas.Name = "menuHerramientas";
            this.menuHerramientas.Size = new System.Drawing.Size(90, 19);
            this.menuHerramientas.Text = "Herramientas";
            // 
            // menuConfiguración
            // 
            this.menuConfiguración.Name = "menuConfiguración";
            this.menuConfiguración.Size = new System.Drawing.Size(180, 22);
            this.menuConfiguración.Text = "Configuración";
            this.menuConfiguración.Click += new System.EventHandler(this.menuConfiguración_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(219, 6);
            // 
            // Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1924, 982);
            this.Controls.Add(this.barStatus);
            this.Controls.Add(this.menuFicheros);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuFicheros;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
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
        private System.Windows.Forms.ToolStripMenuItem menuFicherosTalleres;
        private System.Windows.Forms.ToolStripMenuItem menuFicherosClientes;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem menuHerramientas;
        private System.Windows.Forms.ToolStripMenuItem menuConfiguración;
    }
}

