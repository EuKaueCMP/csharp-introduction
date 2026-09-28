using System.ComponentModel.DataAnnotations;

namespace SistemaCursosMVC.Models
{
    public abstract class Curso
    {
        [Key]
        public int id { get; set; }

        public string Nome { get; set; } = string.Empty;
        public int Horas { get; set; }

        public Curso() { }
        public Curso(string nomeConstrutor, int horasConstrutor)
        {
            Nome = nomeConstrutor;
            Horas = horasConstrutor;
        }

        public abstract double CalcularPreco();
    }
}