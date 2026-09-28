using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SistemaCarrosMVC.Models
{
    public class Moto : Veiculo
    {
        public Moto() : base() { }
        public Moto(string modeloConstrutor, int anoConstrutor) : base(modeloConstrutor, anoConstrutor) { }

        public override double CalcularRevisao()
        {
            return 300;
        }
    }
}