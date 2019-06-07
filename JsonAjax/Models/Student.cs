using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace JsonAjax.Models
{
    public class Student
    {
        public string StudentName { get; set; }
        public string StudentRegNo { get; set; }
        public double StudentCGPA { get; set; }
        public Student(string name,string reg,double cgpa)
        {
            this.StudentName = name;
            this.StudentRegNo = reg;
            this.StudentCGPA = cgpa;
        }
    }
}