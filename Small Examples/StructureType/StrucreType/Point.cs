using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StructureType
{
    public struct Point
    {
        public int X;
        public int Y;

        public void increment()
        {
            X++;
            Y++;
        }
        public void decrement()
        {
            X--;
            Y--;
        }
        public void Display() {
            Console.WriteLine( "X = {0} : Y = {1}", X, Y);
            Console.ReadLine();
        }
    }
}
