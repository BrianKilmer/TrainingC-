using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LVSc1
{
    class AssemblyRobot
    {

        public string name { get; set; }
        
        
        // AssembleCar is a method that takes 2 parametes, the signature being a string and an object
        // returns type = 'Auto' object
        public  Auto AssembleCar(string model, Engine engineType)
        {
            // instantiate a 'newcar' from the 'Auto' class
            Auto newCar = new Auto();
            // assign a value to it's model property
            newCar.Model = model;
            // assign engineType as it's Engine
            newCar.Engine = engineType;
            // return this object to whatever calls this method.
            return newCar;
        }
    }
}
