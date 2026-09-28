using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Parte_2___Classe_Abstrata_e_Abstração
{
    public class Onibus : Transporte
    {
        public const int velocidade = 60;

        public override double CalcularTempoViagem(double distancia)
        {
            double tempoViagem = distancia / velocidade;
            Console.WriteLine($"O tempo de duração em uma viagem de {distancia}Km de onibus é de: {tempoViagem.ToString()}Hrs");
            return tempoViagem;
        }
    }
}