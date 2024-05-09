using EntityCodeFirst.Models;
using System.Linq;
using System.Web.Mvc;

namespace EntityCodeFirst.Controllers
{
    public class NorthwindController : Controller
    {
        
        // GET: Northwind

        NortwindContext db = new NortwindContext();

        public ActionResult Index()
        {
            db.CategoriesTable.ToList();
            db.ProductTable.ToList();
            return View();
        }
    }
}