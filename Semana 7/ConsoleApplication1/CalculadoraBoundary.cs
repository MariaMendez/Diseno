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
            Console.WriteLine("Deme el divisor");
            string divisor = Console.ReadLine();
            double respuesta = double.Parse(divisor);
            return respuesta;
        }
        public double ObtenerDividendo()
           
        {
            Console.WriteLine("Deme el dividendo");
            string dividendo = Console.ReadLine();
            double respuesta = double.Parse(dividendo);
            return respuesta;
        }

        internal void MostrarResultado(string resultado)
        {
            Console.WriteLine(resultado);
            Console.ReadLine();
        }
    }
}
