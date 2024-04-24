using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace background_foreground_Thread
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Thread obj = new Thread(function1);
            obj.IsBackground = true;// in background thread all the thread will dies off if your main application dies off
            obj.Start();

            //The controll will come here and exit the main function
            Console.WriteLine("The main application has exit");//the foreground thread will keep executing even if the application quites here.
        }

        static void function1()
        {
            Console.WriteLine("Function 1 entered...");
            //wait here until user put any input
            Console.ReadLine();//waiting
            Console.WriteLine("Function 1 is exit");
        }
    }
}
