using System;

namespace redTaller.Modelo
{
    public class CodigoPostal
    {

        private String codigo;
        private String nombre;

        public CodigoPostal() { }
        
        /// <summary>
        /// Constructor de Códigos Postales
        /// </summary>
        /// <param name="codigo">Código de Provincia</param>
        /// <param name="nombre">Nombre</param>
        public CodigoPostal(string codigo, string nombre)
        {
            this.Codigo = codigo;
            this.Nombre = nombre;
        }

        public string Codigo { get => codigo; set => codigo = value; }
        public string Nombre { get => nombre; set => nombre = value; }

    }

}
