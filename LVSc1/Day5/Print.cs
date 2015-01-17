using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day5
{
    static class Print
    {
        // takes a paramter 'printableObject' that is of type 'IPrintable'
        public static void ToConsole(IPrintable printableObject)
        {
           // going to use the object that was passed, and call it's Print Method
            printableObject.Print();
        }
    }
}
