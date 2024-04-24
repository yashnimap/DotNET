using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Anonymus
{
    public delegate string GreetingDelegates(string name);
    internal class Program
    {
        static void Main(string[] args)
        {
            GreetingDelegates obj = delegate (string name)
            {
                return "hellow" + name + " a very good morning.";
            };

            string str = obj.Invoke("Yash");
            Console.WriteLine(str);
        }
    }
}
