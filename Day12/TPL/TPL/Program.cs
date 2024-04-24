using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPL
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Parallel.For(0, 1000000, x => RunMillonIterations());
            //Console.Read();

            int[] number = {1,2,3,4,5,6,7,8,9};
            Parallel.For(0, number.Length, i =>
            {
                Console.WriteLine($"square of {number[i]} is {number[i] * number[i]}");
            });
        }

        private static void RunMillonIterations()
        {
            string x = "";
            for (int iIndex = 0; iIndex < 1000000; iIndex++)
            {
                x = x + "s";
            }
        }
    }
}
