using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LINQFromAndJoin
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Product> products = new List<Product> { new Product { ProductName = "FooBar", ItemPrice = 19.95M },
                                                        new Product { ProductName = "BazQuirk", ItemPrice = 29.95M },
                                                        new Product { ProductName = "Widgets", ItemPrice = 39.95M },
                                                        new Product { ProductName = "Gadgets", ItemPrice = 49.95M } };


            List<Order> orderList = setupOrders();


            //var summaryReport = from o in orderList
            //                    from i in o.OrderItems
            //                    join p in products on i.ProductName equals p.ProductName
            //                    select new { p.ProductName, p.ItemPrice, o.OrderID, i.Quantity };

            //foreach (var summary in summaryReport)
            //    Console.WriteLine(summary);

            // What if I want to get a list of products and which
            // order items contain that product (as well as their quantity)?

            //var myOrderList = from o in orderList
            //                  from i in o.OrderItems
            //                  select i;

            //var productsSold = from p in products
            //                   join m in myOrderList
            //                   on p.ProductName equals m.ProductName
            //                   into myOrderItems
            //                   select new { p.ProductName, myOrderItems };


            //foreach (var p in productsSold)
            //{
            //    Console.WriteLine("Product: {0}", p.ProductName);
            //    foreach (var i in p.myOrderItems)
            //        Console.WriteLine("     OrderItem: {0} ... Quantity: {1}", i.OrderItemID.ToString(), i.Quantity.ToString());
            //}


            //var summaryReport = orderList.SelectMany(o => o.OrderItems).Join(products, i => i.ProductName, j => j.ProductName, (i, j) => i);


            //var summaryReport = orderList.SelectMany(o => o.OrderItems.Join(products, i => i.ProductName, j => j.ProductName, (i, j) => new { j.ProductName, j.ItemPrice, i.Quantity, o.OrderID }));

            //foreach (var summary in summaryReport)
            //    Console.WriteLine(summary);

            //var productsSold = products.GroupJoin(orderList.SelectMany(o => o.OrderItems), p => p.ProductName, m => m.ProductName, (p, myOrderItems) => new { p.ProductName, myOrderItems });

            //foreach (var p in productsSold)
            //{
            //    Console.WriteLine("Product: {0}", p.ProductName);
            //    foreach (var i in p.myOrderItems)
            //        Console.WriteLine("     OrderItem: {0} ... Quantity: {1}", i.OrderItemID.ToString(), i.Quantity.ToString());
            //}



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

    class Product
    {
        public string ProductName { get; set; }
        public decimal ItemPrice { get; set; }
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
