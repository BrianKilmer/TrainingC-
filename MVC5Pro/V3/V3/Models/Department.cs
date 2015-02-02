﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace V3.Models
{
    [Table("Department")]
    public class Department
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<Employee> employees { get; set; }
    }
}