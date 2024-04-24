using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nullable_Types
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //bool? AreYouMajor = true;
            //if (AreYouMajor == true)
            //{
            //    Console.WriteLine("user is major");
            //}
            //else if (AreYouMajor == false)
            //{
            //    Console.WriteLine("user is not major");
            //}
            //else
            //{
            //    Console.WriteLine("user did not answer the questions");
            //}

            int? nullableValue = null;

            // Using the null coalescing operator to assign a default value if nullableValue is null
            int nonNullableValue = nullableValue ?? 10; // If nullableValue is null, assign 10

            Console.WriteLine(nonNullableValue); // Output will be 10

            dynamic name = "yash";
            Console.WriteLine(name);
            name = 10;
            int i = 0;
            i = 1;
            Console.WriteLine(name);
            Console.WriteLine(i);
        }
    }
}
