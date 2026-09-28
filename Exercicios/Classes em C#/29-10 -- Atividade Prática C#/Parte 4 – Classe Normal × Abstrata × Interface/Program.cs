namespace Parte_4___Classe_Normal___Abstrata___Interface;

class Program
{
    static void Main(string[] args)
    {
        var carro1 = new Carro("BMW", "320i");
        carro1.Abastecer(12);
        carro1.CalcularTempoViagem(220);
        carro1.IniciarViagem();
    }
}
