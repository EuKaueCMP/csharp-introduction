using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Parte_4___Classe_Normal___Abstrata___Interface
{
    public class Carro : Transporte, Icombustivel
    {
        double nivelMaximotanque = 55;
        double totalCombustivel;
        int velocidade = 100;
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

        public override double CalcularTempoViagem(double distancia)
        {
            Console.WriteLine($"O tempo que a viajem ira demora é: {distancia / velocidade}hrs");
            return distancia;
        }
    }
}