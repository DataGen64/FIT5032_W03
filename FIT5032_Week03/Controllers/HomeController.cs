using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FIT5032_Week03.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            HelloWorld.Hello hello = new HelloWorld.Hello();
            ViewBag.Message = hello.GetHello();

            Excersice.ExampleDictionary ed = new Excersice.ExampleDictionary();
            ed.ExampleDict();

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}