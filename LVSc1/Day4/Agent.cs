using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day4
{
    class Agent : Asset
    {
        public override void Print() 
        {
            Console.WriteLine("{0}... {1}... {2}...", CodeName, Region, SkillSet);
        }
    }
}
