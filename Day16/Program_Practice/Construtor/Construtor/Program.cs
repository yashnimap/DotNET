using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Construtor
{
    public class Construor_Example { 
        public Construor_Example() {
            Console.WriteLine("constructor is executed");
        }  
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            var a = new Construor_Example();
        }
    }
}
