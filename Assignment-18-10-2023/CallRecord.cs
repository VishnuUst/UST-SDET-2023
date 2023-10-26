using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignments
{
    internal class CallRecord
    {
        public static List<CallRecord> callRecords = new List<CallRecord>();
        public CallRecord(int callId, int phoneNumber, double callTime)
        {
            CallId = callId;
            PhoneNumber = phoneNumber;
            CallTime = callTime;
        }

        public int CallId { get; set; }
        public int PhoneNumber { get; set; }
        public double CallTime { get; set; }
        public static void SearchCallRecordByPhoneNumber(int phonenumber)
        {
            var data = callRecords.FindAll(x => x.PhoneNumber == phonenumber);
            Console.WriteLine("***Call history By PhoneNumber***");
            foreach (var record in data)
            {
                if (data != null)
                {
                    Console.WriteLine($"CallId:{record.CallId}\nCallTime:{record.CallTime}");
                }
                else
                {
                    Console.WriteLine("No Record Found!!!!");
                }
            }
        }
        public static void DisplayCountOfCallHistory()
        {
            Dictionary<int,int> history = new Dictionary<int,int>();
            foreach (var callRecord in callRecords)
            {
                if(history.ContainsKey(callRecord.PhoneNumber))
                {
                    history[callRecord.PhoneNumber]++;
                }
                else
                {
                    history[callRecord.PhoneNumber] = 1;
                }
            }
            Console.WriteLine("Total number of call per PhoneNumber");
            foreach(var data in history)
            {
                Console.WriteLine($"{data.Key}:{data.Value}");
            }
        }

    }
}
