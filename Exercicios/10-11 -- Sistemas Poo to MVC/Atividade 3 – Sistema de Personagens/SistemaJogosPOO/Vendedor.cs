using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Atividade2
{
    public class Vendedor : Funcionario
    {
        double porcentagemSal = 1.2;
        public Vendedor(string nome) : base(nome)
        { }

        public override void CalcularSalario()
        {
            double valorSalario = SalarioBase * porcentagemSal;
            Console.WriteLine($"O salario do: {Nome} e de: R$ {valorSalario.ToString("C")}");
        }
    }
}