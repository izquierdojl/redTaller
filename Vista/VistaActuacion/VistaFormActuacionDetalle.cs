using redTaller.Controlador;
using redTaller.Database;
using redTaller.Modelo;
using System;
using System.IO;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace redTaller.Vista.VistaActuacion
{
    public partial class VistaFormActuacionDetalle : redTaller.Vista.VistaBase.VistaFormBase
    {

        int modo; // modo de edición 1 - Añadir  2 - Editar  3 - Consultar

        int idActuacion;
        VistaFormActuacion vista;
        ActuacionDetalle actuacionDetalle;
        ControladorActuacion controlador = new ControladorActuacion();

        public VistaFormActuacionDetalle( VistaFormActuacion vista, int modo, int idActuacion, ActuacionDetalle actuacionDetalle )
        {
            InitializeComponent();
            this.vista = vista;
            this.idActuacion = idActuacion;
            this.modo = modo;
            this.actuacionDetalle = actuacionDetalle;
            if (modo == 1)
            {
                Text = "Nuevo Detalle Actuacion";
            }
            else
            {
                Text = "Detalle Línea de Actuación";
            }

            if (modo > 1)
            {
                textOrden.Value = actuacionDetalle.linea;
                textDescripcion.Text = actuacionDetalle.descripcion;
                if (actuacionDetalle.imagen != null)
                {
                    using (MemoryStream ms = new MemoryStream(actuacionDetalle.imagen))
                    {
                        pictureImagen.Image = System.Drawing.Image.FromStream(ms);
                    }
                }
            }

        }

        private void loadImage()
        {
            if (openFileDialogImage.ShowDialog() == DialogResult.OK)
            {
                pictureImagen.Load(openFileDialogImage.FileName);
            }
        }

        private void btnDelImage_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿ Seguro de eliminar la imagen ?", "Limpiar Imagen", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                pictureImagen.Image = null;
            }
        }

        private void btnLoadImage_Click(object sender, EventArgs e)
        {
            loadImage();
        }

        private void pictureImagen_Click(object sender, EventArgs e)
        {
            loadImage();
        }

        private void guardarActuacionDetalle()
        {
            actuacionDetalle.id_actuacion = idActuacion;
            actuacionDetalle.linea = (int)textOrden.Value;   
            actuacionDetalle.descripcion = textDescripcion.Text;
            if (pictureImagen.Image != null)
            { 
                using (MemoryStream ms = new MemoryStream())
                {
                    pictureImagen.Image.Save(ms, pictureImagen.Image.RawFormat);
                    actuacionDetalle.imagen = ms.ToArray();
                }
            }
            controlador.guardarDetalle(actuacionDetalle, modo, vista, this);
            Close();
            ActuacionDB db = new ActuacionDB();
            vista.recargaGridActuacionDetalle( db.LoadDetalle(vista.actuacion) , actuacionDetalle.linea );
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            guardarActuacionDetalle();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }

}

