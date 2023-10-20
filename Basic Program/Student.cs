using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic_Program
{
    internal class Student
    {
        public int StudentId { get; set; }
        public string ?StudentName { get; set; }
        public string?StudentCity { get; set; }
        public void DisplayStudentDetails()
        {
            Console.WriteLine($"\tRoll Num:{StudentId}\nStudent Name:{StudentName}\n" +
                              $"Student city:{StudentCity}");
        }
    }
}
