using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity_Framework
{
    public class Post
    {
        public int Id { get; set; } 
        public string Name { get; set; }
        public string Description { get; set; }
        public string Author { get; set; }
        public DateTime Created { get; set; }

    }

    public class BlogDbContext : DbContext
    {
        public DbSet<Post> Posts { get; set; }  
    }
    internal class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
