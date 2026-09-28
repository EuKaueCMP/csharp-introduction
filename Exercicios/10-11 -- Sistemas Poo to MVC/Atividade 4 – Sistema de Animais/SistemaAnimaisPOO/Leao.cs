using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Atividade4
{
    public class Leao : Animal
    {
        public string Som = "Rugido";
        public string Alimentacao = "Carnivoro";

        public Leao(string nome) : base(nome)
        { }

        public override void EmitirSom()
        {
            Console.WriteLine($"{Som}");
        }

        public override void TipoAlimentacao()
        {
            Console.WriteLine($"O tipo de alimetacao do Leão é: {Alimentacao}");
        }
    }
}