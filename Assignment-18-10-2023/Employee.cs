using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignments
{
    internal class Employee : Person, IDisplayable
    {
        public Employee(int employeeId,string ? firstname,string?lastname,int age) :base(firstname,lastname,age)
        {
            EmployeeId = employeeId;
        }

        public int EmployeeId {  get; set; }

        public void DisplayInfo()
        {
            Console.WriteLine("***Employee Details***");
            Console.WriteLine($"Employee Id is:{EmployeeId}\nFirstName Is;{FirstName}\nLastName Is:{LastName}\nAge Is:{Age}");
        }
    }
}
