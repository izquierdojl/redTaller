using System;
using System.Collections.Generic;

namespace redTaller.Modelo
{
    public class Actuacion
    {

        public int id { get; set; }
        public Taller taller { get; set; }
        public Cliente cliente { get; set; }
        public Matricula matricula { get; set; }
        public DateTime fecha { get; set; }
        public int km { get; set; }
        public string tipo { get; set; }
        public List<ActuacionDetalle> actuacionDetalle { get; set; }

        public Actuacion()
        {
        }

        public Actuacion(int id, Taller taller, Cliente cliente, Matricula matricula, DateTime fecha, string tipo, int km, List<ActuacionDetalle> actuacionDetalle)
        {
            this.id = id;
            this.taller = taller;
            this.cliente = cliente;
            this.matricula = matricula;
            this.fecha = fecha;
            this.tipo = tipo;
            this.km = km;
            this.actuacionDetalle = actuacionDetalle;
        }

    }

}
