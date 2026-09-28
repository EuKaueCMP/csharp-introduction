using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _29_10____Atividade_Prática_C_
{
    public class Carro : Veiculo
    {
        public int QuatidadeDePortas { get; set; }

        public Carro(string marcaC, string modeloC, int anoC, int quantidadeDePortasC) : base(marcaC, modeloC, anoC)
        {
            QuatidadeDePortas = quantidadeDePortasC;
        }

        public override bool Ligar()
        {
            bool estado = false;

            if (estado == false)
            {
                estado = true;
                Console.WriteLine($"O carro {Modelo} está pronto para rodar!");
                return estado;
            }

            else
                Console.WriteLine($"O carro {Modelo} ja esta ligado");
            return estado;
        }

        public override void ExibirDetalhes()
        {
                Console.WriteLine($"O Modelo do carro é: {Modelo} a quantidade de portas é: {QuatidadeDePortas}... Esta ligado? {Ligar()}");
        }
    }
}