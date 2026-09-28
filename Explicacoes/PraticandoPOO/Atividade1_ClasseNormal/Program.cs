namespace Atividade_POO;

class Program
{
    static void Main(string[] args)
    {
        Pessoa p = new Pessoa
        {
            Nome = "Késsia",
            Idade = 26,
        };

        Aluno a = new Aluno
        {
            Nome = "Paulo",
            Idade = 20,
            Curso = "Desenvolvimento de Sistemas"
        };

        p.Apresentar();
        a.Apresentar();
    }
}
