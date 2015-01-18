using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day9_3
{
    class Program
    {
        static void Main(string[] args)
        {

            //// create instance, initialize
            //Order order1 = new Order { OrderID = 124, OrderDate = DateTime.Now, OrderAmount = 122.00M };
            //Console.WriteLine("Datatype is {0}" , order1.GetType()); 

            //var order2 = new { OrderID = 125, OrderAmount = 1202.00M };
            //Console.WriteLine("Datatype is {0}", order2.GetType());

            //var order3 = new { OrderID = 125, OrderAmount = 1202.00M };
            //Console.WriteLine("Datatype is {0}", order3.GetType());

            //var order4 = new { OrderID = 125, OrderAmount = 1202.00M, MyProp="123" };
            //Console.WriteLine("Datatype is {0}", order4.GetType());

            //var order5 = new { OrderID = 125, MyOrderAmount = 1202.00M };
            //Console.WriteLine("Datatype is {0}", order5.GetType()); // same anon type as above, even after renaming a variable

            List<Order> orderList = setupOrders();

            var myOrders = from o in orderList
                            // creating a new anonymous type that has these properties
                            // being created from scratch (not defined anywhere)
                            select new  //'projecting a new data type, crafting the output of the query
                            {
                                OrderID = o.OrderID,
                                ItemsToShip = o.OrderItems.Sum(p => p.Quantity), // lambda expression
                                DateofOrder = o.OrderDate
                            };

            Console.WriteLine("data type for myOrders is {0}", orderList.GetType());

            foreach (var whoknows in myOrders)
            {
                Console.WriteLine("orderID: {0}, ItemsToShip: {1}", whoknows.OrderID.ToString(), whoknows.ItemsToShip.ToString());        
            }

            Console.ReadLine();
        }

        static private  List<Order> setupOrders()
        {
            List<Order> orderList = new List<Order>();
           
            Order o1 = new Order();
            o1.OrderID = 123;
            o1.OrderDate = DateTime.Parse("1/1/15");

            OrderItem oi1 = new OrderItem();
            oi1.ProductName = "widget";
            oi1.OrderItemId = 1;
            oi1.Quantity = 1;
            o1.OrderItems.Add(oi1);

            OrderItem oi2 = new OrderItem();
            oi2.ProductName = "thingie";
            oi2.OrderItemId = 2;
            oi2.Quantity = 3;
            o1.OrderItems.Add(oi2);
            // ------
            Order o2 = new Order();
            o2.OrderID = 124;
            o2.OrderDate = DateTime.Parse("2/1/15");

            OrderItem oi3 = new OrderItem();
            oi3.ProductName = "widget2";
            oi3.OrderItemId = 1;
            oi3.Quantity = 10;
            o2.OrderItems.Add(oi3);

            OrderItem oi4 = new OrderItem();
            oi4.ProductName = "thingie3";
            oi4.OrderItemId = 2;
            oi4.Quantity = 3;
            o2.OrderItems.Add(oi4);

            orderList.Add(o1);
            orderList.Add(o2);

            return orderList;

        }

        class Order
        {
            public int OrderID { get; set; }
            public DateTime OrderDate { get; set; }
            public decimal OrderAmount { get; set; }
            public List<OrderItem> OrderItems { get; set; }
            public Address BillingAddress { get; set; }
            public Address ShippingAddress { get; set; }

            //default constructor
            public Order()
            {
                OrderItems = new List<OrderItem>();
            }
            //override constructor
            public Order(int orderID, DateTime orderDate)
            {
                OrderID = orderID;
                OrderDate = orderDate;
            }
        }
        class OrderItem
        {
            public int OrderItemId { get; set; }
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
}
