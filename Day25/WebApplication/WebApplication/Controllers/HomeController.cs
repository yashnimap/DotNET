using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplication.Controllers
{
    public class HomeController : Controller
    {
        public string Index()
        {
            return "Hello From Nimap";
        }
        public string Name() {
            return "Hello Yash From Nimap";
        }
    }
}