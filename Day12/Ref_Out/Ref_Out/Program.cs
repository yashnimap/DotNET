using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ref_Out
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //we must initialize ref but in out parameter no need to initialize
            //int count;       
            int count = 10;
            changeValue(ref count);

            Console.WriteLine(count);
            Console.ReadLine();
        }

        static void changeValue(ref int count)
        {
            //out parameter must initialize before returning but in ref no need to initialize 
            count = 50;
        }
    }
}
