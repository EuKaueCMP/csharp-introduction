using Atividade2;

namespace Exercicio2;

class Program
{
    static void Main(string[] args)
    {
        var gerente1 = new Gerente("Paulo Henrique");
        gerente1.ExibirResumo();

        var vendedor1 = new Vendedor("Mauricio Costa");
        vendedor1.ExibirResumo();
    }
}
