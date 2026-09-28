namespace AbertoFechado_O
{
    public class DescontoNatal : Desconto
    {
        public override double Calcular(double Valor) => Valor * 0.10;      
    }
}