using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic_Program
{
    internal class NonTeachingStaff : Staff
    {
       public string? Responsibilities { get; set; }
        public int Experience { get; set; }

        public void DisplayNoonTeachingStaff()
        {

            Console.WriteLine($" Responsibilities{Responsibilities}\nExperience:{Experience}");
        }

    }
}
