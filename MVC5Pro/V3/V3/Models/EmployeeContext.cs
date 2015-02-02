using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace V3.Models
{
    
    public class EmployeeContext  : DbContext
    {
       // retreives reocrds from Employee db into  the Employees Property
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Department> Departments { get; set; }
    }
}