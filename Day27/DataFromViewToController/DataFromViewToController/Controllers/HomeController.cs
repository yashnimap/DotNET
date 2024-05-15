using DataFromViewToController.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DataFromViewToController.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet]
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public string PostUsingParameter(string firstName,string lastName)
        {
            return "From parameters - "+firstName+" "+lastName;  
        }

        public string PostUsingRequest()
        {
            string firstName = Request["firstName"];
            string lastName = Request["lastName"];

            return "From request - " + firstName + " " + lastName;
        }

        public string PostUsingFormCollection(FormCollection form)
        {
            string firstName = form["firstName"];
            string lastName = form["lastName"];

            return "From formCollection - " + firstName + " " + lastName;
        }

        public string PostUsingBinding(Employee emp)
        {
            return "From Binding - " + emp.firstName + " " + emp.lastName;
        }
    }
}