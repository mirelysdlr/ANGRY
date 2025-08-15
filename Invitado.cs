using System;
using System.Collections.Generic;

namespace organizadordeventos.Infrastructure.Models;

    public class Invitado
    {
        public int Id { get; set; }
        public int EventoId { get; set; }
        public string Nombre { get; set; }
        public string Telefono { get; set; }
        public string? Correo { get; set; }
        public string? Relacion { get; set; }
    }

