using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generic_Customer
{
    public class Customer
    {
        public int Id { get; set; }
        public string Name { get; set; }    
        public string Ciy { get; set; }

    }
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Customer> list = new List<Customer>();
            Customer customer = new Customer { Id = 1, Name = "Yash", Ciy = "Thane" };
            Customer customer2 = new Customer { Id = 2, Name = "Jadhav", Ciy = "Mumbai" };
            list.Add(customer);
            list.Add(customer2);

            
            foreach (var item in list)
            {
                Console.WriteLine(item.Id +" "+item.Name+" "+item.Ciy);
            }
        }
    }
}
