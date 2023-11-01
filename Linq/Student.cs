using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linq
{
    internal class Student
    {
        public Student(int studentId, string? studentName, string? department)
        {
            StudentId = studentId;
            StudentName = studentName;
            Department = department;
        }

        public int StudentId {  get; set; }
        public string? StudentName { get; set; }
        public string? Department{ get; set; }

    }
}
