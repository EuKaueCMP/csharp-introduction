namespace SistemaCursosMVC.Models
{
    public class Tecnico : Curso
    {
        public Tecnico(){}      
        public Tecnico(string nomeConstrutor, int horasConstrutor) :base (nomeConstrutor, horasConstrutor)
        {}

        public override double CalcularPreco()
        {
            return Horas * 20;
        }
    }
}