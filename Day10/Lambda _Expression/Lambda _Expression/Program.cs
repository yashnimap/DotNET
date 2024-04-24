using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Lambda__Expression
{
    public delegate string GreetingDelegate(string name);
    internal class Program
    {
        //public static string Greeting(string name)
        //{
        //    return "Hello " + name + "a very good morning";
        //}
        static void Main(string[] args)
        {
            //GreetingDelegate obj = new GreetingDelegate(Greeting);

            //Anonymus method
            //GreetingDelegate obj = delegate (string name)
            //{
            //    return "hellow " + name + " a very good morning";
            //};

            //lambda Expression
            GreetingDelegate obj = (name) =>
            {
                return "hellow " + name + " a very good morning";
            };

            string str = obj.Invoke("Yash");
            Console.WriteLine(str);

        }
    }
}
