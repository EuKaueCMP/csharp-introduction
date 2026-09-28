namespace SistemaAnimaisMVC.Models
{
    public class Elefante : Animal
    {
        public Elefante() :base (){}
        public Elefante(string nomeConstrutor) :base (nomeConstrutor){}

        public override string EmitirSom()
        {
            return "Barrido";
        }
        public override string TipoAlimento()
        {
            return "Herbívoro";
        }
    }
}