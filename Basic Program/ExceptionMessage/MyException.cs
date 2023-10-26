using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic_Program.ExceptionMessage
{
    internal class MyException
    {
        /*public static List<string> exMessageList = new List<string>()
        {
            "Divide By Zero Not Possible!!!",
            "IndexOutRangeFound",
            "Unknown ExceptionMessage"

        };*/
        public static Dictionary<string,string> exMessageList = new Dictionary<string,string>()
        {
            { "One","Divide By Zero Not Possible!!!" },
            { "Two","IndexOutRangeFound"},
            {"Three", "Age is less" },
            {"Four","Age Is More" }

        };
        internal class Num1Exception : Exception
        {
            public Num1Exception(string message) : base(message)
            {

            }
        }
        internal class Num2Exception : Exception
        {
            public Num2Exception(string message) : base(message)
            {

            }
        }

    }
}
