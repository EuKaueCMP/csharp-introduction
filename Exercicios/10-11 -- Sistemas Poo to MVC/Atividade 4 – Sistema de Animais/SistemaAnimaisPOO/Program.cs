using Atividade4;

namespace Atividade_4___Sistema_de_Animais;

class Program
{
    static void Main(string[] args)
    {
        var leao1 = new Leao("Leo");
        leao1.TipoAlimentacao();
        leao1.EmitirSom();

        var elefante1 = new Elefante("Font");
        elefante1.TipoAlimentacao();
        elefante1.EmitirSom();
    }
}
