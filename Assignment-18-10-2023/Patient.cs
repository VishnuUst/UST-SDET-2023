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

        public Patient(int patientId, string? patientName, int age, string? diagnose)
        {
            PatientId = patientId;
            PatientName = patientName;
            Age = age;
            Diagnose = diagnose;
        }

        public static void AddPatient(Patient p)
        {
            if(p.Age<0 || p.Age>120)
            {
                throw new CustomException(MyException.error["One"]);
            }
           if(string.IsNullOrEmpty(p.PatientName) )
            {
                throw new CustomException(MyException.error["Two"]);
            }
           if(string.IsNullOrEmpty(p.Diagnose) ) 
            {
                throw new CustomException(MyException.error["Three"]);
            }
            
            patients.Add(p);

            

        }
        public  void WriteData()
        {

            FileStream fileStream = new FileStream("D:\\SDET-DAILYWORK\\Basic Solution\\Assignment-18-10-2023\\FileHand\\PatientData.txt", FileMode.Append, FileAccess.Write);
            StreamWriter fileWriter = new StreamWriter(fileStream);
            fileWriter.WriteLine($"PatientId:{PatientId},PatientName:{PatientName},Age:{Age},Diagnose:{Diagnose}"); 
            fileWriter.Close();
            fileStream.Close();
        }
        public static void ReadData()
        {
            FileStream fs = new FileStream("D:\\SDET-DAILYWORK\\Basic Solution\\Assignment-18-10-2023\\FileHand\\PatientData.txt", FileMode.Open, FileAccess.Read);
            StreamReader sr = new StreamReader(fs);
            sr.BaseStream.Seek(0, SeekOrigin.Current);
            string str = sr.ReadToEnd();
            Console.WriteLine($"{str}\n");
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
