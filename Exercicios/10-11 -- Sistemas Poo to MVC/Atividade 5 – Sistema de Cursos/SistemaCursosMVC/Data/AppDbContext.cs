using SistemaCursosMVC.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;

namespace SistemaCursosMVC.Data
{
    public class AppDbContext : DbContext
    {
        //* Recebendo as informacoes do banco
        public AppDbContext(DbContextOptions<AppDbContext> options) : base (options) { }

        //* Direciona a classe curso para a tabela curso no banco de dados
        public DbSet<Curso> TabelaCurso { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Curso>()
            .HasDiscriminator<string>("Tipo")
            .HasValue<Tecnico>("Tecnico")
            .HasValue<Superior>("Superior");
        }
    }
}