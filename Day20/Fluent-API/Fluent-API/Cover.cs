using DataAnnotations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fluent_API
{
    public class Cover
    {
        public int Id {  get; set; }
        public Course course { get; set; }  
    }
}
