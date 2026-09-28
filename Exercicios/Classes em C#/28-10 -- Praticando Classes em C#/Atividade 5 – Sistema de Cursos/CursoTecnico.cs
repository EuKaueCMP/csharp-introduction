using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Atividade_5___Sistema_de_Cursos;
using Atividade5;

namespace Atividade5
{
    public class CursoTecnico : Curso
    {
        public CursoTecnico(string nome, int horas) : base(nome, horas)
        { }
        public double valor { get; }

        public override void CalcularPreco()
        {
            Console.WriteLine($"O valor do curso é: {(Horas * 20).ToString("C")}");
        }
    }
}