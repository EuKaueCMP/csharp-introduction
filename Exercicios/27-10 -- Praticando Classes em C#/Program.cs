namespace Praticando_Classes_em_CSharp;

class Program
{

    static void Main(string[] args)
    {
        Console.WriteLine("Sistema de controle do hotel");


        Hospede hospede1 = new Hospede("Kaue", "111", "11111");
        hospede1.ExibirInformacoes();
        Hospede hospede2 = new Hospede("Joca", "222", "22222");
        hospede2.ExibirInformacoes();

        Quarto quarto1 = new Quarto(1, "Simples", 120.00);
        Quarto quarto2 = new Quarto(2, "Suite", 300.00);
        quarto1.ExibirDetalhes();
        quarto2.ExibirDetalhes();

        Console.WriteLine(quarto1.Preco);

        Reserva reserva1 = new Reserva(quarto1.Numero, hospede1.Nome, 12, "Simples", 120.00, true);
        reserva1.CalucularTotal(quarto1.Numero, quarto1.Preco);

        ReservaVip reserva2 = new ReservaVip(quarto2.Numero, hospede2.Nome, 20, "Simples", quarto2.Preco, quarto2.Disponivel);
        reserva2.CalucularTotal(quarto2.Numero, quarto2.Preco);

        reserva1.ResumoReserva(quarto1.Numero, quarto1.Tipo, quarto1.Numero, quarto1.Preco);
        reserva2.ResumoReserva(quarto2.Numero, quarto2.Tipo, quarto2.Numero, quarto2.Preco);
    }
}
