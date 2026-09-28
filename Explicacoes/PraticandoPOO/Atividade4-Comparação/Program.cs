namespace Atividade4_Comparação;

class Program
{
    static void Main(string[] args)
    {
        Programador dev = new Programador();
        dev.Nome = "Joquinha";

        dev.Trabalhar();
        dev.ExecultarTarefa();

        Pessoa p = new Pessoa();
        p.Nome = "Kick";

        p.Falar();
    }
}
