using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LVSc1
{
    class Day1
    {
        static void Main(string[] args)
        {

            //int x = 5;
            //int y = 7;
            //Console.WriteLine("value is " + (x+y));
            //-----------------------
            //string name = "brian";
            //Console.WriteLine("my name is " + name);
            //-----------------------

            //Console.WriteLine("type in something");
            //string uservalue = Console.ReadLine();
            //Console.WriteLine("you typed: " + uservalue);
            //-----------------------
            //Console.WriteLine("pick 1,2 or 3");
            //string message = "";
            //string uval = Console.ReadLine();
            //if (uval == "1")
            //    message = "You picked 1";
            //else
            //    message = "You didn't pick 1";
            //Console.WriteLine(message);
            //-----------------------
            //int a = 1;
            //int b = 0;
            //if (a == 1)
            //{
            //    b = 2;
            //}
            //Console.WriteLine(b);
            //-----------------------
            string success = "1 2 3 4";
            Console.WriteLine("Type in the secret code");
            string uInput = Console.ReadLine();
            if (uInput == success)
            {
                Console.ForegroundColor = ConsoleColor.DarkGreen;
                Console.WriteLine("success!!");
            }
            else
            {
                Console.Beep();
                Console.Beep();
                Console.ForegroundColor = ConsoleColor.Red;
                Console.BackgroundColor = ConsoleColor.Yellow;
                Console.WriteLine("FAIL!!");
            }
            Console.ReadLine();
        }
    }
}
