using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Mvc;
using HttpPostAttribute = System.Web.Http.HttpPostAttribute;

namespace AspNetFirstWebApi.Controllers
{
    public class EmployeesDataController : ApiController
    {
        //public string[] myEmployees = { "rahul", "jeet", "yash", "sarthak", "mayur", "sharma", "siddiq" };
        //public string[] GetEmployess()
        //{
        //    return myEmployees;
        //}

        //[HttpGet]
        //public string GetEmployeesByIndex(int id)
        //{
        //    return myEmployees[id];
        //}

        static List<string> emp = new List<string>
        {
            "siddiq", "Aarif", "Adnan","jeet"
        };

        
        public IEnumerable<string> GetAllEmp()
        { 
            return emp;
        }

        public string getId(int id)
        {
            return emp[id];
        }

        [HttpPost]
        public void PostEmp([FromBody] string value) { 
            emp.Add(value);
            
        }

        public void putEmp(int id , [FromBody] string value)
        {
            emp[id] = value;

        }

        public void deleteEmp(int id)
        {
            emp.RemoveAt(id);
        }
    }
}
