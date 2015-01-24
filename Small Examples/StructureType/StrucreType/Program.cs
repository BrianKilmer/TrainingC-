using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StructureType
{
    class Program
    {
        static void Main(string[] args)
        {
           
            Point myPoint = new Point();
            myPoint.X = 10;
            myPoint.Y = 11;
            myPoint.Display();
            myPoint.increment();
            myPoint.Display();
            myPoint.decrement();
            myPoint.Display();
        }
    }
}
