using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SistemaJogosMVC.Models
{
    public class Guerreiro : Personagem
    {
        public Guerreiro() :base (){}
        public Guerreiro(string nomeConstrutor, int nivelConstrutor) : base(nomeConstrutor, nivelConstrutor)
        { }

        public override double CalcularPoder()
        {
            return Nivel * 10;
        }
    }
}