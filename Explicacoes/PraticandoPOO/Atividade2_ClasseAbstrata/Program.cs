using System.Reflection;

namespace Atividade2_ClasseAbstrata;

class Program
{
    static void Main(string[] args)
    {
        Retangulo r = new Retangulo { Largura = 5, Altura = 3 };
        Circulo c = new Circulo { Raio = 3 };
        // da erro - não podemos instanciar classe abstrata
        // Forma f = new Forma { };
        // f.MostrarTipo();

        r.MostrarTipo();
        Console.WriteLine($"Área do retângulo: {r.CalcularArea()}");

        c.MostrarTipo();
        Console.WriteLine($"Área do circulo: {c.CalcularArea()}");
    }
}
