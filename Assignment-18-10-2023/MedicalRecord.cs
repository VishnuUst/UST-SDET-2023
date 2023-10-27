using Assignments.ExceptionHandling;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Assignments.ExceptionHandling.MyException;

namespace Assignments
{
    internal class MedicalRecord:Patient
    {
        public int RecordId {  get; set; }
        
        public int TotalCost {  get; set; }
        public static List<MedicalRecord> medicalRecords = new List<MedicalRecord>();

        public MedicalRecord(int recordId,int patientId, string? patientName, int age, string? diagnose,int totalcost) : base(patientId, patientName, age, diagnose)
        {
            RecordId = recordId;
            TotalCost = totalcost;
        }

        public static void AddMedicalRecord(MedicalRecord medicalRecord)

        { 
            if(medicalRecord.RecordId<=0)
            {
                throw new InvalidMedicalRecordException(MyException.error["Five"]);
            }
            if(string.IsNullOrEmpty(medicalRecord.PatientName) )
            {
                throw new InvalidPatientException(MyException.error["Two"]);
            }
            if(string.IsNullOrEmpty(medicalRecord.Diagnose) )
            {
                throw new InvalidPatientException(MyException.error["Three"]);
            }
            if(medicalRecord.TotalCost<=0)
            {
                throw new InvalidMedicalRecordException(MyException.error["Four"]);
            }
           
            
            medicalRecords.Add(medicalRecord);



        }
        public static void DisplayMedicalRecords()
        {
            Console.WriteLine("Medical Record Details");
            foreach(MedicalRecord medicalRecord in medicalRecords)
            {
                Console.WriteLine($"Record Id:{medicalRecord.RecordId}\nPatientName:{medicalRecord.PatientName}\nDiagnose:{medicalRecord.Diagnose}\nTotalCost:{medicalRecord.TotalCost}");
            }
        }
    }
}
