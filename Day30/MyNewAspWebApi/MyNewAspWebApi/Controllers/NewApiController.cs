using MyNewAspWebApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Mvc;
using System.Web.Mvc.Razor;
using System.Web.UI.WebControls;

namespace MyNewAspWebApi.Controllers
{
    public class NewApiController : ApiController
    {
        ExampleDataEntities1 db = new ExampleDataEntities1 ();

        [System.Web.Http.HttpGet]
        public IHttpActionResult Action()
        {
            List<Product> products = db.Products.ToList();
            return Ok(products);
        }

        [System.Web.Http.HttpGet]
        public IHttpActionResult Action(int id)
        {
            var products = db.Products.Where(x => x.id == id).FirstOrDefault();
            return Ok(products);
        }
    }
}
