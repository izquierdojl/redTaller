using System;

namespace redTaller.Modelo
{
    public class Provincia
    {

        private String codigo;
        private String nombre;

        public Provincia() { }
        
        /// <summary>
        /// Constructor de Provincia
        /// </summary>
        /// <param name="codigo">Código de Provincia</param>
        /// <param name="nombre">Nombre</param>
        public Provincia(string codigo, string nombre)
        {
            this.Codigo = codigo;
            this.Nombre = nombre;
        }

        public string Codigo { get => codigo; set => codigo = value; }
        public string Nombre { get => nombre; set => nombre = value; }

    }

}
