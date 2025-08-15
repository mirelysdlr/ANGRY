using organizadordeventos.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventiaSolution.Domain.Entities
{
    public class Ubicacion
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Direccion { get; set; }
        public int Capacidad { get; set; }
        public string Tipo { get; set; } // Salón, Auditorio, Virtual

        public ICollection<Evento> EventiaSolution { get; set; }
    }

}
