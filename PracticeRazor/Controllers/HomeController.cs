using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PracticeRazor.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Message = "\n\nThis is my first ViewBag practice. \n<br/>Does a line break work?";

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
        public ActionResult PostTest()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
        public ActionResult AddNumbers()
        {
            ViewBag.Message = "Your contact page.";

            return View();

        }
        public ActionResult ReverseAStringWithRazor()
        {
            

            return View();

        }
    }
}