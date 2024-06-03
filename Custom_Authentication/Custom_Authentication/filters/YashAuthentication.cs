using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Web;
using System.Web.Mvc;
using System.Web.Mvc.Filters;

namespace Custom_Authentication.filters
{
    public class YashAuthentication : ActionFilterAttribute, IAuthenticationFilter
    {
        public string ViewName { get; private set; }

        public void OnAuthentication(AuthenticationContext filterContext)
        {
            if (!filterContext.HttpContext.User.Identity.IsAuthenticated)
            {
                filterContext.Result = new HttpUnauthorizedResult();
            }
                
        }

        public void OnAuthenticationChallenge(AuthenticationChallengeContext filterContext)
        {
            if (filterContext.Result == null || filterContext.Result is HttpUnauthorizedResult)
            {
                filterContext.Result = new ViewResult();
                {
                    ViewName = "Error";
                };
            }
        }
    }
}