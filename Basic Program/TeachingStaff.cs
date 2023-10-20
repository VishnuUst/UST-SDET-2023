using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic_Program
{
    internal class TeachingStaff : Staff
    {
        public string? Specialization {  get; set; }
        public int Semester { get; set; }
        public void DisplayTeachingStaffDetails()
        {
            Console.WriteLine($" Specialization:{Specialization}\n Semester:{Semester}");
        }

    }
}
