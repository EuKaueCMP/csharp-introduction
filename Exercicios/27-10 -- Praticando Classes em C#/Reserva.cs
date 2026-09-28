using System.Security.Cryptography.X509Certificates;

namespace Praticando_Classes_em_CSharp
{
    public class Reserva
    {
        public Hospede HospedeReserva { get; set; }
        public Quarto QuartoReserva { get; set; }
        public int Dias { get; set; }

        public Reserva(int construtorDias, Hospede construtorHospede, Quarto ConstrutroQuartoReserva)
        {
            HospedeReserva = construtorHospede;
            QuartoReserva = ConstrutroQuartoReserva;
            Dias = construtorDias;
        }

        public virtual double CalucularTotal()
        {
            double valor = QuartoReserva.Preco * Dias;
            Console.WriteLine($"Valor total da reserva do quarto {QuartoReserva.Numero} é: R$:{valor.ToString()}.00");
            return valor;
        }

        public void ResumoReserva()
        {
            DateTime dataAtual = DateTime.Now;
            DateTime novaData = dataAtual.AddDays(Dias);
            Console.WriteLine($"\nReserva de: {HospedeReserva.Nome} \nQuarto: {QuartoReserva} {Dias} \nValor total: {CalucularTotal()}");

        }
    }
}