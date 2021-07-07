using Microsoft.EntityFrameworkCore;
using Models;

namespace Data
{
    public class ProyectoContext:DbContext
    {

        public DbSet<Proyecto> Proyectos { get; set; }
        public ProyectoContext():base(){}

        public ProyectoContext(DbContextOptions<ProyectoContext> options) : base(options)
        {
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
                optionsBuilder.UseSqlServer("Server=DESKTOP-3E6FT3J;Database=ProyectosDB;Trusted_Connection=True;");
        }
    }
}
