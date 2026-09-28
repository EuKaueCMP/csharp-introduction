using Atividade5;

namespace Atividade_5___Sistema_de_Cursos;

class Program
{
    static void Main(string[] args)
    {
        var curso1 = new CursoTecnico("Tecnico em Desenvolvimento de Sistemas", 1400);
        curso1.CalcularPreco();
        curso1.ExibirResumo();

        var curso2 = new CursoSuperior("Cibersegurança", 2000);
        curso2.CalcularPreco();
        curso2.ExibirResumo();
    }
}
