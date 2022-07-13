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
            var values = c.NewMembers.ToList();
            return View(values);
           
        }
        [HttpGet]
        public ActionResult AddUser()
        {
            return View();
        }

        [HttpPost]
        public ActionResult AddUser(NewMember nm)
        {
            c.NewMembers.Add(nm);
            c.SaveChanges();                      
            return RedirectToAction("Index");
        }


        public ActionResult DeleteUser(int id)
        {
            var user = c.NewMembers.Find(id);
            c.NewMembers.Remove(user);
            c.SaveChanges();
            return RedirectToAction("Index");
        }

        public ActionResult MakeUser(int id)
        {
            var users = c.NewMembers.Find(id);
            return View("MakeUser", users);
        }
        public ActionResult UpdateUser(NewMember newMember)
        {
            var nm = c.NewMembers.Find(newMember.MemberId);
            nm.MemberName = newMember.MemberName;
            nm.MemberSurname = newMember.MemberSurname;
            nm.MemberMail = newMember.MemberMail;
            nm.MemberCity = newMember.MemberCity;
            nm.MemberPassword = newMember.MemberPassword;
            c.SaveChanges();
            return RedirectToAction("Index");



        }
    }
}