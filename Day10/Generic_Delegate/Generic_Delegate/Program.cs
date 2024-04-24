using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generic_Delegate
{
    internal class Program
    {
        //public delegate double Delegate1(int x, float y, double z);
        //public delegate void Delegate2(int x, float y, double z);
        //public delegate bool Delegate3(string str);
        public static double AddNums1(int x, float y, double z)
        { 
            return x + y + z;
        }
        public static void AddNums2(int x, float y, double z)
        {
            Console.WriteLine(x+y+z);
        }
        public static bool checkLength(string str)
        {
            if (str.Length > 5)
            {
                return true;
            }
            return false;
        }
        static void Main(string[] args)
        {
            //lambda expression
            Func<int, float, double, double> obj1 = (x, y, z) => { return x + y + z; };
            double result = obj1.Invoke(23, 4.0f, 4.5);
            Console.WriteLine(result);

            Action<int, float, double> obj2 = (x, y, z) => { Console.WriteLine(x + y + z); };
            obj2.Invoke(3, 2.5f, 4.0);

            Predicate<string> obj3 = (str) =>
            {
                if (str.Length > 5)
                {
                    return true;
                }
                return false;
            };
            bool s = obj3.Invoke("Yash");
            Console.WriteLine(s);
        }
    }
}
