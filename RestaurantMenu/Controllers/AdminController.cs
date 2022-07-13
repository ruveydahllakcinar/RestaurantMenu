using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using RestaurantMenu.Models.Classes;

namespace RestaurantMenu.Controllers
{
    public class AdminController : Controller
    {
        // GET: Admin
        Context c = new Context();
        public ActionResult Index()
        {
            var values = c.FoodLists.ToList();
            return View(values);
        }
        [HttpGet]
        public ActionResult AddEat()
        {

            return View();
        }
       
        [HttpPost]
        public ActionResult AddEat(FoodList foodList)
        {
            c.FoodLists.Add(foodList);
            c.SaveChanges();
            return RedirectToAction("Index");
        }

        public ActionResult DeleteEat(int id)
        {
            var eat = c.FoodLists.Find(id);
            c.FoodLists.Remove(eat);
            c.SaveChanges();
            return RedirectToAction("Index");

        }

        public ActionResult MakeEat(int id)
        {
            List<SelectListItem> value1 = (from x in c.TypeofFoods.ToList()
                                           select new SelectListItem
                                           {
                                               Text = x.TypeName,
                                               Value = x.Id.ToString()
                                           }).ToList();
            ViewBag.vl1 = value1;
            var eats = c.FoodLists.Find(id);
            return View("MakeEat", eats);
        }
        public ActionResult UpdateEat(FoodList f)
        {
            var eat = c.FoodLists.Find(f.Id);
            eat.EatName = f.EatName;
            eat.Price = f.Price;
            eat.Explanation = f.Explanation;
        
            c.SaveChanges();
            return RedirectToAction("Index");
        }




    }
}