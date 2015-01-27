using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    class Dog : Animal
    {
        // means i can do something else with a method that this class inherits from
        public override void Greet()
        {
            //base.Greet();
            Console.WriteLine("Hello, I'm a dog!");
        }
    }
}
