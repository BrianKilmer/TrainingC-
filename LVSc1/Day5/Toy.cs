using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day5
{
    class Toy : IProduct,IPrintable
    {
        public string   Maufacturer { get; set; }
        public string Name { get; set; }
        public string Type { get; set; }

        public void Print()
        {
            Console.WriteLine("{0} {1} (Type: {2}", Maufacturer, Name, Type);
        }

        public void GetStorageLocation()
        {
            Console.WriteLine("This toy {0} {1} {2} is stored in warehouse C", Maufacturer, Name, Type);
        }
    }
}
