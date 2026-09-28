using Microsoft.EntityFrameworkCore;
using SistemaFuncionariosMVC.Models;

namespace SistemaFuncionariosMVC.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        // Tabela única para todos os tipos de funcionário
        public DbSet<Funcionario> TabelaFuncionario { get; set; }

        // Método corretamente sobrescrito
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Funcionario>()
                .HasDiscriminator<string>("Cargo")
                .HasValue<Gerente>("Gerente")
                .HasValue<Vendedor>("Vendedor");
        }
    }
}