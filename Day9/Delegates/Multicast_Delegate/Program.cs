using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Multicast_Delegate
{
    delegate void ReactDelegate(double Width, double Height);
    internal class Program
    {
        public void GetArea(double Width, double Height)
        {
            Console.WriteLine("Area of rectangle :"+Width*Height);
        }
        public void GetPerimeter(double Width, double Height)
        { 
            Console.WriteLine("Perimeter of rectangle: "+2*(Width+Height));
        }
        static void Main(string[] args)
        {
           Program p = new Program();
            ReactDelegate obj = p.GetArea;
            obj += p.GetPerimeter;

            obj.Invoke(12.34, 56.78);

        }
    }
}
