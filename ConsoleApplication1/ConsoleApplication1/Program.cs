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
           Console.WriteLine( calculadora.Calcular(20));
           Console.ReadKey();
            

        }
    }
}
