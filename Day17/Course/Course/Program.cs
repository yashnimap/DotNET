using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using static CodeFirst.Program;

namespace CodeFirst
{
    internal class Program
    {
        public class Course
        {
            public int ID { get; set; }
            public string Name { get; set; }
            public Author Author { get; set; }
            public CourseLevel Level { get; set; }
            public IList<Tag> Tags { get; set; }
        }
        public class Author
        {
            public int ID { get; set; }
            public string Name { get; set; }
            public IList<Course> courses { get; set; }
        }

        public class Tag
        {
            public int ID { get; set; }
            public string Name { get; set; }
            public IList<Course> Courses { get; set; }

        }

        public enum CourseLevel
        {
            Beginner = 1,
            Intermediate = 2,
            Advanced = 3
        }

        public class PlutoContext : DbContext
        {
            public DbSet<Course> Courses { get; }
            public DbSet<Author> Author { get; set; }
            public DbSet<Tag> Tags { get; }

            public PlutoContext()
                : base("name=DefaultConnection")
            {

            }
        }
        static void Main(string[] args)
        {

        }
    }
}
