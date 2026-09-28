using System.ComponentModel.DataAnnotations;

namespace SistemaFuncionariosMVC.Models
{
    public abstract class Funcionario
    {
        [Key] // chave primária
        public int Id { get; set; }

        [Required] // obrigar a passar o atributo
        public string Nome { get; set; } = string.Empty;

        [Range(0, 10000)]
        public double SalarioBase { get; set; }

        public Funcionario() { }

        public Funcionario(string nomeConstrutor, double salarioBaseConstrutor)
        {
            Nome = nomeConstrutor;
            SalarioBase = salarioBaseConstrutor;
        }

        public abstract double CalcularSalario();
    }
}