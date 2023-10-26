using Assignments.ExceptionHandling;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignments
{
    internal class Patient
    {
        

        public int PatientId { get; set; }  
        public string? PatientName { get; set;}
        public int Age {  get; set; }
        public string ? Diagnose {  get; set; }
       public static List<Patient> patients = new List<Patient>();

       

        public static void AddPatient(int patientId,string?patientName,int age,string?diagnose )
        {
            if( age<0 || age>120)
            {
                throw new CustomException(MyException.error["One"]);
            }
           if(string.IsNullOrEmpty(patientName) )
            {
                throw new CustomException(MyException.error["Two"]);
            }
           if(string.IsNullOrEmpty(diagnose) ) 
            {
                throw new CustomException(MyException.error["Three"]);
            }
            Patient patient = new Patient();
            patient.PatientId = patientId;
            patient.PatientName = patientName;
            patient.Age = age;
            patient.Diagnose = diagnose;
            patients.Add(patient);

            

        }
        public static void Display()
        {
            Console.WriteLine("***Patient details***");
            foreach (Patient patient in patients)
            {
                Console.WriteLine($"Patient Id :{patient.PatientId}\nPatientName:{patient.PatientName}" +
                    $"\nPatientAge:{patient.Age}\nDiagnose:{patient.Diagnose}");
            }
        }

    }
}
