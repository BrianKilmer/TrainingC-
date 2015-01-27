using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Day9Exercise
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Order> orders = setupOrders();


        Console.WriteLine("=================================");
            Console.WriteLine("EX 1");
            Console.WriteLine("Get a list of all orders after December 8, 2007");

            //Query Syntax
            //var o1 = from o in orders
            //            where o.OrderDate > DateTime.Parse("12/8/07")
            //            select o;

            //Method Syntax
            var o1 = orders.Where(p => p.OrderDate > DateTime.Parse("12/8/07"));

            foreach (var o in o1)
                Console.WriteLine("{0} : {1}", o.OrderID, o.OrderDate.ToShortDateString());

                //----------------------------------------------------------
                Console.ReadLine();

        Console.WriteLine("=================================");
                Console.WriteLine("EX 2");
                Console.WriteLine("Same, this time retrieve only the orderID and the amount into an anonymous type.");

                //Query Syntax
                //var o2 = from a2 in orders
                //            where a2.OrderDate > DateTime.Parse("12/8/07")
                //            select new { a2.OrderID, a2.OrderAmount };

                //Method Syntax
                var o2 = orders.Where(p => p.OrderDate > DateTime.Parse("12/8/07"))
                                .Select(o => new { o.OrderID, o.OrderAmount });

                foreach (var o in o2)
                    Console.WriteLine("{0:} : {1:c}", o.OrderID, o.OrderAmount);
                    Console.ReadLine();

        Console.WriteLine("=================================");
                Console.WriteLine("EX 3");
                Console.WriteLine("Find the order with the largest order amount. ");

                //Query Syntax
                //var o3 = (from a3 in orders
                //            orderby a3.OrderAmount
                //            select a3).Last();

                //Method Syntax
                var o3 = orders.OrderByDescending(o => o.OrderAmount).First();

                Console.WriteLine("{0} is the Higest amount", o3.OrderAmount.ToString());
                Console.ReadLine();

        Console.WriteLine("=================================");
                Console.WriteLine("EX 4");

                Console.WriteLine("Find all orders containing widgets.");

                //Query Syntax
                //var o4 = from a4 in orders
                //            from oi in a4.OrderItems
                //            where oi.ProductName == "Widgets"
                //            select new {a4.OrderID, oi.ProductName};

                //Method Syntax
                var o4 = orders.Where(o => o.OrderItems.Any(oi => oi.ProductName == "Widgets"));

                foreach (var o in o4)
                    Console.WriteLine("{0: }", o.OrderID);
                
                Console.ReadLine();

        Console.WriteLine("=================================");
                Console.WriteLine("EX 5");
                Console.WriteLine("Sum up the value of all order items.");

                //Query Syntax
                //var o5 = (from a5 in orders
                //            select a5.OrderAmount).Sum();

                //Method Syntax
                var o5 = orders.Select(o => o.OrderAmount).Sum();

                Console.WriteLine("{0} is the Sum of all orders", o5.ToString());

                Console.ReadLine();

        Console.WriteLine("=================================");
                Console.WriteLine("EX 6");
                Console.WriteLine("What is the average order total?");

                //Query Syntax
                //var o6 = (from a6 in orders
                //            select a6.OrderAmount).Average();

                //Method Syntax
                var o6 = orders.Select(o => o.OrderAmount).Average();

                Console.WriteLine("{0} is the Sum of all orders", o6.ToString());
                Console.ReadLine();

        Console.WriteLine("=================================");
                Console.WriteLine("EX 7");
                Console.WriteLine("How many orders have multiple items?");

                //Query Syntax
                //var o7 = (from a7 in orders
                //            where a7.OrderItems.Count > 1
                //            select a7).Count();

                //Method Syntax
                var o7 = orders.Count(o => o.OrderItems.Any(oi => oi.Quantity > 1));
                Console.WriteLine("{0} orders have more than 1 item" , o7.ToString()); 
                Console.ReadLine();

                //

               
        Console.WriteLine("=================================");
                Console.WriteLine("EX 8");
                Console.WriteLine("Create a flat list of a new anonymous type using LINQ to project the fields OrderID, OrderItemID, ProductName of every order item");

                //Query Syntax
                //var o8 = from a8 in orders
                //            from oi in a8.OrderItems
                //            //select a4;
                //            select new { a8.OrderID, oi.OrderItemID, oi.ProductName, };

                //Method Syntax
                //o => o.OrderItems : collection selector
                // (o, oi) => new..  : result selector
                var o8 = orders.SelectMany(o => o.OrderItems, (o, oi) => new {o.OrderID,oi.OrderItemID, oi.ProductName});

                foreach (var item in o8)
                {
                    Console.WriteLine("{0} : {1} : {2} ", item.OrderID,item.OrderItemID,item.ProductName);  
                }
                

                Console.ReadLine();
                

                Console.WriteLine("Create a new set of orders based on the existing orders ... BUT add 1000 to each OrderID AND set the OrderDate to Now.");
                Console.WriteLine("(Bwahahah ... <evil laugh>.");
        Console.WriteLine("=================================");
                Console.WriteLine("EX 9");

                //Query Syntax
                //var o9 = from a9 in orders
                //            select new Order { OrderID = a9.OrderID + 1000, CustomerName = a9.CustomerName, OrderItems = a9.OrderItems, BillingAddress = a9.BillingAddress, ShippingAddress = a9.ShippingAddress, OrderAmount = a9.OrderAmount, OrderDate = DateTime.Now};

                //Method Syntax
                var o9 = orders.Select (o => new Order 
                {
                    OrderID = o.OrderID + 1000, 
                    CustomerName = o.CustomerName, 
                    OrderItems = o.OrderItems, 
                    BillingAddress = o.BillingAddress, 
                    ShippingAddress = o.ShippingAddress, 
                    OrderAmount = o.OrderAmount, 
                    OrderDate = DateTime.Now
                });
                
                foreach (var item in o9)
                {
                    Console.WriteLine( "{0} : {1}", item.OrderID, item.OrderDate);
                }

                Console.ReadLine();
            }
        

        static private List<Order> setupOrders()
        {
            List<Order> orderList = new List<Order>();

            Order o1 = new Order();
            o1.OrderDate = DateTime.Parse("12/7/2007 1:05 PM");
            o1.OrderAmount = 150.0M;
            o1.OrderID = 9009;

            OrderItem oi1 = new OrderItem();
            oi1.OrderItemID = 123;
            oi1.ProductName = "FooBar";
            oi1.Quantity = 2;
            o1.OrderItems.Add(oi1);

            OrderItem oi2 = new OrderItem();
            oi2.OrderItemID = 124;
            oi2.ProductName = "BazQuirk";
            oi2.Quantity = 3;
            o1.OrderItems.Add(oi2);

            Order o2 = new Order();
            o2.OrderDate = DateTime.Parse("12/8/2007 9:15 AM");
            o2.OrderAmount = 175.0M;
            o2.OrderID = 9010;

            OrderItem oi3 = new OrderItem();
            oi3.OrderItemID = 125;
            oi3.ProductName = "FooBar";
            oi3.Quantity = 1;
            o2.OrderItems.Add(oi3);

            OrderItem oi4 = new OrderItem();
            oi4.OrderItemID = 126;
            oi4.ProductName = "Gadgets";
            oi4.Quantity = 5;
            o2.OrderItems.Add(oi4);

            OrderItem oi5 = new OrderItem();
            oi5.OrderItemID = 127;
            oi5.ProductName = "Bazquirk";
            oi5.Quantity = 1;
            o2.OrderItems.Add(oi5);

            OrderItem oi6 = new OrderItem();
            oi6.OrderItemID = 128;
            oi6.ProductName = "Widgets";
            oi6.Quantity = 6;
            o2.OrderItems.Add(oi6);

            Order o3 = new Order();
            o3.OrderDate = DateTime.Parse("12/9/2007 4:50 PM");
            o3.OrderAmount = 250.0M;
            o3.OrderID = 9011;

            OrderItem oi7 = new OrderItem();
            oi7.OrderItemID = 129;
            oi7.ProductName = "Widgets";
            oi7.Quantity = 3;
            o3.OrderItems.Add(oi7);

            OrderItem oi8 = new OrderItem();
            oi8.OrderItemID = 130;
            oi8.ProductName = "Gadgets";
            oi8.Quantity = 5;
            o3.OrderItems.Add(oi8);

            Order o4 = new Order();
            o4.OrderDate = DateTime.Parse("12/10/2007 1:23 PM");
            o4.OrderAmount = 225.0M;
            o4.OrderID = 9012;

            OrderItem oi9 = new OrderItem();
            oi9.OrderItemID = 131;
            oi9.ProductName = "Widgets";
            oi9.Quantity = 1;
            o4.OrderItems.Add(oi9);

            orderList.Add(o1);
            orderList.Add(o2);
            orderList.Add(o3);
            orderList.Add(o4);

            return orderList;
        }

    }

    class Order
    {
        public int OrderID { get; set; }
        public DateTime OrderDate { get; set; }
        public string CustomerName { get; set; }
        public decimal OrderAmount { get; set; }
        public List<OrderItem> OrderItems { get; set; }
        public Address BillingAddress { get; set; }
        public Address ShippingAddress { get; set; }

        public Order()
        {
            OrderItems = new List<OrderItem>();
        }

        public Order(int orderID, DateTime orderDate)
        {
            OrderID = orderID;
            OrderDate = orderDate;
        }
    }

    class OrderItem
    {
        public int OrderItemID { get; set; }
        public string ProductName { get; set; }
        public int Quantity { get; set; }
    }

    class Address
    {
        public string Address1 { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Zip { get; set; }
    }


}
