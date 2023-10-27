using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignments.ExceptionHandling
{
    internal class MyException 
    {
        public static Dictionary<string, string> error = new Dictionary<string, string>()

        {
            {"One","Age Must be Between 1 and 119" },
            {"Two","Name Not Empty" },
            {"Three","Diagnose Not Empty" },
            {"Four","TotalCost IS greater Than Zero" },
            {"Five","Record Id greater or equal to One" }
        };
        /*internal class Customexception : Exception
        {
            public Customexception(string message):base(message) { }

        }*/
        internal class InvalidPatientException : Exception
        {
            public InvalidPatientException(string message):base(message) { }

        }
        internal class InvalidMedicalRecordException : Exception
        {
            public InvalidMedicalRecordException(string message):base(message) { }
        }

    }
}
