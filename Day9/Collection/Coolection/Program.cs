using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;
using System.Threading.Tasks;

namespace Coolection
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Hashtable ht = new Hashtable();
            ht.Add("Eid", 1010);
            ht.Add("Ename", "Scott");
            ht.Add("Job", "Manager");
            ht.Add("Salary", 25000.00);
            ht.Add("Mgrid", 1001);
            ht.Add("phone", "2345356");
            ht.Add("Email", "yashjadhav@1892.com");
            ht.Add("Location", "Mumbai");
            ht.Add("Dname", "sales");
            ht.Add("Did", 30);

            //Console.WriteLine(ht["Email"]);
            foreach (var item in ht.Keys)
            {
                Console.WriteLine(item+":  " + ht[item]);
            }
            //Console.WriteLine(ht["Salary"].GetHashCode());


    
        }
    }
}
