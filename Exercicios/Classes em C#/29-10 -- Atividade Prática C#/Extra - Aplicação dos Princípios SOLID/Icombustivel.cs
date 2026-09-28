using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace  Extra_Aplicação_dos_Princípios_SOLID
{
    public interface Icombustivel
    {
        void Abastecer(double litros);

        void verificarNivelCombustivel();
    }
}