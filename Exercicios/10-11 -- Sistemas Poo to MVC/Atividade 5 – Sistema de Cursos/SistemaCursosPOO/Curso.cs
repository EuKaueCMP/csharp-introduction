using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Atividade_5___Sistema_de_Cursos
{
    public abstract class Curso
    {
        public string Nome { get; set; }
        public int Horas { get; set; }

        public Curso(string nome, int horas)
        {
            Nome = nome;
            Horas = horas;
        }

        public abstract void CalcularPreco();

        public void ExibirResumo()
        {
            Console.WriteLine($"O nome do curso é: {Nome}, e a carga horaria é de {Horas}");
        }
    }
}