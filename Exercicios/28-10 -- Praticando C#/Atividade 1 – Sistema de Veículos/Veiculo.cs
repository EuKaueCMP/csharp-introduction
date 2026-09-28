namespace Atividade_1_Sistema_de_Veículos
{
    public abstract class Veiculo
    {
        string Modelo { get; set; }
        int Ano { get; set; }

        public abstract double CalcularRevisao();

        public void ExibirResumo()
        {
            Console.WriteLine($"O modelo do carro é: {Modelo} e o ano é {Ano}");
        }
    }
}