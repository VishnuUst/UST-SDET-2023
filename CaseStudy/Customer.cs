using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaseStudy
{
    internal class Customer
    {
      

        public Customer(int customerId, string? customerName, string? phoneNumber)
        {
            CustomerId = customerId;
            CustomerName = customerName;
            PhoneNumber = phoneNumber;
            
        }

        public int CustomerId {  get; set; }
        public string? CustomerName { get; set; }
        public string? PhoneNumber { get; set; }

       
        public void DisplayCustomer()
        {
            Console.WriteLine($"Customer Name is :{CustomerName}");
            Console.WriteLine($"Phone Number is :{PhoneNumber}");
        }


    }
}
