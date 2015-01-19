using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day9_4
{
    static class Program  //need to have a static class if creating an extension method
    {
        static void Main(string[] args)
        {
            int i = 7;
           // Print(i);
            i.Print();

            int anothernum = 10;
            anothernum.Increment().bonus().Double().Decrement().Print();


            Console.ReadLine();
        }

        
        static void Print(this object o) 
        {
            Console.WriteLine("called print: {0}", o.ToString());
        }

        // extension method:
        // - needs the "this" keyword
        // - it has to be static
        // - needs to live in a class that is static
        public static int Increment(this int i)
        {
            return i = i + 1;
        }

        public static int Decrement(this int i)
        {
            return i = i - 1;
        }

        public static int Double(this int i)
        {
            return i * 2;
        }

        public static int bonus(this int i)
        {
            return i + 5;
        }
    }
}
