namespace SistemaFuncionariosMVC.Models
{
    public class Gerente : Funcionario
    {
        public Gerente() { }

        public Gerente(string nomeConstrutor, double salarioBaseConstrutor) : base(nomeConstrutor, salarioBaseConstrutor)
        { }

        public override double CalcularSalario() => SalarioBase * 1.5;
    }
}