using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Parte_4___Classe_Normal___Abstrata___Interface
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