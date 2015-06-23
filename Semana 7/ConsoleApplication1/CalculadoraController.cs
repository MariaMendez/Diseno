using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora
{
    class CalculadoraController
    {
        string CoordineLaDivision(double divisor, double dividendo)
        {
            CalculadoraEntity laCalculadora = new CalculadoraEntity();
            double resultado = laCalculadora.Dividir(divisor, dividendo);
            string resultadoString = resultado.ToString();
            return resultadoString;
        }
    }
}
