namespace redTaller.Modelo
{
    /// <summary>
    /// Representa un cliente del sistema, incluyendo información personal, de contacto y estado.
    /// </summary>
    public class Cliente
    {
        /// <summary>Identificador fiscal del cliente (NIF).</summary>
        public string nif { get; set; }

        /// <summary>Nombre completo del cliente.</summary>
        public string nombre { get; set; }

        /// <summary>Domicilio del cliente.</summary>
        public string domicilio { get; set; }

        /// <summary>Código postal del domicilio del cliente.</summary>
        public string cp { get; set; }

        /// <summary>Población del cliente.</summary>
        public string pob { get; set; }

        /// <summary>Provincia del cliente.</summary>
        public string pro { get; set; }

        /// <summary>Teléfono fijo del cliente.</summary>
        public string tel { get; set; }

        /// <summary>Correo electrónico del cliente.</summary>
        public string email { get; set; }

        /// <summary>Teléfono móvil del cliente.</summary>
        public string movil { get; set; }

        /// <summary>Contraseña del cliente en formato de arreglo de bytes.</summary>
        public byte[] password { get; set; }

        /// <summary>Indica si el cliente está activo.</summary>
        public bool activo { get; set; }

        /// <summary>Indica si el cliente está bloqueado.</summary>
        public bool bloqueado { get; set; }

        /// <summary>Taller donde se dio de alta el cliente.</summary>
        public Taller nif_taller_alta { get; set; }

        /// <summary>Identificador único del cliente.</summary>
        public int id { get; set; }

        /// <summary>
        /// Inicializa una nueva instancia vacía de la clase Cliente.
        /// </summary>
        public Cliente() { }

        /// <summary>
        /// Inicializa una nueva instancia de la clase Cliente con todos sus datos.
        /// </summary>
        /// <param name="nif">NIF del cliente.</param>
        /// <param name="nombre">Nombre del cliente.</param>
        /// <param name="domicilio">Domicilio del cliente.</param>
        /// <param name="cp">Código postal.</param>
        /// <param name="pob">Población.</param>
        /// <param name="pro">Provincia.</param>
        /// <param name="tel">Teléfono fijo.</param>
        /// <param name="email">Correo electrónico.</param>
        /// <param name="movil">Teléfono móvil.</param>
        /// <param name="password">Contraseña en bytes.</param>
        /// <param name="activo">Estado activo.</param>
        /// <param name="bloqueado">Estado bloqueado.</param>
        /// <param name="nif_taller_alta">Taller de alta.</param>
        /// <param name="id">Identificador único.</param>
        public Cliente(string nif, string nombre, string domicilio, string cp, string pob, string pro, string tel, string email, string movil, byte[] password, bool activo, bool bloqueado, Taller nif_taller_alta, int id)
        {
            this.nif = nif;
            this.nombre = nombre;
            this.domicilio = domicilio;
            this.cp = cp;
            this.pob = pob;
            this.pro = pro;
            this.tel = tel;
            this.email = email;
            this.movil = movil;
            this.password = password;
            this.activo = activo;
            this.bloqueado = bloqueado;
            this.nif_taller_alta = nif_taller_alta;
            this.id = id;
        }
    }
}
