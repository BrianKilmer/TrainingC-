using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day5
{
    //class Product
    abstract class Product
    {
        public int ProductID { get; set; }

        // virtual - ifthere is a more specific implemetation of the Print method 
        // on a derived class (on this base class) , use it
        // example in the derived class: public override void Print()
        //public virtual void Print()
        public abstract void Print();
        //{
            //Console.Write("ID: {0}...", ProductID);
        //}
    }
}
