using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day4
{
    class Personnel : Asset
    {
        public string Department { get; set; }
        public string Supervisor { get; set; }

        public Personnel(string _codeName, string _region, string _skillSet, string _department, string _supervisor)
        {
            CodeName = _codeName;
            Region = _region;
            SkillSet = _skillSet;
            Department = _department;
            Supervisor = _supervisor;
        }
    }
}
