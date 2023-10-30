using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaseStudy.MyExceptions
{
    internal class MyProductException
    {
        public static Dictionary<string, string> exMessageList = new Dictionary<string, string>()
        {
            { "One","ProductId is not null!!!" },
            { "Two","Quantity not zero"},
            {"Three", "Product Cost is greater than zero" },
            {"Five","ProductName Not Null" }
            
           

        };
        internal class UserException : Exception
        {
            public UserException(string message) : base(message)
            {

            }
        }
        
    }
}


