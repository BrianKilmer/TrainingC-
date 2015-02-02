using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace V3.Models
{
    // table attribute - table to which it needs to be maped
    [Table("Employee")]
    public class Employee
    {
        public int id { get; set; }
        public string NameFirst { get; set; }
        public string NameLast { get; set; }
        public string gender { get; set; }
        public string city { get; set; }
        public int age { get; set; }
        public int DepartmentID { get; set; }
        //public DateTime DateOfBirth { get; set; }
    }
}