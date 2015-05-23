using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            //int f = 2;
            //System.Console.WriteLine("Hola Mundo:D esto es genial");
            //System.Console.ReadKey();
            Fibonacci calculadora= new Fibonacci();
           Console.WriteLine( calculadora.Calcular(1));
           Console.WriteLine(calculadora.Calcular(2));
           Console.WriteLine(calculadora.Calcular(3));
           Console.WriteLine(calculadora.Calcular(10));

           Console.ReadKey();
            

        }
    }
}
