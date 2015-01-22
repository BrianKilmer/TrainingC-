using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Linq;

namespace LINQProjection
{
    class Program
    {
        // Projection (from a LINQ perspective) is basically 
        // shaping or molding the data that is returned from
        // a LINQ query to include just the stuff you need
        // (as opposed to retrieving every field of the object.)
        // You can use this to:
        //
        // 1) Convert the data from one type to another (i.e., 
        //    copy the value from a property  in TypeA to a 
        //    property in TypeB).
        //
        // 2) Flatten the data from a hierarchy into a non-hierarchical
        //    form.
        //    
        // The new type could be something in in the framework, 
        // a type you created, or an anonymous type. 

        static void Main(string[] args)
        {
            List<Order> orderList = setupOrders();


            ///// Most simple case ...
            //var orders = from o in orderList
            //             select o;

            //foreach (var o in orders)
            //    Console.WriteLine("Order Dates: {0}", o.OrderDate.ToShortDateString());


            // What if we ONLY wanted the OrderDates, not the entire
            // order object?

            //var orders = from z in orderList
            //             select z.OrderDate;

            //foreach (var z in orders)
            //    Console.WriteLine("Order Dates: {0}", z.ToShortDateString());


            // What if we needed more than just the OrderDate property, 
            // but not every property?

            //var orders = from o in orderList
            //             select new { o.OrderDate, o.OrderID };

            //foreach (var o in orders)
            //    Console.WriteLine("Order Dates: {0} - {1}", o.OrderDate.ToShortDateString(), o.OrderID.ToString());

           
            // And just because we're curious ... what does this new
            // anonymous type look like?

            //Console.WriteLine("Type is: {0}", orders.First().GetType());

            //var orderSummaries = from o in orderList
            //                     select new OrderSummary { OrderDate = o.OrderDate, OrderID = o.OrderID };

            //foreach (OrderSummary os in orderSummaries)
            //    Console.WriteLine("Order Summary: {0} - {1}", os.OrderDate.ToShortDateString(), os.OrderID.ToString());  


            // Here's an extreme case of conversion and flattening ...
            //var orderXML = new XElement("Orders", from o in orderList
            //                                      select new XElement("Order", new XAttribute("OrderDate", o.OrderDate), new XAttribute("TotalItems", o.OrderItems.Sum(i => i.Quantity))));

            //Console.WriteLine(orderXML.ToString());

            // How do you flatten out the list of OrderItems across all Orders?

            //Console.WriteLine("Every item in every order ...");


            //var orderItems = from o in orderList
            //                 from oi in o.OrderItems
            //                 select oi;

            //foreach (var item in orderItems)
            //    Console.WriteLine("     {0} - {1} - {2}", item.OrderItemID.ToString(), item.ProductName, item.Quantity.ToString());

            // Most simple case ...
            //var orders = orderList.Select(o => o);
            //foreach (var o in orders)
            //    Console.WriteLine("Order Dates: {0}", o.OrderDate.ToShortDateString());

            // Most simple case ...

            // Like we showed in the previous video, I can shorten
            // this.
            //foreach (var o in orderList.Select(o => o))
            //    Console.WriteLine("Order Dates: {0}", o.OrderDate.ToShortDateString());

            // What if we ONLY wanted the OrderDates, not the entire
            // order object?


            //var orders = orderList.Select(o => o.OrderDate);
            //foreach (var o in orders)
            //    Console.WriteLine("Order Dates: {0}", o.ToShortDateString());

            // Shortened ...
            //foreach (var o in orderList.Select(o => o.OrderDate))
            //    Console.WriteLine("Order Dates: {0}", o.ToShortDateString());

            // What if we needed more than just the OrderDate property, 
            // but not every property?            

            //var orders = orderList.Select(o => new { o.OrderDate, o.OrderID });
            //foreach (var o in orders)
            //    Console.WriteLine("Order Dates: {0} - {1}", o.OrderDate.ToShortDateString(), o.OrderID.ToString());


            //var orderSummaries = orderList.Select(o => new OrderSummary { OrderDate = o.OrderDate, OrderID = o.OrderID });

            //foreach (OrderSummary os in orderSummaries)
            //    Console.WriteLine("Order Summary: {0} - {1}", os.OrderDate.ToShortDateString(), os.OrderID.ToString());  


           // var orderXML = new XElement("Orders", from o in orderList
            //select new XElement("Order", new XAttribute("OrderDate", o.OrderDate), new XAttribute("TotalItems", o.OrderItems.Sum(i => i.Quantity))));

            //var orderXML = new XElement("Orders", orderList.Select(o => new XElement("Order", new XAttribute("OrderDate", o.OrderDate), new XAttribute("TotalItems", o.OrderItems.Sum(i => i.Quantity)))));
            //Console.WriteLine(orderXML.ToString());


            //Console.WriteLine("Every item in every order ...");
            //var orders = orderList.SelectMany(o => o.OrderItems);
            //foreach (var o in orders)
            //    Console.WriteLine("     {0} - {1} - {2}", o.OrderItemID.ToString(), o.ProductName, o.Quantity.ToString());



            Console.WriteLine("");
            Console.WriteLine("Press enter to continue ...");
            Console.ReadLine();

        }

        static private List<Order> setupOrders()
        {
            List<Order> orderList = new List<Order>();

            Order o1 = new Order();
            o1.OrderDate = DateTime.Parse("12/7/2007 1:05 PM");
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

    class OrderSummary
    {
        public DateTime OrderDate { get; set; }
        public int OrderID { get; set; }
    }


}
