using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace Routing
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
                name:"student",
                url:"students",
                defaults: new {controller = "Home", Action = "GetAllResult" }
                );
            
            routes.MapRoute(
                name: "AllStudent",
                url: "studentsf/{id}",
                defaults: new { controller = "Home", Action = "GetStudent", id = 1},
                //constraints: new {id = @"\d+"} 
                );

            routes.MapRoute(
                name: "Address",
                url: "students/{id}/Address",
                defaults: new { controller = "Home", Action = "GetStudentAddress", id = UrlParameter.Optional }
                );

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}
