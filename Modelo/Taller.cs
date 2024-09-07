using System;

namespace redTaller.Modelo
{
    /// <summary>
    /// Clase Taller
    /// </summary>
    internal class Taller
    {
        private String nif;
        private String nombre;
        private String domicilio;
        private String codigoPostal;
        private String poblacion;
        private String provincia;
        private String movil;
        private String telefono;
        private String email;
        private String web;

        public Taller()
        {
        }

        /// <summary>
        /// Constructor Taller
        /// </summary>
        /// <param name="nif">Número de Identificación Fiscal</param>
        /// <param name="nombre">Nombre</param>
        /// <param name="domicilio">Domicilio</param>
        /// <param name="codigoPostal">Código Postal</param>
        /// <param name="poblacion">Población</param>
        /// <param name="provincia">Provincia</param>
        /// <param name="movil">Móvil</param>
        /// <param name="telefono">Teléfono</param>
        /// <param name="email">Dirección eMail</param>
        /// <param name="web">URL Web</param>
        public Taller(string nif, string nombre, string domicilio, string codigoPostal, string poblacion, string provincia, string movil, string telefono, string email, string web)
        {
            this.Nif = nif;
            this.Nombre = nombre;
            this.Domicilio = domicilio;
            this.CodigoPostal = codigoPostal;
            this.Poblacion = poblacion;
            this.Provincia = provincia;
            this.Movil = movil;
            this.Telefono = telefono;
            this.Email = email;
            this.Web = web;
        }

        public string Nif { get => nif; set => nif = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Domicilio { get => domicilio; set => domicilio = value; }
        public string CodigoPostal { get => codigoPostal; set => codigoPostal = value; }
        public string Poblacion { get => poblacion; set => poblacion = value; }
        public string Provincia { get => provincia; set => provincia = value; }
        public string Movil { get => movil; set => movil = value; }
        public string Telefono { get => telefono; set => telefono = value; }
        public string Email { get => email; set => email = value; }
        public string Web { get => web; set => web = value; }

    }

}
