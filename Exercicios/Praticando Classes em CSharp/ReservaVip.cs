namespace Praticando_Classes_em_CSharp
{
    public class ReservaVip : Reserva
    {
        public ReservaVip(int construtorNumero, string construtorHospede, int construtorDias, string construtorTipo, double construtorPreco, bool construtorDisponivel) : base(construtorNumero, construtorHospede, construtorDias, construtorTipo, construtorPreco, construtorDisponivel)
        {
        }


        double desconto = 0.20;

        public override string CalucularTotal(int Numero, double construtorPreco)
        {   
                double valorDesconto = (construtorPreco * Dias) * desconto; 
                double valor = construtorPreco * Dias - valorDesconto;
                Console.WriteLine($"Valor total da reserva do quarto {Numero} é: R$:{valor.ToString()}.00");
                return valor.ToString();
        }
    }
}