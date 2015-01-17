using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day5
{
    class Program
    {
        static void Main(string[] args)
        {
            //ArrayList inventory = new ArrayList();
            //List<Automobile> inventory = new List<Automobile>();

            //List<Product> inventory = new List<Product>();
            List<IPrintable> inventory = new List<IPrintable>();

            Automobile a1 = new Automobile();
            a1.Make = "Honda";
            a1.Model = "civic";
            a1.Year = 2010;
            a1.ExteriorColor = "red";
            a1.Miles = 20000;

            //Automobile a2 = new Automobile();
            //a2.Make = "Dodge";
            //a2.Model = "Dart";
            //a2.Year = 1990;
            //a2.ExteriorColor = "blue";
            //a2.Miles = 200000;

            //Automobile a3 = new Automobile();
            //a3.Make = "toyota";
            //a3.Model = "Celica";
            //a3.Year = 2000;
            //a3.ExteriorColor = "gray";
            //a3.Miles = 50000;

            //Automobile a4 = new Automobile();
            //a4.Make = "Honda";
            //a4.Model = "Accord";
            //a4.Year = 2005;
            //a4.ExteriorColor = "Blue";
            //a4.Miles = 45000;

            //Automobile a5 = new Automobile();
            //a5.Make = "Lexus";
            //a5.Model = "x3";
            //a5.Year = 2011;
            //a5.ExteriorColor = "Green";
            //a5.Miles = 18000;

            Book b1 = new Book();
            //b1.ProductID = 2;
            b1.Author = "Hemingway";
            b1.Title = "MS2";
            b1.ISBN = "100-200-300";

            inventory.Add(a1);
            //inventory.Add(a2);
            //inventory.Add(a3);
            //inventory.Add(a4);
            //inventory.Add(a5);
            inventory.Add(b1);

            // pass in any type of class as long as it implements the 'IPrintable' interface
            Print.ToConsole(a1);
            Print.ToConsole(b1);

            Console.WriteLine();
            Console.WriteLine("Oldest Product location: ");
            Warehouse myWarehouse = new Warehouse();
            myWarehouse.Add(a1);
            myWarehouse.Add(b1);

            var myOldestProduct = myWarehouse.GetOldestItem();
            myOldestProduct.GetStorageLocation();

            Console.WriteLine();
            Toy newToy = new Toy() { Maufacturer = "Hasbro", Name = "Tonka", Type = "truck" };
            Print.ToConsole(newToy);
            myWarehouse.Add(newToy);
            var myNewestProduct = myWarehouse.GetNewestItem();
            myNewestProduct.GetStorageLocation();

            //Console.WriteLine("Current Invemtoy: ");

            //foreach (IPrintable item in inventory)
            //{
            //    item.Print();
            //}
            //Console.WriteLine();

            //Console.WriteLine("we have a special on this car: {0}" , inventory[3].Make );

            

            //Automobile a6 = new Automobile();
            //a6.Make = "Jeep";
            //a6.Model = "Cherokee";
            //a6.Year = 2011;
            //a6.ExteriorColor = "Green";
            //a6.Miles = 18000;
            //inventory.Insert(3, a6);  // insert into the 3rd position
            //Console.WriteLine(a6.Make + " auto inserted..");
            //Console.WriteLine();

            //inventory.RemoveAt(2);

            //Product removeAuto = (Product)inventory[1];
            //inventory.Remove(removeAuto);

            //Console.WriteLine();
            //Console.WriteLine("auto removed");

            //Console.WriteLine("Inventory count is {0}" , inventory.Count);

            //foreach (Product item in inventory)
            //{
            //    item.Print();
            //}

           // Console.WriteLine();
            Console.ReadLine();

        }
    }
}
