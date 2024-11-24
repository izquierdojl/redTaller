
namespace redTaller.Modelo
{
    public class ActuacionDetalle
    {
        public int id { get; set; }
        public int id_actuacion { get; set; }
        public int linea { get; set; }
        public string descripcion { get; set; }
        public byte[] imagen { get; set; }

        public ActuacionDetalle()
        {
        }

        public ActuacionDetalle(int id, int id_actuacion, int orden, string descripcion, byte[] imagen)
        {
            this.id = id;
            this.id_actuacion = id_actuacion;
            this.linea = orden; 
            this.descripcion = descripcion;
            this.imagen = imagen;
        }

    }
}
