using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticNonStatic
{
    class Program
    {
        static void Main(string[] args)
        {
            // calling the static method in the Rectangle class
           Console.WriteLine("The area is: " + Rectangle.CalculateArea(5, 4));
            // create new instance of class and call 1 of its methods
           Rectangle myrec = new Rectangle(12,5);
           myrec.OutputArea();

           Console.ReadLine();
        }
    }
}
