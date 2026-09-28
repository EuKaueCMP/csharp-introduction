namespace AbertoFechado_O
{
    public class DescontoBlackFriday : Desconto
    {
        public override double Calcular(double Valor) => Valor * 0.20;
        
    }
}