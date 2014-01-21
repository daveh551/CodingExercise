using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace TestFizzBuzzWeb.Controllers
{
    public class HomeController : Controller
    {
        
        // GET: /Direct/
        public ActionResult DirectOutput(int begin = 1, int end = 100)
        {
            FizzBuzz.HelperMethods.WebOutput(ControllerContext.HttpContext.Response, begin, end);

            return new EmptyResult();
        }

        //GET /{begin}/{end}
        public ActionResult Index(int begin = 1, int end = 100)
        {
            ViewBag.Begin = begin;
            ViewBag.End = end;

            return View();
        }
	}
}