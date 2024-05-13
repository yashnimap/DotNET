using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace EntityCodeFirst.Models
{
    public class NortwindContext : DbContext
    {
        public NortwindContext() 
            : base ("name=NortwindConnection")  
        { 

        }

        public DbSet<Category>  CategoriesTable { get; set; }
        public DbSet<Product> ProductTable { get; set; }
    }
}