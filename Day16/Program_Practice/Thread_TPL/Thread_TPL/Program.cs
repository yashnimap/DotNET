using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Thread_TPL
{
    internal class Program
    {
        static void HeavyTask1() { 
            for(int i = 0; i < 10000; i++) 
            { 
                for(int j = 0; j <10000; j++)
                {
                    for (int k = 0; k < 10000; k++) 
                    {
                        var x = 0;
                        x++;
                    }
                } 
            }
        }

        static void HeavyTask2() {
            for (int i = 0; i < 10000; i++)
            {
                for (int j = 0; j < 10000; j++)
                {
                    for (int k = 0; k < 10000; k++)
                    {
                        var x = 0;
                        x++;
                    }
                }
            }
        }
        static void Main(string[] args)
        {
            //with the help of thread
            //Thread t1 = new Thread(new ThreadStart(HeavyTask1));
            //t1.Start();
            //Thread t2 = new Thread(new ThreadStart(HeavyTask2));
            //t2.Start();

            //with the help of task
            Task t1 = new Task(HeavyTask1);
            t1.Start();
            Task t2 = new Task(HeavyTask2);
            t2.Start();

            //Task t1 = Task.Run(() => HeavyTask1());
            //Task t2 = Task.Run(() => HeavyTask2());
            Console.WriteLine("hii");
            Console.Read();
            Console.WriteLine("hii");

        }
    }
}
