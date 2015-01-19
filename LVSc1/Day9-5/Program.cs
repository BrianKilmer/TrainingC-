using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day9_5
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] myStrings = { "Adam", "Alan", "Steve", "bob", "Jim", "Bill", "Jacob", "James" };
            
            //List<string> stringsA = new List<string>();

            //foreach (string a in myStrings)
            //{
            //    if (a.StartsWith("a"))
            //    {
            //        stringsA.Add(a);
            //    }
                
            //}

            //foreach (string s in stringsA)
            //{
            //    Console.WriteLine(s); 
            //}

            Console.WriteLine("Type 1 to enter a begining letter, 2 to enter an ending letter");
            string choice = Console.ReadLine();

            Console.WriteLine("Enter Letter");
            string letter = Console.ReadLine();

            List<string> names = new List<string>();

            if (choice == "1")
            {
                names = StringBeginsWith(myStrings, letter);
            }
            if (choice == "2")
            {
                names = StringEndWith(myStrings, letter);
            }

            foreach (string name in names)
            {
                Console.WriteLine(name);  
            }        
            

            Console.ReadLine();
        }
        //     return type  method name      param of type string array,  param of type string
        static List<string> StringBeginsWith(string[] myStrings,          string letter)
        {
            // new list instantiation
            List<string> foundstr = new  List<string>();

            foreach (string a in myStrings)
            {
                if (a.StartsWith(letter))
                {
                    foundstr.Add(a);
                }      
            }

            if (foundstr == null)
                foundstr.Add("array is not initialized");
            else if (foundstr.Count < 1)
                foundstr.Add("array is empty");
            
             return foundstr;  
        }

        static List<string> StringEndWith(string[] myStrings, string letter)
        {
            List<string> foundstr = new List<string>();

            foreach (string a in myStrings)
            {
                if (a.EndsWith(letter))
                {
                    foundstr.Add(a);
                }
            }
            return foundstr;
        }
    }
}
