using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Extension_Method
{
    internal class Program
    {
        public void Test1()
        {
            Console.WriteLine("Method 1");
        }
        public void Test2() 
        {
            Console.WriteLine("Method 2");
        }
        static void Main(string[] args)
        {
            Program program = new Program();
            program.Test1();
            program.Test2();

            program.Test3();
        }
    }
}
