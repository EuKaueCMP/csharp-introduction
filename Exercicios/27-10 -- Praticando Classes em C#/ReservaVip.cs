namespace Praticando_Classes_em_CSharp
{
    public class ReservaVip : Reserva
    {
        public ReservaVip(int construtorNumero, string construtorHospede, int construtorDias, string construtorTipo, double construtorPreco, bool construtorDisponivel) : base(construtorNumero, construtorHospede, construtorDias, construtorTipo, construtorPreco, construtorDisponivel)
        {
        }


        double desconto = 0.20;

        public override string CalucularTotal()
        {
            double ValorSemDesconto = QuartoReserva.Preco * Dias;
            double ValorComDesconto = ValorSemDesconto * desconto;
            Console.WriteLine($"Valor total da reserva do quarto {QuartoReserva.Numero} é: R$:{ValorComDesconto}.00");
            return ValorComDesconto.ToString();
        }
    }
}