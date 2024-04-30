using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diamond_Problems
{
    interface INTERFACEA
    {
        void method1();
        void method2();
    }

    interface INTERFACEB
    {
        void method1();
        void method2();
    }

    public class C :INTERFACEA , INTERFACEB
    {
        void INTERFACEA.method1() { Console.WriteLine("interfaceA method 1"); }
        void INTERFACEA.method2() { Console.WriteLine("interfaceA method 2"); }
        void INTERFACEB.method1() { Console.WriteLine("interfaceB method 1"); }
        void INTERFACEB.method2() { Console.WriteLine("interfaceB method 2"); }

        
    }
    internal class Program 
    {
        static void Main(string[] args)
        {
            INTERFACEA C = new C();
            C.method1();
            C.method2();

            INTERFACEB B = new C();
            B.method1();
            B.method2();

   
        }
    }
}
