using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Async_Await
{
    internal class Program
    {
        public static async void Task1()
        {
            await Task.Run(() =>
            {
                Console.WriteLine("Task1 is started....");
                Thread.Sleep(4000);
                Console.WriteLine("Task1 is completed...");
            });
            
        }

        public static async void Task2()
        {
            await Task.Run(() =>
            {
                Console.WriteLine("Task2 is started....");
                Thread.Sleep(2000);
                Console.WriteLine("Task2 is completed...");
            });
            Console.WriteLine("hellow");
        }

        public static async void Task3()
        {
            await Task.Run(() =>
            {
                Console.WriteLine("Task3 is started....");
                Thread.Sleep(2000);
                Console.WriteLine("Task3 is completed...");
            });
            
            
        }

        public static async void Task4()
        {
            await Task.Run(() =>
            {
                Console.WriteLine("Task4 is started....");
                Thread.Sleep(1000);
                Console.WriteLine("Task4 is completed...");
            });
            
        }
        static void Main(string[] args)
        {
            Task1();
            Task2();
            Task3();
            Task4();
            Console.ReadLine();
        }
    }
}
