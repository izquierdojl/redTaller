using System;

namespace redTaller.Modelo
{
    public class CodigoPostal
    {
        public int id { get; set; }
        public string codigo { get; set; }
        public string nombre { get; set; }
        public Provincia provincia { get; set; }

        public CodigoPostal() { }

        /// <summary>
        /// Constructor de Códigos Postales
        /// </summary>
        /// <param name="codigo">Código de Provincia</param>
        /// <param name="nombre">Nombre</param>
        public CodigoPostal(string codigo, string nombre, Provincia provincia)
        {
            this.codigo = codigo;
            this.nombre = nombre;
            this.provincia = provincia;
        }
    }
}
