using System.Security.Cryptography.X509Certificates;

namespace Praticando_Classes_em_CSharp
{
    public class Reserva : Quarto
    {
        public string Hospede { get; set; }
        public int Quarto { get; set; }
        public int Dias { get; set; }

        public virtual string CalucularTotal(int numero, double construtorPreco)
        {
            double valor = construtorPreco * Dias;
            Console.WriteLine($"Valor total da reserva do quarto {Numero} é: R$:{valor.ToString()}.00");
            return valor.ToString();
        }

        public void ResumoReserva(int construtorNumero, string construtorTipo, int numero, double construtorPreco)
        {
            DateTime dataAtual = DateTime.Now;
            DateTime novaData = dataAtual.AddDays(Dias);
            Console.WriteLine($"\nReserva de: {Hospede} \nQuarto: {construtorNumero} {construtorTipo} \nValor total: {CalucularTotal(numero, construtorPreco)}");
        }

        public Reserva(int construtorNumero, string construtorHospede, int construtorDias, string construtorTipo, double construtorPreco, bool construtorDisponivel) : base(construtorNumero, construtorTipo, construtorPreco, construtorDisponivel)
        {
            Numero = construtorNumero;
            Hospede = construtorHospede;
            Dias = construtorDias;
        }
    }
}