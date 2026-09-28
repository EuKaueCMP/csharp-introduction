using System.Reflection.Metadata;

namespace Praticando_Classes_em_CSharp
{
    public class Quarto
    {
        private int v;
        private int construtorNumero;


        public int Numero { get; set; }
        public string Tipo { get; set; }
        public double Preco { get; set; }
        public bool Disponivel { get; set; }


    public Quarto(int construtorNumero, string construtorTipo, double construtorPreco, bool construtorDisponivel)
    {
        Numero = construtorNumero;
        Tipo = construtorTipo;
        Preco = construtorPreco;
        Disponivel = construtorDisponivel;

    }
        public void ExibirDetalhes()
        {
            if (Disponivel == true)
            {
            Console.WriteLine($"O Quarto de numero: {Numero} é do tipo {Tipo} seu valor de uso é R$:{Preco} e seu estado atual é: Esta Disponivel");
            return;
            }

            else if (Disponivel == false)
            Console.WriteLine($"O Quarto de numero: {Numero} é do tipo {Tipo} seu valor de uso é R$:{Preco} e seu estado atual é: Esta Indisponivel");
            return;
        }

        private bool Ocupar()
        {
            if (Disponivel == true)
            {
                Console.WriteLine($"Parabens o quarto de numero: {Numero} foi alugado");
                return Disponivel = false;
            }

            Console.WriteLine($"O quarto de numero: {Numero} ja esta ocupado");
            return Disponivel = false;
        }

        private bool Desocupar()
        {
            if(Disponivel == false)
            {
                Console.WriteLine($"O quarto de numero: {Numero} foi desocupado");
                return Disponivel = true;
            }
            
            Console.WriteLine($"O quarto de numero: {Numero} ja desocupado");
            return Disponivel = true;
        }
    }
}