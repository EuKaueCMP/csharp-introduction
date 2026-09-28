using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace  Extra_Aplicação_dos_Princípios_SOLID
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