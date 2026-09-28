using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Atividade3
{
    public class Mago : Personagem
    {
        public int Poder { get; }

        public Mago(string nome, int nivel) : base(nome, nivel)
        {

        }

        public override void CalcularPoder()
        {
            Console.WriteLine($"O poder do mago {Nome} é igual a: {(Nivel * 8 )+ 20}");
        }
    }
}