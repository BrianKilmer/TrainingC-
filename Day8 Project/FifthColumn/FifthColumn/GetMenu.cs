using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FifthColumn
{
    class GetMenu
    {
        public string GetMyMenu() 
        {
            Console.WriteLine("Menu");
            Console.WriteLine("----------------------------");
            Console.WriteLine("1 - Incidents By Country");
            Console.WriteLine("2 - Report new Incident");
            Console.WriteLine("3 - Exit");
            Console.WriteLine("----------------------------");
            
            string MenuChoice = Console.ReadLine();
            if (MenuChoice == "1")
            {
                Console.WriteLine("Please enter a 2 character Country Code.");
                string CountryCode = Console.ReadLine();
                return CountryCode;
            }
            else if (MenuChoice == "2")
            {
                Console.WriteLine("Please enter a 2 character Country Code.");
                string CountryCode = Console.ReadLine();
                return CountryCode;
            }
        }
       
    }
}
