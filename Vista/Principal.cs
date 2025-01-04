using redTaller.Controlador;
using redTaller.Util;
using redTaller.Vista.VistaUtil;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls.Primitives;
using System.Windows.Forms;

namespace redTaller
{
    public partial class Principal : Form
    {

        public Principal()
        {
            InitializeComponent();
            this.FormClosing += new FormClosingEventHandler(PrincipalForm_FormClosing);
            this.Load += new EventHandler(PrincipalForm_Load);
            ConfigurarMenuVentana();
            ConfigurarMenuAcercaDe();
        }

        private void menuFicherosProvincias_Click(object sender, EventArgs e)
        {
            ControladorProvincia controladorProvincia = new ControladorProvincia();
            controladorProvincia.mostrar(this);
        }

        private void menuFicherosCodigosPostales_Click(object sender, EventArgs e)
        {
            ControladorCodigoPostal controladorCodigoPostal = new ControladorCodigoPostal();    
            controladorCodigoPostal.mostrar(this);
        }

        private void menuFicherosTalleres_Click(object sender, EventArgs e)
        {
            ControladorTaller controladorTaller = new ControladorTaller();
            controladorTaller.mostrar(this);
        }

        private void menuFicherosClientes_Click(object sender, EventArgs e)
        {
            ControladorCliente controlladorCliente = new ControladorCliente();
            controlladorCliente.mostrar(this);
        }

        private void menuRegistroActuaciones_Click(object sender, EventArgs e)
        {
            ControladorActuacion controladorActuacion = new ControladorActuacion(); 
            controladorActuacion.mostrar(this);
        }

        private void menuConfiguración_Click(object sender, EventArgs e)
        {
            ControladorConfig controladorConfig = new ControladorConfig(this);
            controladorConfig.mostrar();
        }

        public void ActualizaStatusBarUser(string text)
        {
            this.statusUser.Text = text;
        }

        private void PrincipalForm_Load(object sender, EventArgs e)
        {
            this.statusUser.Text = "Usuario : " + Session.Instance.User;

            if( Session.Instance.Profile == "taller" )
            {
                this.menuConfiguración.Visible = false;
                this.menuFicherosTalleres.Visible = false;
                this.menuFicherosCodigosPostales.Visible = false;
                this.menuFicherosProvincias.Visible = false;
                this.menuHerramientas.Visible = false;
                this.toolStripBtnTaller.Visible = false;
            }

        }

        private void ConfigurarMenuVentana()
        {

            ToolStripMenuItem menuVentana = new ToolStripMenuItem("&Ventana");

            ToolStripMenuItem menuCascada = new ToolStripMenuItem("&Cascada", null, new EventHandler(MenuCascada_Click));
            ToolStripMenuItem menuApiladosHorizontal = new ToolStripMenuItem("Apilados &Horizontalmente", null, new EventHandler(MenuApiladosHorizontal_Click));
            ToolStripMenuItem menuApiladosVertical = new ToolStripMenuItem("Apilados &Verticalmente", null, new EventHandler(MenuApiladosVertical_Click));
            ToolStripMenuItem menuMaximizarTodo = new ToolStripMenuItem("Ma&ximizar Todo", null, new EventHandler(MenuMaximizarTodo_Click));
            ToolStripMenuItem menuMinimizarTodo = new ToolStripMenuItem("Mi&nimizar Todo", null, new EventHandler(MenuMinimizarTodo_Click));
            ToolStripMenuItem menuCerrarTodo = new ToolStripMenuItem("&Cerrar Todo", null, new EventHandler(MenuCerrarTodo_Click));
            ToolStripMenuItem menuSalir = new ToolStripMenuItem("&Salir", null, new EventHandler(MenuSalir_Click));

            menuVentana.DropDownItems.Add(menuCascada);
            menuVentana.DropDownItems.Add(menuApiladosHorizontal);
            menuVentana.DropDownItems.Add(menuApiladosVertical);
            menuVentana.DropDownItems.Add(new ToolStripSeparator());
            menuVentana.DropDownItems.Add(menuMaximizarTodo);
            menuVentana.DropDownItems.Add(menuMinimizarTodo);
            menuVentana.DropDownItems.Add(menuCerrarTodo);
            menuVentana.DropDownItems.Add(new ToolStripSeparator());
            menuVentana.DropDownItems.Add(menuSalir);

            menuPrincipal.Items.Add(menuVentana);

        }

        private void ConfigurarMenuAcercaDe()
        {
            ToolStripMenuItem menuAcercaDe = new ToolStripMenuItem("&Acerca de....", null, new EventHandler(menuAcercaDe_Click));
            menuPrincipal.Items.Add(menuAcercaDe);
        }


        private void MenuCascada_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.Cascade);
        }

        private void MenuApiladosHorizontal_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void MenuApiladosVertical_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.TileVertical);
        }

        private void MenuMaximizarTodo_Click(object sender, EventArgs e)
        {
            foreach (Form childForm in this.MdiChildren)
            {
                childForm.WindowState = FormWindowState.Maximized;
            }
        }

        private void MenuMinimizarTodo_Click(object sender, EventArgs e)
        {
            foreach (Form childForm in this.MdiChildren)
            {
                childForm.WindowState = FormWindowState.Minimized;
            }
        }

        private void MenuCerrarTodo_Click(object sender, EventArgs e)
        {
            foreach (Form childForm in this.MdiChildren)
            {
                childForm.Close();
            }
        }

        private void MenuSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void PrincipalForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void toolStripSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void toolStripBtnTaller_Click(object sender, EventArgs e)
        {
            ControladorTaller controladorTaller = new ControladorTaller();
            controladorTaller.mostrar(this);
        }

        private void toolStripCliente_Click(object sender, EventArgs e)
        {
            ControladorCliente controlladorCliente = new ControladorCliente();
            controlladorCliente.mostrar(this);
        }

        private void toolStripActuacion_Click(object sender, EventArgs e)
        {
            ControladorActuacion controladorActuacion = new ControladorActuacion();
            controladorActuacion.mostrar(this);
        }

        private void Principal_Resize(object sender, EventArgs e)
        {

            this.BackgroundImageLayout = ImageLayout.Stretch;
        }

        private void menuAcercaDe_Click(object sender, EventArgs e)
        {
            VistaAcercaDe vistaAcercaDe = new VistaAcercaDe();
            vistaAcercaDe.ShowDialog();
        }
    }

}
