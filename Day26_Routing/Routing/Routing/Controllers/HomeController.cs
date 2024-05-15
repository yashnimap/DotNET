using Routing.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Routing.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult GetAllResult()
        {
            var student = GetStudents();
            return View(student);
        }

        public ActionResult GetStudent(int id)
        {
            var student = GetStudents().FirstOrDefault(x => x.Id==id);   
            return View(student);
        }

        public ActionResult GetStudentAddress(int id) 
        {
            var student = GetStudents().Where(x => x.Id == id).Select(x => x.Address).FirstOrDefault();
            return View(student);
        }

        private List<Student> GetStudents()
        {
            return new List<Student>()
            {
                new Student()
                {
                    Id = 1,
                    Name = "Yash",
                    Class = "First",
                    Address = new Address()
                    {
                        HomeNumber = "101",
                        Address1 = "Bhiwandi",
                        city = "Bhiwandi_city"
                    }
                },
                new Student()
                {
                    Id = 2,
                    Name = "Rahul",
                    Class = "Second",
                    Address = new Address()
                    {
                        HomeNumber = "102",
                        Address1 = "Lower_Parel",
                        city = "Mumbai"
                    }
                },
                new Student()
                {
                    Id = 3,
                    Name = "Nikhil",
                    Class = "Third",
                    Address = new Address()
                    {
                        HomeNumber = "103",
                        Address1 = "Boriwali",
                        city = "Palghar"
                    }
                },
                new Student()
                {
                    Id = 4,
                    Name = "Jeet",
                    Class = "First",
                    Address = new Address()
                    {
                        HomeNumber = "104",
                        Address1 = "Mira_road",
                        city = "Virar"
                    }
                }
            };
        }
    }
}