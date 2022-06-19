using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using RestaurantMenu.Models.Classes;

namespace RestaurantMenu.Controllers
{
    public class MenuController : Controller
    {
        // GET: Menu
        Context c = new Context();
        public ActionResult Index()
        {
            var values = c.FoodLists.ToList();
            var query = from x in c.FoodLists
                        group x by x.TypeofFood into g
                        select new FoodList
                        {
                            TypeofFood = g.Key,
                            Id = g.Count()
                           
                           
                        };
            return View(values);
           
        }


    }
}