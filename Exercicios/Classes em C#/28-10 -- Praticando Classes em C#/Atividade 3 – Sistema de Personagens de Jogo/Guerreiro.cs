using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Atividade3
{
    public class Guerreiro : Personagem
    {
        public int Poder { get; }

        public Guerreiro(string nome, int nivel) : base(nome, nivel)
        {

        }

        public override void CalcularPoder()
        {
            Console.WriteLine($"O poder do guerreiro {Nome} é igual a: {Nivel * 10}");
        }
    }
}