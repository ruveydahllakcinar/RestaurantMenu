using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using RestaurantMenu.Models.Classes;
namespace RestaurantMenu.Controllers
{
    public class BlogController : Controller
    {
        // GET: Blog
        Context c = new Context();
        BlogComment bc = new BlogComment();
        public ActionResult Index()
        {
            bc.Value1 = c.Blogs.ToList();
            bc.Value3 = c.Blogs.Take(2).ToList();
            return View(bc);
        }

        public ActionResult BlogDetail(int id)
        {
            bc.Value1 = c.Blogs.Where(x => x.Id == id).ToList();
            bc.Value2 = c.Comments.Where(x => x.BlogId == id).ToList();
            return View(bc);
        }
        public PartialViewResult BlogList()
        {
            bc.Value1 = c.Blogs.ToList();
            bc.Value3 = c.Blogs.Take(3).ToList();
            return PartialView(bc);
        }

        [HttpGet]
        public PartialViewResult WriteComment(int id)
        {
            ViewBag.value = id;
            return PartialView();
        }


        [HttpPost]
        public PartialViewResult WriteComment(Comments comments)
        {
            c.Comments.Add(comments);
            c.SaveChanges();
            return PartialView();
        }
    }
}