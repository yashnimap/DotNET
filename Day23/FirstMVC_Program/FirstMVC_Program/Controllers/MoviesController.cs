using FirstMVC_Program.Models;
using FirstMVC_Program.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FirstMVC_Program.Controllers
{
    public class MoviesController : Controller
    {
        public ActionResult Random() {
            var movie = new Movie { Name = "All of us are dead" };
            var customer = new List<Customer>
            {
                new Customer{ Name = "Customer 1"},
                new Customer{ Name = "Customer 2"},
                //new Customer{ Name = "Customer 3"},
                //new Customer{ Name = "Customer 4"},
                //new Customer{ Name = "Customer 5"},
                //new Customer{ Name = "Customer 6"}
            };

            var viewModels = new RandomMovieViewModels
            {
                Movie = movie,
                Customers = customer
            };
            return View(viewModels);
        }
    }
}