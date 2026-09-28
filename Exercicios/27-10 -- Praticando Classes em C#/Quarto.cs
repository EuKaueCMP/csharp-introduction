using System.Reflection.Metadata;

namespace Praticando_Classes_em_CSharp
{
    public class Quarto
    {
        public int Numero { get; set; }
        public string Tipo { get; set; }
        public double Preco { get; set; }
        public bool Disponivel { get; set; }


        public Quarto(int construtorNumero, string construtorTipo, double construtorPreco)
        {
            Numero = construtorNumero;
            Tipo = construtorTipo;
            Preco = construtorPreco;

            Disponivel = true;
        }
        public void ExibirDetalhes()
        {
            if (Disponivel == true)
            {
                Console.WriteLine($"O numero do Quarto é: {Numero} é do tipo {Tipo} seu valor de uso é R$:{Preco} e seu estado atual é: Esta Disponivel");
                return;
            }

            Console.WriteLine($"O numero do Quarto é: {Numero} é do tipo {Tipo} seu valor de uso é R$:{Preco} e seu estado atual é: Esta Indisponivel");
            return;
        }

        private void Ocupar()
        {
            if (Disponivel == true)
            {                
                Disponivel = false;
                Console.WriteLine($"Parabens o quarto de numero: {Numero} foi alugado");
            }

            Disponivel = false;
            Console.WriteLine($"O quarto de numero: {Numero} ja esta ocupado");
        }

        private bool Desocupar()
        {
            if (Disponivel == false)
            {
                Console.WriteLine($"O quarto de numero: {Numero} foi desocupado");
                return Disponivel = true;
            }

            Console.WriteLine($"O quarto de numero: {Numero} ja desocupado");
            return Disponivel = true;
        }
    }
}