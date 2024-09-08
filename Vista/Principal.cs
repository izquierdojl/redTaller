using redTaller.Controlador;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace redTaller
{
    public partial class Principal : Form
    {

        ControladorProvincia contProvincia = new ControladorProvincia();

        public Principal()
        {
            InitializeComponent();
        }

        private void menuFicherosProvincias_Click(object sender, EventArgs e)
        {
            contProvincia.mostrar(this);
        }
    }
}
