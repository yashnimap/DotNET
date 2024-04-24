using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Threading
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Thread t1 = new Thread(function1);
            Thread t2 = new Thread(function2);  
            t1.Start();
            t2.Start();
        }
        static void function1()
        { 
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("finction 1 is executed "+ i);
                Thread.Sleep(3000);
            }
        }

        static void function2() {
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("finction 2 is executed " + i);
                Thread.Sleep(3000);
            }
        }
    }
}
