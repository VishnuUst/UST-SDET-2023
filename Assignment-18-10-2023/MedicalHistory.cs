using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignments
{
    internal class MedicalHistory
    {
        public MedicalHistory(int recordId, int patientId, string? description, string? date)
        {
            RecordId = recordId;
            PatientId = patientId;
            Description = description;
            Date = date;
        }

        public int RecordId { get; set; }
        public int PatientId { get; set; }
        public string?Description { get; set; }
        public string? Date { get; set; }
        public static List<MedicalHistory> medicalHistories = new List<MedicalHistory>();
        public static void AddMedicalHostory(MedicalHistory history)
        {
           medicalHistories.Add(history);
        }
        public void WriteData()
        {

            FileStream fileStream = new FileStream("D:\\SDET-DAILYWORK\\Basic Solution\\Assignment-18-10-2023\\FileHand\\MedicalHistory.txt", FileMode.Append, FileAccess.Write);
            StreamWriter fileWriter = new StreamWriter(fileStream);
            fileWriter.WriteLine($"{RecordId} {PatientId} {Description} {Date}");
            fileWriter.Close();
            fileStream.Close();
        }
        public static void ReadDataById(int id)
        {
            FileStream fs = new FileStream("D:\\SDET-DAILYWORK\\Basic Solution\\Assignment-18-10-2023\\FileHand\\MedicalHistory.txt", FileMode.Open, FileAccess.Read);
            StreamReader sr = new StreamReader(fs);
            sr.BaseStream.Seek(0, SeekOrigin.Begin);
            string? str = sr.ReadLine();
            while(str != null)
            {
                string[] n = str.Split(" ");
                int a = int.Parse(n[1]);
                if(id == a)
                {
                    Console.WriteLine($"Record Id:{n[0]}\nDescription:{n[2]}\nDate:{n[3]}\n");
                }
                str=sr.ReadLine();
               
            }
            sr.Close();
            fs.Close();
        }

    }
}
