using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.EnterpriseServices.Internal;

namespace EntityCodeFirst.Models
{
    [Table("tblProduct")]
    public class Product
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
        public Category Category { get; set; }
   
   


    }
}