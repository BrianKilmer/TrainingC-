using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByValueByReference
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = 20;
            AddFive(number);
            //by value (default) never makes it out, so value is unhanged
            Console.WriteLine(number);
            Console.ReadKey();

            //by ref, since its a ref to the var, it does get updated to the new value
            int number2 = 20;
            AddFive2(ref number2);
            Console.WriteLine(number2);
            Console.ReadKey();

        }
        static void AddFive(int number)
        {
            number = number + 5;
        }

        static void AddFive2(ref int number)
        {
            number = number + 5;
        }
    }
}
