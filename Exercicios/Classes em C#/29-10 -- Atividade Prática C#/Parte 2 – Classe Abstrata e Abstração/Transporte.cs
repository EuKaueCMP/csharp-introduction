using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Parte_2___Classe_Abstrata_e_Abstração
{
    public abstract class Transporte
    {
        public abstract double CalcularTempoViagem(double distancia);

        public void IniciarViagem()
        {
            Console.WriteLine($"Viagem iniciada...");
        }
    }
}