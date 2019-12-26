using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication3.Models;

namespace WebApplication3.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult AddUser(User user)
        {
            if(ModelState.IsValid)
            {
                user.Role = Role.Admin;
            }
            return View("ShowUser", user);
        }
        public ActionResult ShowUser(User user)
        {
            return View(user);
        }
        [HttpGet]
        public ActionResult AddUser()
        {
            return View(new User());
        }
        public ActionResult CreateUser()
        {
            return View(new User());
        }
    }
}