using Microsoft.EntityFrameworkCore;
using System.Configuration;
using System.Data.Common;
using WebAPISolution.Models;

namespace WebAPISolution.Contexts
{
    public class AplicationDbContext : DbContext
    {
        public DbSet<WebAPISolution.Models.Asignacion> Asignacion { get; set; } = default!;
        public DbSet<Estudiante>Estudiante {  get; set; }
        public DbSet<Docente> Docente { get; set; }
        public DbSet<Curso> Curso { get; set; }
        public DbSet<Asignacion> Asignacions { get; set; }
        public AplicationDbContext(DbContextOptions<AplicationDbContext> options) : base(options)
        {
        }

        protected AplicationDbContext()
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}
