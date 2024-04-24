using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Extension_Method
{
    static class StaticClass
    {
        public static void Test3(this Program p)
        {
            Console.WriteLine("Method 3");
        }
    }
}
