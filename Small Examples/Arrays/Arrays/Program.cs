using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { 4, 3, 8, 0, 5 };

            Array.Sort(numbers);

            foreach (int i in numbers)
                Console.WriteLine(i);
            Console.WriteLine();

            string[] str = { "d", "r", "a", "D", "c" };
            Array.Sort(str);

            foreach (string i in str)
                Console.WriteLine(i);

            Console.ReadLine();
        }
    }
}
