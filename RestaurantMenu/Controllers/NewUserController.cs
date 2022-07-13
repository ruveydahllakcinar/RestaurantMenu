using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using RestaurantMenu.Models.Classes;

namespace RestaurantMenu.Controllers
{
    public class NewUserController : Controller
    {
        // GET: NewUser
        Context c = new Context();
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult AddNewUser(NewMember nm)
        {
            c.NewMembers.Add(nm);
            c.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}