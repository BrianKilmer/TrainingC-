using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day5Exercise
{
    abstract class Mutant : IDisplayable

    {
        public string CodeName { get; set; }
        public int Level { get; set; }

        // Method header - forcing each of the derived classes
        // to implement the DangerQuotent() method (for their own specific situation)
        public abstract int DangerQuotent();

        // this fulfills in contract/requirement with IDisplayable
        public void DisplayInformation() {
            // DangerQuotent().ToString() - reference the abstract method
            // and still get the implementation, regardless of the derived class
            string DQ = DangerQuotent().ToString();
            Console.WriteLine("CodeName: {0} DQ: {1}", CodeName, DQ);
        }

        
    }
}
