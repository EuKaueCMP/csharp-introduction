namespace SistemaFuncionariosMVC.Models
{
    public class Vendedor : Funcionario
    {
        public Vendedor() { }

        public Vendedor(string nomeConstrutor, double salarioBaseConstrutor) : base(nomeConstrutor, salarioBaseConstrutor) { }
        public override double CalcularSalario() => SalarioBase * 1.5;
    }
}