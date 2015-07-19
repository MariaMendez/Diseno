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
             double dividendo = elLimite.ObtenerDividendo();
             double divisor= elLimite.ObtenerDivisor();
             CalculadoraController laControladora = new CalculadoraController();
             string resultado= laControladora.CoordineLaDivision(dividendo, divisor);
             elLimite.MostrarResultado(resultado);

        }
    }
}
