using EventiaSolution.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace EventiaSolution.Infrastructure.Persistence
{
    public class EventiaDbContext : DbContext
    {
        public EventiaDbContext(DbContextOptions<EventiaDbContext> options)
            : base(options)
        {
        }

        // DbSets para las entidades principales
        public DbSet<Evento> Eventos { get; set; }
        public DbSet<Asistente> Asistentes { get; set; }
        public DbSet<AsistenteEvento> AsistentesEventos { get; set; }
        public DbSet<Entrada> Entradas { get; set; }
        public DbSet<Invitado> Invitados { get; set; }
        public DbSet<Pago> Pagos { get; set; }
        public DbSet<Proveedor> Proveedores { get; set; }
        public DbSet<Tarea> Tareas { get; set; }
        public DbSet<Ubicacion> Ubicaciones { get; set; }
        public DbSet<Usuario> Usuarios { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // Configuraciones adicionales: relaciones, índices, restricciones
            modelBuilder.Entity<AsistenteEvento>()
                .HasKey(ae => new { ae.AsistenteId, ae.EventoId });

            modelBuilder.Entity<AsistenteEvento>()
                .HasOne(ae => ae.Asistente)
                .WithMany(a => a.AsistenteEventos)
                .HasForeignKey(ae => ae.AsistenteId);

            modelBuilder.Entity<AsistenteEvento>()
                .HasOne(ae => ae.Evento)
                .WithMany(e => e.AsistenteEventos)
                .HasForeignKey(ae => ae.EventoId);

            // Ejemplo: índice único en correo de usuario
            modelBuilder.Entity<Usuario>()
                .HasIndex(u => u.Email)
                .IsUnique();
        }
    }
}
