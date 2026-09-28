using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Atividade2
{
    public class Gerente : Funcionario
    {
        double porcentagemSal = 1.5;
        public Gerente(string nome) : base(nome)
        { }

        public override void CalcularSalario()
        {
            double valorSalario = SalarioBase * porcentagemSal;
            Console.WriteLine($"O salario do: {Nome} e de: {valorSalario.ToString("C")}"); 
        }
    }
}