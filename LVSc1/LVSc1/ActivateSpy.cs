using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LVSc1
{
    class ActivateSpy
    {
        //public Auto AssembleCar(string model, Engine engineType)
        public Spy DeploySpy(string Codename, Agency agencytype)
        {
            Spy newSpy = new Spy();
            newSpy.Codename = Codename;
            newSpy.Notes = "Awesome spy";
            return newSpy;
        }
    }
}
