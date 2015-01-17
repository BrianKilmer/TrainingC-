using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day5
{
    public class Warehouse
    {
        // Queue - a FIFO collection  First-in First Out 
        // it handles the elements that it received longest ago first. generic type
        // store something in this collection that is of the type IProduct.
        // so 'inventory' is an internal collection of type 'Queue' of type 'Iproduct'
        private Queue<IProduct> inventory { get; set; }

        public Warehouse()
        {
            inventory = new Queue<IProduct>();
        }

        // return back somethat impelments 'IProduct'
        // and return back the first item in the Queue
        public IProduct GetOldestItem()
        {
            IProduct oldestItem = inventory.First();
            return oldestItem;
        }

        public IProduct GetNewestItem()
        {
            IProduct newestItem = inventory.Last();
            return newestItem;
        }

        public void Add(IProduct produtToAdd)
        {
            // Enqueue Adds an object to the end of the Queue.
            inventory.Enqueue(produtToAdd);
        }
        
    }
}
