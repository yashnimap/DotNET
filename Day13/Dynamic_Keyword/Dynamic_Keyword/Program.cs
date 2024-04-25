using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dynamic_Keyword
{
    internal class Program
    {
        static void Main(string[] args)
        {
            dynamic dynamicVariable = 10;

            Console.WriteLine("Dynamic variable: " + dynamicVariable);

            dynamicVariable = "Hello, dynamic!";
            Console.WriteLine("Dynamic variable: " + dynamicVariable);

            dynamic result = Add(5, 3);
            Console.WriteLine("Result of dynamic addition: " + result); 

            result = Add("5", "3"); 
            Console.WriteLine("Result of dynamic addition: " + result); 
        }
        static dynamic Add(dynamic a, dynamic b)
        {
            return a + b;
        }
    }
}
