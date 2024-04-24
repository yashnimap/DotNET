using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linq
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] a = { 34, 2, 3, 8, 5, 8, 5, 1, 0, 6, 8 };
            var b = from x in a where x >= 5 orderby x ascending select x;

            foreach ( var x in b )
            {
                Console.Write(x+" ");
            }
        }
    }
}
