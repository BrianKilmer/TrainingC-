using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using LanguageFeatures.Models;

namespace LanguageFeatures.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
       // public ActionResult Index()
        public string Index() 
        {
            // this just returns a string, not a view.
            return "Navigate to a Home/<ActionMethod Name>";
        }
        public ViewResult AutoProperty()
        {
            // instantiate new 'Product' object
            Product myProduct = new Product();
            // set the name property value
            myProduct.Name = "kayak";
            // get the property value
            string productName = myProduct.Name;
            //return View("Result", (object)String.Format("ProductName: {0}", productName));


            //create and populate the Product instance in 1 step
            Product myProduct2 = new Product
            {
                ProductID= 100, Description="A cool boat", Name="kayak", Category="WaterSports"
            };
            return View("Result", (object)String.Format("Category: {0} Name: {1} Desc. {2}", myProduct2.Category,myProduct2.Name,myProduct2.Description));
            
        }

        public ViewResult CreateCollection()
        {
            // initializations of an array and 2 classes from the generic collection library
            string[] strArray = { "Apple", "Orange", "banana", "Peach" };
            List<int> intList = new List<int> { 1, 3, 5, 6 };
            Dictionary<string, int> myDict = new Dictionary<string, int>
            {
                {"Apple",1},{"Orange",3},{"banana",5},{"Peach",6}
            };
            return View("Result",(object)strArray[1]);
        }

        public ViewResult UseExtension()
        {
            //Create and populate cart
            ShoppingCart cart = new ShoppingCart
            {
                Products = new List<Product> {
                    new Product {Name = "Tablet",Price= 275M},
                    new Product {Name = "Ball",Price= 75M},
                    new Product {Name = "Bike",Price= 125M},
                    new Product {Name = "Shoes",Price= 100M},
                }
            };
            decimal cartTotal = cart.TotalPrices();
            return View("Result", (object)String.Format("Total Price {0:c}", cartTotal));
        }

        public ViewResult UseExtensionEnumerble()
        {
            IEnumerable<Product> products = new ShoppingCart
            {
                Products = new List<Product> {
                    new Product {Name = "Tablet",Price= 275M},
                    new Product {Name = "Ball",Price= 75M},
                    new Product {Name = "Bike",Price= 125M},
                    new Product {Name = "Shoes",Price= 100M},
                }
            };

            Product[] productArray = 
            {
                new Product {Name = "Tablet",Price= 275M},
                new Product {Name = "Ball",Price= 75M},
                new Product {Name = "Bike",Price= 125M},
                new Product {Name = "Shoes",Price= 100M},
            };

            decimal cartTotal = products.TotalPrices2();
            decimal arrayTotal = products.TotalPrices2();

            return View("Result", (object)String.Format("Total Price {0:c} Array Total {1:c}", cartTotal, arrayTotal));
        }

        public ViewResult UseFilterExtensionMEthod()
        {
            IEnumerable<Product> products = new ShoppingCart
            {
                Products = new List<Product> {
                    new Product {Name = "Tablet",Price= 275M,Category="Computer"},
                    new Product {Name = "Ball",Price= 75M,Category="Athletic"},
                    new Product {Name = "Bike",Price= 125M,Category="Athletic"},
                    new Product {Name = "Shoes",Price= 100M,Category="Athletic"},
                }
            };

            decimal total = 0;
            foreach (Product prod  in products.FilterByCategory("Athletic"))
            {
                total += prod.Price;
            }
            return View("Result", (object)String.Format("Total Price {0:c}", total));
        }
    }
}