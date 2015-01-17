using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LVSc1
{
    class Day3Exercise
    {
        static void Main(string[] args)
        {
            Agency kaos = new Agency();
            kaos.AgencyName = "Kaos1";
            kaos.Country = "Russia";
            kaos.OrganizationSize = 3000;

            ActivateSpy mySpy = new ActivateSpy();
            Spy myNewSpy = mySpy.DeploySpy("Brian", kaos);

            Console.WriteLine("spy name: " + myNewSpy.Codename + " (" + myNewSpy.Notes + ")");
            Console.WriteLine("his Agency is: " + kaos.AgencyName);

            Console.ReadLine();
        }
    }
}
