using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Parte_4___Classe_Normal___Abstrata___Interface
{
    public interface Icombustivel
    {
        void Abastecer(double litros);

        void verificarNivelCombustivel();
    }
}