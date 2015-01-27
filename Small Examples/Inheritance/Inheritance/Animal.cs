using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    class Animal
    {
        public virtual  void Greet()
        {
            Console.WriteLine("Hello, I'm some sort of animal!");
        }
    }
}
