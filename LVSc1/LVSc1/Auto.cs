using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LVSc1
{
    class Auto
    {
        private string make;
        public string Model;
        public int Year;
        public string Color;
        public int Miles;
        private int speed;
        public Engine Engine;  //makes the engine object available to the Auto class as an object

        public Auto()
        {
            // do impt initialization here..
            Console.WriteLine("Initializing...");
        }
        public Auto(string _make, string _model)
        {
            make = _make;
            Model = _model;
        }

        public void Drive()
        {
        }
        public void Drive(int miles)
        {
        }
        public void Drive(int LocationX, int LocationY)
        {

        }
        public void Drive(string Location)
        {

        }


        public AutoCustomer Customer = new AutoCustomer();  // Customer is now available to the Auto class

        public class AutoCustomer
        {
            public string LastName;
            public string Address;
            public DateTime DateOfPurchase;
        }

        public string Make
        {
            get { return Make; }   // return value thats currently stores in our private field
            set
            {
                //make = value; // set the value of the private field 'make' wha ever has been pased into the the = operator
                switch (value)
                {
                    case "Buick":
                        make = value;
                        break;
                    case "Honda":
                        make = value;
                        break;
                    default:
                        throw new Exception("Not a vaid maker");
                }
                //make = value;
            }
        }

        
        public int CurrentSpeed
        {
            get {return speed;}   
            set 
            {
                if (value < 0)
                    speed = 0;
                else if (value > 65)
                    speed = 65;
                else
                    speed = value;
            } 
        }

        public int Accelerate(int IncreasedSpeed)
        {
           
            CurrentSpeed += IncreasedSpeed;
            //Console.WriteLine("Current speed is " + Speed.ToString());
            writeMyLine("my current cool speed is " + CurrentSpeed);
            return CurrentSpeed;
        }

        public int  Decelerate(int DecreasedSpeed)
        {
            CurrentSpeed -= DecreasedSpeed;
            //Console.WriteLine("Current speed is " + Speed.ToString());
            return CurrentSpeed;
        }

        public string SpeedLimitViolation(string initialMessage, int SpeedLimit)
        {
            string message = "";
            if (CurrentSpeed > SpeedLimit)
            {
                message =  "You are speeding";
            }
            else
            {
                message =  "Your speed is ok";
            }

            return initialMessage + " " + message;
        }

        private void writeMyLine(string msg)
        {
            Console.WriteLine("Helper ");
            Console.WriteLine(msg);
        }

        public virtual void Start()
        {
            Console.WriteLine("Car Starting..");
        }
        
    }
    enum Make
    {
        Toyota,
        Buick,
        Honda,
        Ford
    }
}
