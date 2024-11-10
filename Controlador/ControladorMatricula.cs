using redTaller.Database;
using redTaller.Modelo;
using System;
using System.Collections.Generic;
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

    }

}
