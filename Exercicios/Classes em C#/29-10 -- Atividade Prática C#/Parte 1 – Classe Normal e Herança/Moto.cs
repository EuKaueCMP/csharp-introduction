using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _29_10____Atividade_Prática_C_
{
    public class Moto : Veiculo
    {
        public int Cilindrada { get; set; }

        public Moto(string marcaC, string modeloC, int anoC, int cilindradaC) : base(marcaC, modeloC, anoC)
        {
            Cilindrada = cilindradaC;
        }
        public override bool Ligar()
        {
            bool estado = false;

            if (estado == false)
            {
                estado = true;
                Console.WriteLine($"A moto {Modelo} de {Cilindrada}cc está pronta!");
                return estado;
            }

            else
                Console.WriteLine($"A moto {Modelo} ja esta ligado");
            return estado;
        }

        public override void ExibirDetalhes()
        {
            Console.WriteLine($"O Modelo da moto é: {Modelo} a quantidade de portas é: {Cilindrada}... Esta ligada? {Ligar()}");
        }
    }
}