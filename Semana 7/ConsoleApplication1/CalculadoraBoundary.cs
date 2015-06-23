using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora
{
    class CalculadoraBoundary
    {
        public double ObtenerDivisor()
        {
            string divisor = Console.ReadLine();
            double respuesta = double.Parse(divisor);
            return respuesta;
        }
        public double ObtenerDividendo()
        {
            string dividendo = Console.ReadLine();
            double respuesta = double.Parse(dividendo);
            return respuesta;
        }
    }
}
