using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Extention_Method
{
    public static class MyExtension
    {
        public static double CalculateTax(this Product p)
        {
            return (p.ProductPrice * .2);
        }
    }
}
