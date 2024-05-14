using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Vidly.Models;
using Vidly.ViewModels;

namespace Vidly.Controllers
{
    public class MoviesController : Controller
    {
        private IEnumerable<Movie> GetMovies()
        {
            return new List<Movie>
            {
                new Movie{Id =1 , Name = "All of us are dead"},
                new Movie{Id =2 , Name = "Game of thrones"}
            };
        }

        public ViewResult Index()
        { 
            var movies = GetMovies();
            return View(movies);
        }
        
    }
}