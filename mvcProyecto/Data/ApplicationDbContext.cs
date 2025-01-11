using Microsoft.EntityFrameworkCore;
using mvcProyecto.Models;

namespace mvcProyecto.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        //Aqui todos los modelos que se creen 
        public DbSet<Producto> Producto { get; set; }

        public DbSet<Cliente> Clientes { get; set; }
        //FUNCIÓN PARA QUE EL ATRIBUTO CARNET SEA ÚNICO
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Cliente>()
                .HasIndex(c => c.Carnet)
                .IsUnique();

            base.OnModelCreating(modelBuilder);
        }





    }
}
