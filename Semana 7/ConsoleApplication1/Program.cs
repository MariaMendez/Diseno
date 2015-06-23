using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora
{
    class Program
    {
        static void Main(string[] args)
        {
            CalculadoraBoundary elLimite = new CalculadoraBoundary();
             double divisor= elLimite.ObtenerDivisor();
             double dividendo = elLimite.ObtenerDividendo();
             CalculadoraController laControladora = new CalculadoraController();
             string resultado= laControladora.CoordineLaDivision(dividendo, divisor);
             elLimite.MostrarResultado(resultado);

        }
    }
}
