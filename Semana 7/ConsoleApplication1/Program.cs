﻿using System;
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

        }
    }
}
