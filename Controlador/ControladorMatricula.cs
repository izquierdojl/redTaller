using redTaller.Database;
using redTaller.Modelo;
using redTaller.Vista.VistaCliente;
using redTaller.Vista.VistaMatricula;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace redTaller.Controlador
{
    internal class ControladorMatricula
    {
    
        private MatriculaDB matriculaDB;

        public ControladorMatricula()
        {
            matriculaDB = new MatriculaDB();    
        }

        public Matricula Id(int id)
        {
            return matriculaDB.CargaElemento(id);
        }

        public void nuevo(Matricula matricula)
        {
            VistaFormMatricula vistaFormMatricula = new VistaFormMatricula(1, matricula);
            vistaFormMatricula.ShowDialog();
        }

        public void guardar(Matricula matricula, int modo )
        {
            if (modo == 1)
            {
                matriculaDB.insert(matricula);
            }
            else
            {
                matriculaDB.update(matricula);
            }
        }

        public List<string> loadMarcas()
        {
            return matriculaDB.distinctMarcas();
        }

        public List<string> loadModelos( string marca )
        {
            return matriculaDB.distinctModelos(marca);
        }

    }

}
