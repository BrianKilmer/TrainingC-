﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            Animal animal = new Animal();
            animal.Greet();

            Dog dog = new Dog();
            dog.Greet();

            Console.ReadLine();
        }

        
    }
}
