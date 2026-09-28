using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SistemaCarrosMVC.Models
{
    public class Carro : Veiculo
    {
        public Carro() :base (){}
        public Carro(string modeloConstrutor, int anoConstrutor) : base(modeloConstrutor, anoConstrutor) { }

        public override double CalcularRevisao()
        {
            return 500;
        }
    }
}