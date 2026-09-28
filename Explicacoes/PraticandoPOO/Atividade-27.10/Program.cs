namespace Atividade_27._10;

class Program
{
    static void Main(string[] args)
    {
        //! Sem Construtor 
            // Livro novoLivro = new Livro();

            // Console.WriteLine($"Titulo: {novoLivro.Titulo}");
            // Console.WriteLine($"Autor: {novoLivro.Autor}");
            // Console.WriteLine($"Ano: {novoLivro.AnoPublucacao}");
            // Console.WriteLine($"Preço: {novoLivro.Preco}");
            // Console.WriteLine($"Estado: {novoLivro.EstadoDisponivel}");

            // //* colocando valores manualmente 
            // novoLivro.Titulo = "The power the madde";
            // novoLivro.Autor = "Qualquer";
            // novoLivro.AnoPublucacao = 2025;
            // novoLivro.Preco = 1.99;
            // novoLivro.EstadoDisponivel = true;

            // Console.WriteLine($"Exibindo detalhes: ");
            // novoLivro.ExibirDetalhes();        

        //! Com construtor
            Console.WriteLine("Sistema de controle de biblioteca");

            //* Criando objeto novo com construtor
            Livro livro1 = new Livro("Joca e os 10 malandros", "PapilaGusta", 2001, 10.00);
            Livro livro2 = new Livro("Eu quem?", "GangueSemNome", 2002, 2.00);

            // Interação com os livros 
            
            Console.WriteLine("Interagindo com o livro 1");
            livro1.ExibirDetalhes();
            livro1.Emprestar();

            livro1.ExibirDetalhes();
            livro1.Emprestar();

            Console.WriteLine("Interagindo com o livro 2");
            livro2.ExibirDetalhes();
            livro2.Preco = 25.70;
            Console.WriteLine($"Atualização do livro: {livro2.Titulo} para: valor R$:{livro2.Preco:F2}");
    }
}
