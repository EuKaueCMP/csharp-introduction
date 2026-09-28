using Microsoft.EntityFrameworkCore;
using SistemaCarrosMVC.Models;

namespace SistemaCarrosMVC.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) :base(options){}

        public DbSet<Veiculo> TabelaVeiculo { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Veiculo>()
            .HasDiscriminator<string>("Tipo")
            .HasValue<Carro>("Carro")
            .HasValue<Moto>("Moto");
        }
    }
}