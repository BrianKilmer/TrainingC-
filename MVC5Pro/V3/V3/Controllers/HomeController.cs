using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace V3.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Countries = new List<string>()
            {
                "India",
                "US",
                "UK",
                "Canada"
            };
            ViewData["Countries"] = new List<string>()
            {
                "India",
                "US",
                "UK",
                "Canada"
            };
            return View(); // inherits from ActionResult
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public string Index2(string id, string name)
        {
           // return  "URL ID = " + id + " " + Request.QueryString["name"];
            return "URL ID = " + id + " " + name;
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}