using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _28_10____Praticando_Classes_em_C_
{
    public class Carro : Veiculo
    {
        public Carro(string modelo, int ano) : base(modelo, ano)
        {
        }

        public override void CalcularRevisao()
        {
            double total = 0;

            if (Ano > 0)            
                if (Ano <= 2000 && Ano >= 1960)
                    total = 500;
                else if (Ano <= 2011 && Ano >= 2001)
                    total = 1000;
                else if (Ano >= 2012)
                    total = 2000;

                string Vlr_formatado = total.ToString("C");
                Console.WriteLine($"etorna custo fixo de revisão = R$ {Vlr_formatado}.");
            
        }
    }
}