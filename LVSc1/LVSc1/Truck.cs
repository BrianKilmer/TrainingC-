using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LVSc1
{
    class Truck : Auto
    {
        public int TowingCapacity { get; set; }
        public int CargoCapacity { get; set; }

        public void Tow()
        {
            Console.WriteLine("Now towing..");
        }
        public void Haul()
        {
            Console.WriteLine("Now hauling..");
        }

        public override void Start()
        {
            base.Start();
            Console.WriteLine("Truck Ignition sequence");
        }
    }
}
