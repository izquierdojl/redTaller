using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace redTaller.Modelo
{
    public class Matricula
    {
        public string matricula { get; set; }
        public string marca { get; set; }
        public string modelo { get; set; }
        public int id { get; set; }

        public Matricula()
        {
        }

        public Matricula(string matricula)
        {
            this.matricula = matricula;
        }

        public Matricula(string matricula, string marca, string modelo, int id)
        {
            this.matricula = matricula;
            this.marca = marca;
            this.modelo = modelo;
            this.id = id;
        }

    }
}
