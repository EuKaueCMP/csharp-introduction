using Microsoft.EntityFrameworkCore;
using SistemaAnimaisMVC.Models;

namespace SistemaAnimaisMVC.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<Animal> TabelaAnimal { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Animal>()
            .HasDiscriminator<string>("Tipo")
            .HasValue<Elefante>("Elefante")
            .HasValue<Leao>("Leao");
        }            
    }
}