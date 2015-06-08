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
            

            Console.WriteLine("****Semana 1********");
            CalculaFibonacci();
            Console.WriteLine("****Semana 2********");
            ListaCalculaFibo();
            Console.WriteLine("****Semana 4********");
            MaximoFibonacci();
            
        }
        
          public static void CalculaFibonacci()
          {
            Fibonacci calculadora = new Fibonacci();
            System.Console.WriteLine("Hola Mundo:D esto es genial LDkaj");
            Console.WriteLine( calculadora.Calcular(20));
            
        
            }
            public static void ListaCalculaFibo()
            {

                Fibonacci calculadora1= new Fibonacci();
                
                ArrayList entrada = new ArrayList();
                ArrayList salida = new ArrayList();
                entrada.Add(4);
                entrada.Add(6);
                entrada.Add(20);
                entrada.Add(1);
                entrada.Add(11);
                entrada.Add(25);
                foreach (int obj in salida = calculadora1.RecibeArreglo(entrada))
                {
                    Console.WriteLine(obj);
                    
                }
            }

            public static void MaximoFibonacci()
            {
                Fibonacci c = new Fibonacci();
                RespuestaDeMaximoFibonacci respuesta = c.ObtengaElMaximoFibonacciQuePuedoCalcular();

                Console.WriteLine("Maximo Fibonacci:");
                Console.WriteLine(" n = {0}", respuesta.Numero);
                Console.WriteLine(" Fibonacci (n) = {0}", respuesta.Fibonacci);
               
              
            }
          
          
            
            

        
    

}
}
