using DataAnnotations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fluent_API
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var context = new PlutoContext();

            //Linq Syntax
            var query = from c in context.Courses
                        where c.Name.Contains("c#")
                        orderby c.Name
                        select c;
            //foreach (var item in query)
            //{
            //    Console.WriteLine(item.Name);
            //    //Console.WriteLine(item.Id+" "+item.Name+" "+item.Description);
            //}

            //Extension method
            var courses = context.Courses
                .Where(c => c.Name.Contains("c#"))
                .OrderBy(c => c.Name);

            foreach (var item in query)
            {
                Console.WriteLine(item.Name);
            }
        }
    }
}

