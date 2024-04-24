using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Multithreading_Constructor
{
    internal class Program
    {
        //static void Test()
        //{ 
        //    for (int i = 0; i < 10; i++)
        //    {
        //        Console.WriteLine("Test "+ i);
        //    }

        //}

        static void Test(Object max)
        {
            int num = Convert.ToInt32(max);
            for (int i = 0; i < num; i++)
            {
                Console.WriteLine("Test " + i);
            }

        }
        static void Main(string[] args)
        {
            //ThreadStart obj = new ThreadStart(Test); //here we are instantiated delegate explicitly
            //ThreadStart obj = Test;
            //ThreadStart obj = delegate () { Test(); }; //anonymus method
            //ThreadStart obj = () => Test(); //lambda expression

            ParameterizedThreadStart obj = new ParameterizedThreadStart(Test);
            Thread t1 = new Thread(obj);
            t1.Start(10);
        }
    }
}
