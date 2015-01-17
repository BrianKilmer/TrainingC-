using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LVSc1
{
    class Agency
    {
        private string angencyName;
        private string country;
        private int organizationSize;

        public string AgencyName
        {
            get { return angencyName; }
            set { angencyName = value; }
        }
        public string Country
        {
            get { return country; }
            set { country = value; }
        }
        public int OrganizationSize
        {
            get { return organizationSize; }
            set { organizationSize = value; }
        }
        
        
        

        public void GetAgencyInfo()
        {
            //ToDo
        }
    }
}
