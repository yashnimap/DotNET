using FirstMVC_Program.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FirstMVC_Program.Controllers
{
    public class MoviesController : Controller
    {
        // GET: Movies
        //public ActionResult Random()
        //{
        //    var movie = new Movie { Name = "All of us are dead"};
        //    return View(movie);
        //    //return Content("hello yash"); //it will print content we have pass
        //    //return HttpNotFound();        //it will show page not found
        //    //return new EmptyResult();     //it will show an empty page
        //    //return RedirectToAction("Index", "Home", new { page = 1, sortBy = "name"});  //it is used to redirect from one page to another page
        //}

        //public ActionResult Edit(int id) {
        //    return Content("id = " + id);
        //}

        //public ActionResult Index(int? pageIndex, string sortBy)
        //{ 
        //    if(!pageIndex.HasValue) 
        //        pageIndex = 1;
        //    if (string.IsNullOrWhiteSpace(sortBy))
        //        sortBy = "Name";

        //    return Content(string.Format("pageIndex={0}&sortBy={1}",pageIndex, sortBy));    
        //}

        //public ActionResult ByReleaseDate(int year, int month)
        //{
        //    return Content(year + "-" + month);
        //}

        //another way to pass data to view
        public ActionResult Random() {
            var movie = new Movie { Name = "All of us are dead" };
            ViewData["Movie"] = movie;
            ViewBag.Movie = movie;

            return View();
        }
    }
}