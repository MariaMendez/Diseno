using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Fibonacci
    {
       
      
        public ArrayList RecibeArreglo(IEnumerable array)
        {
            ArrayList salida = new ArrayList();    
 foreach(int obj in array){



     
        salida.Add(Calcular(obj));
  
    
   
 }
 
 return salida;
 
        }
        
       

        public int Calcular(int n)
        {
            
         
            if(n==1){
                return 1;

            }
            if (n == 2)
            {
                return 1;

            }


            return Calcular(n - 1) + Calcular(n - 2);

            
        
        }
    }
}
