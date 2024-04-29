using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructor_Overloading
{
    public class Constructor_Overloading_Example
    {
        public Constructor_Overloading_Example() {
            Console.WriteLine("first construcor");
        }
        public Constructor_Overloading_Example(int a, int b) 
        :this()
        {
           
            Console.WriteLine("second constructor");
        }
        public Constructor_Overloading_Example(int a, int b, int c) 
           :this(a, b)        {
            Console.WriteLine("third constructor");
        } 
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            var c = new Constructor_Overloading_Example(10,20,30);


        }
    }
}
