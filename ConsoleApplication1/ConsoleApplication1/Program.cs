using System;
using System.Collections;
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
            //System.Console.WriteLine("Hola Mundo:D esto es genial LD");
            //System.Console.ReadKey();
            Fibonacci calculadora= new Fibonacci();
            ArrayList entrada = new ArrayList();
            entrada.Add(4); 
            entrada.Add(6);
            entrada.Add(20);
            entrada.Add(1);
            entrada.Add(11);
            entrada.Add(25);
            foreach (int obj in calculadora.RecibeArreglo(entrada))
            {




          



            }
           //Console.WriteLine( calculadora.Calcular(20));
           Console.ReadKey();
            

        }
    }
}
