using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodOverloading
{
    class Program
    {
        static void Main(string[] args)
        {
            
            int num1 = 5;
            int num2 = 4;
            int num3 = 7;
            int num4 = 75;

            int mynum = Plus(num1,num2);
            Console.WriteLine(mynum);

            int mynum2 = Plus(num1, num2,num2,num4);
            Console.WriteLine(mynum2);
            Console.ReadLine();
        }

        public static int Plus(int number1, int number2)
        {
            return Plus(number1, number2, 0);
        }

        public static int Plus(int number1, int number2, int number3)
        {
            return Plus(number1, number2, number3, 0);
        }

        public static int Plus(int number1, int number2, int number3, int number4)
        {
            return number1 + number2 + number3 + number4;
        }
            
    }
}
