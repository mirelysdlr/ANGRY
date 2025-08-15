using organizadordeventos.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventiaSolution.Domain.Entities
{
    public class Proveedor
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string TipoServicio { get; set; } // Catering, Sonido, Decoración
        public string Contacto { get; set; }
        public bool Disponible { get; set; }

        public ICollection<Evento> Eventos { get; set; }
    }
}
