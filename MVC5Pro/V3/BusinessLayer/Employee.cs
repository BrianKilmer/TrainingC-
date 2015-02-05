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
        [Required]
        [Display(Name = "First Name")]
        public string NameFirst { get; set; }

        [Required]
        [Display(Name = "Last Name")]
        public string NameLast { get; set; }

        [Required]
        public string gender { get; set; }

        [Required]
        public string city { get; set; }

        [Required]
        public int age { get; set; }

        [Required]
        public int DepartmentID { get; set; }

        [Required]
        [Display(Name = "Birth Date")]
        public DateTime? DateOfBirth { get; set; }
    }
}
