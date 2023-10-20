using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic_Program
{
    internal class StudentMarks : Student
    {
        public int MarkOne {  get; set; }
        public int MarkTwo { get; set; }
        public int MarkThree {  get; set; }
        public int Total { get; set; }
        
        public double Average {  get; set; }

        public int CalculateTotal()
        {
            Total = MarkOne + MarkTwo + MarkThree;
            return Total;
        }
        public double CalculateAverage()
        {
            Average = Total / 3;
            return Average;
        }


    }
}
