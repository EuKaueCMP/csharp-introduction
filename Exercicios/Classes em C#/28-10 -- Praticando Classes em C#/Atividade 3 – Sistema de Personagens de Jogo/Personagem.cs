using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Atividade3
{
    public abstract class Personagem
    {
        public string Nome { get; set; }
        public int Nivel { get; set; }

        public Personagem(string nome, int nivel)
        {
            Nome = nome;
            Nivel = nivel;
        }

        public abstract void CalcularPoder();

        public void Exibirstatus()
        {
            if (this is Mago)
                Console.WriteLine($"O nome do mago é: {Nome} e seu nivel é: {Nivel}");

            else if (this is Guerreiro)
                Console.WriteLine($"O nome do guerreiro é: {Nome} e seu nivel é: {Nivel}");
        }
    }
}