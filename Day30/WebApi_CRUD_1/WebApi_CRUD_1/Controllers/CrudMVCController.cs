using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Web;
using System.Web.Mvc;
using WebApi_CRUD_1.Models;

namespace WebApi_CRUD_1.Controllers
{
    public class CrudMVCController : Controller
    {
        // GET: CrudMVC
        HttpClient client = new HttpClient();
        public ActionResult Index()
        {
            List<Employee> employees = new List<Employee>();
            client.BaseAddress = new Uri("http://localhost:55409/api/CrudApi");
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
            client.BaseAddress = new Uri("http://localhost:55409/api/CrudApi");
            var response = client.PostAsJsonAsync<Employee>("CrudApi", emp);
            response.Wait();

            var test = response.Result;
            if (test.IsSuccessStatusCode)
            {
                return RedirectToAction("Index");
            }
            return View("Create");
        }

        [HttpGet]
        public ActionResult Details(int id)
        {
            Employee e = null;
            client.BaseAddress = new Uri("http://localhost:55409/api/CrudApi");
            var response = client.GetAsync("CrudApi?id="+id.ToString());
            response.Wait();

            var test = response.Result;
            if (test.IsSuccessStatusCode)
            {
                var dislay = test.Content.ReadAsAsync<Employee>();
                dislay.Wait();
                e = dislay.Result;

            }
            return View(e);
        }

        [HttpGet]   
        public ActionResult Edit(int id ) 
        {
            Employee e = null;
            client.BaseAddress = new Uri("http://localhost:55409/api/CrudApi");
            var response = client.GetAsync("CrudApi?id=" + id.ToString());
            response.Wait();

            var test = response.Result;
            if (test.IsSuccessStatusCode)
            {
                var dislay = test.Content.ReadAsAsync<Employee>();
                dislay.Wait();
                e = dislay.Result;

            }
            return View(e);
        }

        [HttpPost]
        public ActionResult Edit(Employee e) 
        {
            client.BaseAddress = new Uri("http://localhost:55409/api/CrudApi");
            var response = client.PutAsJsonAsync<Employee>("CrudApi", e);
            response.Wait();

            var test = response.Result;
            if (test.IsSuccessStatusCode)
            {
                return RedirectToAction("Index");
            }
            return View("Edit");
        }

        public ActionResult Delete(int id)
        {
            Employee e = null;
            client.BaseAddress = new Uri("http://localhost:55409/api/CrudApi");
            var response = client.GetAsync("CrudApi?id="+ id.ToString());
            response.Wait();

            var test = response.Result;
            if (test.IsSuccessStatusCode)
            {
                var display = test.Content.ReadAsAsync<Employee>();
                display.Wait();
                e = display.Result;
            }
            return View(e);
        }

        [HttpDelete, ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id)
        {
            client.BaseAddress = new Uri("http://localhost:55409/api/CrudApi");
            var response = client.DeleteAsync("CrudApi?id="+ id.ToString());
            response.Wait();

            var test = response.Result;
            if (test.IsSuccessStatusCode)
            {

                return RedirectToAction("Index");
            }
            return View("Delete");
           
        }
    }
}