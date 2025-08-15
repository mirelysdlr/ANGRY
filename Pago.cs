using organizadordeventos.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventiaSolution.Domain.Entities
{
    public class Pago
    {
        public int Id { get; set; }
        public decimal Monto { get; set; }
        public DateTime Fecha { get; set; }
        public string MetodoPago { get; set; }
        public string Estado { get; set; } // Pagado, Pendiente, Fallido

        public int AsistenteId { get; set; }
        public Asistente Asistente { get; set; }

        public int EventoId { get; set; }
        public Evento Evento { get; set; }
    }

}
