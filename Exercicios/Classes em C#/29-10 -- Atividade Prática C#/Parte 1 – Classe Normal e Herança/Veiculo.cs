using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _29_10____Atividade_Prática_C_
{
    public class Veiculo
    {
        public string Marca { get; set; }
        public string Modelo { get; set; }
        public int Ano { get; set; }

        public Veiculo(string marcaC, string modeloC, int anoC)
        {
            Marca = marcaC;
            Modelo = modeloC;
            Ano = anoC;
        }

        public virtual bool Ligar()
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

        public virtual void ExibirDetalhes()
        { }
    }
}