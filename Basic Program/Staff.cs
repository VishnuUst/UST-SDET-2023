using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic_Program
{
    internal class Staff
    {
        public int StaffId {  get; set; }
        public string? StaffName { get; set; }
        public string? StaffDepartment {  get; set; }
        public void DisplayStaffDetails()
        {
            Console.WriteLine($" Staff Id : {StaffId}\n Staff Name :{StaffName}\n " +
                              $"Staff Department :{StaffDepartment}");
        }

    }
}
