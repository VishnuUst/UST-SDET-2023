using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic_Program
{
    internal class Doctor : IDoctor
    {
        public int DoctorId { get; set; }
        public string? DoctorName { get; set; }
       public void  AddNewDoctor()
        {
            DoctorId = 1;
            DoctorName = "Dr.Vishnu";
           

        }
       
        public void ModifyDoctor()
        {
            DoctorId = 2;
            DoctorName = "Dr.Gokul";
            
        }
        public void DisplayDoctor()
        {
           
            Console.WriteLine($"DoctorId:{DoctorId}\nDoctorName:{DoctorName}\n");
            


        }
    }
}
