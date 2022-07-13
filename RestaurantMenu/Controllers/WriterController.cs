using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using RestaurantMenu.Models.Classes;

namespace RestaurantMenu.Controllers
{
    public class WriterController : Controller
    {
        // GET: Writer
        Context c = new Context();
        public ActionResult Index()
        {
            var value = c.Blogs.ToList();
            return View(value);
        }
        [HttpGet]
        public ActionResult AddBlog()
        {
            return View();
        }

        [HttpPost]
        public ActionResult AddBlog(Blog blog)
        {
            c.Blogs.Add(blog);
            c.SaveChanges();
            return RedirectToAction("Index");
        }


        public ActionResult DeleteUser(int id)
        {
            var blog = c.Blogs.Find(id);
            c.Blogs.Remove(blog);
            c.SaveChanges();
            return RedirectToAction("Index");
        }

    }
}