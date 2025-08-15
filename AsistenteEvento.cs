using organizadordeventos.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventiaSolution.Domain.Entities
{
    public class AsistenteEvento
    {
        public int EventoId { get; set; }
        public Evento Evento { get; set; }

        public int AsistenteId { get; set; }
        public Asistente Asistente { get; set; }

        public string EstadoRegistro { get; set; } // Confirmado, Pendiente, Cancelado
        public Entrada Entrada { get; set; }
    }

}
