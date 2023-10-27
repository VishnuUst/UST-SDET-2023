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
        public static void AddMedicalRecord(int recordId,string?patientName,string? diagnose,int totalCost)

        { 
            if(recordId<=0)
            {
                throw new InvalidMedicalRecordException(MyException.error["Five"]);
            }
            if(string.IsNullOrEmpty(patientName) )
            {
                throw new InvalidPatientException(MyException.error["Two"]);
            }
            if(string.IsNullOrEmpty(diagnose) )
            {
                throw new InvalidPatientException(MyException.error["Three"]);
            }
            if(totalCost<=0)
            {
                throw new InvalidMedicalRecordException(MyException.error["Four"]);
            }
           
            MedicalRecord medicalRecord = new MedicalRecord();
            medicalRecord.RecordId = recordId;
            medicalRecord.PatientName = patientName;
            medicalRecord.Diagnose = diagnose;
            medicalRecord.TotalCost = totalCost;
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
