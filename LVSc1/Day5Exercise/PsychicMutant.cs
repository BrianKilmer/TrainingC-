using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day5Exercise
{
    class PsychicMutant : Mutant
    {
        public int IQ { get; set; }
        public int PowerUsageCount { get; set; }

        // level * IQ * UsageCount
        public override int DangerQuotent()
        {
            return Level * IQ * PowerUsageCount;
        }
    }

    
}
