using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Assessment_5.Models;

namespace Assessment_5.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Message = "Welcome to GC Coffee";

            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        [HttpGet]
        public ActionResult Register()
        {
            return View();
        }
        [HttpPost]
        public ActionResult AddUser(string firstname, string lastname, string gender, string birthday, string email, string username, string password)
        {
            WebUser user = new WebUser()
            {
                Firstname = firstname,
                Lastname = lastname,
                Gender = gender,
                Birthday = birthday,
                Email = email,
                Username = username,
                Password = password
            };
            return View(user);
        }
        [HttpPost]
        public ActionResult Order(string drink, string size, string collect, string time)
        {
            CustOrder order = new CustOrder()
            {
                Drink = drink,
                Size = size,
                Collect = collect,
                Time = time
            };
            return View(order);
        }
        [HttpGet]
        public ActionResult Review()
        {
            ViewBag.Message = "Thank you for your purchase!";

            return View();
        }
    }
}