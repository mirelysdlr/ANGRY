using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventiaSolution.Domain.Entities
{
    public class Asistente
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Correo { get; set; }
        public string Telefono { get; set; }

        public ICollection<AsistenteEvento> EventosRegistrados { get; set; }
        public ICollection<Pago> Pagos { get; set; }
    }

}
