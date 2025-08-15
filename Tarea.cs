using organizadordeventos.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventiaSolution.Domain.Entities
{
    public class Tarea
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public string Responsable { get; set; }
        public DateTime FechaLimite { get; set; }
        public string Estado { get; set; } // Pendiente, En curso, Completada

        public int EventoId { get; set; }
        public Evento Evento { get; set; }
    }

}
