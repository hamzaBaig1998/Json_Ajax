using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace JsonAjax.Models
{
    public class Employee
    {
        public string EmployeeName { get; set; }
        public int Age { get; set; }
        public Employee(string name,int age)
        {
            this.EmployeeName = name;
            this.Age = age;
        }
    }
}