namespace Parte_2___Classe_Abstrata_e_Abstração;

class Program
{
    static void Main(string[] args)
    {
        var onibus1 = new Onibus();
        onibus1.CalcularTempoViagem(2000);

        var aviao1 = new Aviao();
        aviao1.CalcularTempoViagem(21000);
    }
}
