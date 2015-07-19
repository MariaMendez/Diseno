using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConceptsEnums
{
    class Program
    {
        static void Main(string[] args)
        {
       int[] Values=  (int[])Enum.GetValues(typeof(Gender));
       foreach (int values in Values)
       {
           Console.WriteLine(values);
       }
       string[] Names = Enum.GetNames(typeof(Gender));
       foreach (string names in Names)
       {
           Console.WriteLine(names);
       }
       Console.ReadLine();
        }
       
    }
    public enum Gender
    {
        Unknown,
        Male,
        Female

    }
}
