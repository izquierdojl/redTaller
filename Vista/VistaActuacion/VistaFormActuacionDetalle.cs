﻿using Org.BouncyCastle.Utilities;
using redTaller.Controlador;
using redTaller.Database;
using redTaller.Modelo;
using System;
using System.Drawing;
using System.IO;
using System.Windows.Controls;
using System.Windows.Forms;

namespace redTaller.Vista.VistaActuacion
{
    public partial class VistaFormActuacionDetalle : redTaller.Vista.VistaBase.VistaFormBase
    {

        int modo; // modo de edición 1 - Añadir  2 - Editar  3 - Consultar

        int idActuacion;
        VistaFormActuacion vista;
        ActuacionDetalle actuacionDetalle;
        ControladorActuacion controlador = new ControladorActuacion();
        bool actualizaImagen;

        public VistaFormActuacionDetalle( VistaFormActuacion vista, int modo, int idActuacion, ActuacionDetalle actuacionDetalle )
        {
            InitializeComponent();
            this.vista = vista;
            this.idActuacion = idActuacion;
            this.modo = modo;
            this.actuacionDetalle = actuacionDetalle;
            this.actualizaImagen = false;
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
                    string base64String = System.Text.Encoding.UTF8.GetString(actuacionDetalle.imagen);
                    byte[] imageBytes = Convert.FromBase64String(base64String);
                    using (var ms = new MemoryStream(imageBytes))
                    {
                        pictureImagen.Image = System.Drawing.Image.FromStream(ms);
                    }
                }
            }
            else
            {
                textOrden.Value = controlador.maxLinea(vista.actuacion) + 1;
            }

        }

        private void loadImage()
        {
            openFileDialogImage.Filter = "Archivos de Imagen|*.bmp;*.jpg;*.jpeg;*.png;*.gif";
            openFileDialogImage.Title = "Seleccionar una Imagen";

            if (openFileDialogImage.ShowDialog() == DialogResult.OK)
            {
                pictureImagen.Load(openFileDialogImage.FileName);
                actualizaImagen = true;
            }
        }

        private void btnDelImage_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿ Seguro de eliminar la imagen ?", "Limpiar Imagen", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                pictureImagen.Image = null;
                actuacionDetalle.imagen = null;
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
            if (actualizaImagen && pictureImagen.Image != null)
            { 
                using (MemoryStream ms = new MemoryStream())
                {
                    ms.SetLength(0);
                    pictureImagen.Image.Save(ms, pictureImagen.Image.RawFormat);
                    actuacionDetalle.imagen = System.Text.Encoding.UTF8.GetBytes(Convert.ToBase64String(ms.ToArray()));
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

        private void textOrden_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            bool valido = false;
            if (textOrden.Value > 0)
            {
                if( !controlador.existeLinea( vista.actuacion, (int)textOrden.Value ))
                {
                    valido = true;
                }
                else
                {
                    if( modo == 2 ) // editando, si no cambia la línea, es válido
                    {
                        if( (int)textOrden.Value == actuacionDetalle.linea )
                            valido = true;
                    }
                }

            }
            if( !valido )
                textOrden.Focus();
        }
    }

}

