namespace SistemaAnimaisMVC.Models
{
    public class Leao : Animal
    {
        public Leao() :base (){}
        public Leao(string nomeConstrutor) :base (nomeConstrutor){}

        public override string EmitirSom()
        {
            return "Rugido";
        }
        public override string TipoAlimento()
        {
            return "Carnívoro";
        }
    }
}