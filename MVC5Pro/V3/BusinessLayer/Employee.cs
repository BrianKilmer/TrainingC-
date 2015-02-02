using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace BusinessLayer
{
    public class Employee

    {
        public int id { get; set; }
        [Display(Name = "First Name")]
        public string NameFirst { get; set; }
        [Display(Name = "Last Name")]
        public string NameLast { get; set; }
        public string gender { get; set; }
        public string city { get; set; }
        public int age { get; set; }
        public int DepartmentID { get; set; }
        [Display(Name = "Born")]
        public DateTime DateOfBirth { get; set; }
    }
}
