using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVCSuccinctly.Models;

namespace MVCSuccinctly.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            var model = new GreeetingModel
            {
                Greeting = "Welcome to the World of MVC",
                Name = "Your friendly neighborhood MVC app"
            };
            return View(model);
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
    }
}