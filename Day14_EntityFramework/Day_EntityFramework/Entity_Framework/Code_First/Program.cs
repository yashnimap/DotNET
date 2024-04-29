using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Code_First
{
    public class Cours {
        public int ID { get; set; }
        public string Name { get; set; }    
        public Author Author { get; set; }
        public CourseLevel Level { get; set; }
        public IList<Tag> Tags { get; set; }
    }
    public class Author { 
        public int ID { get; set; }
        public string Name { get; set; }
        public IList<Cours> courses { get; set; }  
    }
    public class Tag { 
        public int ID { get; set; }
        public string Name { get; set; }
        public IList<Cours> Courses { get; set; }

    }
    public enum CourseLevel { 
        Beginner = 1,
        Intermediate = 2,
        Advanced = 3
    }
    public class PlutoContext : DbContext
    {
        public DbSet<Cours> Courses { get;}
        public DbSet<Author> Author { get; set; }
        public DbSet<Tag> Tags { get;}

        public PlutoContext()
            : base("name=DefaultConnection")
        {

        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {

        }
    }
}
