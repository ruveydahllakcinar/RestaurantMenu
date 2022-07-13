using RestaurantMenu.Models.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace RestaurantMenu.Controllers
{
    public class DefaultController : Controller
    {
        // GET: Default
        Context c = new Context();
        public ActionResult Index()
        {
            var values = c.Blogs.ToList();
            return View(values);
        }

        public PartialViewResult BlogPartial()
        {

            var degerler = c.Blogs.OrderByDescending(x => x.Id).Take(3).ToList();
            return PartialView(degerler);
        }
    }
}