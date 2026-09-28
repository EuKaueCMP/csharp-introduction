using Atividade3;

namespace Atividade_3___Sistema_de_Personagens_de_Jogo;

class Program
{
    static void Main(string[] args)
    {
        var guerreiro1 = new Guerreiro("Geromel Arg", 12);
        guerreiro1.Exibirstatus();
        guerreiro1.CalcularPoder();
        
        var mago1 = new Mago("Eliob still", 14);
        mago1.Exibirstatus();
        mago1.CalcularPoder();
    }
}
