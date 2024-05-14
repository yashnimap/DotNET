using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using View.Models;

namespace View.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            ViewBag.companyName = "Nimap Infotech";

            ViewBag.mylist = new List<string> { "India, USA, Russia, England"};

            List<Employee> emplist = new List<Employee>
            {
                new Employee(){Id=1, name = "Yash", salary = 15000},
                new Employee(){Id=2, name = "sarthak", salary = 20000},
                new Employee() {Id=3, name = "Jeet", salary = 3456},
                new Employee() {Id=4, name = "sharma", salary=8903}
            };

            ViewBag.myEmpList = emplist;    
            return View();
        }
    }
}