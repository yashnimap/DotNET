using DataAnnotations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Queries

{
    internal class Program
    {
        static void Main(string[] args)
        {
            var context = new PlutoContext();

            //Restriction
            var queries1 = from a in context.Courses
                           where a.Level == 1
                           select a;

            //ordering
            var queries2 = from a in context.Courses
                           where a.AuthorId==2
                           orderby a.Level , a.Name
                           select a;


            //Projecion
            var queries3 = from a in context.Courses
                           where a.AuthorId == 2
                           orderby a.Level, a.Name descending
                           select new { Name = a.Name, Author = a.Author.Name };

            //Grouping
            var query = from a in context.Courses
                        group a by a.Level
                        into g
                        select g;

            //foreach ( var group in query ) {
            //    Console.WriteLine(group.Key);

            //    foreach (var courses in group)
            //    {
            //        Console.WriteLine(courses.Name);
            //    }
            //}
            //foreach (var item in query)
            //{
            //    Console.WriteLine("{0},({1})",item.Key ,item.Count());
            //}


            //inner join
            var queries4 = from c in context.Courses
                           join a in context.Authors on c.AuthorId equals a.Id 
                           select c;


            //group join 
            var queries5 = from a in context.Authors
                           join c in context.Courses
                           on a.Id equals c.AuthorId into g
                           select new { AuthorName = a.Name , Course = g.Count()};

            //Cross join
            var queries6 = from a in context.Authors
                           from c in context.Courses
                           select new { AuthorName = a.Name, CourseName = c.Name };

            //foreach (var x in queries6)
            //{
            //    Console.WriteLine("{0} ({1})", x.AuthorName , x.CourseName);
            //}


            //====================Linq Extension Method================================
            
            //Restriction
            var queries7 = context.Courses.Where(c => c.AuthorId == 1);

            //ordering
            var queries8 = context.Courses
                .Where(c => c.Level == 1)
                .OrderByDescending(c => c.Name)
                .ThenBy(c => c.Level);

            //Projection
            var queries9 = context.Courses
                .Where(c => c.Level == 1)
                .OrderByDescending(c => c.Name)
                .ThenBy(c => c.Level)
                .SelectMany(c => c.Tags)
                .Distinct();

            //GroupBy
            var queries10 = context.Courses
                .GroupBy(c => c.Level);

            //foreach (var x in queries10)
            //{
            //    Console.WriteLine("Keys :" + x.Key);

            //    foreach (var item in x)
            //    {
            //        Console.WriteLine("\t"+item.Name);
            //    }
            //}

            //join
            var v =  context.Courses
                .Join(context.Authors, 
                c => c.AuthorId, 
                a => a.Id, 
                (course , author) => new
                {
                    CourseName = course.Name,
                    AuthorName = author.Name
                });

            foreach (var item in v)
            {
                Console.WriteLine( item.CourseName + " "+ item.AuthorName);
            }
        }
    }
}

