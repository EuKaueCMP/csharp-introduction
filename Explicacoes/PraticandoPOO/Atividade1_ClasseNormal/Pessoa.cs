
namespace Atividade_POO
{
    public class Pessoa
    {
        public string Nome;
        public int Idade;

        // virtual - vamos utilizar o método em outra classe, podendo sobrescrever
        public virtual void Apresentar()
        {
            
            Console.WriteLine($"Olá, meu nome é {Nome} e tenho {Idade} anos.");
        }
    }
}