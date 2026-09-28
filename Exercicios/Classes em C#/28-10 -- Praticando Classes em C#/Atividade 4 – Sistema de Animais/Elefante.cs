using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Atividade4
{
    public class Elefante : Animal
    {
        public string Som = "Barrido";
        public string Alimentacao = "Herbivoro";

        public Elefante(string nome) : base(nome)
        { }

        public override void EmitirSom()
        {
            Console.WriteLine($"{Som}");
        }

        public override void TipoAlimentacao()
        {
            Console.WriteLine($"O tipo de alimetacao do Elefante é: {Alimentacao}");
        }
    }
}