using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day5Exercise
{
    class ElementalMutant : Mutant
    {
        public int Region { get; set; }

        // level * Region
        public override int DangerQuotent()
        {
            return Level * Region;
        }
    }
}
