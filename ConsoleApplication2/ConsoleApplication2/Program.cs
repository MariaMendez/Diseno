using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enums2
{
    class Program
    {
 
        static void Main(string[] args)
        {
           
            Customer[] customers= new Customer[3];
            customers[0] = new Customer
            {
                Name = "Pepe",
                Gender = Gender.Male

            };
            customers[1] = new Customer
            {
                Name = "Grettel",
                Gender = Gender.Female

            };
            customers[2] = new Customer
            {
                Name = "Luis",
                Gender = Gender.Unknown

            };
            foreach (Customer customer in customers)
            {
                Console.WriteLine("Name= {0} && Gender= {1}",customer.Name,GetGender(customer.Gender));
            }
             Console.ReadLine();
        }
            public static string GetGender(Gender gender)
            {
                    switch(gender){
                        case Gender.Unknown:
                            return "Unknown";
                        case Gender.Male:
                            return "Male";
                        case Gender.Female:
                            return "Female";
                        default:
                            return "Invalid number";
                    }
            } 
      
        }
        public enum Gender{
            Unknown,
            Male,
            Female
        }
        //0- Unknown
        //1- Male
        //2- Female

        public class Customer
        {
            public string Name { get; set; }
            public Gender Gender { get; set; }
        }
        }
    

