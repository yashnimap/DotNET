using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Custom_Authentication.filters
{
    public class MyActionFilter : FilterAttribute,IActionFilter
    {
        public void OnActionExecuted(ActionExecutedContext filterContext)
        {
            Debug.WriteLine("hellow from action filter OnActionExecuted");
            filterContext.Controller.ViewBag.Message = "Yash from action filter";
        }

        public void OnActionExecuting(ActionExecutingContext filterContext)
        {
            Debug.WriteLine("hellow from action filter OnActionExecuting");
        }
    }
}