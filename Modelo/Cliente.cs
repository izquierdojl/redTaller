
namespace redTaller.Modelo
{
    /// <summary>
    /// Clase Taller
    /// </summary>
    public class Cliente
    {
        public string nif { get; set; }
        public string nombre { get; set; }
        public string domicilio { get; set; }
        public string cp { get; set; }
        public string pob { get; set; }
        public string pro { get; set; }
        public string tel { get; set; }
        public string email { get; set; }
        public string movil { get; set; }
        public byte[] password { get; set; }
        public bool activo { get; set; }
        public bool bloqueado { get; set; }
        public Taller nif_taller_alta { get; set; }
        public int id { get; set; }

        public Cliente() { }

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
