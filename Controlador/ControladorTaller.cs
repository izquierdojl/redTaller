using redTaller.Database;
using redTaller.Database.Util;
using redTaller.Modelo;
using redTaller.Util;
using redTaller.Vista.VistaTaller;
using redTaller.Vista.VistaUtil;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace redTaller.Controlador
{
    internal class ControladorTaller
    {
        private TallerDB tallerDB;

        public ControladorTaller()
        {
            this.tallerDB = new TallerDB();
        }

        public void mostrar(Form parent)
        {
            VistaListaTaller vistaListaTaller = new VistaListaTaller(tallerDB.Load(), tallerDB.dc);
            vistaListaTaller.MdiParent = parent;
            vistaListaTaller.Show();
        }

        public void buscar(VistaListaTaller vistaListaTaller, string filtro, string campo)
        {

            Dictionary<string, object> filtros = new Dictionary<string, object>();
            filtros.Add(vistaListaTaller.comboSearch.SelectedValue.ToString(), vistaListaTaller.textSearch.Text);  // Filtro
            vistaListaTaller.recargaGrid(tallerDB.Load(filtros));
        }

        public void nuevo(VistaListaTaller vistaListaTaller)
        {
            VistaFormTaller vistaFormTaller = new VistaFormTaller(vistaListaTaller, 1, new Taller());
            vistaFormTaller.ShowDialog();
        }

        public void modificar(VistaListaTaller vistaListaTaller, int id)
        {
            Taller taller = tallerDB.CargaElemento(id);
            if (taller != null)
            {
                VistaFormTaller vistaFormTaller = new VistaFormTaller(vistaListaTaller, 2, taller);
                vistaFormTaller.ShowDialog();
            }
        }

        public void borrar(VistaListaTaller vistaListaTaller, List<int> ids)
        {
            if (tallerDB.delete(ids) > 0)
            {
                VistaUtil.MsgInfo("Se ha borrado " + ids.Count.ToString() + " registro(s)", "Información");
            }
            else
            {
                VistaUtil.MsgInfo("No se han podido borrar", "Información");
            }
        }


        public void guardar(Taller taller, int modo, VistaListaTaller vistaListaTaller)
        {
            if (modo == 1)
            {
                tallerDB.insert(taller);
            }
            else
            {
                tallerDB.update(taller);
            }
            if (string.IsNullOrEmpty(vistaListaTaller.textSearch.Text))
            {
                vistaListaTaller.recargaGrid(tallerDB.Load(null), taller.id);
            }
            else
            {
                Dictionary<string, object> filtros = new Dictionary<string, object>();
                filtros.Add(vistaListaTaller.comboSearch.SelectedValue.ToString(), vistaListaTaller.textSearch.Text);  // Filtro
                vistaListaTaller.recargaGrid(tallerDB.Load(filtros), taller.id);
            }
        }


        public bool valida(string key)
        {
            return tallerDB.ValidaKey(key);
        }

        public void asignaCodigoPostal(VistaFormTaller vistaFormTaller)
        {
            CodigoPostalDB db = new CodigoPostalDB();
            CodigoPostal codigoPostal = db.CargaElemento(0, vistaFormTaller.textCp.Text);
            if (codigoPostal != null)
            {
                if( string.IsNullOrEmpty( vistaFormTaller.textPoblacion.Text ) )
                    vistaFormTaller.textPoblacion.Text = codigoPostal.nombre;
                if (string.IsNullOrEmpty(vistaFormTaller.textProvincia.Text))
                    vistaFormTaller.textProvincia.Text = codigoPostal.provincia.nombre;
            }

        }

        public void enviaCorreoActivacion(Taller taller)
        {
            TallerDB db = new TallerDB();
            string randomPassword = Password.RandomPassword(8);
            taller.password = Encoding.UTF8.GetBytes(randomPassword);
            if (db.updateActivacion(taller) > 0)
            {
                Email email = new Email();
                string body = $@"
                                Taller : {taller.nombre} 
                                A continuación, se le envía la contraseña para poder acceder a la aplicación REDTALLER
                                Contraseña:
                                {randomPassword}
                                La primera vez que acceda, se le solicitará que la cambie por una privada.
                                Atentamente,
                                ";

                if (email.EnviarEmail(taller.email, "REDTALLER - Activación de Cuenta", body))
                {
                    VistaUtil.MsgInfo("Mensaje enviado correctamente", "Envío correcto");
                }
                else
                {
                    VistaUtil.MsgInfo("No se ha podido realizar el envío del correo electrónico, inténtelo en unos instantes.", "Envio incorrecto");
                }

            }

        }

        public void activa(Taller taller)
        {

        }

    }

}
