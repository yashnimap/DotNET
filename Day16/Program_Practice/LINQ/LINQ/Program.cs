using System;
using System.Collections.Generic;
using System.Linq;

namespace LINQ
{
    internal class Program
    {

        static void Main(string[] args)
        {
           List<string> list = new List<string>();
           list.Add("SARTHAK");
           list.Add("Yashh");
           list.Add("Mayur");
            list.Add("adnan");
            list.Add("sharma");
            list.Add("nikhil");
            list.Add("niketan");

            //var x = list.Find(l1=>l1=="Yashh");
            //if (x ==null)
            //{
            //    Console.WriteLine("No matchuing valye");
            //}
            //else
            //{
            //   Console.WriteLine(x);
            //}

            //var startwith = list.Where(name => name.StartsWith("ni", System.StringComparison.OrdinalIgnoreCase)).ToList();
            //foreach (var item in startwith)
            //{
            //    Console.WriteLine(item);
            //}

            var s = (from b in list
                    where b=="Yashh"
                    select b).FirstOrDefault();
            if(s!=null)
            {
                Console.WriteLine(s);
            }
            else
            {
                Console.WriteLine("no");
            }
            //Console.WriteLine(s);


        }
    }
}
