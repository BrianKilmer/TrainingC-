using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Razor.Models
{
    public class Product
    {
        private string name; //field

        public string Name  //property
        {
            get { return name; }
            set { name = value; }
        }
        //Automatic properties
        public int ProductID { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public string Category { get; set; }

    }
}