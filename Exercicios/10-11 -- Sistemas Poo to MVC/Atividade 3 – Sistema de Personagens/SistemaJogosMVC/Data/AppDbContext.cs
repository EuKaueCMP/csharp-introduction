using Microsoft.EntityFrameworkCore;
using SistemaJogosMVC.Models;

namespace SistemaJogosMVC.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<Personagem> TabelaJogos { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Personagem>()
            .HasDiscriminator<string>("Tipo")
            .HasValue<Guerreiro>("Guerreiro")
            .HasValue<Mago>("Mago");
        }
    }
}