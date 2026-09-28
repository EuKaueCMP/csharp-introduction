using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _28_10____Praticando_Classes_em_C_
{
    public abstract class Veiculo
    {
        public string Modelo { get; set; }
        public int Ano { get; set; }

        public Veiculo(string modelo, int ano)
        {
            Modelo = modelo;
            Ano = ano;
        }
        public abstract void CalcularRevisao();

        public void ExibirResumo()
        {
            Console.WriteLine($"O modelo do veiculo é: {Modelo} e seu ano é: {Ano}");
        }
    }
}