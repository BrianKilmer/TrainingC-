using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LanguageFeatures.Models
{
    public class ShoppingCart
    {
        // represents a collection of Product objects
        public List<Product> Products { get; set; }
    }
}