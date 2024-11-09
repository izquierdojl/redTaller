
namespace redTaller.Modelo
{
    internal class ActuacionDetalle
    {
        public int id { get; set; }
        public string id_reparacion { get; set; }
        public string descripcion { get; set; }
        public byte[] imagen { get; set; }
        public ActuacionDetalle(int id, string id_reparacion, string descripcion, byte[] imagen)
        {
            this.id = id;
            this.id_reparacion = id_reparacion;
            this.descripcion = descripcion;
            this.imagen = imagen;
        }

    }
}
