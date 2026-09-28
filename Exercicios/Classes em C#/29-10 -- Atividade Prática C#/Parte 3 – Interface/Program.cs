namespace Parte_3___Interface;

class Program
{
    static void Main(string[] args)
    {
        var moto1 = new Moto("Yamaha", "MT09");
        moto1.Abastecer(23);
        moto1.verificarNivelCombustivel();
        
        var carro1 = new Carro("Honda", "civic");
        carro1.Abastecer(23);
        carro1.verificarNivelCombustivel();
    }
}
