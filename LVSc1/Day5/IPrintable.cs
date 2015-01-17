using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day5
{
    //classes can only inherit from 1 class
    // you can implement multiple interfaces
    // so class Automobile : IPrintable must implement Print
    interface IPrintable  // this class that implements this interface "able" to do something
    {
         void Print();
    }
}
