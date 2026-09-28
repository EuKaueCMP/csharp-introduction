namespace AbertoFechado_O;

class Program
{
    static void Main(string[] args)
    {
        Desconto dn = new DescontoNatal();
        Desconto db = new DescontoBlackFriday();
           
        Console.WriteLine($"Natal: {dn.Calcular(1000):C}"); //* :C traz o formato monetaio do sistema... //* ex: R$: 1000.00
        Console.WriteLine($"BLackFriday: {db.Calcular(1000).ToString("C")}"); //* .ToString("C") faz o mesmo que :C 
        Console.WriteLine($"Natal naoFomat: {dn.Calcular(1000)}"); 
                                                                                                    
    }
}
