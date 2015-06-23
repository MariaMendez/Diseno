using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora
{
    class CalculadoraEntity
    {
        public double Dividir(double dividendo, double divisor)
        {
            if (divisor == 0)
            {
                throw new Exception("El divisor no debe ser 0");
            }
            return dividendo / divisor;
        }
 
    }
}
