namespace _29_10____Atividade_Prática_C_;

class Program
{
    static void Main(string[] args)
    {
        var carro1 = new Carro("Hyunday", "Elantra", 2023, 4);
        var moto1 = new Moto("Yamaha", "Mt09", 2019, 600);

        carro1.ExibirDetalhes();
        moto1.ExibirDetalhes();
    }
}
