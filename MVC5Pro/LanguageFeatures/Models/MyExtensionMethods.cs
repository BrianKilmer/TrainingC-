using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LanguageFeatures.Models
{
    public static class MyExtensionMethods
    {
        // the "this" keyword marks TotalPrices as an extension method
        // the first parameter (ShoppingCart), signifies which class the extension method can be applied to,
        // we can refer to the instance of the ShoppingCart that the extension method has been applied to
        //    by using the 'cartParam' (any name you wish) parameter
        public static decimal TotalPrices(this ShoppingCart cartParam)
        {
            decimal total = 0;
            foreach (Product prod in cartParam.Products)
            {
                total += prod.Price;
            }
            return total;
        }
    }
}