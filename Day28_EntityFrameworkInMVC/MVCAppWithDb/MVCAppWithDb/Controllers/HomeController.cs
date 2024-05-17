using MyApp.Models;
using MyAppDb.DbOperation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCAppWithDb.Controllers
{
    public class HomeController : Controller
    {
        EmployeeRepository repository = null;
        
        public HomeController() { 
            repository = new EmployeeRepository();
        }
        
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(EmployeeModel model)
        { 
            if(ModelState.IsValid)
            {
                int id = repository.AddEmployee(model);
                if(id > 0) 
                { 
                    ModelState.Clear();
                    ViewBag.Issucess = "Data Added";
                }
            }
            return View();
        }

        
        public ActionResult GetAllRecords() { 
            var emp = repository.GetAllEmployees();
            return View(emp);  
        }

        public ActionResult Details(int id) {
            var emp = repository.GetEmployees(id);
            return View(emp);  
        }

        public ActionResult Edit(int id) { 
            var emp = repository.GetEmployees(id);
            return View(emp);
        }
    }
}