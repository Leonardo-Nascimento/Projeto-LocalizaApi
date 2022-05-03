using Localiza.Domain.Models;
using Localiza.Infra.Contexto.Configuration;
using Microsoft.EntityFrameworkCore;

namespace Localiza.Infra.Contexto
{
    public class LocalizaDbContext : DbContext
    {

        public DbSet<Cliente> Cliente { get; set; }
        public DbSet<Endereco> Endereco { get; set; }
        public DbSet<Fabricante> Fabricante { get; set; }
        public DbSet<Modelo> Modelo { get; set; }
        public DbSet<Veiculo> Veiculo { get; set; }
        public DbSet<Reserva> Reserva { get; set; }

        public LocalizaDbContext(DbContextOptions<LocalizaDbContext> options) : base(options)
        {
            Database.EnsureCreated();
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new ClienteConfiguration());
            modelBuilder.ApplyConfiguration(new EnderecoConfiguration());
            modelBuilder.ApplyConfiguration(new FabricanteConfiguration());
            modelBuilder.ApplyConfiguration(new ModeloConfiguration());
            modelBuilder.ApplyConfiguration(new ReservaConfiguration());
            modelBuilder.ApplyConfiguration(new VeiculoConfiguration());


            modelBuilder.Entity<Veiculo>()
                        .HasOne(v => v.Modelo)
                        .WithOne()
                        .OnDelete(DeleteBehavior.NoAction);
        }



    }
}
