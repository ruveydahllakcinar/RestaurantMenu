using System;
using System.Collections.Generic;
using System.IO;
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
            if (Request.Files.Count > 0)
            {
                string filename = Path.GetFileName(Request.Files[0].FileName);
                string extension = Path.GetExtension(Request.Files[0].FileName);
                string link = "~/Image/" + filename + extension;
                Request.Files[0].SaveAs(Server.MapPath(link));
                blog.BlogImg = "/Image/" + filename + extension;

            }
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
        public ActionResult MakeBlog(int id)
        {
            var blog = c.Blogs.Find(id);
            return View("MakeBlog", blog);
        }
        public ActionResult UpdateBlog(Blog b)
        {

            if (Request.Files.Count > 0)
            {
                string filename = Path.GetFileName(Request.Files[0].FileName);
                string extension = Path.GetExtension(Request.Files[0].FileName);
                string link = "~/Image/" + filename + extension;
                Request.Files[0].SaveAs(Server.MapPath(link));
                b.BlogImg = "/Image/" + filename + extension;

            }
            var bl = c.Blogs.Find(b.Id);
            bl.Title = b.Title;
            bl.Date = b.Date;
            bl.BlogImg = b.BlogImg;
            bl.Explation = b.Explation;
            c.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}