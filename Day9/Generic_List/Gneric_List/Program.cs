using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gneric_List
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Generic generic = new Generic();
            //bool obj = generic.comapare<float>(56.6f, 56.6f);
            //Console.WriteLine(obj);

            Generic2<int> generic2 = new Generic2<int>();
            generic2.Add(3, 5);
            generic2.Sub(3, 3);
            generic2.Mul(3, 5);
        }
    }
}
