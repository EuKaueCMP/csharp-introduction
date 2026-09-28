using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Threading.Tasks;

namespace Parte_3___Interface
{
    public class Carro : Icombustivel
    {
        double nivelMaximotanque = 55;
        double totalCombustivel;
        public Carro(string marca, string modelo) { }

        public void Abastecer(double litros)
        {
            if (litros > 0 && litros <= 55)
            {
                totalCombustivel += litros;
                Console.WriteLine($"Carro abastecido com {litros} litros de gasolina.");
            }

            else
                Console.WriteLine($"por favor insira um numero menor que 55.");
        }

        public void verificarNivelCombustivel()
        {
            Console.WriteLine($"O Nivel de combustivel do Carro é: {(totalCombustivel / nivelMaximotanque) * 100}.");
        }
    }
}