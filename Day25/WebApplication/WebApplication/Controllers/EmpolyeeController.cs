using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplication.Controllers
{
    public class EmpolyeeController : Controller
    {
        public string EmployeeProfile(int id)
        {
            string profile = string.Empty;
            
            if(id == 1) {
                profile = "Employee 1 profile";
            }
            else if(id == 2) {
                profile = "Employee 1 profile";
            }
            else {
                profile = "No record found";
            }
            return profile;
        }
        public string Address(int id, string department)
        {
            return "id = " + id + " dept = " + department;
        }

        public string Address1(int id, int? code=null)
        {
            return "id = " + id + " code = " + code;
        }
    }
    
}