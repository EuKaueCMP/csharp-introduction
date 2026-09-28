using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks;

namespace Parte_3___Interface
{
    public class Moto : Icombustivel
    {
        double nivelMaximotanque = 26;
        double totalCombustivel;
        public Moto(string marca, string modelo) { }

        public void Abastecer(double litros)
        {
            if (litros > 0 && litros <= 55)
            {
                totalCombustivel += litros;
                Console.WriteLine($"Moto abastecido com {litros} litros de gasolina.");
            }

            else
                Console.WriteLine($"Por favor insira um numero menor que 26.");
        }

        public void verificarNivelCombustivel()
        {
            Console.WriteLine($"O Nivel de combustivel da Moto é: {((totalCombustivel / nivelMaximotanque)) * 100}.");
        }
    }
}