using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic_Program
{
    internal class StudentGrade : StudentMarks
    {
        public string? Grade { get; set; } = string.Empty;
        public string FindGrade()
        {
            if(Average>=90)
            {
                Grade = "A";
            }
            else if(Average>=80)
            {
                Grade = "B";
            }
            else if(Average>=75)
            {
                Grade = "C";
            }
            else if(Average>=60)
            {
                Grade = "D";
            }
            else
            {
                Grade="E";
            }
            return Grade;
           
        }

    }
}
