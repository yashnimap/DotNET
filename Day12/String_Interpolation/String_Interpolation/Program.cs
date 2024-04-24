using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace String_Interpolation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 10;
            int b = 20;
            string s = "";
            string s1 = "The sum of " + a + " and " + b + " is " + (a + b);

            string s2 = string.Format("The sum of {0} and {1} is {2}",a , b, a+b);

            string s3 = $"The sum of {a} and {b} is {a+b}";

            Console.WriteLine(s1);
            Console.WriteLine(s2);
            Console.WriteLine(s3);

            Console.WriteLine(string.IsNullOrEmpty(s));

        }
    }
}
