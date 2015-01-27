using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticNonStatic
{
    class Rectangle
    {
        private int width, height;

        public Rectangle(int width, int height)
        {
            this.width = width;
            this.height = height;
        }

        public void OutputArea()
        {
            Console.WriteLine("Area output: " + Rectangle.CalculateArea(this.width, this.height));
        }

        public static int CalculateArea(int width, int height)
        {
            return width * height;
        }
    }
}
