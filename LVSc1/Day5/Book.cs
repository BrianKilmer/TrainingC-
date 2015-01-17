using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day5
{
    class Book : IPrintable, IProduct
    {
        public string Title { get; set; }
        public string Author { get; set; }
        public string ISBN { get; set; }


        //by using the IPrintable interface, this class 'agrees' to use the 'Print' method
       // or void IPrintable.Print()
        public void Print()
        {
            //base.Print();
            Console.WriteLine("ID: {0}..., title: {1}, ({2}), ISBN: {3}", "3", Title, Author, ISBN);
        }

        //by using the IProduct interface, this class 'agrees' to use the 'GetStorageLocation' method
        public void GetStorageLocation()
        {
            Console.WriteLine("This title {0} is stroed in warehouse A", Title);
        }
    }
}
