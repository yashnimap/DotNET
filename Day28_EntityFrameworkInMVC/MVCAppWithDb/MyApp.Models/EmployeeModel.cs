using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace MyApp.Models
{
    public class EmployeeModel
    {
        public int id { get; set; }
        
        [Required]
        public string FirstName { get; set; }
        
        [Required]
        public string LastName { get; set; }
        
        [EmailAddress]
        public string Email { get; set; }
        
        public int? Addressid { get; set; }
        public AddressModel address { get; set; }

        [Required]
        public string Code { get; set; }
    }
}
