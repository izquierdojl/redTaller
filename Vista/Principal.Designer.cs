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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Principal));
            this.menuPrincipal = new System.Windows.Forms.MenuStrip();
            this.menuFicheros = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.menuActuaciones = new System.Windows.Forms.ToolStripMenuItem();
            this.menuHerramientas = new System.Windows.Forms.ToolStripMenuItem();
            this.barStatus = new System.Windows.Forms.StatusStrip();
            this.statusProgram = new System.Windows.Forms.ToolStripStatusLabel();
            this.statusUser = new System.Windows.Forms.ToolStripStatusLabel();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.contextMenuStrip2 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripPrincipal = new System.Windows.Forms.ToolStrip();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSalir = new System.Windows.Forms.ToolStripButton();
            this.toolStripBtnTaller = new System.Windows.Forms.ToolStripButton();
            this.toolStripCliente = new System.Windows.Forms.ToolStripButton();
            this.toolStripActuacion = new System.Windows.Forms.ToolStripButton();
            this.menuFicherosTalleres = new System.Windows.Forms.ToolStripMenuItem();
            this.menuFicherosClientes = new System.Windows.Forms.ToolStripMenuItem();
            this.menuFicherosProvincias = new System.Windows.Forms.ToolStripMenuItem();
            this.menuFicherosCodigosPostales = new System.Windows.Forms.ToolStripMenuItem();
            this.menuRegistroActuaciones = new System.Windows.Forms.ToolStripMenuItem();
            this.menuConfiguración = new System.Windows.Forms.ToolStripMenuItem();
            this.menuPrincipal.SuspendLayout();
            this.barStatus.SuspendLayout();
            this.toolStripPrincipal.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuPrincipal
            // 
            this.menuPrincipal.AutoSize = false;
            this.menuPrincipal.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuPrincipal.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuFicheros,
            this.menuActuaciones,
            this.menuHerramientas});
            this.menuPrincipal.Location = new System.Drawing.Point(0, 0);
            this.menuPrincipal.Name = "menuPrincipal";
            this.menuPrincipal.Padding = new System.Windows.Forms.Padding(4, 1, 0, 1);
            this.menuPrincipal.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.menuPrincipal.Size = new System.Drawing.Size(1283, 24);
            this.menuPrincipal.TabIndex = 1;
            // 
            // menuFicheros
            // 
            this.menuFicheros.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuFicherosTalleres,
            this.menuFicherosClientes,
            this.toolStripSeparator1,
            this.menuFicherosProvincias,
            this.menuFicherosCodigosPostales});
            this.menuFicheros.Name = "menuFicheros";
            this.menuFicheros.ShowShortcutKeys = false;
            this.menuFicheros.Size = new System.Drawing.Size(63, 22);
            this.menuFicheros.Text = "Ficheros";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(227, 6);
            // 
            // menuActuaciones
            // 
            this.menuActuaciones.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuRegistroActuaciones});
            this.menuActuaciones.Name = "menuActuaciones";
            this.menuActuaciones.Size = new System.Drawing.Size(84, 22);
            this.menuActuaciones.Text = "&Actuaciones";
            // 
            // menuHerramientas
            // 
            this.menuHerramientas.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuConfiguración});
            this.menuHerramientas.Name = "menuHerramientas";
            this.menuHerramientas.Size = new System.Drawing.Size(90, 22);
            this.menuHerramientas.Text = "&Herramientas";
            // 
            // barStatus
            // 
            this.barStatus.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.barStatus.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.statusProgram,
            this.statusUser});
            this.barStatus.Location = new System.Drawing.Point(0, 606);
            this.barStatus.Name = "barStatus";
            this.barStatus.Size = new System.Drawing.Size(1283, 32);
            this.barStatus.TabIndex = 3;
            this.barStatus.Text = "statusStrip1";
            // 
            // statusProgram
            // 
            this.statusProgram.AutoSize = false;
            this.statusProgram.Name = "statusProgram";
            this.statusProgram.Size = new System.Drawing.Size(150, 27);
            this.statusProgram.Text = "redTaller";
            this.statusProgram.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // statusUser
            // 
            this.statusUser.Name = "statusUser";
            this.statusUser.Size = new System.Drawing.Size(50, 27);
            this.statusUser.Text = "Usuario:";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // contextMenuStrip2
            // 
            this.contextMenuStrip2.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.contextMenuStrip2.Name = "contextMenuStrip2";
            this.contextMenuStrip2.Size = new System.Drawing.Size(61, 4);
            // 
            // toolStripPrincipal
            // 
            this.toolStripPrincipal.ImageScalingSize = new System.Drawing.Size(0, 0);
            this.toolStripPrincipal.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripSalir,
            this.toolStripSeparator2,
            this.toolStripBtnTaller,
            this.toolStripCliente,
            this.toolStripActuacion});
            this.toolStripPrincipal.Location = new System.Drawing.Point(0, 24);
            this.toolStripPrincipal.Name = "toolStripPrincipal";
            this.toolStripPrincipal.Padding = new System.Windows.Forms.Padding(0, 0, 2, 0);
            this.toolStripPrincipal.Size = new System.Drawing.Size(1283, 71);
            this.toolStripPrincipal.Stretch = true;
            this.toolStripPrincipal.TabIndex = 5;
            this.toolStripPrincipal.Text = "toolStripPrincipal";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 71);
            // 
            // toolStripSalir
            // 
            this.toolStripSalir.AutoSize = false;
            this.toolStripSalir.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripSalir.Image = global::redTaller.Properties.Resources.salir;
            this.toolStripSalir.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripSalir.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripSalir.Name = "toolStripSalir";
            this.toolStripSalir.Size = new System.Drawing.Size(64, 68);
            this.toolStripSalir.Text = "Salir";
            this.toolStripSalir.Click += new System.EventHandler(this.toolStripSalir_Click);
            // 
            // toolStripBtnTaller
            // 
            this.toolStripBtnTaller.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripBtnTaller.Image = global::redTaller.Properties.Resources.taller;
            this.toolStripBtnTaller.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripBtnTaller.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripBtnTaller.Name = "toolStripBtnTaller";
            this.toolStripBtnTaller.Size = new System.Drawing.Size(68, 68);
            this.toolStripBtnTaller.Text = "Talleres";
            this.toolStripBtnTaller.Click += new System.EventHandler(this.toolStripBtnTaller_Click);
            // 
            // toolStripCliente
            // 
            this.toolStripCliente.AutoSize = false;
            this.toolStripCliente.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripCliente.Image = global::redTaller.Properties.Resources.cliente;
            this.toolStripCliente.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripCliente.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripCliente.Name = "toolStripCliente";
            this.toolStripCliente.Size = new System.Drawing.Size(64, 68);
            this.toolStripCliente.Text = "Cliente";
            this.toolStripCliente.Click += new System.EventHandler(this.toolStripCliente_Click);
            // 
            // toolStripActuacion
            // 
            this.toolStripActuacion.AutoSize = false;
            this.toolStripActuacion.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripActuacion.Image = global::redTaller.Properties.Resources.reparacion;
            this.toolStripActuacion.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripActuacion.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripActuacion.Name = "toolStripActuacion";
            this.toolStripActuacion.Size = new System.Drawing.Size(64, 68);
            this.toolStripActuacion.Text = "Actuaciones";
            this.toolStripActuacion.Click += new System.EventHandler(this.toolStripActuacion_Click);
            // 
            // menuFicherosTalleres
            // 
            this.menuFicherosTalleres.Image = global::redTaller.Properties.Resources.taller;
            this.menuFicherosTalleres.Name = "menuFicherosTalleres";
            this.menuFicherosTalleres.Size = new System.Drawing.Size(230, 30);
            this.menuFicherosTalleres.Text = "Fichero de Talleres";
            this.menuFicherosTalleres.Click += new System.EventHandler(this.menuFicherosTalleres_Click);
            // 
            // menuFicherosClientes
            // 
            this.menuFicherosClientes.Image = global::redTaller.Properties.Resources.cliente;
            this.menuFicherosClientes.Name = "menuFicherosClientes";
            this.menuFicherosClientes.Size = new System.Drawing.Size(230, 30);
            this.menuFicherosClientes.Text = "Fichero de &Clientes";
            this.menuFicherosClientes.Click += new System.EventHandler(this.menuFicherosClientes_Click);
            // 
            // menuFicherosProvincias
            // 
            this.menuFicherosProvincias.Image = global::redTaller.Properties.Resources.provincia;
            this.menuFicherosProvincias.Name = "menuFicherosProvincias";
            this.menuFicherosProvincias.Size = new System.Drawing.Size(230, 30);
            this.menuFicherosProvincias.Text = "Fichero de &Provincias";
            this.menuFicherosProvincias.Click += new System.EventHandler(this.menuFicherosProvincias_Click);
            // 
            // menuFicherosCodigosPostales
            // 
            this.menuFicherosCodigosPostales.Image = global::redTaller.Properties.Resources.codigo_postal;
            this.menuFicherosCodigosPostales.Name = "menuFicherosCodigosPostales";
            this.menuFicherosCodigosPostales.Size = new System.Drawing.Size(230, 30);
            this.menuFicherosCodigosPostales.Text = "Fichero de Códigos &Postales";
            this.menuFicherosCodigosPostales.Click += new System.EventHandler(this.menuFicherosCodigosPostales_Click);
            // 
            // menuRegistroActuaciones
            // 
            this.menuRegistroActuaciones.Image = global::redTaller.Properties.Resources.reparacion;
            this.menuRegistroActuaciones.Name = "menuRegistroActuaciones";
            this.menuRegistroActuaciones.Size = new System.Drawing.Size(201, 22);
            this.menuRegistroActuaciones.Text = "&Registro de Actuaciones";
            this.menuRegistroActuaciones.Click += new System.EventHandler(this.menuRegistroActuaciones_Click);
            // 
            // menuConfiguración
            // 
            this.menuConfiguración.Image = global::redTaller.Properties.Resources.configuracion;
            this.menuConfiguración.Name = "menuConfiguración";
            this.menuConfiguración.Size = new System.Drawing.Size(150, 22);
            this.menuConfiguración.Text = "Configuración";
            this.menuConfiguración.Click += new System.EventHandler(this.menuConfiguración_Click);
            // 
            // Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(1283, 638);
            this.Controls.Add(this.toolStripPrincipal);
            this.Controls.Add(this.barStatus);
            this.Controls.Add(this.menuPrincipal);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuPrincipal;
            this.Name = "Principal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "redTaller";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Resize += new System.EventHandler(this.Principal_Resize);
            this.menuPrincipal.ResumeLayout(false);
            this.menuPrincipal.PerformLayout();
            this.barStatus.ResumeLayout(false);
            this.barStatus.PerformLayout();
            this.toolStripPrincipal.ResumeLayout(false);
            this.toolStripPrincipal.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuPrincipal;
        private System.Windows.Forms.ToolStripMenuItem menuFicheros;
        private System.Windows.Forms.ToolStripMenuItem menuFicherosProvincias;
        private System.Windows.Forms.ToolStripMenuItem menuFicherosCodigosPostales;
        private System.Windows.Forms.ToolStripStatusLabel statusProgram;
        private System.Windows.Forms.ToolStripMenuItem menuFicherosTalleres;
        private System.Windows.Forms.ToolStripMenuItem menuFicherosClientes;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem menuHerramientas;
        private System.Windows.Forms.ToolStripMenuItem menuConfiguración;
        public System.Windows.Forms.StatusStrip barStatus;
        public System.Windows.Forms.ToolStripStatusLabel statusUser;
        private System.Windows.Forms.ToolStripMenuItem menuActuaciones;
        private System.Windows.Forms.ToolStripMenuItem menuRegistroActuaciones;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip2;
        private System.Windows.Forms.ToolStrip toolStripPrincipal;
        private System.Windows.Forms.ToolStripButton toolStripBtnTaller;
        private System.Windows.Forms.ToolStripButton toolStripSalir;
        private System.Windows.Forms.ToolStripButton toolStripCliente;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton toolStripActuacion;
    }
}

