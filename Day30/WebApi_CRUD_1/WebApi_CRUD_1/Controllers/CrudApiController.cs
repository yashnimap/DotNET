using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Mvc;
using WebApi_CRUD_1.Models;

namespace WebApi_CRUD_1.Controllers
{
    public class CrudApiController : ApiController
    {
        WebApi_DbEntities1 db = new WebApi_DbEntities1();

        [System.Web.Http.HttpGet]
        public IHttpActionResult GetEmployee()
        {
            List<Employee> emp = db.Employees.ToList();
            return Ok(emp);
        }

        [System.Web.Http.HttpGet]
        public IHttpActionResult GetEmployeeById(int id)
        {
            var emp = db.Employees.Where(model => model.id == id).FirstOrDefault();
            return Ok(emp);
        }

        [System.Web.Http.HttpPost]
        public IHttpActionResult GetEmployee(Employee emp)
        {
            db.Employees.Add(emp);
            db.SaveChanges();
            return Ok();
        }

        [System.Web.Http.HttpPut]
        public IHttpActionResult EmpUpadate(Employee e) 
        {
            var emp = db.Employees.Where(x => x.id == e.id).FirstOrDefault();
            if (emp != null)
            {
                emp.id = e.id;
                emp.name = e.name;
                emp.gender = e.gender;
                emp.age = e.age;
                emp.designation = e.designation;
                emp.salary = e.salary;

                db.SaveChanges();
            }
            else 
            { 
                return NotFound();  
            }

            return Ok();
        }

        [System.Web.Mvc.HttpDelete]
        public IHttpActionResult EmpDelete(int id)
        {
            var emp = db.Employees.Where(model => model.id == id).FirstOrDefault();
            db.Entry(emp).State = System.Data.Entity.EntityState.Deleted;
            db.SaveChanges();
            return Ok();
        }
    }
}
