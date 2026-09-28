using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Parte_2___Classe_Abstrata_e_Abstração
{
    public class Aviao : Transporte
    {
        public const int velocidade = 800;
        public override double CalcularTempoViagem(double distancia)
        {
            double tempoViagem = distancia / velocidade;
            Console.WriteLine($"O tempo em uma viagem de {distancia}Km  de aviao é de: {tempoViagem.ToString()}Hrs");
            return tempoViagem;
        }
    }
}