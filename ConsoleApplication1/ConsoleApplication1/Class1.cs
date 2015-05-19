using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Class1
    {
        int f;
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
