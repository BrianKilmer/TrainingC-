using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day5Exercise
{
    interface IDisplayable
    {
        // Contract: if a class is going to implement this interface,
        // you need to implement DisplayInformation()
        void DisplayInformation();
    }
}
