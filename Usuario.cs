﻿using organizadordeventos.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventiaSolution.Domain.Entities
{
    public class Usuario
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Correo { get; set; }
        public string Contraseña { get; set; }
        public string Telefono { get; set; }
        public string TipoUsuario { get; set; } // Organizador, Asistente, Administrador

        public ICollection<Evento> EventiaSolution{ get; set; }
    }

}
