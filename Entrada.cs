using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventiaSolution.Domain.Entities
{
    public class Entrada
    {
        public int Id { get; set; }
        public string Tipo { get; set; } // General, VIP
        public decimal Precio { get; set; }
        public string Codigo { get; set; }
        public string Estado { get; set; } // Disponible, Usado

        public int AsistenteEventoEventoId { get; set; }
        public int AsistenteEventoAsistenteId { get; set; }
        public AsistenteEvento AsistenteEvento { get; set; }
    }

}
