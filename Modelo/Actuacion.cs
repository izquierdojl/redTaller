using System;

namespace redTaller.Modelo
{
    internal class Actuacion
    {

        public int id { get; set; }
        public Taller taller { get; set; }
        public Cliente cliente { get; set; }
        public Matricula matricula { get; set; }
        public DateTime fecha { get; set; }
        public int km { get; set; }

        public Actuacion()
        {
        }

        public Actuacion(int id, Taller taller, Cliente cliente, Matricula matricula, DateTime fecha, int km)
        {
            this.id = id;
            this.taller = taller;
            this.cliente = cliente;
            this.matricula = matricula;
            this.fecha = fecha;
            this.km = km;
        }

    }

}
