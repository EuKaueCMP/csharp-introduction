using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;

namespace Atividade2
{
    public abstract class Funcionario
    {
        public string Nome { get; set; }
        public double SalarioBase = 1700;

        public Funcionario(string nome)
        {
            Nome = nome;
        }

        public abstract void CalcularSalario();

        public void ExibirResumo()
        {
            if (this is Gerente)
                Console.WriteLine($"O nome do funcionario é: {Nome} e seu salario é: {(SalarioBase * 1.5).ToString("C")}");

            else if (this is Vendedor)
                Console.WriteLine($"O nome do funcionario é: {Nome} e seu salario é: {(SalarioBase * 1.2).ToString("C")}");

        }
    }
}