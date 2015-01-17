using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LVSc1
{
    class Day3
    {
        static void Main(string[] args)
        {
            Auto myCar1 = new Auto("Honda","civic");
            Console.WriteLine("Overloaded model: " + myCar1.Model); 
            //myCar.CurrentSpeed = 0;
            //myCar.Make = "Honda";
            //myCar.Model = "Regal";
            //myCar.Year = 2010;
            //myCar.Color = "Blue";
            //myCar.Miles = 20000;
            //Console.WriteLine(myCar.Make + " " + myCar.Model );

            //int MyCurrentSpeed = 0;
            //MyCurrentSpeed = myCar.Accelerate(2);
            //Console.WriteLine("My current speed is: " + MyCurrentSpeed);
            //MyCurrentSpeed = myCar.Accelerate(4);
            //Console.WriteLine("My current speed is: " + myCar.CurrentSpeed);
            //MyCurrentSpeed = myCar.Accelerate(5);
            //Console.WriteLine("My current speed is: " + MyCurrentSpeed);
            //MyCurrentSpeed = myCar.Accelerate(65);
            //Console.WriteLine("My current speed is: " + MyCurrentSpeed);

            //string message = myCar.SpeedLimitViolation("warining:" , 8);
            //Console.WriteLine(message);

            //MyCurrentSpeed = myCar.Decelerate(100);
            //Console.WriteLine("My current speed is: " + MyCurrentSpeed);
            //message = myCar.SpeedLimitViolation("warning: ", 8);
            //Console.WriteLine(message);
            //Console.ReadLine();

            // created / instantiated new engine objects and assigned values to fields
            Engine v4 = new Engine();
            v4.Size = "v4";
            v4.Horsepower = 200;
            v4.FuelConsumption = 1.6;

            Engine v6 = new Engine();
            v6.Size = "v6";
            v6.Horsepower = 350;
            v6.FuelConsumption = 2.6;

            Engine v8 = new Engine();
            v8.Size = "v8";
            v8.Horsepower = 500;
            v8.FuelConsumption = 3.7;

            //Auto myCar = new Auto();
            //myCar.Engine = v6;

            //Console.WriteLine(myCar.Engine.Horsepower.ToString());

            // instantiate 'robot' as a new AssemblbyRobot object
            AssemblyRobot robot = new AssemblyRobot();
            
            // an object is returned and stored in 'mycar' from calling the AssembleCar method from the AssemblyRobot class
            //   passing in 'honda' as it's model, and the 'v6' obect instatiated from the Engine class
            //   in that method, a new car object is created (newCar) in which properties are assigned and then returned in an object
            Auto myCar = robot.AssembleCar("Honda", v8);

            // if AssembleCar was a static methos then you would access it like this.. fully qualified:
            //Auto myCar = AssemblyRobot.AssembleCar("Honda",v6);
            
            // object 'Mycar' now has it's model field set to 'honda', and it's Engine set to the 'v6' model.
            // the 'v6' Engine's 'Horsepower is 350
            Console.WriteLine(myCar.Engine.Horsepower.ToString());
            Console.WriteLine(myCar.Model.ToString());

            // Customer is a class set up inside of the Auto class and needs to be referenced by: myCar.Customer.<field>
            // fields being assigned values
            myCar.Customer.LastName = "Kilmer";
            myCar.Customer.Address = "123 way";
            myCar.Customer.DateOfPurchase = DateTime.Now;

            Console.WriteLine("owned by: " + myCar.Customer.LastName);


            Truck myTruck = new Truck();
            myTruck.Model = "Big Rig";
            myTruck.Make  = "Honda";
            myTruck.Color = "blue";
            myTruck.TowingCapacity = 100;
            myTruck.Haul();
            myTruck.Tow();
            myTruck.Start();

            //myTruck.Make = Make.Honda;

            Console.ReadLine();
        }
        
        
        
    }
}
