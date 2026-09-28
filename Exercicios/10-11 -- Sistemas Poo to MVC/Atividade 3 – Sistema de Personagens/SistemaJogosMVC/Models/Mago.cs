using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SistemaJogosMVC.Models
{
    public class Mago : Personagem
    {
        public Mago() :base (){}
        public Mago(string nomeConstrutor, int nivelConstrutor) : base(nomeConstrutor, nivelConstrutor)
        { }

        public override double CalcularPoder()
        {
            return Nivel * 10;
        }
    }
}
