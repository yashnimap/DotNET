using Custom_Authentication.filters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Custom_Authentication.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        //[YashAuthentication]
        [MyActionFilter]
        public ActionResult Index()
        {
            return View();
        }
    }
}