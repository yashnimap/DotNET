using ModelsInMVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ModelsInMVC.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            var data = getEmployees();
            return View(data);
        }

        private Employee getEmployees() { 
            return new Employee 
            {
                Id = 1,
                Name = "Yash Jadhav",
                Address = "Nimap Infotech"
            };
        }
    }
}