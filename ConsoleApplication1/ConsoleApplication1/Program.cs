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
            Class1 fibonacci= new Class1();
           Console.WriteLine( fibonacci.Calcular(20));
           Console.ReadKey();
            

        }
    }
}
