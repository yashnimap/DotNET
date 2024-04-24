using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegates
{
    public delegate void AddDelegate(int a, int b); 
    public delegate string sayDelegate(string s);
    internal class Program
    {
        public void AddNums(int a, int b) {
            Console.WriteLine(a+b);
        }
        public static string SayHellow(string name)
        {
            return "Hello "+name;
        }
        static void Main(string[] args)
        {
            Program p = new Program();
            AddDelegate a = new AddDelegate(p.AddNums);
            //a.Invoke(2,3);
            a(100, 200);
            sayDelegate s = new sayDelegate(SayHellow);
            //s.Invoke("Yash");
            string str = s("Yash");
            Console.WriteLine(str);
        }
    }
}
