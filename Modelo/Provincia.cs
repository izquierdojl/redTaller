using System;

namespace redTaller.Modelo
{
    public class Provincia
    {

        public string codigo { get; set; }
        public string nombre {  get; set; }
        public int id { get; set; }

        public Provincia() { }
        
        /// <summary>
        /// Constructor de Provincia
        /// </summary>
        /// <param name="codigo">Código de Provincia</param>
        /// <param name="nombre">Nombre</param>
        public Provincia(string codigo, string nombre)
        {
            this.codigo = codigo;
            this.nombre = nombre;
        }

        public Provincia(string codigo)
        {
            this.codigo = codigo;
        }

    }

}
