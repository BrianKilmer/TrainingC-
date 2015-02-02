using Razor.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Razor.Controllers
{
    public class HomeController : Controller
    {
        Product myProduct = new Product
        {
            ProductID = 1,
            Name= "boat",
            Description = "one man flaoter",
            Category = "watersports",
            Price = 275M
        };


        public ActionResult Index()
        {
            return View(myProduct);
        }

        public ActionResult NameAndPrice()
        {
            return View(myProduct);
        }

        public ActionResult DemoExpressions()
        {
            ViewBag.Count = 1;
            ViewBag.ExpressShip = true;
            ViewBag.ApplyDiscount = false;
            ViewBag.Supplier = null;
            return View(myProduct);
        }

        public ActionResult DemoArray()
        {
            Product[] array =
            {
                new Product {Name = "Ball",Price = 27M},
                new Product {Name = "bat",Price = 24M},
                new Product {Name = "Shoes",Price = 74M},
                new Product {Name = "Hat",Price = 74M}
            };
            return View(array);
        }
    }
}