using System;

namespace redTaller.Modelo
{
    public class CodigoPostal
    {

        private string codigo;
        private string nombre;
        private Provincia provincia;

        public CodigoPostal() { }
        
        /// <summary>
        /// Constructor de Códigos Postales
        /// </summary>
        /// <param name="codigo">Código de Provincia</param>
        /// <param name="nombre">Nombre</param>
        public CodigoPostal(string codigo, string nombre, Provincia provincia)
        {
            this.Codigo = codigo;
            this.Nombre = nombre;
            this.Provincia = provincia;
        }

        public string Codigo { get => codigo; set => codigo = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public Provincia Provincia { get => provincia; set => provincia = value; }
    }

}
