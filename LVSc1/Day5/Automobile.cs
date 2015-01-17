using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day5
{
    // implements 2 interfaces : IPrintable, IProduct
    class Automobile : IPrintable, IProduct
    {
        #region Public Properties

        public string Make { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
        public int Miles { get; set; }
        public string  ExteriorColor { get; set; }

        #endregion

        //by using the IPrintable interface, this class 'agrees' to use the 'Print' method
        public void Print()
        {
            //base.Print();
            Console.WriteLine("ID: {0}... {1} {2} {3}  with {4} Exterior (Odometer: {5})", "1", Year, Make, Model, ExteriorColor, Miles);
        }

        //by using the IProduct interface, this class 'agrees' to use the 'GetStorageLocation' method
        public void GetStorageLocation()
        {
            Console.WriteLine("This car {0} {1} {2} is stored in warehouse 5", Year,Model,Model);
        }
    }
}
