using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Validations.Models
{   
    public class Employee
    {
        [Required(ErrorMessage ="Please enter your fist name")] //custome error message
        public string firstName {  get; set; }
        
        [Required(ErrorMessage ="Please enter your last name")]
        public string lastName { get; set; }
        
        [Required]
        [EmailAddress]
        public string Email {  get; set; }
        
        [Required]
        [Range(18,60)]
        public int age { get; set; }    
    }
}