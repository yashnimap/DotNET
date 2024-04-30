using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IENUMERABLE_IENUMERATOR_IQUERYABLE
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ////IENUMERABLE Example
            //List<string> list = new List<string>();
            //list.Add("Nimap");
            //list.Add("Infotech");
            //list.Add("lower_parel");

            ////IEnumerable<string> ienumerbleemployees = list;

            ////foreach (string item in ienumerbleemployees)
            ////{
            ////    Console.WriteLine(item);
            ////}

            ////IENUMERATOR Example
            //IEnumerator<string> enumerator = list.GetEnumerator();
            //while (enumerator.MoveNext()) {
            //    Console.WriteLine(enumerator.Current);

            //}

            //int[] a = { 21, 32, 13, 4, 75, 36 };
            //var v = from B in a
            //        where B >= 50
            //        select B;
            //var v = a.Where(l1 => l1 >= 21);
            //foreach (int i in v)
            //{
            //    Console.WriteLine(i);
            //}

            string[] a = { "yash", "Mohan", "Jadhav" };
            //var v = from B in a
            //        where B == "Jadhav"
            //        select B;
            var v = a.Where(x => x == "Mohan ");
            if(v=false)
            {
                Console.WriteLine(v.ToString());
            }
            else
            {
                Console.WriteLine("not found");
            }
            //foreach (string i in v)
            //{
            //    Console.WriteLine(i);
            //}

        }
    }
}
