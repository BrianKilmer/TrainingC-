using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClass2
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList animalList = new ArrayList();
            animalList.Add(new Dog());
            animalList.Add(new Cat());

            foreach (FourLeggedAnimal animal in animalList)
                Console.WriteLine(animal.Describe());
            Console.ReadKey();
        }
    }

    abstract class FourLeggedAnimal
    {
        public abstract string Describe();
    }


    class Dog : FourLeggedAnimal
    {

        public override string Describe()
        {
            return "I'm a dog!";
        }
    }

    class Cat : FourLeggedAnimal
    {
        public override string Describe()
        {
            return "I'm a cat!";
        }
    }
}
