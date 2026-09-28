using System.Reflection.Metadata;

namespace _28_10____Praticando_Classes_em_C_;

class Program
{
    static void Main(string[] args)
    {
        var carro1 = new Carro("Seiena", 2001);
        var carro2 = new Carro("Onix", 2023);

        var moto1 = new Moto("MT09", 2022);
        var moto2 = new Moto("cbx 150 twister", 2001);

        carro1.CalcularRevisao();
        carro1.ExibirResumo();

        carro2.CalcularRevisao();
        carro2.ExibirResumo();

        moto1.CalcularRevisao();
        moto1.ExibirResumo();
        
        moto2.CalcularRevisao();
        moto2.ExibirResumo();
    }
}
