using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Atividade_5___Sistema_de_Cursos
{
    public class CursoSuperior : Curso
    {
        public CursoSuperior(string nome, int horas) : base(nome, horas)
        { }
        public double valor { get; }

        public override void CalcularPreco()
        {
            Console.WriteLine($"O valor do curso é: {(Horas * 40).ToString("C")}");
        }
    }
}