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
            //IENUMERABLE Example
            List<string> list = new List<string>();
            list.Add("Nimap");
            list.Add("Infotech");
            list.Add("lower_parel");

            //IEnumerable<string> ienumerbleemployees = list;

            //foreach (string item in ienumerbleemployees)
            //{
            //    Console.WriteLine(item);
            //}

            //IENUMERATOR Example
            IEnumerator<string> enumerator = list.GetEnumerator();
            while (enumerator.MoveNext()) {
                Console.WriteLine(enumerator.Current);

            }

        }
    }
}
