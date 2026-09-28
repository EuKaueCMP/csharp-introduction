using System.Security.Cryptography.X509Certificates;

namespace Atividade_27._10
{
    public class Livro
    {
        public string Titulo { get; set; }
        public string Autor { get; set; }
        public int AnoPublucacao { get; set; }
        // {
        //     get
        //     {
        //         return AnoPublucacao;
        //     }
        //     set
        //     {
        //         if (value > 0)
        //         {
        //             AnoPublucacao = value;
        //         }

        //         else
        //         {
        //             Console.WriteLine("Erro! Ano de publicação invalido");
        //         }
        //     }
        // }
        public double Preco { get; set; }
        public bool EstadoDisponivel { get; set; } = true;

        //* Construtor
        //* É um metodo especial, usado para inicializar o estado do projeto
        public Livro(string tituloConstrutor, string autorConstrutor, int anoConstrutor, double precoConsrutor)
        {
            Titulo = tituloConstrutor;
            Autor = autorConstrutor;
            AnoPublucacao = anoConstrutor;
            Preco = precoConsrutor;
            
            //* Definindo valor inicial como true
            EstadoDisponivel = true;

            Console.WriteLine($"Novo Livro: {tituloConstrutor} foi criado e está disponivel");
        }

        public void ExibirDetalhes()
        {
            Console.WriteLine("Detalhes do livro");
            Console.WriteLine($"Titulo: {Titulo}");
            Console.WriteLine($"Autor: {Autor}");
            Console.WriteLine($"Publicacao: {AnoPublucacao}");
            Console.WriteLine($"Preço: {Preco:F2}"); //* F2 formata com duas casas decimais

            if (EstadoDisponivel)
            {
                Console.WriteLine($"Stauts: Esta disponivel para emprestimo");

            }
            else
            {
                Console.WriteLine($"Stauts: Emprestado! (Indisponivel)");
            }
        }

        public void Emprestar()
        {
            if (EstadoDisponivel)
            {
                EstadoDisponivel = false;
                Console.WriteLine($"O livro: {Titulo} foi emprestado");
            }

            else
            {
                EstadoDisponivel = false;
                Console.WriteLine($"O livro: {Titulo} já foi emprestado");
            }
        }
    }
}