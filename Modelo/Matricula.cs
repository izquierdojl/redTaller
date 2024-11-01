using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace redTaller.Modelo
{
    internal class Matricula
    {
        public string codigo { get; set; }
        public string marca { get; set; }
        public string modelo { get; set; }
        public byte[] imagen { get; set; }
        public int id { get; set; }

        public Matricula()
        {
            this.codigo = codigo;
        }

        public Matricula(string codigo)
        {
            this.codigo = codigo;
        }

        public Matricula(string codigo, string marca, string modelo, byte[] imagen, int id)
        {
            this.codigo = codigo;
            this.marca = marca;
            this.modelo = modelo;
            this.imagen = imagen;
            this.id = id;
        }

    }
}
