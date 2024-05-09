using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace EntityCodeFirst.Models
{
    [Table("tablCategories")]
    public class Category
    {
        [Key]
        public int categId {  get; set; }
        public string categName { get; set; }

    }
}