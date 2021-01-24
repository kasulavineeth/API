using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EmployeeApi.Models
{
    public class Employee
    {
        public string Name { get; set; }
        public string EmpId { get; set; }
        public string EmpYears { get; set; }
        public bool IsFullTime { get; set; }
    }
}