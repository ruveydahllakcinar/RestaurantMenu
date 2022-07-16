using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using RestaurantMenu.Models.Classes;
using System.Web.Security;

namespace RestaurantMenu.Controllers
{
    public class LoginController : Controller
    {
        // GET: Login
        Context c = new Context();
        
        public ActionResult Index()
        {
            return View();
        }
       [HttpGet]
        public ActionResult Login()
        {
            return View();
        } 
        [HttpPost]
        public ActionResult Login(NewMember nm)
        {
            var value = c.NewMembers.FirstOrDefault(x => x.MemberMail == nm.MemberMail && x.MemberPassword == nm.MemberPassword);
            if (value != null)
            {
                FormsAuthentication.SetAuthCookie(value.MemberMail, false);
                Session["MemberMail"] = value.MemberMail.ToString();
                return RedirectToAction("Index","Admin");
            }
            
            return View();
        }
        [HttpGet]
        public ActionResult Writer()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Writer(Writer writer)
        {
            var value = c.Writers.FirstOrDefault(x => x.WriterMail == writer.WriterMail && x.WriterPassword == writer.WriterPassword);
            if (value != null)
            {
                FormsAuthentication.SetAuthCookie(value.WriterMail, false);
                Session["MemberMail"] = value.WriterMail.ToString();
                return RedirectToAction("Index", "Writer");
            }
            return View();
        }
        [HttpGet]
        public ActionResult Register()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Register(NewMember newMember)
        {
            c.NewMembers.Add(newMember);
            c.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}