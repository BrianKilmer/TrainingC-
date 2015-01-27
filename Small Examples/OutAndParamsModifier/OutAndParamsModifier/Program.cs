using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OutAndParamsModifier
{
    class Program
    {
        static void Main(string[] args)
        {
            //-----------------------------------------------------
            // params modifier
            GreetPersons(0);
            GreetPersons(25, "John", "Jane", "Tarzan");
            Console.ReadKey();
            //-----------------------------------------------------
            bool period; // Used as out parameter
            bool comma;
            bool semicolon;
            const string value = "has period, comma."; // Used as input string
            TestString(value, out period, out comma, out semicolon);
            Console.WriteLine( );
            Console.WriteLine(value); // Display value
            Console.Write("period: "); // Display labels and bools
            Console.WriteLine(period);
            Console.Write("comma: ");
            Console.WriteLine(comma);
            Console.Write("semicolon: ");
            Console.WriteLine(semicolon);
            Console.ReadKey();
            //-----------------------------------------------------
        }
        //-----------------------------------------------------
        // the params modifier needs to be the last param.
        static void GreetPersons(int someUnusedParameter, params string[] names)
        {
            foreach (string name in names)
                Console.WriteLine("Hello, " + name);
        }
        //-----------------------------------------------------
        static void TestString(string value, out bool period, out bool comma, out bool semicolon)
        {
            period = comma = semicolon = false; // Assign all out parameters to false

            for (int i = 0; i < value.Length; i++)
            {
                switch (value[i])
                {
                    case '.':
                        {
                            period = true; // Set out parameter
                            break;
                        }
                    case ',':
                        {
                            comma = true; // Set out parameter
                            break;
                        }
                    case ';':
                        {
                            semicolon = true; // Set out parameter
                            break;
                        }
                }
            }
        }
        //-----------------------------------------------------
    }
}
