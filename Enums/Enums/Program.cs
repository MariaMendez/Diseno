using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enums
{
    class Program
    {
        static void Main(string[] args)
        {
            //Esto es un codigo de porque es importante usar enums. Video1 Hola
    class Program
    {
        int f;
        static void Main(string[] args)
        {
            Customer[] customers= new Customer[3];
            customers[0] = new Customer
            {
                Name = "Pepe",
                Gender = 2

            };
            customers[1] = new Customer
            {
                Name = "Grettel",
                Gender = 2

            };
            customers[2] = new Customer
            {
                Name = "Luis",
                Gender = 0

            };
            foreach (Customer customer in customers)
            {
                Console.WriteLine("Name= {0} && Gender= {1}",customer.Name,GetGender(customer.Gender));
            }
             Console.ReadLine();
        }
            public static string GetGender(int gender)
            {
                    switch(gender){
                        case 0:
                            return "Unknown";
                        case 1:
                            return "Male";
                        case 2:
                            return "Female";
                        default:
                            return "Invalid number";
                    }
            } 
           
            
        }
        public class Customer
        {
            public string Name { get; set; }
            public int Gender { get; set; }
        }
        }
    }
}
