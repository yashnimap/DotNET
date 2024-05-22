using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Net.Http;
using System.Web;
using System.Web.Mvc;
using WebApi_CRUD.Models;

namespace WebApi_CRUD.Controllers
{
    public class CrudMVCController : Controller
    {
        // GET: CrudMVC
        HttpClient client = new HttpClient();
        public ActionResult Index()
        {
            List<Employee> employees = new List<Employee>();
            client.BaseAddress = new Uri("http://localhost:50128/api/CrudApi");
            var response = client.GetAsync("CrudApi");
            response.Wait();

            var test = response.Result;
            if (test.IsSuccessStatusCode)
            {
                var dislay = test.Content.ReadAsAsync<List<Employee>>();
                dislay.Wait();
                employees = dislay.Result;  
            }
            return View(employees); 
        }

        
        public ActionResult Create() { 
            return View();
        }

        [HttpPost]
        public ActionResult Create(Employee emp)
        {
            client.BaseAddress = new Uri("http://localhost:50128/api/CrudApi");
            var response = client.PostAsJsonAsync<Employee>("CrudApi",emp);
            response.Wait();

            var test = response.Result;
            if (test.IsSuccessStatusCode)
            {
                return RedirectToAction("Index");
            }
            return View("Create");
        }
    }

}