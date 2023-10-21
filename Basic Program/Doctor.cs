using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic_Program
{
    internal class Doctor : IDoctor,IAppointment
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

        public void BookAppointment(int doctorid, string? patientname)
        {
            Console.WriteLine($"Appointment booked Successfully");
            Console.WriteLine("Appointment details");
            Console.WriteLine($"Patient Name:{patientname}");
            Console.WriteLine($"Doctor Id :{doctorid}");


            Console.WriteLine($"Your Doctor Name :{DoctorName}");
        }

        public void DeleteAppointment(int doctorid)
        {
            Console.WriteLine($"Patient deleted successfully with doctor id {doctorid}\n");
        }
    }
}
