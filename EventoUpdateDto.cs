using System;
using System.ComponentModel.DataAnnotations;

namespace organizadordeventos.Domain.DTOs
{
    public class EventoUpdateDto
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public DateTime Fecha { get; set; }
        public string Lugar { get; set; }
        public string Ubicacion { get; set; }
        public string Color { get; set; }
        public string Descripcion { get; set; }

    }
}