using Custom_Authentication.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;

namespace Custom_Authentication.Controllers
{
    public class AccountController : Controller
    {
        // GET: Account
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Index(User model)
        {
            if (model.UserName == "user" || model.Password == "user")
            {
                FormsAuthentication.SetAuthCookie(model.UserName, false);
                return RedirectToAction("index", "Home");
            }
            return View();
        }
    }
}