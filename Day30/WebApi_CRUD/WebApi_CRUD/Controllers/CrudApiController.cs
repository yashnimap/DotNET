using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebApi_CRUD.Models;

namespace WebApi_CRUD.Controllers
{
    public class CrudApiController : ApiController
    {
        WebApi_DbEntities1 db = new WebApi_DbEntities1 ();

        [HttpGet]
        public IHttpActionResult GetEmployee()
        { 
            List<Employee> emp = db.Employees.ToList();
            return Ok(emp);
        }

        [HttpPost]
        public IHttpActionResult GetEmployee(Employee emp)
        {
            db.Employees.Add(emp);
            db.SaveChanges();
            return Ok();
        }
    }
}
