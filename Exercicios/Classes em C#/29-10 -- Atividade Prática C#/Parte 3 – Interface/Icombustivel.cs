using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Parte_3___Interface
{
    public interface Icombustivel
    {
        void Abastecer(double litros);

        void verificarNivelCombustivel();
    }
}