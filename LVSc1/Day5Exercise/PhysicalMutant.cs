using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day5Exercise
{
    class PhysicalMutant : Mutant
    {
        public int IQ { get; set; }
        public int Strength { get; set; }

        // level * IQ * Strength
        public override int DangerQuotent()
        {
            return Level * IQ * Strength;
        }
    }
}
