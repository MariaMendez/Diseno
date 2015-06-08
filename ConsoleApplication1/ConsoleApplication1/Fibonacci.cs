using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Fibonacci
        // Esta clase es procedimental
    {
        //SEMANA 1
          public int Calcular(int n)
        {
            if (n == 1 || n == 2)
                return 1;
            else
                return Calcular(n - 1) + Calcular(n - 2);
        }
        //SEMANA 2
          //ESTA ES OTRA MANERA DE HACER LO DE LA LISTA(Hecho por el profe)
        //public List<int> CalculeFibonacciDeLista(List<int> lista)
        //{
        //    List<int> resultado = new List<int>();

        //    foreach (int i in lista)
        //    {
        //        resultado.Add(CalculeFibonacci(i));
        //    }
        //    return resultado;
        //}


        

        
        public ArrayList RecibeArreglo(IEnumerable array)
        {
            ArrayList salida = new ArrayList();    
 foreach(int obj in array){



     
        salida.Add(Calcular(obj));
  
    
   
 }
 
 return salida;
 
        }
        //SEMANA 4

        public RespuestaDeMaximoFibonacci ObtengaElMaximoFibonacciQuePuedoCalcular()
        {
            // este objeto contiene la respuesta necesaria para poder comunicar el mensaje esperado
            RespuestaDeMaximoFibonacci respuesta = new RespuestaDeMaximoFibonacci();

            int n = 1;
            try
            {
                // un ciclo infinito
                while (true)
                {
                    int elFibonacci = Calcular(n);

                    // almaceno el resultado
                    respuesta.Numero = n;
                    respuesta.Fibonacci = elFibonacci;

                    // continuo al siguiente número
                    n++;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Se obtuvo una excepción en el numero: " + n);
                Console.WriteLine("El mensaje de la excepción es : " + ex.Message);
            }

            return respuesta;

        }


    }

}
