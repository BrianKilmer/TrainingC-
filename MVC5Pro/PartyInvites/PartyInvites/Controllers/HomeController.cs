using PartyInvites.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PartyInvites.Controllers
{
    public class HomeController : Controller
    {
        // Action method
        public ViewResult Index()
        {
            int hour = DateTime.Now.Hour;
            //Conditional ternary operator        true              false
            ViewBag.AnyVaribleName = hour < 12 ? "Good morning" : "Good afternoon";
            //ViewBag.AnotherVar = "Keep on truck'n!";
            return View();
        }

        [HttpGet]
        public ViewResult RsvpForm()
        {
            return View();
        }

        [HttpPost]
        // overloaded version
        // takes GuestResponse object passed as a parameter
        // and returns to the view ("Thanks") with the data from the form fields
        public ViewResult RsvpForm(GuestResponse guestResponse)
        {
            // ModelState property to see if all validation in the Model has passed.
            if (ModelState.IsValid)
            {
                // todo  email... 
                // overloaded iview, object model
                ViewBag.Email = guestResponse.Email;
                return View("Thanks", guestResponse);
            }
            else // if there are validation errors, return the the RsvpForm view()
            {
                return View();
            }
            
        }
        
    }
}